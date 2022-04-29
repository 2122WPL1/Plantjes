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

    }
}
