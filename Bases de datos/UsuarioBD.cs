using SIMED.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMED_V1.Bases_de_datos
{
    public class UsuarioBD
    {

        public static bool InsertarUsuario(Usuarios usuario)
        {

            var resultado = true;
            var db = new BD3K3G05_2022Context();
            try
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();

                resultado = true;
            }
            catch (Exception ex)
            {
                resultado = false;
                ErroresForm window = new ErroresForm();
                window.show("Error" + " " + ex);
            }
            return resultado;
        }


        public static bool ActualizarContraseña(string email, string password)
        {
            var resultado = true;
            var db = new BD3K3G05_2022Context();
            try
            {
                var usuario = db.Usuarios.First(a => a.Email == email);
                usuario.Contraseña = password;
                db.Usuarios.Update(usuario);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {
                resultado = false;
                ErroresForm window = new ErroresForm();
                window.show("Error" + " " + ex);
            }
            return resultado;

        }

        public static bool ValidarUsuario(string nombreDeUsuario, string password)
        {
            string epass = Util.Encrypt.GetSHA256(password);
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM USUARIOS WHERE NombreDeUsuario like @nombreUsu AND Contraseña like @pass";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsu", nombreDeUsuario);
                cmd.Parameters.AddWithValue("@pass", epass);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);


                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                return resultado;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {

                cn.Close();

            }

            return resultado;

        }


        public static string ObtenerEmail(string nombreDeUsuario)
        {
            string email;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT Email FROM USUARIOS WHERE NombreDeUsuario like @nombreUsu";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsu", nombreDeUsuario);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                email = consulta;
                cn.Open();
                cmd.Connection = cn;
                return email;

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {

                cn.Close();

            }

        }

        internal static object ObtenerUsuariosTotales()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = @"SELECT * FROM USUARIOS";
                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla.Rows.Count-1;

            }
            catch (Exception ex)
            {

                ErroresForm window = new ErroresForm();
                window.show("Error" + " " + ex);
                throw;
            }

            finally
            {
                cn.Close();
            }
        }

        public static bool ValidarUsername(string nombreDeUsuario)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM USUARIOS WHERE NombreDeUsuario like @nombreUsu";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsu", nombreDeUsuario);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);


                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                    return resultado;
                }
                else
                {
                    resultado = false;
                    return resultado;
                }

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {

                cn.Close();

            }

            return resultado;



        }

        public static bool ValidarPassword(string pass)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM USUARIOS WHERE Contraseña like @password";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);


                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                    return resultado;
                }
                else
                {
                    resultado = false;
                    return resultado;
                }

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {

                cn.Close();

            }

            return resultado;



        }



        public static bool ValidarEmail(string email)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);




            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM USUARIOS WHERE Email like @mail";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@mail", email);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);


                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                    return resultado;
                }
                else
                {
                    resultado = false;
                    return resultado;
                }

            }
            catch (Exception ex)
            {
                ErroresForm window = new ErroresForm();
                window.show("Error: " + ex);

            }
            finally
            {

                cn.Close();

            }

            return resultado;

        }





        public static bool InsertarEmpleado(Empleados empleado)
        {


            var resultado = true;
            var db = new BD3K3G05_2022Context();
            try
            {
                db.Empleados.Add(empleado);
                db.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {
                resultado = false;
                ErroresForm window = new ErroresForm();
                window.show("Error" + " " + ex);
            }
            return resultado;
           
            return resultado;
        }

        public static int BuscarLegajo()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            int legajo;


            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM EMPLEADOS ORDER BY legajo desc";
                cmd.Parameters.Clear();


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;



                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    legajo = int.Parse(dr["legajo"].ToString());
                    return legajo;
                }
               
            }
            catch (Exception ex)
            {

                ErroresForm window = new ErroresForm();
                window.show("Error" + " " + ex);
            }

            finally
            {
                cn.Close();
            }


            return -1;
            
        }


    }




}