using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Plantjes.Models.Db;
    

namespace Plantjes.Dao
{
    //Gesplitst door Andang
    public class DAOFoto : DAOLogic
    {
        //private object context;
        public static List<Foto> GetAllFoto()
        {
            var foto = context.Fotos.ToList();
            return foto;
        }


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
    }

}
