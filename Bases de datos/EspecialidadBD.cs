using SIMED_V1.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.Specialized;

namespace SIMED_V1.Bases_de_datos
{
    public class EspecialidadBD
    {
        public static bool InsertarEspecialidad(Especialidades especialidad)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            bool resultado = false;


            try
            {

                SqlCommand cmd = new SqlCommand();
                if (ObtenerEspecialidades(especialidad.DescripcionEspecialidad).Rows.Count == 0) 
                {
                    string consulta = @"INSERT INTO ESPECIALIDADES (descripcionEspecialidad) VALUES (@desEsp)";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@desEsp", especialidad.DescripcionEspecialidad);

                    cmd.CommandText = consulta;

                    cn.Open();
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();
                    resultado = true;
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

            return resultado;
        }

        public static DataTable ObtenerEspecialidades()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = @"SELECT * FROM ESPECIALIDADES";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;

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
        public static DataTable ObtenerEspecialidades(int id)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            
            try
            {

                SqlCommand cmd = new SqlCommand();
                
                string    consulta = @"SELECT * FROM ESPECIALIDADES WHERE id_especialidad=@idEspecialidad";
                


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idEspecialidad", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;

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

        public static DataTable ObtenerEspecialidades(string descripcion)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = @"SELECT * FROM ESPECIALIDADES WHERE descripcionEspecialidad=@descEspecialidad";



                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@descEspecialidad", descripcion);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;

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
        public static DataTable ObtenerEspecialidades(Especialidades esp)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = @"SELECT * FROM ESPECIALIDADES WHERE id_especialidad=@idEspecialidad  AND descripcionEspecialidad=@descEspecialidad";



                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idEspecialidad", esp.IdEspecialidad);
                cmd.Parameters.AddWithValue("@descEspecialidad", esp.DescripcionEspecialidad);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;

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

        public static bool EliminarEspecialidad(int idEspecialidad)
        {
            bool resultado = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                if (ObtenerEspecialidades(idEspecialidad).Rows.Count != 0)
                {
                    string consulta = "DELETE FROM ESPECIALIDADES WHERE id_especialidad = @idEsp";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idEsp", idEspecialidad);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;

                    cn.Open();
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();
                    resultado = true;
                }

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
            return resultado;
        }

        public static bool EliminarEspecialidad(string descEspecialidad)
        {
            bool resultado = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                if (ObtenerEspecialidades(descEspecialidad).Rows.Count != 0)
                {
                    string consulta = "DELETE FROM ESPECIALIDADES WHERE descripcionEspecialidad= @desEsp";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@desEsp", descEspecialidad);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;

                    cn.Open();
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();
                    resultado = true;
                }

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
            return resultado;
        }
        public static bool EliminarEspecialidad(Especialidades esp)
        {
            bool resultado = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                if (ObtenerEspecialidades(esp).Rows.Count != 0) 
                {
                    string consulta = "DELETE FROM ESPECIALIDADES WHERE id_especialidad = @idEsp AND descripcionEspecialidad=@descEsp";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idEsp", esp.IdEspecialidad);
                    cmd.Parameters.AddWithValue("@descEsp", esp.DescripcionEspecialidad);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;

                    cn.Open();
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();
                    resultado = true;
                }
                
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
            return resultado;
        }

        public static bool ModificarEspecialidad(Especialidades especialidad)
        {
            bool resultado = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                if (ObtenerEspecialidades(especialidad.DescripcionEspecialidad).Rows.Count == 0)
                {
                    string consulta = "UPDATE ESPECIALIDADES SET descripcionEspecialidad=@descEsp WHERE id_especialidad=@idEsp";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idEsp", especialidad.IdEspecialidad);
                    cmd.Parameters.AddWithValue("@descEsp", especialidad.DescripcionEspecialidad);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;

                    cn.Open();
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();
                    resultado = true;
                }
  
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
            return resultado;
        }

    }
}
