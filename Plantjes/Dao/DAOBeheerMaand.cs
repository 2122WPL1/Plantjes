using System.Collections.Generic;
using System.Linq;
using Plantjes.Models.Db;

namespace Plantjes.Dao;

public partial class DAOLogic {
    #region FilterBeheerMaandFromPlant

    public IQueryable<BeheerMaand> FilterBeheerMaandFromPlant(int selectedItem) {
        return context.BeheerMaands.Distinct().Where(s => s.PlantId == selectedItem);
    }

    #endregion

    public List<BeheerMaand> FillBeheerdaad() {
        return context.BeheerMaands.ToList();
    }

    //Get a list of all the Beheermaand types
    public List<BeheerMaand> GetBeheerMaanden() {
        return context.BeheerMaands.ToList();
    }
}