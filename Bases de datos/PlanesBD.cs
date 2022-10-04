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
    public class PlanesBD
    {
        public static bool PlanYaExiste(Planes p)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM PLANES WHERE nombrePlan LIKE @nombrePlan";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombrePlan", p.NombrePlan);
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

        public static bool AgregarPlanABD(Planes p)
        {
            string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadena);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO PLANES (nombrePlan, id_tipoPlan, precio, id_rangoEtario) VALUES(@nombrePlan, @idTipoPlan, @precioPlan, @idRangoEtario)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombrePlan", p.NombrePlan);
                cmd.Parameters.AddWithValue("@idTipoPlan", p.IdTipoPlan);
                cmd.Parameters.AddWithValue("@precioPlan", p.Precio);
                cmd.Parameters.AddWithValue("@idRangoEtario", p.IdRangoEtario);

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

        public static List<Planes> getPlanes()
        {
            var resultado = new List<Planes>();
            var db = new BD3K3G05_2022Context();

            try
            {
                var resultado2 = db.Planes.Where(i => i.IdPlan > 0).ToList();
                resultado = resultado2;
            }
            catch (Exception ex)
            {
            }
            return resultado;
        }

        public static DataTable ObtenerRE()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM RANGOS_ETARIOS";

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

        public static DataTable ObtenerListadoPlanes()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetPlanes";

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

        public static DataTable ObtenerListadoPlanes(string nombrePlan)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetPlanesConNombre";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@planNombre", nombrePlan);
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

        public static Planes ObtenerPlan(string nombrePlan)
        {
            string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadena);
            Planes p = new Planes();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM PLANES WHERE nombrePlan LIKE @nombre_plan";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre_plan", nombrePlan);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    p.IdPlan = int.Parse(dr["id_plan"].ToString());
                    p.NombrePlan = dr["nombrePlan"].ToString();
                    p.IdTipoPlan = int.Parse(dr["id_tipoPlan"].ToString());
                    p.Precio = float.Parse(dr["precio"].ToString());
                    p.IdRangoEtario = int.Parse(dr["id_rangoEtario"].ToString());
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

            return p;
        }

        public static bool ActualizarPlan(Planes p)
         {
            string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadena);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE PLANES SET nombrePlan = @nombre_plan, id_tipoPlan = @idTipoPlan, precio = @precioPlan, id_rangoEtario = @idRangoEtario WHERE id_plan LIKE @idPlan";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idPlan", p.IdPlan);
                cmd.Parameters.AddWithValue("@nombre_plan", p.NombrePlan);
                cmd.Parameters.AddWithValue("@idTipoPlan", p.IdTipoPlan);
                cmd.Parameters.AddWithValue("@precioPlan", p.Precio);
                cmd.Parameters.AddWithValue("@idRangoEtario", p.IdRangoEtario);

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

        public static bool EliminarModelo(Planes p)
        {
            string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadena);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE PLANES WHERE id_plan LIKE @idPlan";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("idPlan", p.IdPlan);

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
