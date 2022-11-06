using SIMED_V1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMED_V1.Bases_de_datos
{
    public class TiposViajesBD
    {
        public static List<TiposViaje> getTiposViaje()
        {
            var resultado = new List<TiposViaje>();
            var db = new BD3K3G05_2022Context();

            try
            {
                resultado = db.TiposViaje.Where(i => i.IdTipoViaje > 0).ToList();
            }
            catch (Exception ex)
            {
            }
            return resultado;
        }
        public static bool insertarViaje(TiposViaje viaje)
        {
            var resultado = true;
            var db = new BD3K3G05_2022Context();

            try
            {
                db.TiposViaje.Add(viaje);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {
                resultado = false;
                MessageBox.Show(ex.ToString());
            }
            return resultado;
        }

        public static bool modificarViaje(TiposViaje viaje)
        {
            var resultado = true;
            var db = new BD3K3G05_2022Context();

            try
            {
                var tipoViaje = db.TiposViaje.First(a => a.IdTipoViaje == viaje.IdTipoViaje);
                tipoViaje.DescripcionTipoViaje = viaje.DescripcionTipoViaje;
                db.TiposViaje.Update(tipoViaje);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {
                resultado = false;
            }
            return resultado;
        }
        public static TiposViaje obtenerTipoViaje(int id)
        {
            var resultado = new TiposViaje();
            var db = new BD3K3G05_2022Context();

            try
            {
                resultado = db.TiposViaje.First(a => a.IdTipoViaje == id);
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado;
        }
        public static bool eliminarTipoViaje(int id)
        {
            var resultado = true;
            var db = new BD3K3G05_2022Context();

            try
            {
                var tipoViaje = db.TiposViaje.First(a => a.IdTipoViaje == id);
                db.TiposViaje.Remove(tipoViaje);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {
                resultado = false;
            }

            return resultado;
        }
        public static TiposViaje getTipoViajeByDesc(string desc)
        {
            var resultado = new TiposViaje();
            var db = new BD3K3G05_2022Context();

            try
            {
                var tipoViaje = db.TiposViaje.First(a => a.DescripcionTipoViaje == desc);
                resultado = tipoViaje;
            }
            catch (Exception ex)
            {
                
            }

            return resultado;
        }
    }
}
