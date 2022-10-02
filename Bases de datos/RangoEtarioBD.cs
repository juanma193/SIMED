using SIMED.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SIMED_V1.Bases_de_datos
{
    public class RangoEtarioBD
    {
        public static bool InsertarRangoEtario(RangosEtarios rango)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                if (ObtenerRangoEtario(rango.DescripcionRangoEtario).Rows.Count == 0)
                {
                    string consulta = @"INSERT INTO RANGOS_ETARIOS (descripcionRangoEtario) VALUES(@descripcion)";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@descripcion", rango.DescripcionRangoEtario);
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
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error " + ex);
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public static DataTable ObtenerRangoEtario()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = @"SELECT * FROM RANGOS_ETARIOS";
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
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error " + ex);
                throw;
            }
            finally
            {
                cn.Close();
            }
        }


        public static bool EliminarRangoEtario(RangosEtarios rango)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                if (ObtenerRangoEtario(rango).Rows.Count != 0) 
                {
                    string consulta = @"DELETE FROM RANGOS_ETARIOS WHERE id_rangoEtario=@idRE AND descripcionRangoEtario=@desc";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idRE", rango.IdRangoEtario);
                    cmd.Parameters.AddWithValue("@desc", rango.DescripcionRangoEtario);
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
                window.show("Error " + ex);
                throw;
            }

            finally
            {
                cn.Close();
            }
            return resultado;
        }


        public static bool EliminarRangoEtario(string descR)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                if (ObtenerRangoEtario(descR).Rows.Count != 0)
                {
                    string consulta = @"DELETE FROM RANGOS_ETARIOS WHERE descripcionRangoEtario=@desc";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@desc", descR);
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
                window.show("Error " + ex);
                throw;
            }

            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static bool EliminarRangoEtario(int idR)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                if (ObtenerRangoEtario(idR).Rows.Count != 0)
                {
                    string consulta = @"DELETE FROM RANGOS_ETARIOS WHERE id_rangoEtario=@id";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", idR);
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
                window.show("Error " + ex);
                throw;
            }

            finally
            {
                cn.Close();
            }
            return resultado;
        }



        public static DataTable ObtenerRangoEtario(RangosEtarios rango)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                string consulta = "";
                SqlCommand cmd = new SqlCommand();
                if (rango.IdRangoEtario.ToString() != "" && rango.DescripcionRangoEtario == "")
                {
                    consulta = "SELECT id_rangoEtario, descripcionRangoEtario FROM RANGOS_ETARIOS WHERE descripcionRangoEtario = @desc";
                }
                else if (rango.IdRangoEtario.ToString() == "" && rango.DescripcionRangoEtario != "")
                {
                    consulta = "SELECT id_rangoEtario, descripcionRangoEtario FROM RANGOS_ETARIOS WHERE id_rangoEtario=@id";
                }
                else if(rango.IdRangoEtario.ToString() != "" && rango.DescripcionRangoEtario != "")
                {
                    consulta = "SELECT id_rangoEtario, descripcionRangoEtario FROM RANGOS_ETARIOS WHERE id_rangoEtario=@id AND descripcionRangoEtario=@desc";
                }
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@desc", rango.DescripcionRangoEtario);
                cmd.Parameters.AddWithValue("@id", rango.IdRangoEtario);
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
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error " + ex);
                throw;
            }
            finally
            {
                cn.Close();
            }
        }


        public static DataTable ObtenerRangoEtario(int idRango)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT id_rangoEtario, descripcionRangoEtario FROM RANGOS_ETARIOS WHERE id_rangoEtario=@id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", idRango);
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
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error " + ex);
                throw;
            }
            finally
            {
                cn.Close();
            }
        }


        public static DataTable ObtenerRangoEtario(string descRango)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT id_rangoEtario, descripcionRangoEtario FROM RANGOS_ETARIOS WHERE descripcionRangoEtario=@desc";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@desc", descRango);
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
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error " + ex);
                throw;
            }
            finally
            {
                cn.Close();
            }
        }



        public static bool ModificarRangoEtario(RangosEtarios rango)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            bool resultado = false;

            try
            {

                SqlCommand cmd = new SqlCommand();
                if (ObtenerRangoEtario(rango.DescripcionRangoEtario).Rows.Count == 0)
                {
                    string consulta = @"UPDATE RANGOS_ETARIOS SET descripcionRangoEtario=@descRE WHERE id_rangoEtario=@idRE";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idRe", rango.IdRangoEtario);
                    cmd.Parameters.AddWithValue("@descRE", rango.DescripcionRangoEtario);
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
                window.show("Error " + ex);
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
