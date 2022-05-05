using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Data;
using Plantjes.Dao;
using Plantjes.Models.Db;
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
            FillGrondSoort();
        };
    }

    public void FillGrondSoort()
    {
        var modeltype = typeof(ViewModelGrow);
        List<AbiotiekMulti> AbioList =
            DAOAbiotiek.filterAbiotiekMultiFromPlant((int)_detailService.SelectedPlant.PlantId);
        foreach (AbiotiekMulti abimulti in AbioList)
        {
            var prop = modeltype.GetProperty($"SelectedCheckBoxGrondsoort{abimulti.Waarde}");
            var propsetter = prop.GetSetMethod();
            propsetter.Invoke(this, new object[] { true });
        }
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

    #region Bezonning
    private string _selectedCheckBoxBezonningZ;

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

    #region Antagonische omgeving
    //Gemaakt door Warre
    private string _selectedCheckBoxAntagonischGeenInvloed;

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

    public string SelectedCheckBoxGrondSoortK
    {
        get => SelectedCheckBoxGrondSoortK;
        set
        {
            _selectedCheckBoxGrondSoortK = value;
            OnPropertyChanged();
        }
    }

    private string _selectedCheckBoxGrondSoortZLK;

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