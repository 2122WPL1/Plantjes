using System.Collections.Generic;
using System.Linq;
using Plantjes.Models.Db;

namespace Plantjes.Dao;

public partial class DAOAbiotiek : DAOLogic {
    //Get a list of all the Abiotiek types
    public static List<Abiotiek> GetAllAbiotieks() {
        return context.Abiotieks.ToList();
    }

    //Get a list of all the AbiotiekMulti types
    public static List<AbiotiekMulti> GetAllAbiotieksMulti() {
        //List is unfiltered, a plantId can be present multiple times
        //The aditional filteren will take place in the ViewModel
        return context.AbiotiekMultis.ToList();
    }

    #region Filter abiotiek from plant

    public static IQueryable<Abiotiek> filterAbiotiekFromPlant(int selectedItem) {
        return context.Abiotieks.Distinct().Where(s => s.PlantId == selectedItem);
    }

    public static IQueryable<AbiotiekMulti> filterAbiotiekMultiFromPlant(int selectedItem) {
        return context.AbiotiekMultis.Distinct().Where(s => s.PlantId == selectedItem);
    }

    #endregion
}