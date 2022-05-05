using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Data;
using Plantjes.Dao;
using Plantjes.Models.Db;
using Plantjes.Utilities.Attributes;
using Plantjes.ViewModels.Services;

namespace Plantjes.ViewModels; 

public class ViewModelGrow : ViewModelBase {
    private DAOLogic _dao;
    private DetailService _detailService;

    public ViewModelGrow(DetailService detailservice) {
        _detailService = detailservice;
        _dao = DAOLogic.Instance();
        _detailService.SelectedPlantChanged += (sender, plant) =>
        {
            ClearAllFields();

            FillGrondSoort();
        };
    }


    #region Filling elements based on plant selection
    //region written by Marijn with Xander's help

    public void FillGrondSoort()
    {
        //het nemen van modeltype van de huidige viewmodel en een lijst van abiotiekmulti gegevens op basis van geselecteerde plant id
        var modeltype = typeof(ViewModelGrow);
        List<AbiotiekMulti> AbioList =
            DAOAbiotiek.filterAbiotiekMultiFromPlant((int)_detailService.SelectedPlant.PlantId);

        //checkboxes invullen waar nodig
        foreach (AbiotiekMulti abimulti in AbioList)
        {
            var prop = modeltype.GetProperty($"SelectedCheckBoxGrondsoort{abimulti.Waarde}");
            var propsetter = prop.GetSetMethod();
            propsetter.Invoke(this, new object[] { true });
        }
    }

    #endregion
    //geschreven door christophe, op basis van een voorbeeld van owen

    #region CheckboxGrondsoort

    private bool _selectedCheckBoxGrondsoortGB1;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortGB1 {
        get => _selectedCheckBoxGrondsoortGB1;

        set {
            _selectedCheckBoxGrondsoortGB1 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortGB2;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortGB2 {
        get => _selectedCheckBoxGrondsoortGB2;

        set {
            _selectedCheckBoxGrondsoortGB2 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortGB3;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortGB3 {
        get => _selectedCheckBoxGrondsoortGB3;

        set {
            _selectedCheckBoxGrondsoortGB3 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortOP1;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortOP1 {
        get => _selectedCheckBoxGrondsoortOP1;

        set {
            _selectedCheckBoxGrondsoortOP1 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortOP1B;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortOP1B {
        get => _selectedCheckBoxGrondsoortOP1B;

        set {
            _selectedCheckBoxGrondsoortOP1B = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortOP2;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortOP2 {
        get => _selectedCheckBoxGrondsoortOP2;

        set {
            _selectedCheckBoxGrondsoortOP2 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortOP2B;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortOP2B {
        get => _selectedCheckBoxGrondsoortOP2B;

        set {
            _selectedCheckBoxGrondsoortOP2B = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortOP3;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortOP3 {
        get => _selectedCheckBoxGrondsoortOP3;

        set {
            _selectedCheckBoxGrondsoortOP3 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortOP3B;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortOP3B {
        get => _selectedCheckBoxGrondsoortOP3B;

        set {
            _selectedCheckBoxGrondsoortOP3B = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortSH1;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortSH1 {
        get => _selectedCheckBoxGrondsoortSH1;

        set {
            _selectedCheckBoxGrondsoortSH1 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortSH2;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortSH2 {
        get => _selectedCheckBoxGrondsoortSH2;

        set {
            _selectedCheckBoxGrondsoortSH2 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortB1;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortB1 {
        get => _selectedCheckBoxGrondsoortB1;

        set {
            _selectedCheckBoxGrondsoortB1 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortB2;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortB2 {
        get => _selectedCheckBoxGrondsoortB2;

        set {
            _selectedCheckBoxGrondsoortB2 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortB3;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortB3 {
        get => _selectedCheckBoxGrondsoortB3;

        set {
            _selectedCheckBoxGrondsoortB3 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortGR1;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortGR1 {
        get => _selectedCheckBoxGrondsoortGR1;

        set {
            _selectedCheckBoxGrondsoortGR1 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortGR2;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortGR2 {
        get => _selectedCheckBoxGrondsoortGR2;

        set {
            _selectedCheckBoxGrondsoortGR2 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortH1;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortH1 {
        get => _selectedCheckBoxGrondsoortH1;

        set {
            _selectedCheckBoxGrondsoortH1 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortH2;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortH2 {
        get => _selectedCheckBoxGrondsoortH2;

        set {
            _selectedCheckBoxGrondsoortH2 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortST1;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortST1 {
        get => _selectedCheckBoxGrondsoortST1;

        set {
            _selectedCheckBoxGrondsoortST1 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortST2;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortST2 {
        get => _selectedCheckBoxGrondsoortST2;

        set {
            _selectedCheckBoxGrondsoortST2 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortBR1;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortBR1 {
        get => _selectedCheckBoxGrondsoortBR1;

        set {
            _selectedCheckBoxGrondsoortBR1 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortBR2;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortBR2 {
        get => _selectedCheckBoxGrondsoortBR2;

        set {
            _selectedCheckBoxGrondsoortBR2 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortBR3;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortBR3 {
        get => _selectedCheckBoxGrondsoortBR3;

        set {
            _selectedCheckBoxGrondsoortBR3 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortOB1;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortOB1 {
        get => _selectedCheckBoxGrondsoortOB1;

        set {
            _selectedCheckBoxGrondsoortOB1 = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxGrondsoortOB2;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortOB2 {
        get => _selectedCheckBoxGrondsoortOB2;

        set {
            _selectedCheckBoxGrondsoortOB2 = value;
            OnPropertyChanged();
        }
    }
    private bool _selectedCheckBoxGrondsoortA1;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortA1
    {
        get => _selectedCheckBoxGrondsoortA1;

        set
        {
            _selectedCheckBoxGrondsoortA1 = value;
            OnPropertyChanged();
        }
    }
    private bool _selectedCheckBoxGrondsoortA2;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortA2
    {
        get => _selectedCheckBoxGrondsoortA2;

        set
        {
            _selectedCheckBoxGrondsoortA2 = value;
            OnPropertyChanged();
        }
    }
    private bool _selectedCheckBoxGrondsoortM1;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortM1
    {
        get => _selectedCheckBoxGrondsoortM1;

        set
        {
            _selectedCheckBoxGrondsoortM1 = value;
            OnPropertyChanged();
        }
    }
    private bool _selectedCheckBoxGrondsoortM2;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortM2
    {
        get => _selectedCheckBoxGrondsoortM2;

        set
        {
            _selectedCheckBoxGrondsoortM2 = value;
            OnPropertyChanged();
        }
    }
    private bool _selectedCheckBoxGrondsoortO4;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortO4
    {
        get => _selectedCheckBoxGrondsoortO4;

        set
        {
            _selectedCheckBoxGrondsoortO4 = value;
            OnPropertyChanged();
        }
    }
    private bool _selectedCheckBoxGrondsoortO5;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortO5
    {
        get => _selectedCheckBoxGrondsoortO5;

        set
        {
            _selectedCheckBoxGrondsoortO5 = value;
            OnPropertyChanged();
        }
    }
    private bool _selectedCheckBoxGrondsoortSV1;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortSV1
    {
        get => _selectedCheckBoxGrondsoortSV1;

        set
        {
            _selectedCheckBoxGrondsoortSV1 = value;
            OnPropertyChanged();
        }
    }
    private bool _selectedCheckBoxGrondsoortSV2;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortSV2
    {
        get => _selectedCheckBoxGrondsoortSV2;

        set
        {
            _selectedCheckBoxGrondsoortSV2 = value;
            OnPropertyChanged();
        }
    }
    private bool _selectedCheckBoxGrondsoortSV3;

    [Clearable<bool>]
    public bool SelectedCheckBoxGrondsoortSV3
    {
        get => _selectedCheckBoxGrondsoortSV3;

        set
        {
            _selectedCheckBoxGrondsoortSV3 = value;
            OnPropertyChanged();
        }
    }

    #endregion

    #region Bezonning
    private string _selectedCheckBoxBezonningZ;

    [Clearable<bool>]
    public string SelectedCheckBoxBezonningZ
    {
        get => _selectedCheckBoxBezonningZ;
        set
        {
            _selectedCheckBoxBezonningZ = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxBezonningS;

    [Clearable<bool>]
    public string SelectedCheckBoxBezonningS
    {
        get => _selectedCheckBoxBezonningS;
        set
        {
            _selectedCheckBoxBezonningS = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxBezonningHS;

    [Clearable<bool>]
    public string SelectedCheckBoxBezonningHS
    {
        get => _selectedCheckBoxBezonningHS;
        set
        {
            _selectedCheckBoxBezonningHS = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxBezonningZS;

    [Clearable<bool>]
    public string SelectedCheckBoxBezonningZS
    {
        get => _selectedCheckBoxBezonningZS;
        set
        {
            _selectedCheckBoxBezonningZS = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxBezonningZHS;

    [Clearable<bool>]
    public string SelectedCheckBoxBezonningZHS
    {
        get => _selectedCheckBoxBezonningZHS;
        set
        {
            _selectedCheckBoxBezonningZHS = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxBezonningZHSS;

    [Clearable<bool>]
    public string SelectCheckBoxBezonningZHSS
    {
        get => _selectedCheckBoxBezonningZHSS;
        set
        {
            _selectedCheckBoxBezonningZHSS = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxBezonningHSS;

    [Clearable<bool>]
    public string SelectedCheckBoxBezonningHSS
    {
        get => _selectedCheckBoxBezonningHSS;
        set
        {
            _selectedCheckBoxBezonningHSS = value;
            OnPropertyChanged();
        }
    }
    #endregion

    #region CheckboxVoedingsbehoefte

    private bool _selectedCheckBoxVoedingsbehoefteArm;

    [Clearable<bool>]
    public bool SelectedCheckBoxVoedingsbehoefteArm {
        get => _selectedCheckBoxVoedingsbehoefteArm;

        set {
            _selectedCheckBoxVoedingsbehoefteArm = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVoedingsbehoefteArmMatig;

    [Clearable<bool>]
    public bool SelectedCheckBoxVoedingsbehoefteArmMatig {
        get => _selectedCheckBoxVoedingsbehoefteArmMatig;

        set {
            _selectedCheckBoxVoedingsbehoefteArmMatig = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVoedingsbehoefteMatig;

    [Clearable<bool>]
    public bool SelectedCheckBoxVoedingsbehoefteMatig {
        get => _selectedCheckBoxVoedingsbehoefteMatig;

        set {
            _selectedCheckBoxVoedingsbehoefteMatig = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVoedingsbehoefteMatigVoedselrijk;

    [Clearable<bool>]
    public bool SelectedCheckBoxVoedingsbehoefteMatigVoedselrijk {
        get => _selectedCheckBoxVoedingsbehoefteMatigVoedselrijk;

        set {
            _selectedCheckBoxVoedingsbehoefteMatigVoedselrijk = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVoedingsbehoefteVoedselrijk;

    [Clearable<bool>]
    public bool SelectedCheckBoxVoedingsbehoefteVoedselrijk {
        get => _selectedCheckBoxVoedingsbehoefteVoedselrijk;

        set {
            _selectedCheckBoxVoedingsbehoefteVoedselrijk = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVoedingsbehoefteVoedselrijkIndifferent;

    [Clearable<bool>]
    public bool SelectedCheckBoxVoedingsbehoefteVoedselrijkIndifferent {
        get => _selectedCheckBoxVoedingsbehoefteVoedselrijkIndifferent;

        set {
            _selectedCheckBoxVoedingsbehoefteVoedselrijkIndifferent = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVoedingsbehoefteIndifferent;

    [Clearable<bool>]
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

    [Clearable<bool>]
    public bool SelectedCheckBoxVochtbehoefteDroog {
        get => _selectedCheckBoxVochtbehoefteDroog;

        set {
            _selectedCheckBoxVochtbehoefteDroog = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVochtbehoefteDroogFris;

    [Clearable<bool>]
    public bool SelectedCheckBoxVochtbehoefteDroogFris {
        get => _selectedCheckBoxVochtbehoefteDroogFris;

        set {
            _selectedCheckBoxVochtbehoefteDroogFris = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVochtbehoefteFris;

    [Clearable<bool>]
    public bool SelectedCheckBoxVochtbehoefteFris {
        get => _selectedCheckBoxVochtbehoefteFris;

        set {
            _selectedCheckBoxVochtbehoefteFris = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVochtbehoefteFrisVochtig;

    [Clearable<bool>]
    public bool SelectedCheckBoxVochtbehoefteFrisVochtig {
        get => _selectedCheckBoxVochtbehoefteFrisVochtig;

        set {
            _selectedCheckBoxVochtbehoefteFrisVochtig = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVochtbehoefteVochtig;

    [Clearable<bool>]
    public bool SelectedCheckBoxVochtbehoefteVochtig {
        get => _selectedCheckBoxVochtbehoefteVochtig;

        set {
            _selectedCheckBoxVochtbehoefteVochtig = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVochtbehoefteVochtigNat;

    [Clearable<bool>]
    public bool SelectedCheckBoxVochtbehoefteVochtigNat {
        get => _selectedCheckBoxVochtbehoefteVochtigNat;

        set {
            _selectedCheckBoxVochtbehoefteVochtigNat = value;
            OnPropertyChanged();
        }
    }

    private bool _selectedCheckBoxVochtbehoefteNat;

    [Clearable<bool>]
    public bool SelectedCheckBoxVochtbehoefteNat {
        get => _selectedCheckBoxVochtbehoefteNat;

        set {
            _selectedCheckBoxVochtbehoefteNat = value;
            OnPropertyChanged();
        }
    }

    #endregion

    #region Antagonische omgeving
    //Gemaakt door Warre
    private string _selectedCheckBoxAntagonischGeenInvloed;

    [Clearable<bool>]
    public string SelectedCheckBoxAntagonischGeenInvloed
    {
        get => _selectedCheckBoxAntagonischGeenInvloed;
        set
        {
            _selectedCheckBoxAntagonischGeenInvloed = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxAntagonischTerugDringen;

    [Clearable<bool>]
    public string SelectedCheckBoxAntagonischTerugDringen
    {
        get => _selectedCheckBoxAntagonischTerugDringen;
        set
        {
            _selectedCheckBoxAntagonischTerugDringen = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxAntagonischGereduceerd;

    [Clearable<bool>]
    public string SelectedCheckBoxAntagonischGereduceerd
    {
        get => _selectedCheckBoxAntagonischGereduceerd;
        set
        {
            _selectedCheckBoxAntagonischGereduceerd = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxAntagonischGroei;

    [Clearable<bool>]
    public string SelectedCheckBoxAntagonischGroei
    {
        get => _selectedCheckBoxAntagonischGroei;
        set
        {
            _selectedCheckBoxAntagonischGroei = value;
            OnPropertyChanged();
        }
    }

    #endregion

    #region Grondsoort
    //Gemaakt door Warre
    private string _selectedCheckBoxGrondSoortZ;

    [Clearable<bool>]
    public string SelectedCheckBoxGrondSoortZ
    {
        get => _selectedCheckBoxGrondSoortZ;
        set
        {
            _selectedCheckBoxGrondSoortZ = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxGrondSoortZL;

    [Clearable<bool>]
    public string SelectedCheckBoxGrondSoortZL
    {
        get => _selectedCheckBoxGrondSoortZL;
        set
        {
            _selectedCheckBoxGrondSoortZL = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxGrondSoortL;

    [Clearable<bool>]
    public string SelectedCheckBoxGrondSoortL
    {
        get => _selectedCheckBoxGrondSoortL;
        set
        {
            _selectedCheckBoxGrondSoortL = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxGrondSoortLK;

    [Clearable<bool>]
    public string SelectedCheckBoxGrondSoortLK
    {
        get => _selectedCheckBoxGrondSoortLK;
        set
        {
            _selectedCheckBoxGrondSoortLK = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxGrondSoortK;

    [Clearable<bool>]
    public string SelectedCheckBoxGrondSoortK
    {
        get => _selectedCheckBoxGrondSoortK;
        set
        {
            _selectedCheckBoxGrondSoortK = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxGrondSoortZLK;

    [Clearable<bool>]
    public string SelectedCheckBoxGrondSoortZLK
    {
        get => _selectedCheckBoxGrondSoortZLK;
        set
        {
            _selectedCheckBoxGrondSoortZLK = value;
            OnPropertyChanged();
        }
    }

    #endregion
}