using SIMED.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                MessageBox.Show(ex.ToString());
            }
            return resultado;
        }
        public static bool modificarAfiliado(Afiliados afil)
        {
            var resultado = true;
            var db = new BD3K3G05_2022Context();

            try
            {
                var afiliado = db.Afiliados.First(a => a.NumeroDocumento == afil.NumeroDocumento);
                afiliado.Nombre = afil.Nombre;
                afiliado.Apellido = afil.Apellido;
                afiliado.Calle = afil.Calle;
                afiliado.NroCalle = afil.NroCalle;
                afiliado.NumeroTelefono = afil.NumeroTelefono;
                afiliado.IdSexo = afil.IdSexo;
                afiliado.IdBarrio = afil.IdBarrio;
                db.Afiliados.Update(afiliado);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {
                resultado = false;
            }
            return resultado;
        }

       

        public static List<Afiliados>getAfiliadosInicio()
        {
            var resultado = new List<Afiliados>();
            var db = new BD3K3G05_2022Context();

            try
            {
                var afiliados = db.Afiliados;
               
                resultado = afiliados.ToList(); 
                
               
                
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado;
        }

        internal static int ObtenerBarrioXDescripcion(string descripcion)
        {
            var resultado = new List<Barrios>();
            var db = new BD3K3G05_2022Context();
            int cont = 0;



            try
            {
                var barrioss = db.Barrios.Where(a => a.NombreBarrio == descripcion).ToList();

                foreach (var barrio in barrioss)
                {
                    cont = barrio.IdBarrio;
                    return cont;
                }





            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return cont;

        }

        public static List<Afiliados> getAfiliados(int nroDocumento, string nombre, string apellido)
        {
            var resultado = new List<Afiliados>();
            var db = new BD3K3G05_2022Context();

            try
            {
                var afiliados = db.Afiliados.Where(a => a.NumeroDocumento == nroDocumento || (a.Apellido.Contains(apellido) && apellido.Length > 0) || (a.Nombre.Contains(nombre)) && nombre.Length > 0);
                resultado = afiliados.ToList();
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado;
        }

        public static Afiliados obtenerAfiliado(int nroDoc)
        {
            var resultado = new Afiliados();
            var db = new BD3K3G05_2022Context();

            try
            {
                resultado = db.Afiliados.First(a => a.NumeroDocumento == nroDoc);
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado;
        }
        public static bool eliminarAfiliado(int nroDoc)
        {
            var resultado = true;
            var db = new BD3K3G05_2022Context();

            try
            {
                var afiliado = db.Afiliados.First(a => a.NumeroDocumento == nroDoc);
                db.Afiliados.Remove(afiliado);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {
                resultado = false;
            }

            return resultado;
        }

        public static int getCiudades( int barrio)
        {
            
                
                var db = new BD3K3G05_2022Context();
                int devolver =0;

                try
                {
                var result = db.Barrios.First(i => i.IdBarrio == barrio);
                int ciudad = result.IdCiudad;

                var resultado = db.Ciudades.First(i => i.IdCiudad == ciudad);
                devolver = resultado.IdCiudad;

                return devolver;

                }
                catch (Exception ex)
                {
                }
            return devolver;
            
        }

        internal static int ObtenerBarrio(int idBarrio)
        {
            var resultado = new List<Barrios>();
            var db = new BD3K3G05_2022Context();
            int cont = 0;

            

            try
            {
                var barrioss = db.Barrios.Where(a => a.IdBarrio >0 && a.IdBarrio <= idBarrio).ToList();
                foreach (var barrio in barrioss)
                {
                    cont++;
                }

               



            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return cont;
        }

        internal static string ObtenerBarrioXId(int idBarrio)
        {

            var resultado = new List<Barrios>();
            var db = new BD3K3G05_2022Context();
            string cont = "";



            try
            {

                var barrioss = db.Barrios.Where(a => a.IdBarrio == idBarrio).ToList();

                foreach (var barrio in barrioss)
                {
                    cont = barrio.NombreBarrio;
                    return cont;
                }





            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return cont;

        }
    }
}
