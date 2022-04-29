using System.Collections.Generic;
using System.Linq;
using Plantjes.Models.Db;
    

namespace Plantjes.Dao
{
    //Gesplitst door Andang
    public class DAOFoto : DAOLogic
    {
        //Xander - return object directly
        public static List<Foto> GetAllFoto()
        {
            return context.Fotos.ToList();
        }
    }
}
