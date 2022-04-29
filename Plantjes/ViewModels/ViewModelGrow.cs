using System.Windows;
using Plantjes.Dao;
using Plantjes.ViewModels.Services;

namespace Plantjes.ViewModels; 

public class ViewModelGrow : ViewModelBase {
    private DAOLogic _dao;
    private DetailService _detailService = (DetailService)App.Current.Services.GetService(typeof(DetailService));

    public ViewModelGrow(DetailService detailservice) {
        _detailService = detailservice;
        _dao = DAOLogic.Instance();
    }

    //geschreven door christophe, op basis van een voorbeeld van owen

    #region CheckboxGrondsoort

    private bool _selectedCheckBoxGrondsoortGB1;

    public bool SelectedCheckBoxGrondsoortGB1 {
        get => _selectedCheckBoxGrondsoortGB1;

        set {
            _selectedCheckBoxGrondsoortGB1 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortGB2;

    public bool SelectedCheckBoxGrondsoortGB2 {
        get => _selectedCheckBoxGrondsoortGB2;

        set {
            _selectedCheckBoxGrondsoortGB2 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortGB3;

    public bool SelectedCheckBoxGrondsoortGB3 {
        get => _selectedCheckBoxGrondsoortGB3;

        set {
            _selectedCheckBoxGrondsoortGB3 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortOP1;

    public bool SelectedCheckBoxGrondsoortOP1 {
        get => _selectedCheckBoxGrondsoortOP1;

        set {
            _selectedCheckBoxGrondsoortOP1 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortOP1B;

    public bool SelectedCheckBoxGrondsoortOP1B {
        get => _selectedCheckBoxGrondsoortOP1B;

        set {
            _selectedCheckBoxGrondsoortOP1B = value;
            OnPropertyChanged();
        }
    }


    private bool _selectedCheckBoxGrondsoortOP2;

    public bool SelectedCheckBoxGrondsoortOP2 {
        get => _selectedCheckBoxGrondsoortOP2;

        set {
            _selectedCheckBoxGrondsoortOP2 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortOP2B;

    public bool SelectedCheckBoxGrondsoortOP2B {
        get => _selectedCheckBoxGrondsoortOP2B;

        set {
            _selectedCheckBoxGrondsoortOP2B = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortOP3;

    public bool SelectedCheckBoxGrondsoortOP3 {
        get => _selectedCheckBoxGrondsoortOP3;

        set {
            _selectedCheckBoxGrondsoortOP3 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortOP3B;

    public bool SelectedCheckBoxGrondsoortOP3B {
        get => _selectedCheckBoxGrondsoortOP3B;

        set {
            _selectedCheckBoxGrondsoortOP3B = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortSH1;

    public bool SelectedCheckBoxGrondsoortSH1 {
        get => _selectedCheckBoxGrondsoortSH1;

        set {
            _selectedCheckBoxGrondsoortSH1 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortSH2;

    public bool SelectedCheckBoxGrondsoortSH2 {
        get => _selectedCheckBoxGrondsoortSH2;

        set {
            _selectedCheckBoxGrondsoortSH2 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortB1;

    public bool SelectedCheckBoxGrondsoortB1 {
        get => _selectedCheckBoxGrondsoortB1;

        set {
            _selectedCheckBoxGrondsoortB1 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortB2;

    public bool SelectedCheckBoxGrondsoortB2 {
        get => _selectedCheckBoxGrondsoortB2;

        set {
            _selectedCheckBoxGrondsoortB2 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortB3;

    public bool SelectedCheckBoxGrondsoortB3 {
        get => _selectedCheckBoxGrondsoortB3;

        set {
            _selectedCheckBoxGrondsoortB3 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortGR1;

    public bool SelectedCheckBoxGrondsoortGR1 {
        get => _selectedCheckBoxGrondsoortGR1;

        set {
            _selectedCheckBoxGrondsoortGR1 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortGR2;

    public bool SelectedCheckBoxGrondsoortGR2 {
        get => _selectedCheckBoxGrondsoortGR2;

        set {
            _selectedCheckBoxGrondsoortGR2 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortH1;

    public bool SelectedCheckBoxGrondsoortH1 {
        get => _selectedCheckBoxGrondsoortH1;

        set {
            _selectedCheckBoxGrondsoortH1 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortH2;

    public bool SelectedCheckBoxGrondsoortH2 {
        get => _selectedCheckBoxGrondsoortH2;

        set {
            _selectedCheckBoxGrondsoortH2 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortST1;

    public bool SelectedCheckBoxGrondsoortST1 {
        get => _selectedCheckBoxGrondsoortST1;

        set {
            _selectedCheckBoxGrondsoortST1 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortST2;

    public bool SelectedCheckBoxGrondsoortST2 {
        get => _selectedCheckBoxGrondsoortST2;

        set {
            _selectedCheckBoxGrondsoortST2 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortBR1;

    public bool SelectedCheckBoxGrondsoortBR1 {
        get => _selectedCheckBoxGrondsoortBR1;

        set {
            _selectedCheckBoxGrondsoortBR1 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortBR2;

    public bool SelectedCheckBoxGrondsoortBR2 {
        get => _selectedCheckBoxGrondsoortBR2;

        set {
            _selectedCheckBoxGrondsoortBR2 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortBR3;

    public bool SelectedCheckBoxGrondsoortBR3 {
        get => _selectedCheckBoxGrondsoortBR3;

        set {
            _selectedCheckBoxGrondsoortBR3 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortOB1;

    public bool SelectedCheckBoxGrondsoortOB1 {
        get => _selectedCheckBoxGrondsoortOB1;

        set {
            _selectedCheckBoxGrondsoortOB1 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortOB2;

    public bool SelectedCheckBoxGrondsoortOB2 {
        get => _selectedCheckBoxGrondsoortOB2;

        set {
            _selectedCheckBoxGrondsoortOB2 = value;
            OnPropertyChanged();
        }
    }

    #endregion

    #region CheckboxStrategie

    private bool _selectedCheckBoxStrategieC;

    public bool SelectedCheckBoxStrategieC {
        get => _selectedCheckBoxStrategieC;

        set {
            _selectedCheckBoxStrategieC = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxStrategieCR;

    public bool SelectedCheckBoxStrategieCR {
        get => _selectedCheckBoxStrategieCR;

        set {
            _selectedCheckBoxStrategieCR = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxStrategieR;

    public bool SelectedCheckBoxStrategieR {
        get => _selectedCheckBoxStrategieR;

        set {
            _selectedCheckBoxStrategieR = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxStrategieRS;

    public bool SelectedCheckBoxStrategieRS {
        get => _selectedCheckBoxStrategieRS;

        set {
            _selectedCheckBoxStrategieRS = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxStrategieS;

    public bool SelectedCheckBoxStrategieS {
        get => _selectedCheckBoxStrategieS;

        set {
            _selectedCheckBoxStrategieS = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxStrategieSC;

    public bool SelectedCheckBoxStrategieSC {
        get => _selectedCheckBoxStrategieSC;

        set {
            _selectedCheckBoxStrategieSC = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxStrategieCSR;

    public bool SelectedCheckBoxStrategieCSR {
        get => _selectedCheckBoxStrategieCSR;

        set {
            _selectedCheckBoxStrategieCSR = value;
            MessageBox.Show(SelectedCheckBoxStrategieCSR.ToString());
            OnPropertyChanged();
        }
    }

    #endregion

    #region CheckboxVoedingsbehoefte

    private bool _selectedCheckBoxVoedingsbehoefteArm;

    public bool SelectedCheckBoxVoedingsbehoefteArm {
        get => _selectedCheckBoxVoedingsbehoefteArm;

        set {
            _selectedCheckBoxVoedingsbehoefteArm = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVoedingsbehoefteArmMatig;

    public bool SelectedCheckBoxVoedingsbehoefteArmMatig {
        get => _selectedCheckBoxVoedingsbehoefteArmMatig;

        set {
            _selectedCheckBoxVoedingsbehoefteArmMatig = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVoedingsbehoefteMatig;

    public bool SelectedCheckBoxVoedingsbehoefteMatig {
        get => _selectedCheckBoxVoedingsbehoefteMatig;

        set {
            _selectedCheckBoxVoedingsbehoefteMatig = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVoedingsbehoefteMatigVoedselrijk;

    public bool SelectedCheckBoxVoedingsbehoefteMatigVoedselrijk {
        get => _selectedCheckBoxVoedingsbehoefteMatigVoedselrijk;

        set {
            _selectedCheckBoxVoedingsbehoefteMatigVoedselrijk = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVoedingsbehoefteVoedselrijk;

    public bool SelectedCheckBoxVoedingsbehoefteVoedselrijk {
        get => _selectedCheckBoxVoedingsbehoefteVoedselrijk;

        set {
            _selectedCheckBoxVoedingsbehoefteVoedselrijk = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVoedingsbehoefteVoedselrijkIndifferent;

    public bool SelectedCheckBoxVoedingsbehoefteVoedselrijkIndifferent {
        get => _selectedCheckBoxVoedingsbehoefteVoedselrijkIndifferent;

        set {
            _selectedCheckBoxVoedingsbehoefteVoedselrijkIndifferent = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVoedingsbehoefteIndifferent;

    public bool SelectedCheckBoxVoedingsbehoefteIndifferent {
        get => _selectedCheckBoxVoedingsbehoefteIndifferent;

        set {
            _selectedCheckBoxVoedingsbehoefteIndifferent = value;
            OnPropertyChanged();
        }
    }

    #endregion

    #region CheckboxVochtBehoefte

    private bool _selectedCheckBoxVochtbehoefteDroog;

    public bool SelectedCheckBoxVochtbehoefteDroog {
        get => _selectedCheckBoxVochtbehoefteDroog;

        set {
            _selectedCheckBoxVochtbehoefteDroog = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVochtbehoefteDroogFris;

    public bool SelectedCheckBoxVochtbehoefteDroogFris {
        get => _selectedCheckBoxVochtbehoefteDroogFris;

        set {
            _selectedCheckBoxVochtbehoefteDroogFris = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVochtbehoefteFris;

    public bool SelectedCheckBoxVochtbehoefteFris {
        get => _selectedCheckBoxVochtbehoefteFris;

        set {
            _selectedCheckBoxVochtbehoefteFris = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVochtbehoefteFrisVochtig;

    public bool SelectedCheckBoxVochtbehoefteFrisVochtig {
        get => _selectedCheckBoxVochtbehoefteFrisVochtig;

        set {
            _selectedCheckBoxVochtbehoefteFrisVochtig = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVochtbehoefteVochtig;

    public bool SelectedCheckBoxVochtbehoefteVochtig {
        get => _selectedCheckBoxVochtbehoefteVochtig;

        set {
            _selectedCheckBoxVochtbehoefteVochtig = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVochtbehoefteVochtigNat;

    public bool SelectedCheckBoxVochtbehoefteVochtigNat {
        get => _selectedCheckBoxVochtbehoefteVochtigNat;

        set {
            _selectedCheckBoxVochtbehoefteVochtigNat = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVochtbehoefteNat;

    public bool SelectedCheckBoxVochtbehoefteNat {
        get => _selectedCheckBoxVochtbehoefteNat;

        set {
            _selectedCheckBoxVochtbehoefteNat = value;
            OnPropertyChanged();
        }
    }

    #endregion
}