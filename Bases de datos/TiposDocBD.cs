using SIMED.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMED_V1.Bases_de_datos
{
    public class TiposDocBD
    {
        public static List<TiposDocumentos> getTiposDoc()
        {
            var resultado = new List<TiposDocumentos>();
            var db = new BD3K3G05_2022Context();

            try
            {
                resultado = db.TiposDocumentos.Where(i => i.IdTipoDocumento > 0).ToList();
            }
            catch (Exception ex)
            {
            }
            return resultado;
        }
    }
}
