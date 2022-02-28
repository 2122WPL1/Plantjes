namespace Plantjes.Models.Db; 

public class TfgsvSoort {
    public long Soortid { get; set; }
    public long GeslachtGeslachtId { get; set; }
    public string Soortnaam { get; set; }
    public string NlNaam { get; set; }

    public virtual TfgsvGeslacht GeslachtGeslacht { get; set; }
}