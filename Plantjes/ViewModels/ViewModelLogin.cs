﻿using System.Windows;
using System.Windows.Media;
using Microsoft.Toolkit.Mvvm.Input;
using Plantjes.Models.Enums;
using Plantjes.ViewModels.Interfaces;
using Plantjes.Views.Home;

//written by kenny
namespace Plantjes.ViewModels; 

public class ViewModelLogin : ViewModelBase 
{
    private string _errorMessage;
    private string _loggedInMessage;
    public string _passwordInput;

    private string _userNameInput;

    public ViewModelLogin(IloginUserService loginUserService) 
    {
        _loginService = loginUserService;
        loginCommand = new RelayCommand(LoginButtonClick);
        cancelCommand = new RelayCommand(CancelButton);
        registerCommand = new RelayCommand(RegisterButtonView);
    }

    private IloginUserService _loginService { get; }
    public RelayCommand loginCommand { get; set; }
    public RelayCommand cancelCommand { get; set; }
    public RelayCommand registerCommand { get; set; }

    public string errorMessage 
    {
        get => _errorMessage;
        set {
            _errorMessage = value;
        }
    }
    public string userNameInput 
    {
        get => _userNameInput;
        set {
            _userNameInput = value;
            OnPropertyChanged();
        }
    }

    public string passwordInput 
    {
        get => _passwordInput;
        set {
            _passwordInput = value;
            OnPropertyChanged();
        }
    }

    public void RegisterButtonView() 
    {
        var registerWindow = new RegisterWindow();
        registerWindow.Show();
        Application.Current.Windows[0]?.Close();
    }

    public void CancelButton() 
    {
        Application.Current.Shutdown();
    }

    private SolidColorBrush _GebruikersNaamColor;
    public SolidColorBrush GebruikersNaamColor
    {
        get
        {
            return _GebruikersNaamColor;
        }
        set
        {
            _GebruikersNaamColor = value;
            RaisePropertyChanged("GebruikersNaamColor");
        }
    }

    private SolidColorBrush _PasswordColor;
    public SolidColorBrush PasswordColor
    {
        get
        {
            return _PasswordColor;
        }
        set
        {
            _PasswordColor = value;
            RaisePropertyChanged("PasswordColor");
        }
    }

    private void LoginButtonClick() 
    {
        if (!string.IsNullOrWhiteSpace(userNameInput)) 
        {
            var loginResult = _loginService.CheckCredentials(userNameInput, passwordInput);

            if (loginResult.loginStatus == LoginStatus.LoggedIn) 
            {
                //  loggedInMessage = _loginService.LoggedInMessage(userNameInput);
                var mainWindow = new MainWindow();
                mainWindow.Show();
                Application.Current.Windows[0]?.Close();
            }
            else if (loginResult.loginStatus == LoginStatus.NotLoggedIn)
            {
                errorMessage = loginResult.errorMessage;
                GebruikersNaamColor = new SolidColorBrush(Colors.Red);
            }
        }
        else 
        {
            errorMessage = "Gebruikersnaam invullen.";
            GebruikersNaamColor = new SolidColorBrush(Colors.Red);
        }
        RaisePropertyChanged("errorMessage");
    }
}