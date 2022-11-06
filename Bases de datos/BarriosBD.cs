using SIMED_V1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMED_V1.Bases_de_datos
{
    public class BarriosBD
    {
        public static List<Barrios> getBarrios()
        {
            var resultado = new List<Barrios>();
            var db = new BD3K3G05_2022Context();

            try
            {
                resultado = db.Barrios.Where(i => i.IdBarrio > 0).ToList();
            }
            catch (Exception ex)
            {
            }
            return resultado;
        }

        public static List<Ciudades> getCiudades()
        {
            var resultado = new List<Ciudades>();
            var db = new BD3K3G05_2022Context();

            try
            {
                resultado = db.Ciudades.Where(i => i.IdCiudad > 0).ToList();
            }
            catch (Exception ex)
            {
            }
            return resultado;
        }

        public static List<Barrios> getBarriosDesdeCiudad(int ciudad)
        {
            var resultado = new List<Barrios>();
            var db = new BD3K3G05_2022Context();

            try
            {
                resultado = db.Barrios.Where(i => i.IdCiudad == ciudad).ToList();
            }
            catch (Exception ex)
            {
            }
            return resultado;
        }
    }

}
