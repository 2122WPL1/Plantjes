using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Documents;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.VisualBasic;
using Plantjes.Dao;
using Plantjes.Models.Db;
using Plantjes.ViewModels.Services;

namespace Plantjes.ViewModels;

public class ViewModelGrooming : ViewModelBase
{
    private DAOLogic _dao;
    private DetailService _detailService;
    
    private IList<string> _beheerOmschrijving = new List<string>();
    private Dictionary<string, string> _beheerVulling = new Dictionary<string, string>();
    public string BeheerText { get; set; }


    public ViewModelGrooming(DetailService detailservice)
    {
        _dao = DAOLogic.Instance();
        _detailService = detailservice;
        _detailService.SelectedPlantChanged += (sender, plant) =>
        {
            ClearAllFields();

            if (_detailService.SelectedPlant != null)
            {
                FillBeheerComboboxCollections();
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

    public void fillComboBoxType(ObservableCollection<TfgsvType> cmbTypeCollection)
    {
        var list = DAOTfgsv.fillTfgsvType();

        foreach (var item in list) cmbTypeCollection.Add(item);
    }

    private void FillBeheerComboboxCollections()
    {
        var modeltype = typeof(ViewModelGrooming);
        List<BeheerMaand> BeheerList =
            DAOBeheerMaand.FilterBeheerMaandFromPlant((int)_detailService.SelectedPlant.PlantId);
        foreach (BeheerMaand beheer in BeheerList)
        {
            cmbBeheerdaad.Add(beheer.Beheerdaad);
            BeheerOmschrijving.Add(beheer.Omschrijving);
            BeheerVulling.Add(beheer.Beheerdaad, beheer.Omschrijving);
        }
    }

    private void FillBeheerdaadMaand()
    {
        var modeltype = typeof(ViewModelGrooming);
        List<BeheerMaand> BeheerList =
            DAOBeheerMaand.FilterBeheerMaandFromPlant((int)_detailService.SelectedPlant.PlantId);
        foreach (BeheerMaand beheer in BeheerList)
        {
            if (beheer.Jan.HasValue && beheer.Jan.Value)
            {
                SelectedCheckBoxJan = beheer.Jan.Value;
            }
            if (beheer.Feb.HasValue && beheer.Feb.Value)
            {
                SelectedCheckBoxFeb = beheer.Feb.Value;
            }
            if (beheer.Mrt.HasValue && beheer.Mrt.Value)
            {
                SelectedCheckBoxMar = beheer.Mrt.Value;
            }
            if (beheer.Apr.HasValue && beheer.Apr.Value)
            {
                SelectedCheckBoxApr = beheer.Apr.Value;
            }
            if (beheer.Mei.HasValue && beheer.Mei.Value)
            {
                SelectedCheckBoxMay = beheer.Mei.Value;
            }
            if (beheer.Jun.HasValue && beheer.Jun.Value)
            {
                SelectedCheckBoxJun = beheer.Jun.Value;
            }
            if (beheer.Jul.HasValue && beheer.Jul.Value)
            {
                SelectedCheckBoxJul = beheer.Jul.Value;
            }
            if (beheer.Aug.HasValue && beheer.Aug.Value)
            {
                SelectedCheckBoxAug = beheer.Aug.Value;
            }
            if (beheer.Sept.HasValue && beheer.Sept.Value)
            {
                SelectedCheckBoxSep = beheer.Sept.Value;
            }
            if (beheer.Okt.HasValue && beheer.Okt.Value)
            {
                SelectedCheckBoxOct = beheer.Okt.Value;
            }
            if (beheer.Nov.HasValue && beheer.Nov.Value)
            {
                SelectedCheckBoxNov = beheer.Nov.Value;
            }
            if (beheer.Dec.HasValue && beheer.Dec.Value)
            {
                SelectedCheckBoxDec = beheer.Dec.Value;
            }
        }
    }
    #endregion

    #region Binding combobox items/opvulling

    public Dictionary<string, string> BeheerVulling
    {
        get => _beheerVulling;

        set
        {
            _beheerVulling = value;
            OnPropertyChanged();
        }
    }

    public IList<string> BeheerOmschrijving
    {
        get => _beheerOmschrijving;

        set
        {
            _beheerOmschrijving = value;
            OnPropertyChanged();
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

    public bool SelectedCheckBoxMay
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