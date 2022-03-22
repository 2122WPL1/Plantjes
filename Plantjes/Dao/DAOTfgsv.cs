using Plantjes.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantjes.Dao
{
    //Gesplitst door Warre
    internal class DAOTfgsv : DAOLogic
    {
        public static IQueryable<TfgsvType> fillTfgsvType()
        {
            // request List of wanted type
            // distinct to prevrent more than one of each type
            // Here we use IQueryable<T>, it makes it easier for us to use our search queries and find the objects that we need.
            // This will also make it possible for us to use all the properties instead of only a selection of an object in our ViewModels.
            // Good way to interact with our datacontext
            var selection = context.TfgsvTypes.Distinct();
            return selection;
        }

        public static IQueryable<TfgsvFamilie> fillTfgsvFamilie(int selectedItem)
        {
            // request List of wanted type
            // distinct to prevrent more than one of each type
            // The if else is to check if something is selected in the previous combobox. if its not he doesn't filter
            // Here we use IQueryable<T>, it makes it easier for us to use our search queries and find the objects that we need.
            // This will also make it possible for us to use all the properties instead of only a selection of an object in our ViewModels.
            // Good way to interact with our datacontext

            if (selectedItem > 0)
            {
                var selection = context.TfgsvFamilies.Distinct().OrderBy(s => s.Familienaam).Where(s => s.TypeTypeid == selectedItem);
                return selection;
            }
            else
            {
                var selection = context.TfgsvFamilies.Distinct().OrderBy(s => s.Familienaam);
                return selection;
            }
        }

        public static IQueryable<TfgsvGeslacht> fillTfgsvGeslacht(int selectedItem)
        {
            // request List of wanted type
            // distinct to prevrent more than one of each type
            // The if else is to check if something is selected in the previous combobox. if its not he doesn't filter
            // Here we use IQueryable<T>, it makes it easier for us to use our search queries and find the objects that we need.
            // This will also make it possible for us to use all the properties instead of only a selection of an object in our ViewModels.
            // Good way to interact with our datacontext
            if (selectedItem > 0)
            {
                var selection = context.TfgsvGeslachts.Distinct().OrderBy(s => s.Geslachtnaam).Where(s => s.FamilieFamileId == selectedItem);
                return selection;
            }
            else
            {
                var selection = context.TfgsvGeslachts.Distinct().OrderBy(s => s.Geslachtnaam);
                return selection;
            }
        }

        public static IQueryable<TfgsvSoort> fillTfgsvSoort(int selectedItem)
        {
            // request List of wanted type
            // distinct to prevrent more than one of each type
            // The if else is to check if something is selected in the previous combobox. if its not he doesn't filter
            // Here we use IQueryable<T>, it makes it easier for us to use our search queries and find the objects that we need.
            // This will also make it possible for us to use all the properties instead of only a selection of an object in our ViewModels.
            // Good way to interact with our datacontext
            if (selectedItem > 0)
            {
                var selection = context.TfgsvSoorts.Where(s => s.GeslachtGeslachtId == selectedItem).OrderBy(s => s.Soortnaam).Distinct();
                return selection;
            }
            else
            {
                var selection = context.TfgsvSoorts.Distinct().OrderBy(s => s.Soortnaam);
                return selection;
            }
        }

        public static IQueryable<TfgsvVariant> fillTfgsvVariant()
        {
            // request List of wanted type
            // distinct to prevrent more than one of each type
            // The if else is to check if something is selected in the previous combobox. if its not he doesn't filter
            // Here we use IQueryable<T>, it makes it easier for us to use our search queries and find the objects that we need.
            // This will also make it possible for us to use all the properties instead of only a selection of an object in our ViewModels.
            // Good way to interact with our datacontext

            var selection = context.TfgsvVariants.Distinct().OrderBy(s => s.Variantnaam);
            return selection;
        }
    }
}
