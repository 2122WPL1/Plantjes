using System.Collections.Generic;
using System.Linq;
using Plantjes.Models.Db;

namespace Plantjes.Dao;

public partial class DAOLogic {
    public List<Commensalisme> GetAllCommensalisme() {
        return context.Commensalismes.ToList();
    }

    public List<CommensalismeMulti> GetAllCommensalismeMulti() {
        //List is unfiltered, a plantId can be present multiple times
        //The aditional filtering will take place in the ViewModel
        return context.CommensalismeMultis.ToList();
    }

    #region FilterCommensalismeFromPlant

    public IQueryable<Commensalisme> FilterCommensalismeFromPlant(int selectedItem) {
        return context.Commensalismes.Distinct().Where(s => s.PlantId == selectedItem);
    }

    public IQueryable<CommensalismeMulti> FilterCommensalismeMulti(int selectedItem) {
        return context.CommensalismeMultis.Distinct().Where(s => s.PlantId == selectedItem);
    }

    #endregion
}