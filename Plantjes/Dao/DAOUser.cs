using Microsoft.EntityFrameworkCore;
using Plantjes.Models.Db;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;
using Plantjes.ViewModels;

namespace Plantjes.Dao {
    //Gesplitst door Xander, aangepast door Warre
    internal class DAOUser : DAOLogic
    {
        //Xander - optimisation: reutrn object directly, use firstordefault (13% faster)
        public static Gebruiker GetGebruikerWithEmail(string userEmail)
        {
            return context.Gebruikers.Include(x => x.Rol).FirstOrDefault(g => g.Emailadres == userEmail);
        }

        //written by kenny -- changed by Kjell
        public static void RegisterUser(string vivesNr, string firstName, string lastName, string emailadres, string password, DateTime last_login) {
            var passwordBytes = Encoding.ASCII.GetBytes(password);
            var md5Hasher = new MD5CryptoServiceProvider();
            var passwordHashed = md5Hasher.ComputeHash(passwordBytes);
            Rol role;
            if (emailadres.EndsWith("@vives.be")) role = context.Rols.First(x => x.Omschrijving == "Docent");
            else if (emailadres.EndsWith("@student.vives.be")) role = context.Rols.First(x => x.Omschrijving == "Student");
            else role = context.Rols.First(x => x.Omschrijving == "Oud-Student");
            if (role == null) throw new MissingMemberException("Rol niet gevonden!");
            var gebruiker = new Gebruiker {
                Vivesnr = vivesNr,
                Voornaam = firstName,
                Achternaam = lastName,
                Emailadres = emailadres,
                HashPaswoord = passwordHashed,
                Rol = role,
                LastLogin = last_login
            };
            context.Gebruikers.Add(gebruiker);
            context.SaveChanges();
        }

        //Written by Kjell
        //Save new password in database
        //
        public static void ChangePassword(string password, Gebruiker gebruiker)
        {
            var passwordBytes = Encoding.ASCII.GetBytes(password);
            var md5Hasher = new MD5CryptoServiceProvider();
            var passwordHashed = md5Hasher.ComputeHash(passwordBytes);

            gebruiker.HashPaswoord = passwordHashed;
            //Also saving date to the date of today
            gebruiker.LastLogin = DateTime.Now;

            context.Gebruikers.Update(gebruiker);
            context.SaveChanges();
        }



        //written by kenny
        public static List<Gebruiker> getAllGebruikers() {
            return context.Gebruikers.ToList();
        }

        //written by kenny

        public static bool GetEmailInUse(string email)
        {
            return context.Gebruikers.Any(x => x.Emailadres == email);
        }

        //<Xander Baes>
        /// <summary>
        /// Add users from CSV
        /// </summary>
        public static void AddUsersFromCsv() {
            //import
            importUsersFromCsv();
            //show errors
            //openInExcelAndWait("errors.csv");
        }

        //legacy - object to csv column names
        private static void generateCsv() {
            //generate csv with headings
            //delete if exists
            if (File.Exists("import.csv")) File.Delete("import.csv");
            //get fields
            var fields = typeof(ViewModelRegister).GetProperties().Where(x => x.Name.Contains("Input")).Where(x => !x.Name.Contains("password")).Select(x => x.Name.Replace("Input", ""));
            //write as column headings
            File.WriteAllText("import.csv", String.Join(",", fields));
        }
        
        private static void openInExcelAndWait(string filename) {
            //search for excel, or fall back to notepad
            string executable = "notepad";
            if (File.Exists(@"C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE"))
                executable = @"C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE";
            else if (File.Exists(@"C:\Program Files (x86)\Microsoft Office\root\Office16\EXCEL.EXE"))
                executable = @"C:\Program Files (x86)\Microsoft Office\root\Office16\EXCEL.EXE";
            //execute
            Process proc = Process.Start(executable, filename);
            //wait for exit, seem sto fire almost immediately
            proc.WaitForExit();
            //wait until file readable (unlocked) because Microsoft decided that you shouldn't be able to do this, for some reason
            bool ExcelExited = false;
            while (!ExcelExited) {
                try {
                    File.ReadAllLines(filename);
                    ExcelExited = true;
                }
                catch { }
            }
        }

        private static List<(CsvImportErrorType ErrorType, string Message)> _csvErrors;
        private static int _csvAdded = 0;
        private static void importUsersFromCsv() {
            _csvErrors = new();
            _csvAdded = 0;
            //import from csv
            //open files
            var ofd = new OpenFileDialog() {
                Multiselect = false,
                CheckPathExists = true,
                CheckFileExists = true,
                Title = "Selecteer CSV bestand met gebruikers.",
                Filter = "Leerlingenlijst (*.csv)|*.csv",
                FileName = "Excel KU-Loket -> save as .csv",
                AddExtension = true,
                DefaultExt = "*.csv",
                ShowReadOnly = false
            };

            if ((bool)!ofd.ShowDialog()) return;
            var ifs = File.OpenText(ofd.FileName);
            //get fields
            var firstline = ifs.ReadLine();
            var separator = ",";
            if (!firstline.Contains(separator)) separator = ";";
            var fields = firstline.Split(separator).ToList();
            //get student role
            var role = context.Rols.First(x => x.Omschrijving == "Student");
            
            //read all lines...
            string line = "";
            while ((line = ifs.ReadLine()) != null && line != "") {
                //split by fields
                var infields = line.Split(separator);
                //get password
                var passwordBytes = Encoding.ASCII.GetBytes(infields[fields.ToList().IndexOf("Studentennummer")]);
                var md5Hasher = new MD5CryptoServiceProvider();
                var passwordHashed = md5Hasher.ComputeHash(passwordBytes);
                //create user object
                var user = new Gebruiker() {
                    Vivesnr = infields[fields.IndexOf("Studentennummer")],
                    Voornaam = infields[fields.IndexOf("Voornaam")],
                    Achternaam = infields[fields.IndexOf("Familienaam")],
                    Emailadres = infields[fields.IndexOf("Emailadres")],
                    Rol = role,
                    HashPaswoord = passwordHashed,
                };
                //duplicate/data checks
                if (context.Gebruikers.Any(x => x.Emailadres == user.Emailadres)) {
                    _csvErrors.Add((CsvImportErrorType.DuplicateEmail, $"Gebruiker met email {user.Emailadres} bestaat al!"));
                }
                else if (context.Gebruikers.Any(x => x.Vivesnr == user.Vivesnr)) {
                    _csvErrors.Add((CsvImportErrorType.DuplicateRnumber, $"Gebruiker met Vives-nummer {user.Vivesnr} bestaat al!"));
                }
                else if (!user.Emailadres.Contains("@")) {
                    _csvErrors.Add((CsvImportErrorType.InvalidEmail, $"Emailadres {user.Emailadres} is geen geldig emailadres!"));
                }
            else if (user.Vivesnr.Length != 7) {
                _csvErrors.Add((CsvImportErrorType.InvalidRNumber, $"R-nummer {user.Vivesnr} is geen geldig nummer!"));
            }
                else {
                    //all checks passed, add to db
                    context.Gebruikers.Add(user);
                    context.SaveChanges();
                    _csvAdded++;
                }
            }

            //Show error summary
            if (!_csvErrors.Any()) MessageBox.Show("Geen fouten bij het importeren.");
            else
            {
                var mbr = MessageBox.Show(GetErrorSummary(), "", MessageBoxButton.YesNo);
                if (mbr == MessageBoxResult.Yes) {
                    var wnd = new Window();
                    var lb = new ListBox();
                    foreach (var (errorType, message) in _csvErrors) {
                        lb.Items.Add(message);
                    }

                    wnd.Content = lb;
                    wnd.Show();
                }
            }
            //close files
            ifs.Close();
        }

        private static string GetErrorSummary() {
            string summary = $"Toegevoegd: {_csvAdded}, Fouten: {_csvErrors.Count}";
            if (_csvErrors.Count > 0) summary += "\n\n";
            if (_csvErrors.Any(x => x.ErrorType == CsvImportErrorType.DuplicateEmail)) summary += $"{_csvErrors.Count(x => x.ErrorType == CsvImportErrorType.DuplicateEmail)} duplicate emails\n";
            if (_csvErrors.Any(x => x.ErrorType == CsvImportErrorType.DuplicateRnumber)) summary += $"{_csvErrors.Count(x => x.ErrorType == CsvImportErrorType.DuplicateRnumber)} duplicate R-nummers\n";
            if (_csvErrors.Any(x => x.ErrorType == CsvImportErrorType.InvalidEmail)) summary += $"{_csvErrors.Count(x => x.ErrorType == CsvImportErrorType.InvalidEmail)} ongeldige emails\n";
            if (_csvErrors.Any(x => x.ErrorType == CsvImportErrorType.InvalidRNumber)) summary += $"{_csvErrors.Count(x => x.ErrorType == CsvImportErrorType.InvalidRNumber)} ongeldige R-nummers\n";
            return summary + "\nWil je deze weergeven in een lijst?";
        }

        private string GetErrorList() {
            string errorList = "";
            foreach (var (errorType, message) in _csvErrors.OrderBy(x=>x.ErrorType)) {
                errorList += message + "\n";
            }
            return errorList;
        }
        private enum CsvImportErrorType {
            DuplicateEmail,
            DuplicateRnumber,
            InvalidRNumber,
            InvalidEmail,
        }


        public static List<Gebruiker> GetAllUsersNoTracking() => context.Gebruikers.AsNoTracking().ToList();

        public static Gebruiker GetUser(int id) => context.Gebruikers.First(x => x.Id == id);
        public static Gebruiker GetUserNoTracking(int id) => context.Gebruikers.AsNoTracking().First(x => x.Id == id);

        public static void DeleteUser(int id) {
            context.Gebruikers.Remove(GetUser(id));
            context.SaveChanges();
        }

        public static void AddOrUpdate(Gebruiker user) {
            var dbuser = context.Gebruikers.FirstOrDefault(x => x.Id == user.Id);
            if (dbuser != null) {
                dbuser.Emailadres = user.Emailadres;
                dbuser.Vivesnr = user.Vivesnr;
                dbuser.Voornaam = user.Voornaam;
                dbuser.Achternaam = user.Achternaam;
            }
            else context.Gebruikers.Add(user);

            context.SaveChanges();
        }
        //</Xander Baes>
    }
}