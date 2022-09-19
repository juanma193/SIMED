using SIMED.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMED_V1.Bases_de_datos
{
    public class PlanesBD
    {
        public static List<Planes> getPlanes()
        {
            var resultado = new List<Planes>();
            var db = new BD3K3G05_2022Context();

            try
            {
                resultado = db.Planes.Where(i => i.IdPlan > 0).ToList();
            }
            catch (Exception ex)
            {
            }
            return resultado;
        }
    }
}
