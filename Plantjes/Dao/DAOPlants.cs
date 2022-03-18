using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Plantjes.Models.Db;

namespace Plantjes.Dao
{
    public partial class DAOLogic
    {
        //get a list of all the plants.
        ///Kenny
        public List<Plant> getAllPlants()
        {
            // kijken hoeveel er zijn geselecteerd

            var plants = context.Plants.ToList();
            return plants;
        }

        ///Owen
        public string GetImages(long id, string ImageCategorie)
        {
            var foto = context.Fotos.Where(s => s.Eigenschap == ImageCategorie).SingleOrDefault(s => s.Plant == id);


            if (foto != null)
            {
                var location = foto;
                return location.UrlLocatie;
            }

            return null;
        }
        
        /* 4.gebruik: var example = DAOLogic.Instance();
    }
         */


        //search functions

        /* NARROW DOWN FUNCTIONS */

        #region Kenny's first search

        //DIT IS KENNY ZIJN CODE KAN ZIJN DAT WE DIT NOG GEBRUIKEN IN HET VOLGEND KWARTAAL.

        //A function that looks if the given list of plants contains the given string in plant.type .
        //if this is the case the plant will stay in the list.
        //if this is not the case, the plant will be deleted out of the list.
        //public void narrowDownOnType(List<Plant> listPlants, string type)
        //{
        //    foreach (Plant plant in listPlants.ToList())
        //    {           
        //        if (plant.Type != null)
        //        {
        //            var simplifyString = Simplify(plant.Geslacht.ToString());
        //            if (simplifyString.Contains(Simplify(type)) != true)
        //            {
        //                listPlants.Remove(plant);
        //            }
        //        }
        //    }
        //}

        ////A function that looks if the given list of plants contains the given string in plant.geslacht .
        ////if this is the case the plant will stay in the list.
        ////if this is not the case, the plant will be deleted out of the list.

        //public void narrowDownOnGeslacht(List<Plant> listPlants, string geslacht)
        //{
        //    foreach (Plant plant in listPlants.ToList())
        //    {
        //        if (plant.Geslacht != null)
        //        {
        //            var simplifyString = Simplify(plant.Geslacht.ToString());
        //            if (simplifyString.Contains(Simplify(geslacht)) != true)
        //            {
        //                listPlants.Remove(plant);
        //            }
        //        }
        //    }
        //}
        ////A function that looks if the given list of plants contains the given string in plant.Family .
        ////if this is the case the plant will stay in the list.
        ////if this is not the case, the plant will be deleted out of the list.
        //public void narrowDownOnFamily(List<Plant> listPlants, string Familie)
        //{
        //    foreach (Plant plant in listPlants.ToList())
        //    {
        //        if (plant.Familie != null)
        //        {
        //            var simplifyString = Simplify(plant.Familie.ToString());
        //            if (simplifyString.Contains(Simplify(Familie)) != true)
        //            {
        //                listPlants.Remove(plant);
        //            }
        //        }
        //    }
        //}
        ////A function that looks if the given list of plants contains the given string in plant.soort .
        ////if this is the case the plant will stay in the list.
        ////if this is not the case, the plant will be deleted out of the list.
        //public void narrowDownOnSoort(List<Plant> listPlants, string soort)
        //{
        //    foreach (Plant plant in listPlants.ToList())
        //    {
        //        if (plant.Soort != null)
        //        {
        //            var simplifyString = Simplify(plant.Soort.ToString());
        //            if (simplifyString.Contains(Simplify(soort)) != true)
        //            {
        //                listPlants.Remove(plant);
        //            }
        //        }
        //    }
        //}
        ////A function that looks if the given list of plants contains the given string in plant.naam .
        ////if this is the case the plant will stay in the list.
        ////if this is not the case, the plant will be deleted out of the list.
        //public void narrowDownOnName(List<Plant> listPlants, string naam)
        //{
        //    foreach (Plant plant in listPlants.ToList())
        //    {
        //        if (plant.Fgsv != null)
        //        {
        //            var simplifyString = Simplify(plant.Fgsv.ToString());
        //            if (simplifyString.Contains(Simplify(naam)) != true)
        //            {
        //                listPlants.Remove(plant);
        //            }
        //        }
        //    }
        //}
        ////A function that looks if the given list of plants contains the given string in plant.variant .
        ////if this is the case the plant will stay in the list.
        ////if this is not the case, the plant will be deleted out of the list.
        //public void narrowDownOnVariant(List<Plant> listPlants, string variant)
        //{
        //    foreach (Plant plant in listPlants.ToList())
        //    {
        //        if (plant.Variant != null)
        //        {
        //            var simplifyString = Simplify(plant.Variant.ToString());
        //            if (simplifyString.Contains(Simplify(variant)) != true)
        //            {
        //                listPlants.Remove(plant);
        //            }
        //        }
        //    }
        //}
        //A function that returns a list of plants
        //the returned list are all the plants that contain the given string in their geslacht


        //Robin: removed "static", couldn't reach context
        //public List<Plant> OnGeslacht(string geslacht)
        //{
        //    var listPlants = context.Plant.Where(p => p.Geslacht.Contains(geslacht)).ToList();
        //    return listPlants;
        //}
        ////A function that returns a list of plants
        ////the returned list are all the plants that contain the given string in their latin name
        //public List<Plant> OnName(string name)
        //{
        //    var listPlants = context.Plant.Where(p => p.Fgsv.Contains(name)).ToList();
        //    return listPlants;
        //}
        //public List<Plant> OnVariant(string variant)
        //{
        //    var listPlants = context.Plant.Where(p => p.Variant.Contains(variant)).ToList();
        //    return listPlants;
        //}
        ////A function that returns a list of plants
        ////the returned list are al the plants that contain the given string in their family
        //public List<Plant> OnFamily(string family)
        //{
        //    var listPlants = context.Plant.Where(p => p.Familie.Contains(family)).ToList();
        //    return listPlants;
        //}

        #endregion

        ///Robin

        #region Lists of all the plant properties with multiple values, used to display plant details


        

        public List<ExtraEigenschap> GetAllExtraEigenschap()
        {
            var extraEigenschap = context.ExtraEigenschaps.ToList();
            return extraEigenschap;
        }

        public List<Fenotype> GetAllFenoTypes()
        {
            var fenoTypes = context.Fenotypes.ToList();
            return fenoTypes;
        }

        public List<Foto> GetAllFoto()
        {
            var foto = context.Fotos.ToList();
            return foto;
        }

        #endregion

        ///Owen, Robin, Christophe



        public IQueryable<Fenotype> fillFenoTypeRatioBloeiBlad()
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

        #region FilterFromPlant

        ///Owen: op basis van basiscode Kenny, Christophe

        #region FilterFenoTypeFromPlant

        public IQueryable<Fenotype> filterFenoTypeFromPlant(int selectedItem)
        {
            var selection = context.Fenotypes.Distinct().Where(s => s.PlantId == selectedItem);
            return selection;
        }

        public IQueryable<FenotypeMulti> FilterFenotypeMultiFromPlant(int selectedItem)
        {
            var selection = context.FenotypeMultis.Distinct().Where(s => s.PlantId == selectedItem);
            return selection;
        }

        #endregion
        
        #region FilterExtraEigenschapFromPlant

        public IQueryable<ExtraEigenschap> FilterExtraEigenschapFromPlant(int selectedItem)
        {
            var selection = context.ExtraEigenschaps.Distinct().Where(s => s.PlantId == selectedItem);
            return selection;
        }

        #endregion

        #endregion
    }
}
