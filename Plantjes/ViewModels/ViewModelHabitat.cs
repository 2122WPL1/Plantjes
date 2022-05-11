using System.Collections.ObjectModel;
using System.Windows;
using Plantjes.Dao;
using Plantjes.Models.Db;
using Plantjes.ViewModels.Services;

namespace Plantjes.ViewModels; 

public class ViewModelHabitat : ViewModelBase 
{
    private readonly DAOLogic _dao;

    private string _selectedNectarwaarde;

    private string _selectedOntwikkelsnelheid;

    private string _selectedPollenwaarde;

    public ViewModelHabitat(DetailService detailservice) {
        _dao = DAOLogic.Instance();


        cmbPollenWaarde = new ObservableCollection<ExtraPollenwaarde>();
        cmbNectarWaarde = new ObservableCollection<ExtraNectarwaarde>();


        fillComboBoxPollenwaarde();
        fillComboBoxNectarwaarde();
    }

    public ObservableCollection<ExtraPollenwaarde> cmbPollenWaarde { get; set; }
    public ObservableCollection<ExtraNectarwaarde> cmbNectarWaarde { get; set; }

    public string SelectedPollenwaarde {
        get => _selectedPollenwaarde;
        set {
            _selectedPollenwaarde = value;
            OnPropertyChanged();
        }
    }

    public string SelectedNectarwaarde {
        get => _selectedNectarwaarde;
        set {
            _selectedNectarwaarde = value;
            OnPropertyChanged();
        }
    }

    public string SelectedOntwikkelsnelheid {
        get => _selectedOntwikkelsnelheid;
        set {
            _selectedOntwikkelsnelheid = value;
            OnPropertyChanged();
        }
    }

    //aangepast door Warre
    public void fillComboBoxPollenwaarde() {
        var list = DAOExtraPollen.FillExtraPollenwaardes();

        foreach (var item in list) cmbPollenWaarde.Add(item);
    }

    public void fillComboBoxNectarwaarde() {
        var list = DAOExtraNectar.FillExtraNectarwaardes();

        foreach (var item in list) cmbNectarWaarde.Add(item);
    }


    #region Binding checkboxen Ontwikkelsnelheid
    //Gemaakt door Warre
    private bool _selectedCheckBoxOntwikkelsnelheidTraag;

    public bool selectedCheckBoxOntwikkelsnelheidTraag
    {
        get => _selectedCheckBoxOntwikkelsnelheidTraag;
        set {
            _selectedCheckBoxOntwikkelsnelheidTraag = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxOntwikkelsnelheidMatig;

    public bool selectedCheckBoxOntwikkelsnelheidMatig
    {
        get => _selectedCheckBoxOntwikkelsnelheidMatig;
        set {
            _selectedCheckBoxOntwikkelsnelheidMatig = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxOntwikkelsnelheidSnel;

    public bool selectedCheckBoxOntwikkelsnelheidSnel
    {
        get => _selectedCheckBoxOntwikkelsnelheidSnel;
        set {
            _selectedCheckBoxOntwikkelsnelheidSnel = value;
            OnPropertyChanged();
        }
    }
    #endregion

    #region Sociabliliteit

    private bool _selectedCheckBoxSociabiliteitI;

    public bool SelectedCheckBoxSociabiliteitI {
        get => _selectedCheckBoxSociabiliteitI;
        set {
            _selectedCheckBoxSociabiliteitI = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxSociabiliteitII;

    public bool SelectedCheckBoxSociabiliteitII {
        get => _selectedCheckBoxSociabiliteitII;
        set {
            _selectedCheckBoxSociabiliteitII = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxSociabiliteitIII;

    public bool SelectedCheckBoxSociabiliteitIII {
        get => _selectedCheckBoxSociabiliteitIII;
        set {
            _selectedCheckBoxSociabiliteitIII = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxSociabiliteitIV;

    public bool SelectedCheckBoxSociabiliteitIV {
        get => _selectedCheckBoxSociabiliteitIV;
        set {
            _selectedCheckBoxSociabiliteitIV = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxSociabiliteitV;

    public bool SelectedCheckBoxSociabiliteitV {
        get => _selectedCheckBoxSociabiliteitV;
        set {
            _selectedCheckBoxSociabiliteitV = value;
            OnPropertyChanged();
        }
    }
    #endregion

    #region PlantEigenschappen
    private bool _selectedCheckBoxBijvriendelijk;

    public bool SelectedCheckBoxBijvriendelijk {
        get => _selectedCheckBoxBijvriendelijk;
        set {
            _selectedCheckBoxBijvriendelijk = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxEetbaarKruidbaar;

    public bool SelectedCheckBoxEetbaarKruidbaar {
        get => _selectedCheckBoxEetbaarKruidbaar;
        set {
            _selectedCheckBoxEetbaarKruidbaar = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGeurend;

    public bool SelectedCheckBoxGeurend {
        get => _selectedCheckBoxGeurend;
        set {
            _selectedCheckBoxGeurend = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVlindervriendelijk;

    public bool SelectedCheckBoxVlindervriendelijk {
        get => _selectedCheckBoxVlindervriendelijk;
        set {
            _selectedCheckBoxVlindervriendelijk = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVorstgevoelig;

    public bool SelectedCheckBoxVorstgevoelig {
        get => _selectedCheckBoxVorstgevoelig;
        set {
            _selectedCheckBoxVorstgevoelig = value;
            OnPropertyChanged();
        }
    }
    #endregion

    #region Levensvorm

    private bool _selectedCheckBox1;

    public bool SelectedCheckBox1 {
        get => _selectedCheckBox1;
        set {
            _selectedCheckBox1 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBox2;

    public bool SelectedCheckBox2 {
        get => _selectedCheckBox2;
        set {
            _selectedCheckBox2 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBox3;

    public bool SelectedCheckBox3 {
        get => _selectedCheckBox3;
        set {
            _selectedCheckBox3 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBox4;

    public bool SelectedCheckBox4 {
        get => _selectedCheckBox4;
        set {
            _selectedCheckBox4 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBox5;

    public bool SelectedCheckBox5 {
        get => _selectedCheckBox5;
        set {
            _selectedCheckBox5 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBox6;

    public bool SelectedCheckBox6 {
        get => _selectedCheckBox6;
        set {
            _selectedCheckBox6 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBox7;

    public bool SelectedCheckBox7 {
        get => _selectedCheckBox7;
        set {
            _selectedCheckBox7 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBox8;

    public bool SelectedCheckBox8 {
        get => _selectedCheckBox8;
        set {
            _selectedCheckBox8 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBox9;

    public bool SelectedCheckBox9 {
        get => _selectedCheckBox9;
        set {
            _selectedCheckBox9 = value;
            OnPropertyChanged();
        }
    }
    #endregion

    #region CheckboxStrategie

    private bool _selectedCheckBoxStrategieC;

    public bool SelectedCheckBoxStrategieC
    {
        get => _selectedCheckBoxStrategieC;

        set
        {
            _selectedCheckBoxStrategieC = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxStrategieCR;

    public bool SelectedCheckBoxStrategieCR
    {
        get => _selectedCheckBoxStrategieCR;

        set
        {
            _selectedCheckBoxStrategieCR = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxStrategieR;

    public bool SelectedCheckBoxStrategieR
    {
        get => _selectedCheckBoxStrategieR;

        set
        {
            _selectedCheckBoxStrategieR = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxStrategieRS;

    public bool SelectedCheckBoxStrategieRS
    {
        get => _selectedCheckBoxStrategieRS;

        set
        {
            _selectedCheckBoxStrategieRS = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxStrategieS;

    public bool SelectedCheckBoxStrategieS
    {
        get => _selectedCheckBoxStrategieS;

        set
        {
            _selectedCheckBoxStrategieS = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxStrategieSC;

    public bool SelectedCheckBoxStrategieSC
    {
        get => _selectedCheckBoxStrategieSC;

        set
        {
            _selectedCheckBoxStrategieSC = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxStrategieCSR;

    public bool SelectedCheckBoxStrategieCSR
    {
        get => _selectedCheckBoxStrategieCSR;

        set
        {
            _selectedCheckBoxStrategieCSR = value;
            OnPropertyChanged();
        }
    }

    #endregion
}