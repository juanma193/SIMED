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
        public static bool InsertarUsuario(string nombreDeUsuario, string password, string usermail)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            bool resultado = false;


            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO USUARIOS (NombreDeUsuario,Contraseña,Email) VALUES(@nombreUsu,@pass, @email)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsu", nombreDeUsuario);
                cmd.Parameters.AddWithValue("@pass", password);
                cmd.Parameters.AddWithValue("@email", usermail);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
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



            return resultado;
        }


        public static bool ActualizarContraseña(string email, string password)
        {
            bool bandera = false;

            try
            {

                SqlConnection con = new SqlConnection("Data Source=200.69.137.167,11333;Initial Catalog=BD3K3G05_2022;User ID=BD3K3G05_2022;Password=CLV05_25089");
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[USUARIOS] SET [Contraseña] = '" + password + "'WHERE Email='" + email + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                bandera = true;
            }
            catch (Exception)
            {

                bandera = false;
            }

            return bandera;

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



    }




}