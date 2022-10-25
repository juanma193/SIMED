using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using SIMED.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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



        public static List<int> obtenerMatriculaMedicoTupla(DateTime fecha, TimeSpan hora)
        {
            List<int> resultado = new List<int>();
            List<Medicosxviajes> viajes;
            var db = new BD3K3G05_2022Context();

            try
            {
                var travels = db.Medicosxviajes.Where(a => a.Fecha == fecha && a.HoraSalida == hora);
                viajes = travels.ToList();

                foreach (var viaje in viajes)
                {
                    resultado.Add(viaje.NumeroMatriculaMedico);
                }

            }
            catch (Exception ex)
            {
                resultado = null;
            }



            if (resultado.Count == 0)
            {
                resultado.Add(-1);
                return resultado;
            }


            else { return resultado; }


        }

        public static List<int> obtenerMatriculaEnfermeroTupla(DateTime fecha, TimeSpan hora)
        {
            List<int> resultado = new List<int>();
            List<Enfermerosxviajes> viajes;
            var db = new BD3K3G05_2022Context();

            try
            {
                var travels = db.Enfermerosxviajes.Where(a => a.Fecha == fecha && a.HoraSalida == hora);
                viajes = travels.ToList();

                foreach (var viaje in viajes)
                {
                    resultado.Add(viaje.NumeroMatriculaEnfermero);
                }

            }
            catch (Exception ex)
            {
                resultado = null;
            }



            if (resultado.Count == 0)
            {
                resultado.Add(-1);
                return resultado;
            }


            else { return resultado; }


        }


        public static bool BorrarEnfermerosXViajesModif(DateTime fecha, int idMovil, TimeSpan horaSalida)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = @"DELETE FROM ENFERMEROSXVIAJES WHERE fecha=@fechaV AND id_movil=@idMovilV AND hora_salida=@horaSal";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaV", fecha);
                cmd.Parameters.AddWithValue("@idMovilV", idMovil);
                cmd.Parameters.AddWithValue("@horaSal", horaSalida);
                
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;


                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

            finally
            {
                cn.Close();
            }

        }

        public static bool BorrarMedicosXViajesModif(DateTime fecha, int idMovil, TimeSpan horaSalida)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = @"DELETE FROM MEDICOSXVIAJES WHERE fecha=@fechaV AND id_movil=@idMovilV AND hora_salida=@horaSal";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaV", fecha);
                cmd.Parameters.AddWithValue("@idMovilV", idMovil);
                cmd.Parameters.AddWithValue("@horaSal", horaSalida);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;


                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();


                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

            finally
            {
                cn.Close();
            }

        }


        public static bool ModificarViaje(DateTime fecha, int idMovil, TimeSpan horaSalida, TimeSpan horaLlegada, List<int> listaEnf,
                                  List<int> listaMed, int turnoRot, int tipoViaje, float combPrevio, float combPost, float km)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlTransaction objTransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = @"UPDATE VIAJES SET id_turnoRotativo=@turno, id_tipoViaje=@tipo, horaLlegada=@horaLleg, 
                                    cantCombustiblePrevio=@cbPrevio, cantCombustiblePost=@cbPost, kilometrosRealizados=@kilometros 
                                    WHERE (fecha=@fechaV AND id_movil=@idMovilV AND hora_salida=@horaSal)";


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
                objTransaccion = cn.BeginTransaction("ModificacionDeViaje");
                cmd.Transaction = objTransaccion;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                bool res = BorrarEnfermerosXViajesModif(fecha, idMovil, horaSalida);
                bool res2 = BorrarMedicosXViajesModif(fecha, idMovil, horaSalida);

                if(res && res2)
                {
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
                else 
                {
                    objTransaccion.Rollback();
                    return false; 
                }
                

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


        public static bool EliminarViaje(DateTime fecha, int idMovil, TimeSpan horaSalida, List<int> listaEnf,
                                  List<int> listaMed)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlTransaction objTransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {

                bool res = BorrarEnfermerosXViajesModif(fecha, idMovil, horaSalida);
                bool res2 = BorrarMedicosXViajesModif(fecha, idMovil, horaSalida);

                if (res && res2)
                {
                    SqlCommand cmd = new SqlCommand();
                    string consulta = @"DELETE FROM VIAJES WHERE fecha=@fechaV AND id_movil=@idMovilV AND hora_salida=@horaSal";


                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@fechaV", fecha);
                    cmd.Parameters.AddWithValue("@idMovilV", idMovil);
                    cmd.Parameters.AddWithValue("@horaSal", horaSalida);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;


                    cn.Open();
                    objTransaccion = cn.BeginTransaction("EliminacionDeViaje");
                    cmd.Transaction = objTransaccion;
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();

                    objTransaccion.Commit();
                    return true;
                }
                else
                {
                    objTransaccion.Rollback();
                    return false;
                }


            }
            catch (Exception ex)
            {
                objTransaccion.Rollback();
                MessageBox.Show(ex.Message);
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
        public static List<Viajes> CargarViajes()
        {
            var resultado = new List<Viajes>();
            var db = new BD3K3G05_2022Context();



            try
            {
                

                var viajes = db.ViajesxEnfermeros;
                resultado = viajes.ToList();
                
            }
            catch (Exception ex)
            {
                resultado = null;
            }





            return resultado;


        }

        public static List<Viajes> getViajes(DateTime fecha)
        {
            var resultado = new List<Viajes>();
            var db = new BD3K3G05_2022Context();

            try
            {
                var viajes = db.ViajesxEnfermeros.Where(a => a.Fecha == fecha);
                resultado = viajes.ToList();
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado;
        }
        public static List<Viajes> getViajesXPatente(Ambulancias movil)
        {
            var resultado = new List<Viajes>();
            var db = new BD3K3G05_2022Context();

            try
            {
                var viajes = db.ViajesxEnfermeros.Where(a => a.IdMovil == movil.IdMovil);
                resultado = viajes.ToList();
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado;
        }



        public static string obtenerPatente(int idmovil)
        {
            var resultado = new Ambulancias();
            var db = new BD3K3G05_2022Context();

            try
            {
                resultado = db.Ambulancias.First(a => a.IdMovil == idmovil);
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado.Patente;
        }

        public static Ambulancias obtenerMovil(int id)
        {
            var resultado = new Ambulancias();
            var db = new BD3K3G05_2022Context();

            try
            {
                resultado = db.Ambulancias.First(a => a.IdMovil == id);
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado;
        }


        public static int obtenerMatriculaMedico(DateTime fecha)
        {
            var resultado = new Medicosxviajes();
            var db = new BD3K3G05_2022Context();

            try
            {
                resultado = db.Medicosxviajes.First(a => a.Fecha == fecha);
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            if (resultado == null)
            {
                return -1;
            }
            else { return resultado.NumeroMatriculaMedico; }

            
        }

        public static int obtenerMatriculaMedicoNoRepetido(DateTime fecha,int matricula)
        {
            var resultado = new Medicosxviajes();
            var db = new BD3K3G05_2022Context();

            try
            {
                resultado = db.Medicosxviajes.First(a => a.Fecha == fecha && a.NumeroMatriculaMedico == matricula);
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            if (resultado == null)
            {
                return -1;
            }
            else { return resultado.NumeroMatriculaMedico; }


        }


        


        public static List<Enfermerosxviajes> obtenerViajesDeLosEnfermeros(DateTime fecha, TimeSpan hora)
        {
            var resultado = new List<Enfermerosxviajes>();
            
            var db = new BD3K3G05_2022Context();

            try
            {
                var viajes = db.Enfermerosxviajes.Where(a => a.Fecha == fecha && a.HoraSalida == hora);
                resultado = viajes.ToList();
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado;
        }


        public static List<Medicosxviajes> obtenerViajesDeLosMedicos(DateTime fecha, TimeSpan hora)
        {
            var resultado = new List<Medicosxviajes>();

            var db = new BD3K3G05_2022Context();

            try
            {
                var viajes = db.Medicosxviajes.Where(a => a.Fecha == fecha && a.HoraSalida == hora);
                resultado = viajes.ToList();
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado;
        }

        public static List<Enfermeros> obtenerEnfermeros(List<Enfermerosxviajes> listas)
        {
            var resultado = new List<Enfermeros>();

            var db = new BD3K3G05_2022Context();

            try
            {
                foreach (var lista in listas) {

                    var viajes = db.Enfermeros.First(a => a.NumeroMatricula == lista.NumeroMatriculaEnfermero);
                    resultado.Add(viajes);

                }


                
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado;
        }
        public static int obtenerMatriculaEnfermeroNoRepetido(DateTime fecha, int matricula)
        {
            var resultado = new Enfermerosxviajes();
            var db = new BD3K3G05_2022Context();

            try
            {
                resultado = db.Enfermerosxviajes.First(a => a.Fecha == fecha && a.NumeroMatriculaEnfermero == matricula);
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado.NumeroMatriculaEnfermero;
        }


        public static List<DateTime> getFechasxMedico(int matricula)
        {
            var fechas = new List<DateTime>();
            var travels = new List<Medicosxviajes>();
            var db = new BD3K3G05_2022Context();

            try
            {
                var viajes = db.Medicosxviajes.Where(a => a.NumeroMatriculaMedico == matricula);
                travels = viajes.ToList();
            }
            catch (Exception ex)
            {
                travels = null;
            }



            foreach (var travel in travels)
            {

                fechas.Add(travel.Fecha);
                
            }
         
            
  


            return fechas;
        }

        public static List<DateTime> getFechasxEnfermero(int matricula)
        {
            var fechas = new List<DateTime>();
            var travels = new List<Enfermerosxviajes>();
            var db = new BD3K3G05_2022Context();

            try
            {
                var viajes = db.Enfermerosxviajes.Where(a => a.NumeroMatriculaEnfermero == matricula);
                travels = viajes.ToList();
            }
            catch (Exception ex)
            {
                travels = null;
            }

            foreach (var travel in travels)
            {
                String hora = travel.HoraSalida.Hours.ToString();
                if (hora.Length == 1)
                    hora = "0" + hora;
                String minutos = travel.HoraSalida.Minutes.ToString();
                if (minutos.Length == 1)
                    minutos += "0";

                var fechayHora = travel.Fecha.ToString("yyyy-MM-dd") + " " + hora + ":" + minutos;



                DateTime myDate = DateTime.ParseExact(fechayHora, "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture);

                fechas.Add(myDate);
            }
            HashSet<DateTime> hashWithoutDuplicates = new HashSet<DateTime>(fechas);
            List<DateTime> listWithoutDuplicates = hashWithoutDuplicates.ToList();



            return listWithoutDuplicates;
        }

        public static int obtenerMatriculaEnfermero(DateTime fecha)
        {
            var resultado = new Enfermerosxviajes();
            var db = new BD3K3G05_2022Context();
            try
            {
                resultado = db.Enfermerosxviajes.First(a => a.Fecha == fecha);
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado.NumeroMatriculaEnfermero;
        }

        public static List<DateTime> getFechasxMedicoxEnfermero(int matriculaEnfermero, int matriculaMedico)
        {
            var fechas = new List<DateTime>();
            var travelsMedicos = new List<Medicosxviajes>();
            var travelsEnfermeros = new List<Enfermerosxviajes>();
            var db = new BD3K3G05_2022Context();

            try
            {
                var viajesMedicos = db.Medicosxviajes.Where(a => a.NumeroMatriculaMedico == matriculaMedico);
                travelsMedicos = viajesMedicos.ToList();

                var viajesEnfermeros = db.Enfermerosxviajes.Where(a => a.NumeroMatriculaEnfermero == matriculaEnfermero);
                travelsEnfermeros = viajesEnfermeros.ToList();
            }
            catch (Exception ex)
            {
                travelsMedicos = null;
                travelsEnfermeros = null;
            }

            HashSet<DateTime> hashWithoutDuplicates = new HashSet<DateTime>();

            foreach (var travel in travelsMedicos)
            {

                String hora = travel.HoraSalida.Hours.ToString();
                if (hora.Length == 1)
                    hora = "0" + hora;
                String minutos = travel.HoraSalida.Minutes.ToString();
                if (minutos.Length == 1)
                    minutos += "0";

                var fechayHora = travel.Fecha.ToString("yyyy-MM-dd") + " " + hora + ":" + minutos;

               

                DateTime myDate = DateTime.ParseExact(fechayHora, "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture);

                hashWithoutDuplicates.Add(myDate);
            }

            foreach (var travel in travelsEnfermeros)
            {
                String hora = travel.HoraSalida.Hours.ToString();
                if (hora.Length == 1)
                    hora = "0" + hora;
                String minutos = travel.HoraSalida.Minutes.ToString();
                if (minutos.Length == 1)
                    minutos += "0";

                var fechayHora = travel.Fecha.ToString("yyyy-MM-dd") + " " + hora + ":" + minutos;



                DateTime myDate = DateTime.ParseExact(fechayHora, "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture);

                if (hashWithoutDuplicates.Contains(myDate))
                {
                    fechas.Add(myDate);
                }

               
            }

            HashSet<DateTime> hashWithoutDuplicatesfinal = new HashSet<DateTime>(fechas);
            List<DateTime> listWithoutDuplicates = hashWithoutDuplicatesfinal.ToList();



            return listWithoutDuplicates;
        }

        public static List<Viajes> getViajesXFechas(List<DateTime> fechas)
        {
            var resultado = new List<Viajes>();
            var db = new BD3K3G05_2022Context();



            try
            {
                foreach (var fecha in fechas)
                {
                    var viajes = db.ViajesxEnfermeros.First(a => a.Fecha == fecha);

                   
                        resultado.Add(viajes);
                    


                }


            }
            catch (Exception ex)
            {
                resultado = null;
            }



            

            return resultado;


        }

        public static List<Viajes> getViajesXFechasCheckBox(List<DateTime> fechas, DateTime date)
        {
            var resultado = new List<Viajes>();
            var db = new BD3K3G05_2022Context();



            try
            {
                foreach (var fecha in fechas)
                {

                    var viajes = db.ViajesxEnfermeros.First(a => a.Fecha == fecha);

                    if (viajes.Fecha == date)
                    {
                        resultado.Add(viajes);
                    }


                    



                }


            }
            catch (Exception ex)
            {
                resultado = null;
            }





            return resultado;


        }

        public static List<Viajes> getViajesXFechasUsandoMedico(List<DateTime> fechas)
        {
            var resultado = new List<Viajes>();
            var db = new BD3K3G05_2022Context();



            try
            {
                foreach (var fecha in fechas)
                {
                    var viajes = db.ViajesxEnfermeros.First(a => a.Fecha == fecha);



                    resultado.Add(viajes);

                }


            }
            catch (Exception ex)
            {
                resultado = null;
            }


           


            return resultado;


        }




        public static List<Viajes> getViajesXPatenteXFecha(DateTime fecha,Ambulancias movil)
        {
            var resultado = new List<Viajes>();
            var db = new BD3K3G05_2022Context();

            try
            {
               
             var viajes = db.ViajesxEnfermeros.Where(a => a.Fecha == fecha && a.IdMovil == movil.IdMovil);
             resultado = viajes.ToList();

                


            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado;
        }

        public static List<int> getEnfermerosCompleto( string nombre, string apellido)
        {
            var resultado = new List<int>();
            var nurses = new List<Enfermeros>();
            var db = new BD3K3G05_2022Context();

            try
            {
                var enfermeros = db.Enfermeros.Where(a => (a.Apellido.Contains(apellido) && apellido.Length > 0) || (a.Nombre.Contains(nombre)) && nombre.Length > 0);
                nurses = enfermeros.ToList();
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            foreach (var nurse in nurses) {

                resultado.Add(nurse.NumeroMatricula);

            }

            return resultado;
        }

       

        public static List<int> getEnfermerosSoloNombre(string nombre)
        {
            var resultado = new List<int>();
            var nurses = new List<Enfermeros>();
            var db = new BD3K3G05_2022Context();

            try
            {
                var enfermeros = db.Enfermeros.Where(a => (a.Nombre.Contains(nombre)) && nombre.Length > 0);
                nurses = enfermeros.ToList();
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            foreach (var nurse in nurses)
            {

                resultado.Add(nurse.NumeroMatricula);

            }

            return resultado;
        }

        public static List<int> getEnfermerosSoloApellido(string apellido)
        {
            var resultado = new List<int>();
            var nurses = new List<Enfermeros>();
            var db = new BD3K3G05_2022Context();

            try
            {
                var enfermeros = db.Enfermeros.Where(a => (a.Apellido.Contains(apellido)) && apellido.Length > 0);
                nurses = enfermeros.ToList();
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            foreach (var nurse in nurses)
            {

                resultado.Add(nurse.NumeroMatricula);

            }

            return resultado;
        }

        public static List<int> getMedicosCompleto(string nombre, string apellido)
        {

            var resultado = new List<int>();

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "";
                //Búsqueda por nombre y apellido
                if (nombre != "" && apellido != "")
                {
                    consulta = @"SELECT numeroMatricula FROM MEDICOS WHERE nombre LIKE @nomMedico AND apellido LIKE @apeMedico";
                }



                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nomMedico", nombre);
                cmd.Parameters.AddWithValue("@apeMedico", apellido);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                foreach (DataRow row in tabla.Rows)
                {
                    resultado.Add(int.Parse(row["numeroMatricula"].ToString()));
                }

            }

            catch (Exception ex) { }

            finally
            {
                cn.Close();
            }

            return resultado;

        }
        public static List<Medicos> obtenerMedicos(List<Medicosxviajes> lista)
        {

            var resultado = new List<Medicos>();


            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                foreach (var medico in lista)
                {
                    Medicos medic = new Medicos();
                    SqlCommand cmd = new SqlCommand();
                    string consulta = "";
                    //Búsqueda por nombre y apellido
                    if (medico.NumeroMatriculaMedico.ToString() != "")
                    {
                        consulta = @"SELECT * FROM MEDICOS WHERE numeroMatricula LIKE @matricula";
                    }



                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@matricula", medico.NumeroMatriculaMedico);

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;

                    cn.Open();
                    cmd.Connection = cn;

                    DataTable tabla = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);

                    foreach (DataRow row in tabla.Rows)
                    {

                        medic.NumeroMatricula = int.Parse(row[0].ToString());
                        medic.NumDocumento = long.Parse(row[1].ToString());
                        medic.IdTipoDocumento = int.Parse(row[2].ToString());
                        medic.Apellido = row[3].ToString();
                        medic.IdSexo = int.Parse(row[4].ToString());
                        medic.Nombre = row[5].ToString();
                        medic.IdBarrio = int.Parse(row[6].ToString());
                        medic.FechaNacimiento = DateTime.Parse(row[7].ToString());
                        medic.IdRelacionLaboral = int.Parse(row[8].ToString());
                        medic.HorarioIngreso = TimeSpan.Parse(row[9].ToString());
                        medic.HorarioEgreso = TimeSpan.Parse(row[10].ToString());
                        medic.IdEspecialidad = int.Parse(row[11].ToString());
                        medic.Calle = row[12].ToString();
                        medic.NroCalle = int.Parse(row[13].ToString());
                    }
                    resultado.Add(medic);
                    cn.Close();
                }
                }

            catch (Exception ex) { }

            finally
            {
                cn.Close();
            }

            return resultado;

        }


       


        public static List<int> getMedicosCompletoSoloNombre(string nombre)
        {

            var resultado = new List<int>();

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "";
                //Búsqueda por nombre y apellido
                if (nombre != "")
                {
                    consulta = @"SELECT numeroMatricula FROM MEDICOS WHERE nombre LIKE @nomMedico";
                }



                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nomMedico", nombre);
                
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                foreach (DataRow row in tabla.Rows)
                {
                    resultado.Add(int.Parse(row["numeroMatricula"].ToString()));
                }

            }

            catch (Exception ex) { }

            finally
            {
                cn.Close();
            }

            return resultado;

        }

        public static List<int> getMedicosCompletoSoloApellido(string apellido)
        {

            var resultado = new List<int>();

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "";
                //Búsqueda por nombre y apellido
                if (apellido != "")
                {
                    consulta = @"SELECT numeroMatricula FROM MEDICOS WHERE apellido LIKE @apeMedico";
                }



                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@apeMedico", apellido);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                foreach (DataRow row in tabla.Rows)
                {
                    resultado.Add(int.Parse(row["numeroMatricula"].ToString()));
                }

            }

            catch (Exception ex) { }

            finally
            {
                cn.Close();
            }

            return resultado;

        }




        public static List<DateTime> getFechasViajesXMatriculasEnfermeros(List<int> matriculas)
        {
            var resultado = new List<DateTime>();

            var travels = new List<Enfermerosxviajes>();
            var db = new BD3K3G05_2022Context();

            try
            {
                foreach (var matricula in matriculas)
                {
                    var viajes = db.Enfermerosxviajes.Where(a => a.NumeroMatriculaEnfermero == matricula);
                    travels = viajes.ToList();

                }


            }
            catch (Exception ex)
            {
                resultado = null;
            }

            foreach (var viaje in travels) {

                resultado.Add(viaje.Fecha);
            }


            return resultado;
        }


        public static List<DateTime> getFechasViajesXMatriculasEnfermerosYMedicos(List<int> matriculasMedicos, List<int> matriculasEnfermeros)
        {
            var resultado = new List<DateTime>();

            var travelsEnfermeros = new List<Enfermerosxviajes>();
            var travelsMedicos = new List<Medicosxviajes>();
            var db = new BD3K3G05_2022Context();
            HashSet<DateTime> hashWithoutDuplicates = new HashSet<DateTime>();
            var fechas = new List<DateTime>();

            try
            {
                foreach (var matricula in matriculasEnfermeros)
                {
                    var viajes = db.Enfermerosxviajes.Where(a => a.NumeroMatriculaEnfermero == matricula);
                    travelsEnfermeros = viajes.ToList();


                }

                foreach (var matricula in matriculasMedicos)
                {
                    var viajes = db.Medicosxviajes.Where(a => a.NumeroMatriculaMedico == matricula);
                    travelsMedicos = viajes.ToList();


                }



                foreach (var travel in travelsMedicos)
                {

                    String hora = travel.HoraSalida.Hours.ToString();
                    if (hora.Length == 1)
                        hora = "0" + hora;
                    String minutos = travel.HoraSalida.Minutes.ToString();
                    if (minutos.Length == 1)
                        minutos += "0";

                    var fechayHora = travel.Fecha.ToString("yyyy-MM-dd") + " " + hora + ":" + minutos;



                    DateTime myDate = DateTime.ParseExact(fechayHora, "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture);

                    hashWithoutDuplicates.Add(myDate);
                }

                foreach (var travel in travelsEnfermeros)
                {
                    String hora = travel.HoraSalida.Hours.ToString();
                    if (hora.Length == 1)
                        hora = "0" + hora;
                    String minutos = travel.HoraSalida.Minutes.ToString();
                    if (minutos.Length == 1)
                        minutos += "0";

                    var fechayHora = travel.Fecha.ToString("yyyy-MM-dd") + " " + hora + ":" + minutos;



                    DateTime myDate = DateTime.ParseExact(fechayHora, "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture);

                    if (hashWithoutDuplicates.Contains(myDate))
                    {
                        fechas.Add(myDate);
                    }


                }

            }

            catch (Exception ex) { 
            
            
            
            }
            

                HashSet<DateTime> hashWithoutDuplicatesfinal = new HashSet<DateTime>(fechas);
                List<DateTime> listWithoutDuplicates = hashWithoutDuplicatesfinal.ToList();



                return listWithoutDuplicates;
            

        }


        public static List<DateTime> getFechasViajesXMatriculasMedicos(List<int> matriculas)
        {
            var resultado = new List<DateTime>();

            var travels = new List<Medicosxviajes>();
            var db = new BD3K3G05_2022Context();

            try
            {
                foreach (var matricula in matriculas)
                {
                    var viajes = db.Medicosxviajes.Where(a => a.NumeroMatriculaMedico == matricula);
                    travels = viajes.ToList();

                }


            }
            catch (Exception ex)
            {
                resultado = null;
            }

            foreach (var viaje in travels)
            {

                resultado.Add(viaje.Fecha);
            }


            return resultado;
        }


        public static Viajes getViajesParaModificar(DateTime fecha, TimeSpan hora)
        {
            Viajes resultado; 
            var db = new BD3K3G05_2022Context();


            try
            {
                
               var viajes = db.ViajesxEnfermeros.First(a => a.Fecha == fecha && a.HoraSalida == hora);


                resultado = viajes;
                
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado;


        }

      

    }
}
