using Plantjes.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantjes.Dao
{
    internal class DAOExtraPollen : DAOLogic
    {
        public static List<ExtraPollenwaarde> FillExtraPollenwaardes()
        {
            var selection = context.ExtraPollenwaardes.ToList();
            return selection;
        }
    }
}
