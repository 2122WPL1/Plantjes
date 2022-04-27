using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Plantjes.Models.Db;

namespace Plantjes.Dao
{
    internal class DAOPlants : DAOLogic
    {
        //get a list of all the plants.
        ///Kenny
        public static List<Plant> getAllPlants()
        {
            // kijken hoeveel er zijn geselecteerd

            var plants = context.Plants.ToList();
            return plants;
        }

        ///Owen
        public static string GetImages(long id, string ImageCategorie)
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
        //public static void narrowDownOnType(List<Plant> listPlants, string type)
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

        //public static void narrowDownOnGeslacht(List<Plant> listPlants, string geslacht)
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
        //public static void narrowDownOnFamily(List<Plant> listPlants, string Familie)
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
        //public static void narrowDownOnSoort(List<Plant> listPlants, string soort)
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
        //public static void narrowDownOnName(List<Plant> listPlants, string naam)
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
        //public static void narrowDownOnVariant(List<Plant> listPlants, string variant)
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
        //public static List<Plant> OnGeslacht(string geslacht)
        //{
        //    var listPlants = context.Plant.Where(p => p.Geslacht.Contains(geslacht)).ToList();
        //    return listPlants;
        //}
        ////A function that returns a list of plants
        ////the returned list are all the plants that contain the given string in their latin name
        //public static List<Plant> OnName(string name)
        //{
        //    var listPlants = context.Plant.Where(p => p.Fgsv.Contains(name)).ToList();
        //    return listPlants;
        //}
        //public static List<Plant> OnVariant(string variant)
        //{
        //    var listPlants = context.Plant.Where(p => p.Variant.Contains(variant)).ToList();
        //    return listPlants;
        //}
        ////A function that returns a list of plants
        ////the returned list are al the plants that contain the given string in their family
        //public static List<Plant> OnFamily(string family)
        //{
        //    var listPlants = context.Plant.Where(p => p.Familie.Contains(family)).ToList();
        //    return listPlants;
        //}

        #endregion

        ///Robin

        #region Lists of all the plant properties with multiple values, used to display plant details

        public static List<UpdatePlant> GetAllUpdatePlant()
        {
            var updatePlant = context.UpdatePlants.ToList();
            return updatePlant;
        }

        #endregion

        ///Owen, Robin, Christophe

        #region FilterFromPlant

        ///Owen: op basis van basiscode Kenny, Christophe

        #region FilterFenoTypeFromPlant

        #endregion

        #region FilterAbiotiekFromPlant

        public static IQueryable<Abiotiek> filterAbiotiekFromPlant(int selectedItem)
        {
            var selection = context.Abiotieks.Distinct().Where(s => s.PlantId == selectedItem);
            return selection;
        }

        public static IQueryable<AbiotiekMulti> filterAbiotiekMultiFromPlant(int selectedItem)
        {
            var selection = context.AbiotiekMultis.Distinct().Where(s => s.PlantId == selectedItem);
            return selection;
        }

        #endregion

        #region FilterBeheerMaandFromPlant

        public static IQueryable<BeheerMaand> FilterBeheerMaandFromPlant(int selectedItem)
        {
            var selection = context.BeheerMaands.Distinct().Where(s => s.PlantId == selectedItem);
            return selection;
        }

        #endregion

        #region FilterCommensalismeFromPlant

        public static IQueryable<Commensalisme> FilterCommensalismeFromPlant(int selectedItem)
        {
            var selection = context.Commensalismes.Distinct().Where(s => s.PlantId == selectedItem);
            return selection;
        }

        public static IQueryable<CommensalismeMulti> FilterCommensalismeMulti(int selectedItem)
        {
            var selection = context.CommensalismeMultis.Distinct().Where(s => s.PlantId == selectedItem);
            return selection;
        }

        #endregion

        #endregion
    }
}
