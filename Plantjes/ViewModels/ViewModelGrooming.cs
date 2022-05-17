using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Documents;
using Plantjes.Dao;
using Plantjes.Models.Db;
using Plantjes.ViewModels.Services;

namespace Plantjes.ViewModels;

public class ViewModelGrooming : ViewModelBase
{
    private DAOLogic _dao;
    private DetailService _detailService;

    private string _selectedBeheerdaad;


    public ViewModelGrooming(DetailService detailservice)
    {
        _dao = DAOLogic.Instance();
        _detailService = detailservice;
        _detailService.SelectedPlantChanged += (sender, plant) =>
        {
            ClearAllFields();

            if (_detailService.SelectedPlant != null)
            {
                FillBeheerdaadMaand();
            }
        };

        cmbBeheerdaad = new ObservableCollection<string>();

        
    }

    //geschreven door christophe, op basis van een voorbeeld van owen
    public ObservableCollection<string> cmbBeheerdaad { get; set; }

    //Aangepast door Warre

    #region Filling elements based on plant selection
    //region written by Warre based on FillGrondSoort by Marijn & Xander

    private void FillBeheerdaadMaand()
    {
        var modeltype = typeof(ViewModelGrooming);
        List<BeheerMaand> BeheerList =
            DAOBeheerMaand.FilterBeheerMaandFromPlant((int)_detailService.SelectedPlant.PlantId);

        foreach (BeheerMaand beheer in BeheerList)
        {
            string field = "";
            if (beheer.Jan.HasValue && beheer.Jan.Value)
            {
                field = "SelectedCheckBoxJan";
            }
            else if (beheer.Jan.HasValue && beheer.Jan.Value)
            {
                field = "SelectedCheckBoxJan";
            }
            else if (beheer.Jan.HasValue && beheer.Jan.Value)
            {
                field = "SelectedCheckBoxJan";
            }
            else if(beheer.Jan.HasValue && beheer.Jan.Value)
            {
                field = "SelectedCheckBoxJan";
            }
            else if (beheer.Jan.HasValue && beheer.Jan.Value)
            {
                field = "SelectedCheckBoxJan";
            }
            else if (beheer.Jan.HasValue && beheer.Jan.Value)
            {
                field = "SelectedCheckBoxJan";
            }
            else if (beheer.Jan.HasValue && beheer.Jan.Value)
            {
                field = "SelectedCheckBoxJan";
            }
            else if (beheer.Jan.HasValue && beheer.Jan.Value)
            {
                field = "SelectedCheckBoxJan";
            }
            else if (beheer.Jan.HasValue && beheer.Jan.Value)
            {
                field = "SelectedCheckBoxJan";
            }
            else if (beheer.Jan.HasValue && beheer.Jan.Value)
            {
                field = "SelectedCheckBoxJan";
            }
            else if (beheer.Jan.HasValue && beheer.Jan.Value)
            {
                field = "SelectedCheckBoxJan";
            }
            else if (beheer.Jan.HasValue && beheer.Jan.Value)
            {
                field = "SelectedCheckBoxJan";
            }
            else
            {
                
            }

        }
    }
    #endregion


    #region Binding checkboxen Beheerdaad maand

    private bool _selectedCheckBoxJan;

    public bool SelectedCheckBoxJan
    {
        get => _selectedCheckBoxJan;

        set
        {
            _selectedCheckBoxJan = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxFeb;

    public bool SelectedCheckBoxFeb
    {
        get => _selectedCheckBoxFeb;

        set
        {
            _selectedCheckBoxFeb = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxMar;

    public bool SelectedCheckBoxMar
    {
        get => _selectedCheckBoxMar;

        set
        {
            _selectedCheckBoxMar = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxApr;

    public bool SelectedCheckBoxApr
    {
        get => _selectedCheckBoxApr;

        set
        {
            _selectedCheckBoxApr = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxMay;

    public bool SelectedCheckBoxFMay
    {
        get => _selectedCheckBoxMay;

        set
        {
            _selectedCheckBoxMay = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxJun;

    public bool SelectedCheckBoxJun
    {
        get => _selectedCheckBoxJun;

        set
        {
            _selectedCheckBoxJun = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxJul;

    public bool SelectedCheckBoxJul
    {
        get => _selectedCheckBoxJul;

        set
        {
            _selectedCheckBoxJul = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxAug;

    public bool SelectedCheckBoxAug
    {
        get => _selectedCheckBoxAug;

        set
        {
            _selectedCheckBoxAug = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxSep;

    public bool SelectedCheckBoxSep
    {
        get => _selectedCheckBoxSep;

        set
        {
            _selectedCheckBoxSep = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxOct;

    public bool SelectedCheckBoxOct
    {
        get => _selectedCheckBoxOct;

        set
        {
            _selectedCheckBoxOct = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxNov;

    public bool SelectedCheckBoxNov
    {
        get => _selectedCheckBoxNov;

        set
        {
            _selectedCheckBoxNov = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxDec;

    public bool SelectedCheckBoxDec
    {
        get => _selectedCheckBoxDec;

        set
        {
            _selectedCheckBoxDec = value;
            OnPropertyChanged();
        }
    }

    #endregion
}