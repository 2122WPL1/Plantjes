using System.Linq;
using System.Windows;
using Plantjes.Dao;
using Plantjes.ViewModels.Services;

namespace Plantjes.ViewModels;

public class ViewModelBloom : ViewModelBase {
    // Using a DependencyProperty as the backing store for 
    //IsCheckBoxChecked.  This enables animation, styling, binding, etc...

    private DAOLogic _dao;
    private DetailService _detailService = (DetailService)App.Current.Services.GetService(typeof(DetailService));

    private SearchService _SearchService = (SearchService)App.Current.Services.GetService(typeof(SearchService));

    //geschreven door christophe, op basis van een voorbeeld van owen
    private string _selectedBloeiHoogte;

    public ViewModelBloom(DetailService detailservice) {
        _dao = DAOLogic.Instance();
        detailservice.SelectedPlantChanged += (sender, plant) => {
            var fm = DAOFenotype.FilterFenotypeMultiFromPlant((int)plant.PlantId);
            var bh = fm.FirstOrDefault(x => x.Eigenschap == "Bloeihoogte");
            if (bh != null) SelectedBloeiHoogte = bh.Waarde;
            else SelectedBloeiHoogte = "Onbekend";
        };
    }

    public string SelectedBloeiHoogte {
        get => _selectedBloeiHoogte;
        set {
            _selectedBloeiHoogte = value;
            OnPropertyChanged();
        }
    }

    #region Checkbox Bloeikleur

    private bool _selectedCheckBoxBloeikleurZwart;

    public bool SelectedCheckBoxBloeikleurZwart {
        get => _selectedCheckBoxBloeikleurZwart;

        set {
            _selectedCheckBoxBloeikleurZwart = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeikleurWit;

    public bool SelectedCheckBoxBloeikleurWit {
        get => _selectedCheckBoxBloeikleurWit;

        set {
            _selectedCheckBoxBloeikleurWit = value;
            MessageBox.Show(SelectedCheckBoxBloeikleurZwart.ToString());
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeikleurRosé;

    public bool SelectedCheckBoxBloeikleurRosé {
        get => _selectedCheckBoxBloeikleurRosé;

        set {
            _selectedCheckBoxBloeikleurRosé = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeikleurRood;

    public bool SelectedCheckBoxBloeikleurRood {
        get => _selectedCheckBoxBloeikleurRood;

        set {
            _selectedCheckBoxBloeikleurRood = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeikleurOranje;

    public bool SelectedCheckBoxBloeikleurOranje {
        get => _selectedCheckBoxBloeikleurOranje;

        set {
            _selectedCheckBoxBloeikleurOranje = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeikleurLila;

    public bool SelectedCheckBoxBloeikleurLila {
        get => _selectedCheckBoxBloeikleurLila;

        set {
            _selectedCheckBoxBloeikleurLila = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeikleurGrijs;

    public bool SelectedCheckBoxBloeikleurGrijs {
        get => _selectedCheckBoxBloeikleurGrijs;

        set {
            _selectedCheckBoxBloeikleurGrijs = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeikleurGroen;

    public bool SelectedCheckBoxBloeikleurGroen {
        get => _selectedCheckBoxBloeikleurGroen;

        set {
            _selectedCheckBoxBloeikleurGroen = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeikleurGeel;

    public bool SelectedCheckBoxBloeikleurGeel {
        get => _selectedCheckBoxBloeikleurGeel;

        set {
            _selectedCheckBoxBloeikleurGeel = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeikleurBlauw;

    public bool SelectedCheckBoxBloeikleurBlauw {
        get => _selectedCheckBoxBloeikleurBlauw;

        set {
            _selectedCheckBoxBloeikleurBlauw = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeikleurViolet;

    public bool SelectedCheckBoxBloeikleurViolet {
        get => _selectedCheckBoxBloeikleurViolet;

        set {
            _selectedCheckBoxBloeikleurViolet = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeikleurPaars;

    public bool SelectedCheckBoxBloeikleurPaars {
        get => _selectedCheckBoxBloeikleurPaars;

        set {
            _selectedCheckBoxBloeikleurPaars = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeikleurBruin;

    public bool SelectedCheckBoxBloeikleurBruin {
        get => _selectedCheckBoxBloeikleurBruin;

        set {
            _selectedCheckBoxBloeikleurBruin = value;
            OnPropertyChanged();
        }
    }

    #endregion

    #region Binding Checkbox BloeiHoogte

    private bool _selectedCheckBoxBloeiHoogteJan;

    public bool SelectedCheckBoxBloeiHoogteJan {
        get => _selectedCheckBoxBloeiHoogteJan;

        set {
            _selectedCheckBoxBloeiHoogteJan = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeiHoogteFeb;

    public bool SelectedCheckBoxBloeiHoogteFeb {
        get => _selectedCheckBoxBloeiHoogteFeb;

        set {
            _selectedCheckBoxBloeiHoogteFeb = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeiHoogteMar;

    public bool SelectedCheckBoxBloeiHoogteMar {
        get => _selectedCheckBoxBloeiHoogteMar;

        set {
            _selectedCheckBoxBloeiHoogteMar = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeiHoogteApr;

    public bool SelectedCheckBoxBloeiHoogteApr {
        get => _selectedCheckBoxBloeiHoogteApr;

        set {
            _selectedCheckBoxBloeiHoogteApr = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeiHoogteMay;

    public bool SelectedCheckBoxBloeiHoogteMay {
        get => _selectedCheckBoxBloeiHoogteMay;

        set {
            _selectedCheckBoxBloeiHoogteMay = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeiHoogteJun;

    public bool SelectedCheckBoxBloeiHoogteJun {
        get => _selectedCheckBoxBloeiHoogteJun;

        set {
            _selectedCheckBoxBloeiHoogteJun = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeiHoogteJul;

    public bool SelectedCheckBoxBloeiHoogteJul {
        get => _selectedCheckBoxBloeiHoogteJul;

        set {
            _selectedCheckBoxBloeiHoogteJul = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeiHoogteAug;

    public bool SelectedCheckBoxBloeiHoogteAug {
        get => _selectedCheckBoxBloeiHoogteAug;

        set {
            _selectedCheckBoxBloeiHoogteAug = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeiHoogteSep;

    public bool SelectedCheckBoxBloeiHoogteSep {
        get => _selectedCheckBoxBloeiHoogteSep;

        set {
            _selectedCheckBoxBloeiHoogteSep = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeiHoogteOct;

    public bool SelectedCheckBoxBloeiHoogteOct {
        get => _selectedCheckBoxBloeiHoogteOct;

        set {
            _selectedCheckBoxBloeiHoogteOct = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeiHoogteNov;

    public bool SelectedCheckBoxBloeiHoogteNov {
        get => _selectedCheckBoxBloeiHoogteNov;

        set {
            _selectedCheckBoxBloeiHoogteNov = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeiHoogteDec;

    public bool SelectedCheckBoxBloeiHoogteDec {
        get => _selectedCheckBoxBloeiHoogteDec;

        set {
            _selectedCheckBoxBloeiHoogteDec = value;
            OnPropertyChanged();
        }
    }

    #endregion

    #region Binding Checkbox Bloeit In

    private bool _selectedCheckBoxBloeitInJan;

    public bool SelectedCheckBoxBloeitInJan {
        get => _selectedCheckBoxBloeitInJan;

        set {
            _selectedCheckBoxBloeitInJan = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeitInFeb;

    public bool SelectedCheckBoxBloeitInFeb {
        get => _selectedCheckBoxBloeitInFeb;

        set {
            _selectedCheckBoxBloeitInFeb = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeitInMar;

    public bool SelectedCheckBoxBloeitInMar {
        get => _selectedCheckBoxBloeitInMar;

        set {
            _selectedCheckBoxBloeitInMar = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeitInApr;

    public bool SelectedCheckBoxBloeitInApr {
        get => _selectedCheckBoxBloeitInApr;

        set {
            _selectedCheckBoxBloeitInApr = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeitInMay;

    public bool SelectedCheckBoxBloeitInMay {
        get => _selectedCheckBoxBloeitInMay;

        set {
            _selectedCheckBoxBloeitInMay = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeitInJun;

    public bool SelectedCheckBoxBloeitInJun {
        get => _selectedCheckBoxBloeitInJun;

        set {
            _selectedCheckBoxBloeitInJun = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeitInJul;

    public bool SelectedCheckBoxBloeitInJul {
        get => _selectedCheckBoxBloeitInJul;

        set {
            _selectedCheckBoxBloeitInJul = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeitInAug;

    public bool SelectedCheckBoxBloeitInAug {
        get => _selectedCheckBoxBloeitInAug;

        set {
            _selectedCheckBoxBloeitInAug = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeitInSep;

    public bool SelectedCheckBoxBloeitInSep {
        get => _selectedCheckBoxBloeitInSep;

        set {
            _selectedCheckBoxBloeitInSep = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeitInOct;

    public bool SelectedCheckBoxBloeitInOct {
        get => _selectedCheckBoxBloeitInOct;

        set {
            _selectedCheckBoxBloeitInOct = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeitInNov;

    public bool SelectedCheckBoxBloeitInNov {
        get => _selectedCheckBoxBloeitInNov;

        set {
            _selectedCheckBoxBloeitInNov = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeitInDec;

    public bool SelectedCheckBoxBloeitInDec {
        get => _selectedCheckBoxBloeiHoogteDec;

        set {
            _selectedCheckBoxBloeiHoogteDec = value;
            OnPropertyChanged();
        }
    }

    #endregion

    #region Binding checkboxes Bloeiwijzevorm

    private bool _selectedCheckBoxBloeiwijzeVorm1;

    public bool SelectedCheckBoxBloeiwijzeVorm1 {
        get => _selectedCheckBoxBloeiwijzeVorm1;

        set {
            _selectedCheckBoxBloeiwijzeVorm1 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeiwijzeVorm2;

    public bool SelectedCheckBoxBloeiwijzeVorm2 {
        get => _selectedCheckBoxBloeiwijzeVorm2;

        set {
            _selectedCheckBoxBloeiwijzeVorm2 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeiwijzeVorm3;

    public bool SelectedCheckBoxBloeiwijzeVorm3 {
        get => _selectedCheckBoxBloeiwijzeVorm3;

        set {
            _selectedCheckBoxBloeiwijzeVorm3 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeiwijzeVorm4;

    public bool SelectedCheckBoxBloeiwijzeVorm4 {
        get => _selectedCheckBoxBloeiwijzeVorm4;

        set {
            _selectedCheckBoxBloeiwijzeVorm4 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeiwijzeVorm5;

    public bool SelectedCheckBoxBloeiwijzeVorm5 {
        get => _selectedCheckBoxBloeiwijzeVorm5;

        set {
            _selectedCheckBoxBloeiwijzeVorm5 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBloeiwijzeVorm6;

    public bool SelectedCheckBoxBloeiwijzeVorm6 {
        get => _selectedCheckBoxBloeiwijzeVorm6;

        set {
            _selectedCheckBoxBloeiwijzeVorm6 = value;
            OnPropertyChanged();
        }
    }

    #endregion

    #region Ratio Bloei/Blad

    // Gemaakt door Warre
    private bool _selectedCheckBoxRatioPachysandra;

    public bool SelectedCheckBoxRatioPachysandra {
        get => _selectedCheckBoxRatioPachysandra;
        set {
            _selectedCheckBoxRatioPachysandra = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxRatioGeranium;

    public bool SelectedCheckBoxRatioGeranium {
        get => _selectedCheckBoxRatioGeranium;
        set {
            _selectedCheckBoxRatioGeranium = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxRatioSalvia;

    public bool SelectedCheckBoxRatioSalvia {
        get => _selectedCheckBoxRatioSalvia;
        set {
            _selectedCheckBoxRatioSalvia = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxRatioAster;

    public bool SelectedCheckBoxRatioAster {
        get => _selectedCheckBoxRatioAster;
        set {
            _selectedCheckBoxRatioAster = value;
            OnPropertyChanged();
        }
    }

    #endregion
}