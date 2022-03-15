using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Plantjes.Models.Db;

namespace Plantjes.Dao
{
    public partial class DAOLogic
    {
        //written by kenny
        public Gebruiker GetGebruikerWithEmail(string userEmail)
        {
            return context.Gebruikers.SingleOrDefault(g => g.Emailadres == userEmail);
        }

        //written by kenny
        public void RegisterUser(string vivesNr, string firstName, string lastName, string emailadres, string password)
        {
            var passwordBytes = Encoding.ASCII.GetBytes(password);
            var md5Hasher = new MD5CryptoServiceProvider();
            var passwordHashed = md5Hasher.ComputeHash(passwordBytes);

            var gebruiker = new Gebruiker
            {
                Vivesnr = vivesNr,
                Voornaam = firstName,
                Achternaam = lastName,
                Emailadres = emailadres,
                HashPaswoord = passwordHashed
            };
            context.Gebruikers.Add(gebruiker);
            context.SaveChanges();
        }

        //written by kenny
        public List<Gebruiker> getAllGebruikers()
        {
            return context.Gebruikers.ToList();
        }

        //written by kenny
        public bool CheckIfEmailAlreadyExists(string email)
        {
            return context.Gebruikers.Any(x => x.Emailadres == email);
        }
    }
}
