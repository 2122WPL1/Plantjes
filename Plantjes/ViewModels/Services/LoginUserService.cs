using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

using Plantjes.Dao;
using Plantjes.Models.Classes;
using Plantjes.Models.Db;
using Plantjes.Models.Enums;
using Plantjes.ViewModels.Interfaces;
using Plantjes.Views.Home;

namespace Plantjes.ViewModels.Services;

public class LoginUserService : IloginUserService, INotifyPropertyChanged
{
    //dao verklaren om data op te vragen en te setten in de databank
    private readonly DAOLogic _dao;

    public LoginUserService()
    {
        _dao = DAOLogic.Instance();
    } //gebruiker verklaren  om te gebruiken in de logica

    private Gebruiker _gebruiker { get; set; }

    #region Register Region

    public string RegisterButton(string vivesNrInput, string lastNameInput, string firstNameInput,
        string emailAdresInput, string passwordInput, string passwordRepeatInput)
    {
        //errorMessage die gereturned wordt om de gebruiker te waarschuwen wat er aan de hand is
        var Message = string.Empty;
        //checken of alle velden ingevuld zijn
        if (vivesNrInput != null && firstNameInput != null && lastNameInput != null && emailAdresInput != null && passwordInput != null && passwordRepeatInput != null)
        {
            //checken als het emailadres een geldig vives email is.
            if (emailAdresInput != null && emailAdresInput.Contains(".") && emailAdresInput.Contains("@")
                //checken als het email adres al bestaat of niet.
                && !_dao.CheckIfEmailAlreadyExists(emailAdresInput))
            {
                //checken als het herhaalde wachtwoord klopt of niet.
                if (passwordInput == passwordRepeatInput)
                {
                    //gebruiker registreren.
                    _dao.RegisterUser(vivesNrInput, firstNameInput, lastNameInput, emailAdresInput, passwordInput);
                    //Message = $"{firstNameInput}, je bent succevol geregistreerd,"+"\r\n"+$" uw gebruikersnaam is {emailAdresInput}." + 
                    // "\r\n" + $" {firstNameInput}, je kan dit venster wegklikken en inloggen.";
                    var loginWindow = new LoginWindow();
                    loginWindow.Show();
                } //foutafhandeling
                else {
                    Message = "Zorg dat de wachtwoorden overeenkomen.";
                }
            }
            else {
                Message = $"Fout! {emailAdresInput} is geen geldig emailadres, " + "\r\n" + " of het eamiladres is al in gebruik.";
            }
        }
        else {
            Message = "Zorg dat alle velden ingevuld zijn.";
        } //Message terugsturen om te binden aan een label in de viewModel.

        return Message;
    }

    #endregion

    #region Login Region

    //globale gebruiker om te gebruiken in de service
    public Gebruiker gebruiker = new();

    //zorgen dat de INotifyPropertyChanged geimplementeerd wordt
    public event PropertyChangedEventHandler PropertyChanged;

    //het eigenlijke loginsysteem
    public LoginResult CheckCredentials(string userNameInput, string passwordInput)
    {
        //Nieuw loginResult om te gebruiken, status op NotLoggedIn zetten
        var loginResult = new LoginResult { loginStatus = LoginStatus.NotLoggedIn };

        //check if email is valid email
        if (userNameInput != null) //&& userNameInput.Contains("@student.vives.be")
        {
            //gebruiker zoeken in de databank
            gebruiker = _dao.GetGebruikerWithEmail(userNameInput);
            loginResult.gebruiker = gebruiker;
        }
        else
        {
            //indien geen geldig emailadress, errorMessage opvullen
            loginResult.errorMessage = "FOUT! Dit is geen geldig Vives emailadres.";
            return loginResult;
        }

        //xander - password check
        if (passwordInput != null)
        {
            //omzetten van het ingegeven passwoord naar een gehashed passwoord
            var passwordBytes = Encoding.ASCII.GetBytes(passwordInput);
            var md5Hasher = new MD5CryptoServiceProvider();
            var passwordHashed = md5Hasher.ComputeHash(passwordBytes);

            if (gebruiker != null)
            {
                _gebruiker = gebruiker;
                loginResult.gebruiker = gebruiker;
                //passwoord controle
                if (gebruiker.HashPaswoord != null && passwordHashed.SequenceEqual(gebruiker.HashPaswoord))
                    //indien true status naar LoggedIn zetten
                    loginResult.loginStatus = LoginStatus.LoggedIn;
                else
                    //indien false errorMessage opvullen
                    loginResult.errorMessage += "\r\n" + "FOUT! Het ingegeven wachtwoord is niet juist. Gelieve opnieuw te proberen.";
            }
            else
            {
                // als de gebruiker niet gevonden wordt, errorMessage invullen
                loginResult.errorMessage = $"FOUT! Er is geen account gevonden voor {userNameInput}" + "\r\n" + "Gelieve eerst te registreren.";
            }
        }
        else
        {
            //xander - password check
            loginResult.errorMessage = "Gelieve een wachtwoord in te geven.";
        }

        return loginResult;
    }
    //Functie om naam weer te geven in loginWindow, als login succesvol is
    public string LoggedInMessage() {
        var message = string.Empty;
        if (_gebruiker != null)
        {
            message = $"Ingelogd als: {_gebruiker.Voornaam} {_gebruiker.Achternaam}";
            return message;
        }

        return message;
    }

    #endregion
}