using Plantjes.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantjes.Dao
{
    //Gesplitst door Warre
    internal class DAOExtraNectar : DAOLogic
    {
        public static List<ExtraNectarwaarde> FillExtraNectarwaardes()
        {
            var selection = context.ExtraNectarwaardes.ToList();
            return selection;
        }
    }
}
