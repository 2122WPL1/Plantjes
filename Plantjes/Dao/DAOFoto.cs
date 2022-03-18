using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Plantjes.Models.Db;
    

namespace Plantjes.Dao
{
    public class DAOFoto : DAOLogic
    {
        //private object context;
        public static List<Foto> GetAllFoto()
        {
            var foto = context.Fotos.ToList();
            return foto;
        }
    }
}
