using Microsoft.EntityFrameworkCore;
using Plantjes.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Plantjes.Dao
{
    //Gesplitst door Xander, aangepast door Warre
    internal class DAOUser : DAOLogic
    {
        public static Gebruiker GetGebruikerWithEmail(string userEmail)
        {
            var x = context.Gebruikers.Include(x => x.Rol).SingleOrDefault(g => g.Emailadres == userEmail);
            return x;
        }

        //written by kenny
        public static void RegisterUser(string vivesNr, string firstName, string lastName, string emailadres, string password)
        {
            var passwordBytes = Encoding.ASCII.GetBytes(password);
            var md5Hasher = new MD5CryptoServiceProvider();
            var passwordHashed = md5Hasher.ComputeHash(passwordBytes);
            Rol role;
            if (emailadres.EndsWith("@vives.be")) role = context.Rols.First(x => x.Omschrijving == "Docent");
            else if (emailadres.EndsWith("@student.vives.be")) role = context.Rols.First(x => x.Omschrijving == "Student");
            else role = context.Rols.First(x => x.Omschrijving == "Oud-Student");
            if (role == null) throw new MissingMemberException("Rol niet gevonden!");
            var gebruiker = new Gebruiker
            {
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
        public static List<Gebruiker> getAllGebruikers()
        {
            return context.Gebruikers.ToList();
        }

        //written by kenny
        public static bool GetEmailInUse(string email)
        {
            return context.Gebruikers.Any(x => x.Emailadres == email);
        }
    }
}
