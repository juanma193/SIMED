using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using SIMED.Models;
using System.IO.Packaging;
using System.Runtime.CompilerServices;
using SIMED_V1.Forms_Para_ABM;

namespace SIMED_V1.Bases_de_datos
{
    public class EnfermeroBD
    {
        public static bool InsertarEnfermero(Enfermeros enfermero)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            bool resultado = false;
            

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = @"INSERT INTO ENFERMEROS (numeroMatricula, nombre, apellido, fechaNacimiento,
                                  telefono, numeroDocumento, id_tipoDocumento, id_especialidad, calle, nroCalle, 
                                  id_barrio, id_sexo) VALUES(@nroMatriculaE, @nombreE, @apellidoE, @fechaNacimientoE,
                                  @telefonoE, @numDocE, @tipoDocE, @especialidadE, @calleE, @nroCalleE, @barrioE, @sexoE)";
                
                
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroMatriculaE", enfermero.NumeroMatricula);
                cmd.Parameters.AddWithValue("@nombreE", enfermero.Nombre);
                cmd.Parameters.AddWithValue("@apellidoE", enfermero.Apellido);
                cmd.Parameters.AddWithValue("@fechaNacimientoE", enfermero.FechaNacimiento);
                cmd.Parameters.AddWithValue("@telefonoE", enfermero.Telefono);
                cmd.Parameters.AddWithValue("@numDocE", enfermero.NumeroDocumento);
                cmd.Parameters.AddWithValue("@tipoDocE", enfermero.IdTipoDocumento);
                cmd.Parameters.AddWithValue("especialidadE", enfermero.IdEspecialidad);
                cmd.Parameters.AddWithValue("@calleE", enfermero.Calle);
                cmd.Parameters.AddWithValue("@nroCalleE", enfermero.NroCalle);
                cmd.Parameters.AddWithValue("@barrioE", enfermero.IdBarrio);
                cmd.Parameters.AddWithValue("@sexoE", enfermero.IdSexo);
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

        public static DataTable ObtenerTiposDocumento()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = @"SELECT * FROM TIPOS_DOCUMENTOS";
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

        public static DataTable ObtenerBarrios(int idCiudadEnfermero)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = @"SELECT id_barrio, nombre_barrio FROM BARRIOS WHERE id_ciudad = @idCiudad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idCiudad", idCiudadEnfermero);
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


        public static DataTable ObtenerCiudades()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = @"SELECT * FROM CIUDADES";
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

        // Para obtener los TODOS los enfermeros al cargar el form.
        public static DataTable ObtenerEnfermeros()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = @"SELECT numeroMatricula, nombre, apellido FROM ENFERMEROS";
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

        public static DataTable ObtenerEnfermeroCompleto(int matriculaEnfermero)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = @"SELECT * FROM ENFERMEROS E LEFT JOIN TIPOS_DOCUMENTOS T ON E.id_tipoDocumento = T.id_tipoDocumento 
                                   LEFT JOIN BARRIOS B ON E.id_barrio = B.id_barrio LEFT JOIN CIUDADES C ON B.id_ciudad = C.id_ciudad
                                   LEFT JOIN ESPECIALIDADES ES ON E.id_especialidad = ES.id_especialidad WHERE E.numeroMatricula = @matEnfermero";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@matEnfermero", matriculaEnfermero);
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


        public static DataTable ObtenerEnfermeros(int matriculaEnfermero, string nombreEnfermero, string apellidoEnfermero)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "";
                //Busca sólo por matricula
                if (matriculaEnfermero.ToString() != "" && nombreEnfermero == "" && apellidoEnfermero == "")
                {
                    consulta = @"SELECT numeroMatricula, nombre, apellido FROM ENFERMEROS WHERE numeroMatricula = @matEnfermero";
                }
                //Busca por nombre y matricula
                if (matriculaEnfermero.ToString() != "" && nombreEnfermero != "" && apellidoEnfermero == "")
                {
                    consulta = @"SELECT numeroMatricula, nombre, apellido FROM ENFERMEROS WHERE numeroMatricula = @matEnfermero AND nombre like @nomEnfermero";
                }
                //Busca sólo por nombre
                if (matriculaEnfermero.ToString() == "-1" && nombreEnfermero != "" && apellidoEnfermero == "")
                {
                    consulta = @"SELECT numeroMatricula, nombre, apellido FROM ENFERMEROS WHERE nombre like @nomEnfermero";
                }
                //Busca por apellido y matricula
                if (matriculaEnfermero.ToString() != "" && nombreEnfermero == "" && apellidoEnfermero != "")
                {
                    consulta = @"SELECT numeroMatricula, nombre, apellido FROM ENFERMEROS WHERE numeroMatricula = @matEnfermero AND apellido like @apeEnfermero";
                }
                //Busca sólo por apellido
                if (matriculaEnfermero.ToString() == "-1" && nombreEnfermero == "" && apellidoEnfermero != "")
                {
                    consulta = @"SELECT numeroMatricula, nombre, apellido FROM ENFERMEROS WHERE apellido like @apeEnfermero";
                }
                //Busca por matricula, nombre y apellido
                if (matriculaEnfermero.ToString() != "" && nombreEnfermero != "" && apellidoEnfermero != "")
                {
                    consulta = @"SELECT numeroMatricula, nombre, apellido FROM ENFERMEROS WHERE numeroMatricula = @matEnfermero AND nombre like @nomEnfermero AND apellido like @apeEnfermero";
                }
                //Busca por nombre y apellido
                if (matriculaEnfermero.ToString() == "-1" && nombreEnfermero != "" && apellidoEnfermero != "")
                {
                    consulta = @"SELECT numeroMatricula, nombre, apellido FROM ENFERMEROS WHERE nombre like @nomEnfermero AND apellido like @apeEnfermero";
                }

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nomEnfermero", nombreEnfermero);
                cmd.Parameters.AddWithValue("@apeEnfermero", apellidoEnfermero);
                cmd.Parameters.AddWithValue("@matEnfermero", matriculaEnfermero);
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

        public static bool EliminarEnfermero(int matriculaEnfermero)
        {
            bool resultado = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta ="DELETE FROM ENFERMEROS WHERE numeroMatricula = @matEnfermero";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@matEnfermero", matriculaEnfermero);
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
                throw;
            }

            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static bool ModificarEnfermero(Enfermeros enfermero)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            bool resultado = false;

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = @"UPDATE ENFERMEROS SET nombre=@nombreE, apellido= @apellidoE, fechaNacimiento= @fechaNacimientoE,
                                  telefono=@telefonoE, numeroDocumento=@numDocE, id_tipoDocumento=@tipoDocE, id_especialidad=@especialidadE,
                                  calle=@calleE, nroCalle=@nroCalleE, id_barrio=@barrioE, id_sexo=@sexoE WHERE numeroMatricula=@nroMatriculaE ";
                
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroMatriculaE", enfermero.NumeroMatricula);
                cmd.Parameters.AddWithValue("@nombreE", enfermero.Nombre);
                cmd.Parameters.AddWithValue("@apellidoE", enfermero.Apellido);
                cmd.Parameters.AddWithValue("@fechaNacimientoE", enfermero.FechaNacimiento);
                cmd.Parameters.AddWithValue("@telefonoE", enfermero.Telefono);
                cmd.Parameters.AddWithValue("@numDocE", enfermero.NumeroDocumento);
                cmd.Parameters.AddWithValue("@tipoDocE", enfermero.IdTipoDocumento);
                cmd.Parameters.AddWithValue("especialidadE", enfermero.IdEspecialidad);
                cmd.Parameters.AddWithValue("@calleE", enfermero.Calle);
                cmd.Parameters.AddWithValue("@nroCalleE", enfermero.NroCalle);
                cmd.Parameters.AddWithValue("@barrioE", enfermero.IdBarrio);
                cmd.Parameters.AddWithValue("@sexoE", enfermero.IdSexo);
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
        // SOLUCIONAR ERROR - NO APARECE LA CIUDAD CORRECTAMENTE EN EL FORM
        //    public static string ObtenerCiudad(int barrioEnfermero)
        //    {
        //        string ciudadEnfermero;
        //        string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        //        SqlConnection cn = new SqlConnection(cadenaConexion);
        //        try
        //        {
        //            SqlCommand cmd = new SqlCommand();


        //            string consulta = @"SELECT descripcionCiudad FROM CIUDADES JOIN BARRIOS ON CIUDADES.id_ciudad = BARRIOS.id_ciudad WHERE BARRIOS.id_barrio = @barrioE";


        //            cmd.Parameters.Clear();
        //            cmd.Parameters.AddWithValue("@barrioE", barrioEnfermero);
        //            cmd.CommandType = CommandType.Text;
        //            cmd.CommandText = consulta;
        //            ciudadEnfermero = consulta;
        //            cn.Open();
        //            cmd.Connection = cn;
        //            return ciudadEnfermero;

        //        }
        //        catch (Exception ex)
        //        {

        //            throw;
        //        }
        //        finally
        //        {

        //            cn.Close();

        //        }
        //    }
    }
}
