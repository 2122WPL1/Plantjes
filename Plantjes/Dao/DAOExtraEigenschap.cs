using Plantjes.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantjes.Dao
{
    //Gesplitst door Andang
    internal class DAOExtraEigenschap : DAOLogic
    {
        public static List<ExtraEigenschap> GetAllExtraEigenschap()
        {
            var extraEigenschap = context.ExtraEigenschaps.ToList();
            return extraEigenschap;
        }
        public static IQueryable<ExtraEigenschap> FilterExtraEigenschapFromPlant(int selectedItem)
        {
            var selection = context.ExtraEigenschaps.Distinct().Where(s => s.PlantId == selectedItem);
            return selection;
        }
    }
}
