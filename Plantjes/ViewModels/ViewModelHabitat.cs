using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Documents;
using Plantjes.Dao;
using Plantjes.Models.Db;
using Plantjes.Utilities.Attributes;
using Plantjes.ViewModels.Services;

namespace Plantjes.ViewModels; 

public class ViewModelHabitat : ViewModelBase 
{
    private readonly DAOLogic _dao;
    private DetailService _detailService;

    public ViewModelHabitat(DetailService detailservice) {
        _dao = DAOLogic.Instance();
        _detailService = detailservice;
        _detailService.SelectedPlantChanged += (sender, plant) =>
        {
            ClearAllFields();

            FillPollenMin();
            FillPollenMax();
            FillNectarMin();
            FillNectarMax();
            FillOntwikkelsnelheid();
            FillSociabiliteit();
            FillPlantEigenschappen();
            FillLevensvorm();
            FillStrategie();
        };

    }



    #region Filling elements based on plant selection
    //region written by Warre based FillGrondSoort by Marijn & Xander

    public void FillPollenMin()
    {
        var modeltype = typeof(ViewModelHabitat);
        List<ExtraEigenschap> ListPollenMin =
            DAOExtraEigenschap.FilterExtraEigenschapFromPlant((int)_detailService.SelectedPlant.PlantId);

        foreach (ExtraEigenschap pollmin in ListPollenMin)
        {
            string field = "SelectedPollenwaarde";
            if (pollmin != null)
            {
                field += "Min" + pollmin.Pollenwaarde;
            }
            else
            {
                field += "Onbekend";
            }

            var prop = modeltype.GetProperty(field);
            var propsetter = prop.GetSetMethod();
            propsetter.Invoke(this, new object?[] { true });
        }
    }

    public void FillPollenMax()
    {
        var modeltype = typeof(ViewModelHabitat);
        List<ExtraEigenschap> ListPollenMax =
            DAOExtraEigenschap.FilterExtraEigenschapFromPlant((int)_detailService.SelectedPlant.PlantId);

        foreach (ExtraEigenschap pollmax in ListPollenMax)
        {
            string field = "SelectedPollenwaarde";
            if (pollmax != null)
            {
                field += "Max" + pollmax.Pollenwaarde;
            }
            else
            {
                field += "Onbekend";
            }

            var prop = modeltype.GetProperty(field);
            var propsetter = prop.GetSetMethod();
            propsetter.Invoke(this, new object?[] { true });
        }
    }

    public void FillNectarMin()
    {
        var modeltype = typeof(ViewModelHabitat);
        List<ExtraEigenschap> ListNectarMin =
            DAOExtraEigenschap.FilterExtraEigenschapFromPlant((int)_detailService.SelectedPlant.PlantId);

        foreach (ExtraEigenschap necmin in ListNectarMin)
        {
            string field = "SelectedNectarwaarde";
            if (necmin != null)
            {
                field += "Min" + necmin.Pollenwaarde;
            }
            else
            {
                field += "Onbekend";
            }

            var prop = modeltype.GetProperty(field);
            var propsetter = prop.GetSetMethod();
            propsetter.Invoke(this, new object?[] { true });
        }
    }

    public void FillNectarMax()
    {
        var modeltype = typeof(ViewModelHabitat);
        List<ExtraEigenschap> ListNectarMax =
            DAOExtraEigenschap.FilterExtraEigenschapFromPlant((int)_detailService.SelectedPlant.PlantId);

        foreach (ExtraEigenschap necmax in ListNectarMax)
        {
            string field = "SelectedNectarwaarde";
            if (necmax != null)
            {
                field += "Max" + necmax.Pollenwaarde;
            }
            else
            {
                field += "Onbekend";
            }

            var prop = modeltype.GetProperty(field);
            var propsetter = prop.GetSetMethod();
            propsetter.Invoke(this, new object?[] { true });
        }
    }

    public void FillOntwikkelsnelheid()
    {
        var modeltype = typeof(ViewModelHabitat);
        List<Commensalisme> CommListOntwikkel =
            DAOCommensalisme.FilterCommensalismeFromPlant((int)_detailService.SelectedPlant.PlantId);

        foreach (Commensalisme comm in CommListOntwikkel)
        {
            string field = "SelectedCheckBoxOntwikkelsnelheid";
            if (comm.Ontwikkelsnelheid != null)
            {
                field += comm.Ontwikkelsnelheid;
            }
            else
            {
                field += "Onbekend";
            }
            var prop = modeltype.GetProperty(field);
            var propsetter = prop.GetSetMethod();
            propsetter.Invoke(this, new object?[] { true });
        }
    }

    public void FillSociabiliteit()
    {
        var modeltype = typeof(ViewModelHabitat);
        List<CommensalismeMulti> CommListSocia =
            DAOCommensalisme.FilterCommensalismeMulti((int)_detailService.SelectedPlant.PlantId);

        foreach (CommensalismeMulti commmulti in CommListSocia)
        {
            string field = "SelectedCheckBoxSociabiliteit";
            if (commmulti.Waarde != null)
            {
                field += commmulti.Waarde;
            }
            else
            {
                field += "Onbekend";
            }
            var prop = modeltype.GetProperty(field);
            var propsetter = prop.GetSetMethod();
            propsetter.Invoke(this, new object?[] { true });
        }
    }

    public void FillPlantEigenschappen()
    {
        var modeltype = typeof(ViewModelHabitat);
        List<ExtraEigenschap> ListExtraEig =
            DAOExtraEigenschap.FilterExtraEigenschapFromPlant((int)_detailService.SelectedPlant.PlantId);

        foreach (ExtraEigenschap extra in ListExtraEig)
        {
            string field = "";

            if (extra.Bijvriendelijke.HasValue && extra.Bijvriendelijke.Value)
            {
                field = "SelectedCheckBoxBijvriendelijk";
            }

            else if (extra.Eetbaar.HasValue && extra.Eetbaar.Value)
            {
                field = "SelectedCheckBoxEetbaar";
            }

            else if (extra.Kruidgebruik.HasValue && extra.Kruidgebruik.Value)
            {
                field = "SelectedCheckBoxKruidbaar";
            }

            else if (extra.Geurend.HasValue && extra.Geurend.Value)
            {
                field = "SelectedCheckBoxGeurend";
            }

            else if (extra.Vlindervriendelijk.HasValue && extra.Vlindervriendelijk.Value)
            {
                field = "SelectedCheckBoxVlindervriendelijk";
            }

            else if (extra.Vorstgevoelig.HasValue && extra.Vorstgevoelig.Value)
            {
                field = "SelectedCheckBoxVorstgevoelig";
            }
            else
            {
                field = "SelectedCheckBoxLevensvormOnbekend";
            }

            var prop = modeltype.GetProperty(field);
            var propsetter = prop.GetSetMethod();
            propsetter.Invoke(this, new object?[] { true });
        }
    }

    public void FillLevensvorm()
    {
        var modeltype = typeof(ViewModelHabitat);
        List<CommensalismeMulti> CommultiListLeven =
            DAOCommensalisme.FilterCommensalismeMulti((int)_detailService.SelectedPlant.PlantId);
        bool exist = false;

        string field = "SelectedCheckBoxLevensvorm";
        for (int i = 0; i < CommultiListLeven.Count; i++)
        {
            exist = CommultiListLeven[i].Eigenschap.Contains("levensvorm");
        }

        if (exist)
        {
            foreach (CommensalismeMulti commulti in CommultiListLeven)
            {
                if (commulti.Eigenschap == "levensvorm")
                {
                    switch (commulti.Waarde)
                    {
                        case "zogenaamde bodembedekker, weinig verdraagzaam met andere planten":
                            field += "1";
                            break;
                        case "verdraagzame bodembedekker, ook voor een soortenrijke aanplant":
                            field += "2";
                            break;
                        case "woekerende soort, worteluitlopers":
                            field += "3";
                            break;
                        case "weinig of niet woekerend, goed te combineren":
                            field += "4";
                            break;
                        case "robuuste, meestal grote plant, ook als solitair":
                            field += "5";
                            break;
                        case "zich sterk uitzaaiende soort":
                            field += "6";
                            break;
                        case "kortlevende plant":
                            field += "7";
                            break;
                        case "geeft een goeide snijbloem":
                            field += "8";
                            break;
                        case "slelt meer eisen qua 'eten en drinken' of winterbescherming":
                            field += "9";
                            break;
                        default:
                            field += "Onbekend";
                            break;
                    }
                }
            }
        }
        else
        {
            field += "Onbekend";
        }

        var prop = modeltype.GetProperty(field);
        var propsetter = prop.GetSetMethod();
        propsetter.Invoke(this, new object?[] { true });
    }

    public void FillStrategie()
    {
        var modeltype = typeof(ViewModelHabitat);
        List<Commensalisme> CommListStrat =
            DAOCommensalisme.FilterCommensalismeFromPlant((int)_detailService.SelectedPlant.PlantId);

        foreach (Commensalisme comm in CommListStrat)
        {
            string field = "SelectedCheckBoxStrategie";
            if (comm.Strategie != null)
            {
                field += comm.Strategie;
            }
            else
            {
                field += "Onbekend";
            }

            var prop = modeltype.GetProperty(field);
            var propsetter = prop.GetSetMethod();
            propsetter.Invoke(this, new object?[] { true });
        }
    }

    #endregion



    #region Binding Pollen

    private string _selectedPollenwaardeOnbekend;
    [Clearable<string>]
    public string SelectedPollenwaardeOnbekend
    {
        get => _selectedPollenwaardeOnbekend;
        set
        {
            _selectedPollenwaardeOnbekend = value;
            OnPropertyChanged();
        }
    }

    #region PollenMin

    private string _selectedPollenwaardeMin1;
    [Clearable<string>]
    public string SelectedPollenwaardeMin1
    {
        get => _selectedPollenwaardeMin1;
        set
        {
            _selectedPollenwaardeMin1 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedPollenwaardeMin2;
    [Clearable<string>]
    public string SelectedPollenwaardeMin2
    {
        get => _selectedPollenwaardeMin2;
        set
        {
            _selectedPollenwaardeMin2 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedPollenwaardeMin3;
    [Clearable<string>]
    public string SelectedPollenwaardeMin3
    {
        get => _selectedPollenwaardeMin3;
        set
        {
            _selectedPollenwaardeMin3 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedPollenwaardeMin4;
    [Clearable<string>]
    public string SelectedPollenwaardeMin4
    {
        get => _selectedPollenwaardeMin4;
        set
        {
            _selectedPollenwaardeMin4 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedPollenwaardeMin5;
    [Clearable<string>]
    public string SelectedPollenwaardeMin5
    {
        get => _selectedPollenwaardeMin5;
        set
        {
            _selectedPollenwaardeMin5 = value;
            OnPropertyChanged();
        }
    }
    #endregion

    #region PollenMax

    private string _selectedPollenwaardeMax1;
    [Clearable<string>]
    public string SelectedPollenwaardeMax1
    {
        get => _selectedPollenwaardeMax1;
        set
        {
            _selectedPollenwaardeMax1 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedPollenwaardeMax2;
    [Clearable<string>]
    public string SelectedPollenwaardeMax2
    {
        get => _selectedPollenwaardeMax2;
        set
        {
            _selectedPollenwaardeMax2 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedPollenwaardeMax3;
    [Clearable<string>]
    public string SelectedPollenwaardeMax3
    {
        get => _selectedPollenwaardeMax3;
        set
        {
            _selectedPollenwaardeMax3 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedPollenwaardeMax4;
    [Clearable<string>]
    public string SelectedPollenwaardeMax4
    {
        get => _selectedPollenwaardeMax4;
        set
        {
            _selectedPollenwaardeMax4 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedPollenwaardeMax5;
    [Clearable<string>]
    public string SelectedPollenwaardeMax5
    {
        get => _selectedPollenwaardeMax5;
        set
        {
            _selectedPollenwaardeMax5 = value;
            OnPropertyChanged();
        }
    }
    #endregion

    #endregion

    #region Binding Nectar

    private string _selectedNectarwaardeOnbekend;
    [Clearable<string>]
    public string SelectedNectarwaardeOnbekend
    {
        get => _selectedNectarwaardeOnbekend;
        set
        {
            _selectedNectarwaardeOnbekend = value;
            OnPropertyChanged();
        }
    }

    #region NectarMin

    private string _selectedNectarwaardeMin1;
    [Clearable<string>]
    public string SelectedNectarwaardeMin1
    {
        get => _selectedNectarwaardeMin1;
        set
        {
            _selectedNectarwaardeMin1 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedNectarwaardeMin2;
    [Clearable<string>]
    public string SelectedNectarwaardeMin2
    {
        get => _selectedNectarwaardeMin2;
        set
        {
            _selectedNectarwaardeMin2 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedNectarwaardeMin3;
    [Clearable<string>]
    public string SelectedNectarwaardeMin3
    {
        get => _selectedNectarwaardeMin3;
        set
        {
            _selectedNectarwaardeMin3 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedNectarwaardeMin4;
    [Clearable<string>]
    public string SelectedNectarwaardeMin4
    {
        get => _selectedNectarwaardeMin4;
        set
        {
            _selectedNectarwaardeMin4 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedNectarwaardeMin5;
    [Clearable<string>]
    public string SelectedNectarwaardeMin5
    {
        get => _selectedNectarwaardeMin5;
        set
        {
            _selectedNectarwaardeMin5 = value;
            OnPropertyChanged();
        }
    }
    #endregion

    #region NectarMax

    private string _selectedNectarwaardeMax1;
    [Clearable<string>]
    public string SelectedNectarwaardeMax1
    {
        get => _selectedNectarwaardeMax1;
        set
        {
            _selectedNectarwaardeMax1 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedNectarwaardeMax2;
    [Clearable<string>]
    public string SelectedNectarwaardeMax2
    {
        get => _selectedNectarwaardeMax2;
        set
        {
            _selectedNectarwaardeMax2 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedNectarwaardeMax3;
    [Clearable<string>]
    public string SelectedNectarwaardeMax3
    {
        get => _selectedNectarwaardeMax3;
        set
        {
            _selectedNectarwaardeMax3 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedNectarwaardeMax4;
    [Clearable<string>]
    public string SelectedNectarwaardeMax4
    {
        get => _selectedNectarwaardeMax4;
        set
        {
            _selectedNectarwaardeMax4 = value;
            OnPropertyChanged();
        }
    }

    private string _selectedNectarwaardeMax5;
    [Clearable<string>]
    public string SelectedNectarwaardeMax5
    {
        get => _selectedNectarwaardeMax5;
        set
        {
            _selectedNectarwaardeMax5 = value;
            OnPropertyChanged();
        }
    }
    #endregion

    #endregion

    #region Binding Ontwikkelsnelheid
    //Gemaakt door Warre

    private bool _selectedCheckBoxOntwikkelsnelheidOnbekend;
    [Clearable<bool>]
    public bool SelectedCheckBoxOntwikkelsnelheidOnbekend
    {
        get => _selectedCheckBoxOntwikkelsnelheidOnbekend;
        set
        {
            _selectedCheckBoxOntwikkelsnelheidOnbekend = value;
            OnPropertyChanged();
        }
    }


    private bool _selectedCheckBoxOntwikkelsnelheidTraag;
    [Clearable<bool>]
    public bool SelectedCheckBoxOntwikkelsnelheidTraag
    {
        get => _selectedCheckBoxOntwikkelsnelheidTraag;
        set {
            _selectedCheckBoxOntwikkelsnelheidTraag = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxOntwikkelsnelheidMatig;
    [Clearable<bool>]
    public bool SelectedCheckBoxOntwikkelsnelheidMatig
    {
        get => _selectedCheckBoxOntwikkelsnelheidMatig;
        set {
            _selectedCheckBoxOntwikkelsnelheidMatig = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxOntwikkelsnelheidSnel;
    [Clearable<bool>]
    public bool SelectedCheckBoxOntwikkelsnelheidSnel
    {
        get => _selectedCheckBoxOntwikkelsnelheidSnel;
        set {
            _selectedCheckBoxOntwikkelsnelheidSnel = value;
            OnPropertyChanged();
        }
    }
    #endregion

    #region Sociabliliteit

    private bool _selectedCheckBoxSociabiliteitOnbekend;
    [Clearable<bool>]
    public bool SelectedCheckBoxSociabiliteitOnbekend
    {
        get => _selectedCheckBoxSociabiliteitOnbekend;
        set
        {
            _selectedCheckBoxSociabiliteitOnbekend = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxSociabiliteitI;
    [Clearable<bool>]
    public bool SelectedCheckBoxSociabiliteitI {
        get => _selectedCheckBoxSociabiliteitI;
        set {
            _selectedCheckBoxSociabiliteitI = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxSociabiliteitII;
    [Clearable<bool>]
    public bool SelectedCheckBoxSociabiliteitII {
        get => _selectedCheckBoxSociabiliteitII;
        set {
            _selectedCheckBoxSociabiliteitII = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxSociabiliteitIII;
    [Clearable<bool>]
    public bool SelectedCheckBoxSociabiliteitIII {
        get => _selectedCheckBoxSociabiliteitIII;
        set {
            _selectedCheckBoxSociabiliteitIII = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxSociabiliteitIV;
    [Clearable<bool>]
    public bool SelectedCheckBoxSociabiliteitIV {
        get => _selectedCheckBoxSociabiliteitIV;
        set {
            _selectedCheckBoxSociabiliteitIV = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxSociabiliteitV;
    [Clearable<bool>]
    public bool SelectedCheckBoxSociabiliteitV {
        get => _selectedCheckBoxSociabiliteitV;
        set {
            _selectedCheckBoxSociabiliteitV = value;
            OnPropertyChanged();
        }
    }
    #endregion

    #region PlantEigenschappen

    private bool _selectedCheckBoxOnbekend;
    [Clearable<bool>]
    public bool SelectedCheckBoxOnbekend
    {
        get => _selectedCheckBoxOnbekend;
        set
        {
            _selectedCheckBoxOnbekend = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxBijvriendelijk;
    [Clearable<bool>]
    public bool SelectedCheckBoxBijvriendelijk {
        get => _selectedCheckBoxBijvriendelijk;
        set {
            _selectedCheckBoxBijvriendelijk = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxEetbaar;
    [Clearable<bool>]
    public bool SelectedCheckBoxEetbaar {
        get => _selectedCheckBoxEetbaar;
        set {
            _selectedCheckBoxEetbaar = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxKruidbaar;
    [Clearable<bool>]
    public bool SelectCheckBoxKruidbaar
    {
        get => _selectedCheckBoxKruidbaar;
        set
        {
            _selectedCheckBoxKruidbaar = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGeurend;
    [Clearable<bool>]
    public bool SelectedCheckBoxGeurend {
        get => _selectedCheckBoxGeurend;
        set {
            _selectedCheckBoxGeurend = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVlindervriendelijk;
    [Clearable<bool>]
    public bool SelectedCheckBoxVlindervriendelijk {
        get => _selectedCheckBoxVlindervriendelijk;
        set {
            _selectedCheckBoxVlindervriendelijk = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVorstgevoelig;
    [Clearable<bool>]
    public bool SelectedCheckBoxVorstgevoelig {
        get => _selectedCheckBoxVorstgevoelig;
        set {
            _selectedCheckBoxVorstgevoelig = value;
            OnPropertyChanged();
        }
    }
    #endregion

    #region Levensvorm

    private bool _selectedCheckBoxLevensvormOnbekend;
    [Clearable<bool>]
    public bool SelectedCheckBoxLevensvormOnbekend
    {
        get => _selectedCheckBoxLevensvormOnbekend;
        set
        {
            _selectedCheckBoxLevensvormOnbekend = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxLevensvorm1;
    [Clearable<bool>]
    public bool SelectedCheckBoxLevensvorm1
    {
        get => _selectedCheckBoxLevensvorm1;
        set {
            _selectedCheckBoxLevensvorm1 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxLevensvorm2;
    [Clearable<bool>]
    public bool SelectedCheckBoxLevensvorm2
    {
        get => _selectedCheckBoxLevensvorm2;
        set {
            _selectedCheckBoxLevensvorm2 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxLevensvorm3;
    [Clearable<bool>]
    public bool SelectedCheckBoxLevensvorm3
    {
        get => _selectedCheckBoxLevensvorm3;
        set {
            _selectedCheckBoxLevensvorm3 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxLevensvorm4;
    [Clearable<bool>]
    public bool SelectedCheckBoxLevensvorm4
    {
        get => _selectedCheckBoxLevensvorm4;
        set {
            _selectedCheckBoxLevensvorm4 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxLevensvorm5;
    [Clearable<bool>]
    public bool SelectedCheckBoxLevensvorm5
    {
        get => _selectedCheckBoxLevensvorm5;
        set {
            _selectedCheckBoxLevensvorm5 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxLevensvorm6;
    [Clearable<bool>]
    public bool SelectedCheckBoxLevensvorm6
    {
        get => _selectedCheckBoxLevensvorm6;
        set {
            _selectedCheckBoxLevensvorm6 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxLevensvorm7;
    [Clearable<bool>]
    public bool SelectedCheckBoxLevensvorm7
    {
        get => _selectedCheckBoxLevensvorm7;
        set {
            _selectedCheckBoxLevensvorm7 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxLevensvorm8;
    [Clearable<bool>]
    public bool SelectedCheckBoxLevensvorm8
    {
        get => _selectedCheckBoxLevensvorm8;
        set {
            _selectedCheckBoxLevensvorm8 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxLevensvorm9;
    [Clearable<bool>]
    public bool SelectedCheckBoxLevensvorm9
    {
        get => _selectedCheckBoxLevensvorm9;
        set {
            _selectedCheckBoxLevensvorm9 = value;
            OnPropertyChanged();
        }
    }
    #endregion

    #region CheckboxStrategie

    private bool _selectedCheckBoxStrategieOnbekend;
    [Clearable<bool>]
    public bool SelectedCheckBoxStrategieOnbekend
    {
        get => _selectedCheckBoxStrategieOnbekend;

        set
        {
            _selectedCheckBoxStrategieOnbekend = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxStrategieC;
    [Clearable<bool>]
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
    [Clearable<bool>]
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
    [Clearable<bool>]
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
    [Clearable<bool>]
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
    [Clearable<bool>]
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
    [Clearable<bool>]
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
    [Clearable<bool>]
    public bool SelectedCheckBoxStrategieCSR
    {
        get => _selectedCheckBoxStrategieCSR;

        set
        {
            _selectedCheckBoxStrategieCSR = value;
            MessageBox.Show(SelectedCheckBoxStrategieCSR.ToString());
            OnPropertyChanged();
        }
    }

    #endregion
}