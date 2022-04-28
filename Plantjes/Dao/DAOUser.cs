using Microsoft.EntityFrameworkCore;
using Plantjes.Models.Db;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using Plantjes.ViewModels;

namespace Plantjes.Dao {
    //Gesplitst door Xander, aangepast door Warre
    internal class DAOUser : DAOLogic {
        public static Gebruiker GetGebruikerWithEmail(string userEmail) {
            var x = context.Gebruikers.Include(x => x.Rol).SingleOrDefault(g => g.Emailadres == userEmail);
            return x;
        }

        //written by kenny
        public static void RegisterUser(string vivesNr, string firstName, string lastName, string emailadres, string password) {
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
                Rol = role
            };
            context.Gebruikers.Add(gebruiker);
            context.SaveChanges();
        }

        //written by kenny
        public static List<Gebruiker> getAllGebruikers() {
            return context.Gebruikers.ToList();
        }

        //written by kenny
        public static bool GetEmailInUse(string email) {
            return context.Gebruikers.Any(x => x.Emailadres == email);
        }

        //<Xander Baes>
        /// <summary>
        /// Add users from CSV
        /// </summary>
        public static void AddUsersFromCsv() {
            //generate new csv with headings
            generateCsv();
            //open in excel
            openInExcelAndWait("import.csv");
            //import
            importUsersFromCsv();
            //show errors
            openInExcelAndWait("errors.csv");
        }

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

        private static void importUsersFromCsv() {
            //import from csv
            //open files
            if (File.Exists("errors.csv")) File.Delete("errors.csv");
            var ifs = File.OpenText("import.csv");
            var log = new List<string>();
            //get fields
            var fields = ifs.ReadLine().Split(",").ToList();
            //get student role
            var role = context.Rols.First(x => x.Omschrijving == "Student");
            int errors = 0, added = 0;
            //read all lines...
            string line = "";
            while ((line = ifs.ReadLine()) != null && line != "") {
                //split by fields
                var infields = line.Split(",");
                //get password
                var passwordBytes = Encoding.ASCII.GetBytes(infields[fields.ToList().IndexOf("vivesNr")]);
                var md5Hasher = new MD5CryptoServiceProvider();
                var passwordHashed = md5Hasher.ComputeHash(passwordBytes);
                //create user object
                var user = new Gebruiker() {
                    Vivesnr = infields[fields.IndexOf("vivesNr")],
                    Voornaam = infields[fields.IndexOf("firstName")],
                    Achternaam = infields[fields.IndexOf("lastName")],
                    Emailadres = infields[fields.IndexOf("emailAdres")],
                    Rol = role,
                    HashPaswoord = passwordHashed,
                    LastLogin = DateTime.UnixEpoch
                };
                //duplicate/data checks
                if (context.Gebruikers.Any(x => x.Emailadres == user.Emailadres)) {
                    errors++;
                    log.Add($"Gebruiker met email {user.Emailadres} bestaat al!");
                }
                else if (context.Gebruikers.Any(x => x.Vivesnr == user.Vivesnr)) {
                    errors++;
                    log.Add($"Gebruiker met Vives-nummer {user.Vivesnr} bestaat al!");
                }
                else if (!user.Emailadres.Contains("@")) {
                    errors++;
                    log.Add($"Emailadres {user.Emailadres} is geen geldig emailadres!");
                }
                else {
                    //all checks passed, add to db
                    context.Gebruikers.Add(user);
                    context.SaveChanges();
                    added++;
                }
            }

            //add status header
            log.Insert(0, $"Added: {added},Errors:{errors}");
            File.WriteAllLines("errors.csv", log);
            //close files
            ifs.Close();
        }
        //</Xander Baes>
    }
}