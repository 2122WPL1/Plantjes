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
    }
}
