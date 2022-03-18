using System.Collections.ObjectModel;
using System.Windows;
using Plantjes.Dao;
using Plantjes.Models.Db;
using Plantjes.ViewModels.Interfaces;

namespace Plantjes.ViewModels; 

public class ViewModelHabitat : ViewModelBase 
{
    private readonly DAOLogic _dao;

    private string _selectedNectarwaarde;

    private string _selectedOntwikkelsnelheid;

    private string _selectedPollenwaarde;

    public ViewModelHabitat(IDetailService detailservice) {
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

    //geschreven door christophe, op basis van een voorbeeld van owen
    public void fillComboBoxPollenwaarde() {
        var list = DAOExtraPollen.FillExtraPollenwaardes();

        foreach (var item in list) cmbPollenWaarde.Add(item);
    }

    public void fillComboBoxNectarwaarde() {
        var list = DAOExtraNectar.FillExtraNectarwaardes();

        foreach (var item in list) cmbNectarWaarde.Add(item);
    }

    #region Binding checkboxen Habitat

    private string _selectedCheckBoxHabitat1;

    public string SelectedCheckBoxHabitat1 {
        get => _selectedCheckBoxHabitat1;
        set {
            _selectedCheckBoxHabitat1 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxHabitat2;

    public string SelectedCheckBoxHabitat2 {
        get => _selectedCheckBoxHabitat2;
        set {
            _selectedCheckBoxHabitat2 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxHabitat3;

    public string SelectedCheckBoxHabitat3 {
        get => _selectedCheckBoxHabitat3;
        set {
            _selectedCheckBoxHabitat3 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxHabitat4;

    public string SelectedCheckBoxHabitat4 {
        get => _selectedCheckBoxHabitat4;
        set {
            _selectedCheckBoxHabitat4 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxHabitat5;

    public string SelectedCheckBoxHabitat5 {
        get => _selectedCheckBoxHabitat5;
        set {
            _selectedCheckBoxHabitat5 = value;
            MessageBox.Show(SelectedCheckBoxHabitat5);
            OnPropertyChanged();
        }
    }


    private string _selectedCheckBoxBezonningZ;

    public string SelectedCheckBoxBezonningZ {
        get => _selectedCheckBoxBezonningZ;
        set {
            _selectedCheckBoxBezonningZ = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxBezonningZHS;

    public string SelectedCheckBoxBezonningZHS {
        get => _selectedCheckBoxBezonningZHS;
        set {
            _selectedCheckBoxBezonningZHS = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxBezonningHS;

    public string SelectedCheckBoxBezonningHS {
        get => _selectedCheckBoxBezonningHS;
        set {
            _selectedCheckBoxBezonningHS = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxBezonningHSS;

    public string SelectedCheckBoxBezonningHSS {
        get => _selectedCheckBoxBezonningHSS;
        set {
            _selectedCheckBoxBezonningHSS = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxBezonningS;

    public string SelectedCheckBoxBezonningS {
        get => _selectedCheckBoxBezonningS;
        set {
            _selectedCheckBoxBezonningS = value;
            OnPropertyChanged();
        }
    }


    private string _selectedCheckBoxSociabiliteitI;

    public string SelectedCheckBoxSociabiliteitI {
        get => _selectedCheckBoxSociabiliteitI;
        set {
            _selectedCheckBoxSociabiliteitI = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxSociabiliteitII;

    public string SelectedCheckBoxSociabiliteitII {
        get => _selectedCheckBoxSociabiliteitII;
        set {
            _selectedCheckBoxSociabiliteitII = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxSociabiliteitIII;

    public string SelectedCheckBoxSociabiliteitIII {
        get => _selectedCheckBoxSociabiliteitIII;
        set {
            _selectedCheckBoxSociabiliteitIII = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxSociabiliteitIV;

    public string SelectedCheckBoxSociabiliteitIV {
        get => _selectedCheckBoxSociabiliteitIV;
        set {
            _selectedCheckBoxSociabiliteitIV = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxSociabiliteitV;

    public string SelectedCheckBoxSociabiliteitV {
        get => _selectedCheckBoxSociabiliteitV;
        set {
            _selectedCheckBoxSociabiliteitV = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxBijvriendelijk;

    public string SelectedCheckBoxBijvriendelijk {
        get => _selectedCheckBoxBijvriendelijk;
        set {
            _selectedCheckBoxBijvriendelijk = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxEetbaarKruidbaar;

    public string SelectedCheckBoxEetbaarKruidbaar {
        get => _selectedCheckBoxEetbaarKruidbaar;
        set {
            _selectedCheckBoxEetbaarKruidbaar = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxGeurend;

    public string SelectedCheckBoxGeurend {
        get => _selectedCheckBoxGeurend;
        set {
            _selectedCheckBoxGeurend = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxVlindervriendelijk;

    public string SelectedCheckBoxVlindervriendelijk {
        get => _selectedCheckBoxVlindervriendelijk;
        set {
            _selectedCheckBoxVlindervriendelijk = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxVorstgevoelig;

    public string SelectedCheckBoxVorstgevoelig {
        get => _selectedCheckBoxVorstgevoelig;
        set {
            _selectedCheckBoxVorstgevoelig = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBox1;

    public string SelectedCheckBox1 {
        get => _selectedCheckBox1;
        set {
            _selectedCheckBox1 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBox2;

    public string SelectedCheckBox2 {
        get => _selectedCheckBox2;
        set {
            _selectedCheckBox2 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBox3;

    public string SelectedCheckBox3 {
        get => _selectedCheckBox3;
        set {
            _selectedCheckBox3 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBox4;

    public string SelectedCheckBox4 {
        get => _selectedCheckBox4;
        set {
            _selectedCheckBox4 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBox5;

    public string SelectedCheckBox5 {
        get => _selectedCheckBox5;
        set {
            _selectedCheckBox5 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBox6;

    public string SelectedCheckBox6 {
        get => _selectedCheckBox6;
        set {
            _selectedCheckBox6 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBox7;

    public string SelectedCheckBox7 {
        get => _selectedCheckBox7;
        set {
            _selectedCheckBox7 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBox8;

    public string SelectedCheckBox8 {
        get => _selectedCheckBox8;
        set {
            _selectedCheckBox8 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBox9;

    public string SelectedCheckBox9 {
        get => _selectedCheckBox9;
        set {
            _selectedCheckBox9 = value;
            MessageBox.Show(SelectedCheckBox9);
            OnPropertyChanged();
        }
    }

    #endregion
}