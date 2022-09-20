using SIMED.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMED_V1.Bases_de_datos
{
    public class AfiliadosBD
    {
        public static bool insertarAfiliado(Afiliados afiliado)
        {
            var resultado = true;
            var db = new BD3K3G05_2022Context();

            try
            {
                db.Afiliados.Add(afiliado);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {
                resultado = false;
            }
            return resultado;
        }
        public static List<Afiliados> getAfiliados(int idAfiliado, string nombre, string apellido)
        {
            var resultado = new List<Afiliados>();
            var db = new BD3K3G05_2022Context();

            try
            {
                var afiliados = db.Afiliados.Where(a => a.NumeroAfiliado == idAfiliado || (a.Apellido.Contains(apellido) && apellido.Length > 0) || (a.Nombre.Contains(nombre)) && nombre.Length > 0);
                resultado = afiliados.ToList();
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado;
        }
    }
}
