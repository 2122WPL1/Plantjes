using Plantjes.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantjes.Dao
{
    internal class DAOFenotype : DAOLogic
    {
        public static List<Fenotype> GetAllFenoTypes()
        {
            var fenoTypes = context.Fenotypes.ToList();
            return fenoTypes;
        }
        public static IQueryable<Fenotype> fillFenoTypeRatioBloeiBlad()
        {
            // this is NOT part of the cascade function and wil not be added as it is not needed 
            // request List of wanted type
            // distinct to prevrent more than one of each type
            // The if else is to check if something is selected in the previous combobox. if its not he doesn't filter.
            // Here we use IQueryable<T>, it makes it easier for us to use our search queries and find the objects that we need.
            // This will also make it possible for us to use all the properties instead of only a selection of an object in our ViewModels.
            // Good way to interact with our datacontext

            var selection = context.Fenotypes.Distinct().OrderBy(s => s.RatioBloeiBlad);
            return selection;
        }
        public static IQueryable<Fenotype> filterFenoTypeFromPlant(int selectedItem)
        {
            var selection = context.Fenotypes.Distinct().Where(s => s.PlantId == selectedItem);
            return selection;
        }
        public static IQueryable<FenotypeMulti> FilterFenotypeMultiFromPlant(int selectedItem)
        {
            var selection = context.FenotypeMultis.Distinct().Where(s => s.PlantId == selectedItem);
            return selection;
        }
    }
}
