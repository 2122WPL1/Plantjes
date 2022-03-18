using Plantjes.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantjes.Dao
{
    internal class DAOUpdatePlant : DAOLogic
    {
        public static List<UpdatePlant> GetAllUpdatePlant()
        {
            var updatePlant = context.UpdatePlants.ToList();
            return updatePlant;
        }
    }
}
