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
    public class ModelosMarcasBD
    {
        public static bool AgregarModeloABD(Modelos m)
        {
            string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadena);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO MODELOS (nombre_modelo, id_marca) VALUES(@nombreModelo, @marcaModelo)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreModelo", m.NombreModelo);
                cmd.Parameters.AddWithValue("@marcaModelo", m.IdMarca);


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

        public static bool ModeloYaExiste(Modelos m)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM MODELOS WHERE nombre_modelo LIKE @nombreModelo AND id_marca LIKE @marcaModelo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreModelo", m.NombreModelo);
                cmd.Parameters.AddWithValue("@marcaModelo", m.IdMarca);
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

        //Obtiene listado completo de modelos
        public static DataTable ObtenerListadoModelos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetModelosMarcas";

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

        //Obtiene listado de modelos, distinguiendo por nombre
        public static DataTable ObtenerListadoModelos(string nombreModelo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetModelosMarcasConNombre";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreModelo", nombreModelo);
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

        //Obtiene listado de modelos, distinguiendo por id de marca
        public static DataTable ObtenerListadoModelos(int idMarca)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetModelosMarcasConMarca";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idMarca", idMarca);
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


        //Obtiene listado de modelos, distinguiendo por nombre e id de marca
        public static DataTable ObtenerListadoModelos(string nombreModelo, int idMarca)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetModelosMarcasConTodo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreModelo", nombreModelo);
                cmd.Parameters.AddWithValue("@idMarca", idMarca);
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

        public static DataTable ObtenerMarcas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM MARCAS";

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

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static Modelos ObtenerModelo(string nombreModelo)
        {
            string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadena);
            Modelos m = new Modelos();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM MODELOS WHERE nombre_modelo LIKE @nombreModelo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreModelo", nombreModelo);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    m.IdModelo = int.Parse(dr["id_modelo"].ToString());
                    m.NombreModelo = dr["nombre_modelo"].ToString();
                    m.IdMarca = int.Parse(dr["id_marca"].ToString());
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

            return m;
        }

        public static bool ActualizarModelo(Modelos m)
        {
            string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadena);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE MODELOS SET nombre_modelo = @nombreModelo, id_marca = @idMarca WHERE id_modelo LIKE @idModelo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreModelo", m.NombreModelo);
                cmd.Parameters.AddWithValue("@idMarca", m.IdMarca);
                cmd.Parameters.AddWithValue("idModelo", m.IdModelo);

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

        public static bool EliminarModelo(Modelos m)
        {
            string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadena);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE MODELOS WHERE id_modelo LIKE @idModelo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreModelo", m.NombreModelo);
                cmd.Parameters.AddWithValue("@idMarca", m.IdMarca);
                cmd.Parameters.AddWithValue("idModelo", m.IdModelo);

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
    }
}
