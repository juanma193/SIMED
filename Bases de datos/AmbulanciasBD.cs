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
    public class AmbulanciasBD
    {
        public static bool AgregarAmbulanciaABD(Ambulancias a)
        {
            string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadena);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO AMBULANCIAS (patente, id_modelo, id_categoria) VALUES(@patente, @modelo, @categoria)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", a.Patente);
                cmd.Parameters.AddWithValue("@modelo", a.IdModelo);
                cmd.Parameters.AddWithValue("@categoria", a.IdCategoria);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static bool AmbulanciaYaExiste(Ambulancias a)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM AMBULANCIAS WHERE patente LIKE @patente";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", a.Patente);
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
        }

        public static Ambulancias ObtenerAmbulancia(string patente)
        {
            string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadena);
            Ambulancias a = new Ambulancias();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetAmbulanciaConPatenteCellClick";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patenteAmbulancia", patente);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    a.IdMovil = int.Parse(dr["id_movil"].ToString());
                    a.Patente = dr["patente"].ToString();
                    a.IdModelo = int.Parse(dr["id_modelo"].ToString());
                    a.IdCategoria = int.Parse(dr["id_categoria"].ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return a;
        }



        public static bool ActualizarAmbulancia(Ambulancias a)
        {
            string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadena);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE AMBULANCIAS SET patente = @patente, id_modelo = @idmodelo, id_categoria = @idcategoria WHERE id_movil LIKE @idmovil";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", a.Patente);
                cmd.Parameters.AddWithValue("@idmodelo", a.IdModelo);
                cmd.Parameters.AddWithValue("@idcategoria", a.IdCategoria);
                cmd.Parameters.AddWithValue("@idmovil", a.IdMovil);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public static bool EliminarAmbulancia(Ambulancias a)
        {
            string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadena);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE AMBULANCIAS WHERE id_movil LIKE @idmovil";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("idmovil", a.IdMovil);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public static DataTable ObtenerListadoAmbulancias(string patente)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetAmbulanciasConPatente";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patenteAmbulancia", patente);
                cmd.CommandType = CommandType.StoredProcedure;
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

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerListadoAmbulancias()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetAmbulancias";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
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

                throw;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
