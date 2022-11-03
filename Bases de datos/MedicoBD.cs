using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using SIMED.Models;
using System.IO.Packaging;
using System.Runtime.CompilerServices;
using SIMED_V1.Forms_Para_ABM;
using System.Data;

namespace SIMED_V1.Bases_de_datos
{
    public class MedicoBD
    {
        public static bool InsertarMedico(Medicos medico)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = @"INSERT INTO MEDICOS (numeroMatricula, numDocumento, id_tipoDocumento, 
                                    apellido, id_sexo, nombre, id_barrio, fechaNacimiento, id_relacionLaboral, horarioIngreso, horarioEgreso, 
                                    id_especialidad, calle, nroCalle) VALUES(@nroMat, @doc, @tipoDoc, @ape, @sexo, @nom, @barrio, @fechaNac, @reLab,
                                    @horIng, @horEgr, @esp, @calleM, @nroCalleM)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroMat", medico.NumeroMatricula);
                cmd.Parameters.AddWithValue("@doc", medico.NumDocumento);
                cmd.Parameters.AddWithValue("@tipoDoc", medico.IdTipoDocumento);
                cmd.Parameters.AddWithValue("@ape", medico.Apellido);
                cmd.Parameters.AddWithValue("@sexo", medico.IdSexo);
                cmd.Parameters.AddWithValue("@nom", medico.Nombre);
                cmd.Parameters.AddWithValue("@barrio", medico.IdBarrio);
                cmd.Parameters.AddWithValue("@fechaNac", medico.FechaNacimiento);
                cmd.Parameters.AddWithValue("@reLab", medico.IdRelacionLaboral);
                cmd.Parameters.AddWithValue("@horIng", medico.HorarioIngreso);
                cmd.Parameters.AddWithValue("@horEgr", medico.HorarioEgreso);
                cmd.Parameters.AddWithValue("@esp", medico.IdEspecialidad);
                cmd.Parameters.AddWithValue("@calleM", medico.Calle);
                cmd.Parameters.AddWithValue("@nroCalleM", medico.NroCalle);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch(Exception ex)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error " + ex);
                throw;
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
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error " + ex);
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        internal static object ObtenerMedicosTotales()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = @"SELECT * FROM MEDICOS";
                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla.Rows.Count;

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
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error " + ex);
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerBarrios(int idCiudadMedico)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = @"SELECT id_barrio, nombre_barrio FROM BARRIOS WHERE id_ciudad = @idCiudad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idCiudad", idCiudadMedico);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText= consulta;

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
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error " + ex);
                throw;
            }
            finally
            {
                cn.Close();
            }
        }


        public static void InsertarMedicosDiasLaborales(MedicosxDiasLaborales diasLaborales)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = @"INSERT INTO MEDICOSXDIAS_LABORALES (numeroMatricula, id_diaLaboral)
                                    VALUES(@nroMat, @diaLab)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroMat", diasLaborales.NumeroMatricula);
                cmd.Parameters.AddWithValue("@diaLab", diasLaborales.IdDiaLaboral);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

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

        }


        public static DataTable ObtenerMedicos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = @"SELECT numeroMatricula, nombre, apellido FROM MEDICOS";

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

        public static DataTable ObtenerMedicoCompletoReporte()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = @"SELECT numeroMatricula, numDocumento, id_tipoDocumento, apellido, id_sexo, nombre, id_barrio
                                fechaNacimiento, id_relacionLaboral, horarioIngreso, horarioEgreso, id_especialidad,
                                calle, nroCalle FROM MEDICOS";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

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


        public static DataTable ObtenerMedicos(int matriculaM, string nombreM, string apellidoM)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "";

                //Búsqueda solo por matrícula
                if (matriculaM.ToString() != "" && nombreM == "" && apellidoM == "")
                {
                    consulta = @"SELECT numeroMatricula, nombre, apellido FROM MEDICOS WHERE numeroMatricula = @matMedico";
                }

                //Búsqueda por nombre y matrícula
                if (matriculaM.ToString() != "" && nombreM != "" && apellidoM == "")
                {
                    consulta = @"SELECT numeroMatricula, nombre, apellido FROM MEDICOS WHERE numeroMatricula = @matMedico AND nombre LIKE @nomMedico";
                }

                //Búsqueda solo por nombre
                if (matriculaM.ToString() == "-1" && nombreM != "" && apellidoM == "")
                {
                    consulta = @"SELECT numeroMatricula, nombre, apellido FROM MEDICOS WHERE nombre LIKE @nomMedico";
                }

                //Búsqueda por apellido y matrícula
                if (matriculaM.ToString() != "" && nombreM == "" && apellidoM != "")
                {
                    consulta = @"SELECT numeroMatricula, nombre, apellido FROM MEDICOS WHERE numeroMatricula = @matMedico AND apellido LIKE @apeMedico";
                }

                //Búsqueda solo por apellido
                if(matriculaM.ToString() == "-1" && nombreM == "" && apellidoM != "")
                {
                    consulta = @"SELECT numeroMatricula, nombre, apellido FROM MEDICOS WHERE apellido LIKE @apeMedico";
                }

                //Búsqueda por matrícula, nombre y apellido
                if(matriculaM.ToString() != "" && nombreM != "" && apellidoM != "")
                {
                    consulta = @"SELECT numeroMatricula, nombre, apellido FROM MEDICOS WHERE numeroMatricula = @matMedico AND nombre LIKE @nomMedico AND apellido LIKE @apeMedico";
                }

                //Búsqueda por nombre y apellido
                if(matriculaM.ToString() == "-1" && nombreM != "" && apellidoM != "")
                {
                    consulta = @"SELECT numeroMatricula, nombre, apellido FROM MEDICOS WHERE nombre LIKE @nomMedico AND apellido LIKE @apeMedico";
                }
            


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@matMedico", matriculaM);
                cmd.Parameters.AddWithValue("@nomMedico", nombreM);
                cmd.Parameters.AddWithValue("@apeMedico", apellidoM);
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


        public static DataTable ObtenerMedicoCompleto(int matriculaMedico)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = @"SELECT * FROM MEDICOS M LEFT JOIN TIPOS_DOCUMENTOS T ON M.id_tipoDocumento = T.id_tipoDocumento 
                                   LEFT JOIN BARRIOS B ON M.id_barrio = B.id_barrio LEFT JOIN CIUDADES C ON B.id_ciudad = C.id_ciudad
                                   LEFT JOIN ESPECIALIDADES ES ON M.id_especialidad = ES.id_especialidad LEFT JOIN MEDICOSxDIAS_LABORALES 
                                   MD ON MD.numeroMatricula = M.numeroMatricula WHERE M.numeroMatricula = @matMedico";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@matMedico", matriculaMedico);
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
                window.show("Error " + ex);
                throw;
            }

            finally
            {
                cn.Close();
            }
        }


        public static bool EliminarMedico(int matriculaMedico)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = @"DELETE FROM MEDICOS WHERE numeroMatricula = @matMedico";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@matMedico", matriculaMedico);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
                return resultado;


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
        }

        public static bool EliminarMedicosDiasLaborales(int matriculaMedico)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = @"DELETE FROM MEDICOSXDIAS_LABORALES WHERE numeroMatricula = @matM";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@matM", matriculaMedico);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                return resultado = true;

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

        public static bool ModificarMedico(Medicos medico)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            bool resultado = false;

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = @"UPDATE MEDICOS SET nombre=@nombreM, apellido= @apellidoM, fechaNacimiento= @fechaNacimientoM,
                                  numDocumento=@numDocM, id_tipoDocumento=@tipoDocM, id_especialidad=@especialidadM,
                                  calle=@calleM, nroCalle=@nroCalleM, id_barrio=@barrioM, id_sexo=@sexoM, id_relacionLaboral=@reLab,
                                  horarioIngreso=@horIng, horarioEgreso=@horEgr WHERE numeroMatricula=@nroMatriculaM ";
                
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroMatriculaM", medico.NumeroMatricula);
                cmd.Parameters.AddWithValue("@numDocM", medico.NumDocumento);
                cmd.Parameters.AddWithValue("@tipoDocM", medico.IdTipoDocumento);
                cmd.Parameters.AddWithValue("@apellidoM", medico.Apellido);
                cmd.Parameters.AddWithValue("@sexoM", medico.IdSexo);
                cmd.Parameters.AddWithValue("@nombreM", medico.Nombre);
                cmd.Parameters.AddWithValue("@barrioM", medico.IdBarrio);
                cmd.Parameters.AddWithValue("@fechaNacimientoM", medico.FechaNacimiento);
                cmd.Parameters.AddWithValue("@reLab", medico.IdRelacionLaboral);
                cmd.Parameters.AddWithValue("@horIng", medico.HorarioIngreso);
                cmd.Parameters.AddWithValue("@horEgr", medico.HorarioEgreso);
                cmd.Parameters.AddWithValue("@especialidadM", medico.IdEspecialidad);
                cmd.Parameters.AddWithValue("@calleM", medico.Calle);
                cmd.Parameters.AddWithValue("@nroCalleM", medico.NroCalle);
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
                window.show("Error " + ex);
                throw;
            }

            finally
            {
                cn.Close();
            }



            return resultado;
        }


        public static void ModificarMedicosDiasLaborales(MedicosxDiasLaborales diasLaborales)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = @"IF NOT EXISTS(SELECT * FROM MEDICOSxDIAS_LABORALES WHERE numeroMatricula = @matM AND id_diaLaboral = @diaLab)
                                    INSERT INTO MEDICOSxDIAS_LABORALES (numeroMatricula,id_diaLaboral) VALUES (@matM,@diaLab)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@matM", diasLaborales.NumeroMatricula);
                cmd.Parameters.AddWithValue("@diaLab", diasLaborales.IdDiaLaboral);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();


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

        internal static void ModificarMedicosDiasLaboralesUnchecked(MedicosxDiasLaborales diasLaborales)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = @"IF EXISTS(SELECT * FROM MEDICOSxDIAS_LABORALES WHERE numeroMatricula = @matM AND id_diaLaboral = @diaLab)
                                    DELETE FROM MEDICOSXDIAS_LABORALES WHERE numeroMatricula = @matM AND id_diaLaboral = @diaLab";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@matM", diasLaborales.NumeroMatricula);
                cmd.Parameters.AddWithValue("@diaLab", diasLaborales.IdDiaLaboral);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();


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
        public static Medicos getMedicoCompleto2(int nroMedico)
        {
            var resultado = new Medicos();
            var db = new BD3K3G05_2022Context();

            try
            {
                resultado = db.Medicos.First(a => a.NumeroMatricula == nroMedico);
            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado;
        }

    }
}
