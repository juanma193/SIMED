using SIMED_V1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMED_V1.Bases_de_datos
{
    public class EmpleadosBD
    {
        public static List<Empleados> getEmpleados(string nombre, string apellido)
        {
            var resultado = new List<Empleados>();
            var db = new BD3K3G05_2022Context();

            try
            {
                var empleados = db.Empleados.Where(a => a.Nombre == nombre || (a.Apellido.Contains(apellido) && apellido.Length > 0) || (a.Nombre.Contains(nombre)) && nombre.Length > 0);
                resultado = empleados.ToList();
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado;
        }

        public static List<Empleados> getTodo()
        {
            var resultado = new List<Empleados>();
            var db = new BD3K3G05_2022Context();

            try
            {
                var empleados = db.Empleados;
                resultado = empleados.ToList();
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado;
        }

        public static List<Usuarios> getUsuarios(string nombreusu, string email)
        {
            var resultado = new List<Usuarios>();
            var db = new BD3K3G05_2022Context();

            try
            {
                var usuarios = db.Usuarios.Where(a => a.NombreDeUsuario == nombreusu || (a.NombreDeUsuario.Contains(nombreusu) && nombreusu.Length > 0) || (a.Email.Contains(email)) && email.Length > 0);
                resultado = usuarios.ToList();
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado;
        }


        public static List<Usuarios> getUsuariosDesdeEmpleado(int legajo)
        {
            var resultado = new List<Usuarios>();
            var db = new BD3K3G05_2022Context();

            try
            {
                var users = db.Usuarios.Where(a => a.LegajoEmpleado == legajo);
                resultado.AddRange(users);
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado;
        }


        public static List<Empleados> getEmpleadosDesdeUsuarios(int legajo)
        {
            var resultado = new List<Empleados>();
            var db = new BD3K3G05_2022Context();

            try
            {
                var empleados = db.Empleados.Where(a => a.Legajo == legajo);
                resultado.AddRange(empleados);
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado;
        }

        public static Empleados obtenerEmpleado(int legajo)
        {
            var resultado = new Empleados();
            var db = new BD3K3G05_2022Context();

            try
            {
                resultado = db.Empleados.First(a => a.Legajo == legajo);
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado;
        }

        public static Usuarios obtenerUsuario (int id)
        {
            var resultado = new Usuarios();
            var db = new BD3K3G05_2022Context();

            try
            {
                resultado = db.Usuarios.First(a => a.IdUsuario == id);
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado;
        }

        public static Usuarios obtenerUsuarioconusername(string name)
        {
            var resultado = new Usuarios();
            var db = new BD3K3G05_2022Context();

            try
            {
                resultado = db.Usuarios.First(a => a.NombreDeUsuario == name);
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado;
        }

        public static Usuarios obtenerUsuarioDesdeEmpleado(int legajo)
        {
            var resultado = new Usuarios();
            var db = new BD3K3G05_2022Context();

            try
            {
                resultado = db.Usuarios.First(a => a.LegajoEmpleado == legajo);
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado;
        }

        public static bool modificarEmpleado(Empleados empl)
        {
            var resultado = true;
            var db = new BD3K3G05_2022Context();

            try
            {
                var empleado = db.Empleados.First(a => a.Legajo == empl.Legajo);
                empleado.Nombre = empl.Nombre;
                empleado.Apellido = empl.Apellido;
                empleado.Edad = empl.Edad;
                empleado.IdSexo = empl.IdSexo;

                int legajo = empleado.Legajo;

                empleado.Legajo = legajo;

                db.Empleados.Update(empleado);
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

        public static bool modificarUsuario(Usuarios usu)
        {
            var resultado = true;
            var db = new BD3K3G05_2022Context();

            try
            {
                var usuarios = db.Usuarios.First(a => a.IdUsuario == usu.IdUsuario);
                usuarios.NombreDeUsuario = usu.NombreDeUsuario;
                usuarios.Email = usu.Email;
  

                db.Usuarios.Update(usuarios);
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

        public static string UpperCaseFirstChar(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            s = s.ToLower();
            s = s.Trim();
            char[] a = s.ToCharArray();
            int i = 0;
            bool primero = true;
            foreach (Char car in a)
            {
                if (primero && car != ' ')
                {
                    a[i] = char.ToUpper(car);
                    primero = false;
                }
                if (car == ' ')
                    primero = true;
                i++;
            }
            return new string(a);
        }

        public static bool eliminarEmpleado(int legajo)
        {
            var resultado = true;
            var db = new BD3K3G05_2022Context();

            try
            {
                var empleado = db.Empleados.First(a => a.Legajo == legajo);
                db.Empleados.Remove(empleado);
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

        internal static bool eliminarUsuario(int id)
        {
            var resultado = true;
            var db = new BD3K3G05_2022Context();

            try
            {
                var usuario = db.Usuarios.First(a => a.IdUsuario == id);
                db.Usuarios.Remove(usuario);
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
    }




}
