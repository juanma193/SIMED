using Microsoft.EntityFrameworkCore.Metadata.Conventions;
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
    public class ViajesBD
    {
        public static bool InsertarViaje(DateTime fecha, int idMovil, DateTime horaSalida, DateTime horaLlegada, List<int> listaEnf,
                                  List<int> listaMed, int turnoRot, int tipoViaje, float combPrevio, float combPost, float km) 
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlTransaction objTransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = @"INSERT INTO VIAJES (fecha, id_movil, hora_salida, id_turnoRotativo, id_tipoViaje,
                                  horaLlegada, cantCombustiblePrevio, cantCombustiblePost, kilometrosRealizados ) VALUES(@fechaV,
                                  @idMovilV, @horaSal, @turno, @tipo, @horaLleg, @cbPrevio, @cbPost, @kilometros)";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaV", fecha);
                cmd.Parameters.AddWithValue("@idMovilV", idMovil);
                cmd.Parameters.AddWithValue("@horaSal", horaSalida);
                cmd.Parameters.AddWithValue("@turno", turnoRot);
                cmd.Parameters.AddWithValue("@tipo", tipoViaje);
                cmd.Parameters.AddWithValue("@horaLleg", horaLlegada);
                cmd.Parameters.AddWithValue("@cbPrevio", combPrevio);
                cmd.Parameters.AddWithValue("cbPost", combPost);
                cmd.Parameters.AddWithValue("@kilometros", km);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                

                cn.Open();
                objTransaccion = cn.BeginTransaction("AltaDeViaje");
                cmd.Transaction = objTransaccion;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                
                foreach (var matEnf in listaEnf)
                {
                    
                    string consultaEnfXViaje = @"INSERT INTO ENFERMEROSXVIAJES (numeroMatriculaEnfermero, fecha, hora_salida, id_movil) VALUES(@matE, @fechaV,
                                                @horaSal, @idMovilV)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@matE", matEnf);
                    cmd.Parameters.AddWithValue("@fechaV", fecha);
                    cmd.Parameters.AddWithValue("@idMovilV", idMovil);
                    cmd.Parameters.AddWithValue("@horaSal", horaSalida);

                    cmd.CommandText = consultaEnfXViaje;
                    cmd.ExecuteNonQuery();
                }

                foreach (var matMed in listaMed)
                {

                    string consultaMedxViaje = @"INSERT INTO MEDICOSXVIAJES (numeroMatriculaMedico, fecha, hora_salida, id_movil) VALUES(@matM, @fechaV,
                                                @horaSal, @idMovilV)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@matM", matMed);
                    cmd.Parameters.AddWithValue("@fechaV", fecha);
                    cmd.Parameters.AddWithValue("@idMovilV", idMovil);
                    cmd.Parameters.AddWithValue("@horaSal", horaSalida);

                    

                    cmd.CommandText = consultaMedxViaje;
                    cmd.ExecuteNonQuery();
                }

                objTransaccion.Commit();
                return true;

            }
            catch (Exception ex)
            {
                objTransaccion.Rollback();
                return false;
            }

            finally
            {
                cn.Close();
            }
        }


        public static DataTable ObtenerMoviles()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = @"SELECT * FROM AMBULANCIAS";
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

        //USAR LA QUE YA EXISTE ?
        public static DataTable ObtenerTiposViajes()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = @"SELECT * FROM TIPOS_VIAJE";
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

    }
}
