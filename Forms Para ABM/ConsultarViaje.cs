using SIMED_V1.Entidades;
using SIMED_V1.Bases_de_datos;
using SIMED_V1.Forms_Mensajes_Personalizados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMED_V1.Forms_Para_ABM
{
    public partial class ConsultarViaje : Form
    {
        int indice = 0;
        PrincipalForm principio;
        public ConsultarViaje(PrincipalForm principal)
        {
            InitializeComponent();
            CargarComboMoviles();
            CargarTodos();
            principio = principal;
        }

        private void CargarComboMoviles()
        {
            try
            {
                cmbMoviles.DisplayMember = "patente";
                cmbMoviles.ValueMember = "id_movil";
                cmbMoviles.DataSource = ViajesBD.ObtenerMoviles();
                cmbMoviles.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error " + ex);
            }
        }

        public void CargarTodos()
        {
            gbViajes.Rows.Clear();
            var viajes = ViajesBD.CargarViajes();

            foreach (var viaje in viajes)
            {
                AgregarViajeConTuplas(viaje);
            }




        }

        private void cmbMoviles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtFechaViaje_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarViaje_Click(object sender, EventArgs e)
        {
            try {
                gbViajes.Rows.Clear();

                var resultado = new List<Viajes>();
                DataGridViewRow fila = new DataGridViewRow();

                var viajes = ViajesBD.getViajes(dtFechaViaje.Value);

                foreach (var viaje in viajes)
                {
                    AgregarViajeConTuplas(viaje);
                }

                LimpiarCampos();
            }
            catch(Exception ex)
            {
                ErroresForm mensaje = new ErroresForm();
                mensaje.show("Se ha producido un error");
            }
        }

        private DataGridViewRow AgregarViaje(Viajes viaje)
        {
            DataGridViewRow fila = new DataGridViewRow();

            DataGridViewTextBoxCell celdaFecha = new DataGridViewTextBoxCell();
            celdaFecha.Value = viaje.Fecha;
            fila.Cells.Add(celdaFecha);

            DataGridViewTextBoxCell celdaHoraSalida = new DataGridViewTextBoxCell();
            celdaHoraSalida.Value = viaje.HoraSalida;
            fila.Cells.Add(celdaHoraSalida);

            DataGridViewTextBoxCell celdaTipoViaje = new DataGridViewTextBoxCell();

            if (viaje.IdTipoViaje == 2)
            {
                celdaTipoViaje.Value = "Viaje a hospital";
                fila.Cells.Add(celdaTipoViaje);
            }

            if (viaje.IdTipoViaje == 4)
            {
                celdaTipoViaje.Value = "Viaje a domicilio";
                fila.Cells.Add(celdaTipoViaje);
            }

            if (viaje.IdTipoViaje == 6)
            {
                celdaTipoViaje.Value = "Viaje punto a punto";
                fila.Cells.Add(celdaTipoViaje);
            }

            if (viaje.IdTipoViaje == 8)
            {
                celdaTipoViaje.Value = "Viaje en ambulancia";
                fila.Cells.Add(celdaTipoViaje);
            }


            DataGridViewTextBoxCell celdaPatente = new DataGridViewTextBoxCell();
            String movil = ViajesBD.obtenerPatente(viaje.IdMovil);
            celdaPatente.Value = movil;
            fila.Cells.Add(celdaPatente);

            DataGridViewTextBoxCell celdaTurnoRotativo = new DataGridViewTextBoxCell();
            if (viaje.IdTurnoRotativo == 0)
            {
                celdaTurnoRotativo.Value = "Mañana";
                fila.Cells.Add(celdaTurnoRotativo);
            }

            if (viaje.IdTurnoRotativo == 1)
            {
                celdaTurnoRotativo.Value = "Tarde";
                fila.Cells.Add(celdaTurnoRotativo);
            }

            if (viaje.IdTurnoRotativo == 2)
            {
                celdaTurnoRotativo.Value = "Noche";
                fila.Cells.Add(celdaTurnoRotativo);
            }


            DataGridViewTextBoxCell celdaMedico = new DataGridViewTextBoxCell();
            int matriculaMedico = ViajesBD.obtenerMatriculaMedico(viaje.Fecha);
            if (matriculaMedico == -1)
            {
                celdaMedico.Value = "---";
                fila.Cells.Add(celdaMedico);
            }
            else
            {

                celdaMedico.Value = matriculaMedico;
                fila.Cells.Add(celdaMedico);

            }


            DataGridViewTextBoxCell celdaEnfermero = new DataGridViewTextBoxCell();
            int matriculaEnfermero = ViajesBD.obtenerMatriculaEnfermero(viaje.Fecha);
            celdaEnfermero.Value = matriculaEnfermero;
            fila.Cells.Add(celdaEnfermero);



            gbViajes.Rows.Add(fila);

            return fila;


        }

        private DataGridViewRow AgregarViajeMedicoNoRepetido(Viajes viaje, int matricula)
        {
            DataGridViewRow fila = new DataGridViewRow();

            DataGridViewTextBoxCell celdaFecha = new DataGridViewTextBoxCell();
            celdaFecha.Value = viaje.Fecha;
            fila.Cells.Add(celdaFecha);

            DataGridViewTextBoxCell celdaHoraSalida = new DataGridViewTextBoxCell();
            celdaHoraSalida.Value = viaje.HoraSalida;
            fila.Cells.Add(celdaHoraSalida);

            DataGridViewTextBoxCell celdaTipoViaje = new DataGridViewTextBoxCell();

            if (viaje.IdTipoViaje == 2)
            {
                celdaTipoViaje.Value = "Viaje a hospital";
                fila.Cells.Add(celdaTipoViaje);
            }

            if (viaje.IdTipoViaje == 4)
            {
                celdaTipoViaje.Value = "Viaje a domicilio";
                fila.Cells.Add(celdaTipoViaje);
            }

            if (viaje.IdTipoViaje == 6)
            {
                celdaTipoViaje.Value = "Viaje punto a punto";
                fila.Cells.Add(celdaTipoViaje);
            }

            if (viaje.IdTipoViaje == 8)
            {
                celdaTipoViaje.Value = "Viaje en ambulancia";
                fila.Cells.Add(celdaTipoViaje);
            }


            DataGridViewTextBoxCell celdaPatente = new DataGridViewTextBoxCell();
            String movil = ViajesBD.obtenerPatente(viaje.IdMovil);
            celdaPatente.Value = movil;
            fila.Cells.Add(celdaPatente);

            DataGridViewTextBoxCell celdaTurnoRotativo = new DataGridViewTextBoxCell();
            if (viaje.IdTurnoRotativo == 0)
            {
                celdaTurnoRotativo.Value = "Mañana";
                fila.Cells.Add(celdaTurnoRotativo);
            }

            if (viaje.IdTurnoRotativo == 1)
            {
                celdaTurnoRotativo.Value = "Tarde";
                fila.Cells.Add(celdaTurnoRotativo);
            }

            if (viaje.IdTurnoRotativo == 2)
            {
                celdaTurnoRotativo.Value = "Noche";
                fila.Cells.Add(celdaTurnoRotativo);
            }


            DataGridViewTextBoxCell celdaMedico = new DataGridViewTextBoxCell();
            int matriculaMedico = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, matricula);
            if (matriculaMedico == -1)
            {
                celdaMedico.Value = "---";
                fila.Cells.Add(celdaMedico);
            }
            else
            {

                celdaMedico.Value = matriculaMedico;
                fila.Cells.Add(celdaMedico);

            }


            DataGridViewTextBoxCell celdaEnfermero = new DataGridViewTextBoxCell();
            int matriculaEnfermero = ViajesBD.obtenerMatriculaEnfermero(viaje.Fecha);
            celdaEnfermero.Value = matriculaEnfermero;
            fila.Cells.Add(celdaEnfermero);



            gbViajes.Rows.Add(fila);

            return fila;


        }

        private DataGridViewRow AgregarViajeEnfermeroNoRepetido(Viajes viaje, int matricula)
        {
            DataGridViewRow fila = new DataGridViewRow();

            DataGridViewTextBoxCell celdaFecha = new DataGridViewTextBoxCell();
            celdaFecha.Value = viaje.Fecha;
            fila.Cells.Add(celdaFecha);

            DataGridViewTextBoxCell celdaHoraSalida = new DataGridViewTextBoxCell();
            celdaHoraSalida.Value = viaje.HoraSalida;
            fila.Cells.Add(celdaHoraSalida);

            DataGridViewTextBoxCell celdaTipoViaje = new DataGridViewTextBoxCell();

            if (viaje.IdTipoViaje == 2)
            {
                celdaTipoViaje.Value = "Viaje a hospital";
                fila.Cells.Add(celdaTipoViaje);
            }

            if (viaje.IdTipoViaje == 4)
            {
                celdaTipoViaje.Value = "Viaje a domicilio";
                fila.Cells.Add(celdaTipoViaje);
            }

            if (viaje.IdTipoViaje == 6)
            {
                celdaTipoViaje.Value = "Viaje punto a punto";
                fila.Cells.Add(celdaTipoViaje);
            }

            if (viaje.IdTipoViaje == 8)
            {
                celdaTipoViaje.Value = "Viaje en ambulancia";
                fila.Cells.Add(celdaTipoViaje);
            }


            DataGridViewTextBoxCell celdaPatente = new DataGridViewTextBoxCell();
            String movil = ViajesBD.obtenerPatente(viaje.IdMovil);
            celdaPatente.Value = movil;
            fila.Cells.Add(celdaPatente);

            DataGridViewTextBoxCell celdaTurnoRotativo = new DataGridViewTextBoxCell();
            if (viaje.IdTurnoRotativo == 0)
            {
                celdaTurnoRotativo.Value = "Mañana";
                fila.Cells.Add(celdaTurnoRotativo);
            }

            if (viaje.IdTurnoRotativo == 1)
            {
                celdaTurnoRotativo.Value = "Tarde";
                fila.Cells.Add(celdaTurnoRotativo);
            }

            if (viaje.IdTurnoRotativo == 2)
            {
                celdaTurnoRotativo.Value = "Noche";
                fila.Cells.Add(celdaTurnoRotativo);
            }


            DataGridViewTextBoxCell celdaMedico = new DataGridViewTextBoxCell();
            int matriculaMedico = ViajesBD.obtenerMatriculaMedico(viaje.Fecha);
            if (matriculaMedico == -1)
            {
                celdaMedico.Value = "---";
                fila.Cells.Add(celdaMedico);
            }
            else
            {

                celdaMedico.Value = matriculaMedico;
                fila.Cells.Add(celdaMedico);

            }


            DataGridViewTextBoxCell celdaEnfermero = new DataGridViewTextBoxCell();
            int matriculaEnfermero = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, matricula);
            celdaEnfermero.Value = matriculaEnfermero;
            fila.Cells.Add(celdaEnfermero);



            gbViajes.Rows.Add(fila);

            return fila;


        }


        private DataGridViewRow AgregarViajeEquipoNoRepetido(Viajes viaje, int matriculaMedico, int matriculaEnfermero)
        {
            DataGridViewRow fila = new DataGridViewRow();

            DataGridViewTextBoxCell celdaFecha = new DataGridViewTextBoxCell();
            celdaFecha.Value = viaje.Fecha;
            fila.Cells.Add(celdaFecha);

            DataGridViewTextBoxCell celdaHoraSalida = new DataGridViewTextBoxCell();
            celdaHoraSalida.Value = viaje.HoraSalida;
            fila.Cells.Add(celdaHoraSalida);

            DataGridViewTextBoxCell celdaTipoViaje = new DataGridViewTextBoxCell();

            if (viaje.IdTipoViaje == 2)
            {
                celdaTipoViaje.Value = "Viaje a hospital";
                fila.Cells.Add(celdaTipoViaje);
            }

            if (viaje.IdTipoViaje == 4)
            {
                celdaTipoViaje.Value = "Viaje a domicilio";
                fila.Cells.Add(celdaTipoViaje);
            }

            if (viaje.IdTipoViaje == 6)
            {
                celdaTipoViaje.Value = "Viaje punto a punto";
                fila.Cells.Add(celdaTipoViaje);
            }

            if (viaje.IdTipoViaje == 8)
            {
                celdaTipoViaje.Value = "Viaje en ambulancia";
                fila.Cells.Add(celdaTipoViaje);
            }


            DataGridViewTextBoxCell celdaPatente = new DataGridViewTextBoxCell();
            String movil = ViajesBD.obtenerPatente(viaje.IdMovil);
            celdaPatente.Value = movil;
            fila.Cells.Add(celdaPatente);

            DataGridViewTextBoxCell celdaTurnoRotativo = new DataGridViewTextBoxCell();
            if (viaje.IdTurnoRotativo == 0)
            {
                celdaTurnoRotativo.Value = "Mañana";
                fila.Cells.Add(celdaTurnoRotativo);
            }

            if (viaje.IdTurnoRotativo == 1)
            {
                celdaTurnoRotativo.Value = "Tarde";
                fila.Cells.Add(celdaTurnoRotativo);
            }

            if (viaje.IdTurnoRotativo == 2)
            {
                celdaTurnoRotativo.Value = "Noche";
                fila.Cells.Add(celdaTurnoRotativo);
            }


            DataGridViewTextBoxCell celdaMedico = new DataGridViewTextBoxCell();
            int matriculaMedicoGrid = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, matriculaMedico);
            if (matriculaMedicoGrid == -1)
            {
                celdaMedico.Value = "---";
                fila.Cells.Add(celdaMedico);
            }
            else
            {

                celdaMedico.Value = matriculaMedicoGrid;
                fila.Cells.Add(celdaMedico);

            }


            DataGridViewTextBoxCell celdaEnfermero = new DataGridViewTextBoxCell();
            int matriculaEnfermeroGrid = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, matriculaEnfermero);
            celdaEnfermero.Value = matriculaEnfermeroGrid;
            fila.Cells.Add(celdaEnfermero);



            gbViajes.Rows.Add(fila);

            return fila;


        }



        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void txtMatriculaMedico_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarPorPatente_Click(object sender, EventArgs e)
        {
            if (cmbMoviles.SelectedIndex == -1)
            {
                ErroresForm vent = new ErroresForm();
                vent.show("Seleccione un móvil a buscar");
            }
            else
            {
                try
                {
                    gbViajes.Rows.Clear();

                    if (!(chkIncluirFechas.Checked))
                    {
                        Ambulancias movil = ViajesBD.obtenerMovil((int)cmbMoviles.SelectedValue);

                        var resultado = new List<Viajes>();
                        DataGridViewRow fila = new DataGridViewRow();

                        var viajes = ViajesBD.getViajesXPatente(movil);

                        foreach (var viaje in viajes)
                        {
                            AgregarViajeConTuplas(viaje);
                        }
                    }
                    else
                    {
                        Ambulancias movil = ViajesBD.obtenerMovil((int)cmbMoviles.SelectedValue);



                        var resultado = new List<Viajes>();
                        DataGridViewRow fila = new DataGridViewRow();

                        var viajes = ViajesBD.getViajesXPatenteXFecha(dtFechaViaje.Value, movil);

                        foreach (var viaje in viajes)
                        {
                            AgregarViaje(viaje);
                        }


                    }

                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    ErroresForm vent = new ErroresForm();
                    vent.show("Se ha producido un error");
                }
            }
            
            
        }


        private void btnBuscarPorDatosPersonales_Click(object sender, EventArgs e)
        {
            if (txtConsultaNombreEnfermero.Text == "" && txtConsultaApellidoEnfermero.Text == "" && txtConsultaNombreMedico.Text == "" && txtConsultaApellidoMedico.Text == "")
            {
                ErroresForm v = new ErroresForm();
                v.show("Ingrese un nombre o apellido a buscar");
            }
            else
            {
                try
                {
                    gbViajes.Rows.Clear();

                    var resultado = new List<Viajes>();
                    DataGridViewRow fila = new DataGridViewRow();

                    if (!(chkIncluirFechas.Checked))
                    {


                        if (txtConsultaNombreEnfermero.Text != "" && txtConsultaApellidoEnfermero.Text != "" && txtConsultaNombreMedico.Text == "" && txtConsultaApellidoMedico.Text == "")
                        {
                            var enfermeros = ViajesBD.getEnfermerosCompleto(txtConsultaNombreEnfermero.Text, txtConsultaApellidoEnfermero.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasEnfermeros(enfermeros);

                            var viajes = ViajesBD.getViajesXFechas(fechas);

                            foreach (var enfermero in enfermeros)
                            {

                                foreach (var viaje in viajes)
                                {

                                    int matricula = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, enfermero);

                                    if (enfermero == matricula)
                                    {
                                        AgregarViajeEnfermeroNoRepetido(viaje, matricula);
                                    }


                                }



                            }


                        }

                        if (txtConsultaNombreMedico.Text != "" && txtConsultaApellidoMedico.Text != "" && txtConsultaNombreEnfermero.Text == "" && txtConsultaApellidoEnfermero.Text == "")
                        {
                            var medicos = ViajesBD.getMedicosCompleto(txtConsultaNombreMedico.Text, txtConsultaApellidoMedico.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasMedicos(medicos);

                            var viajes = ViajesBD.getViajesXFechas(fechas);

                            foreach (var medico in medicos)
                            {

                                foreach (var viaje in viajes)
                                {

                                    int matricula = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, medico);

                                    if (medico == matricula)
                                    {
                                        AgregarViajeMedicoNoRepetido(viaje, matricula);
                                    }


                                }


                            }

                        }

                        if (txtConsultaNombreEnfermero.Text != "" && txtConsultaApellidoEnfermero.Text == "" && txtConsultaNombreMedico.Text == "" && txtConsultaApellidoMedico.Text == "")
                        {
                            var enfermeros = ViajesBD.getEnfermerosSoloNombre(txtConsultaNombreEnfermero.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasEnfermeros(enfermeros);

                            var viajes = ViajesBD.getViajesXFechas(fechas);

                            foreach (var enfermero in enfermeros)
                            {

                                foreach (var viaje in viajes)
                                {

                                    int matricula = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, enfermero);

                                    if (enfermero == matricula)
                                    {
                                        AgregarViajeEnfermeroNoRepetido(viaje, matricula);
                                    }


                                }
                            }

                        }

                        if (txtConsultaNombreEnfermero.Text == "" && txtConsultaApellidoEnfermero.Text != "" && txtConsultaNombreMedico.Text == "" && txtConsultaApellidoMedico.Text == "")
                        {

                            var enfermeros = ViajesBD.getEnfermerosSoloApellido(txtConsultaApellidoEnfermero.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasEnfermeros(enfermeros);

                            var viajes = ViajesBD.getViajesXFechas(fechas);

                            foreach (var enfermero in enfermeros)
                            {

                                foreach (var viaje in viajes)
                                {

                                    int matricula = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, enfermero);

                                    if (enfermero == matricula)
                                    {
                                        AgregarViajeEnfermeroNoRepetido(viaje, matricula);
                                    }


                                }

                            }

                        }


                        if (txtConsultaNombreEnfermero.Text == "" && txtConsultaApellidoEnfermero.Text == "" && txtConsultaNombreMedico.Text != "" && txtConsultaApellidoMedico.Text == "")
                        {
                            var medicos = ViajesBD.getMedicosCompletoSoloNombre(txtConsultaNombreMedico.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasMedicos(medicos);

                            var viajes = ViajesBD.getViajesXFechas(fechas);

                            foreach (var medico in medicos)
                            {

                                foreach (var viaje in viajes)
                                {

                                    int matricula = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, medico);

                                    if (medico == matricula)
                                    {
                                        AgregarViajeMedicoNoRepetido(viaje, matricula);
                                    }


                                }


                            }



                        }



                        if (txtConsultaNombreEnfermero.Text == "" && txtConsultaApellidoEnfermero.Text == "" && txtConsultaNombreMedico.Text == "" && txtConsultaApellidoMedico.Text != "")
                        {
                            var medicos = ViajesBD.getMedicosCompletoSoloApellido(txtConsultaApellidoMedico.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasMedicos(medicos);

                            var viajes = ViajesBD.getViajesXFechas(fechas);

                            foreach (var medico in medicos)
                            {

                                foreach (var viaje in viajes)
                                {

                                    int matricula = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, medico);

                                    if (medico == matricula)
                                    {
                                        AgregarViajeMedicoNoRepetido(viaje, matricula);
                                    }


                                }


                            }



                        }


                        if (txtConsultaNombreEnfermero.Text != "" && txtConsultaApellidoEnfermero.Text == "" && txtConsultaNombreMedico.Text != "" && txtConsultaApellidoMedico.Text == "")
                        {
                            var medicos = ViajesBD.getMedicosCompletoSoloNombre(txtConsultaNombreMedico.Text);

                            var enfermeros = ViajesBD.getEnfermerosSoloNombre(txtConsultaNombreEnfermero.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasEnfermerosYMedicos(medicos, enfermeros);

                            var viajes = ViajesBD.getViajesXFechas(fechas);

                            foreach (var viaje in viajes)
                            {
                                foreach (var medico in medicos)
                                {

                                    int matriculaMedico = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, medico);

                                    foreach (var enfermero in enfermeros)
                                    {
                                        int matriculaEnfermero = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, enfermero);

                                        if (matriculaMedico == medico && matriculaEnfermero == enfermero)
                                        {
                                            AgregarViajeEquipoNoRepetido(viaje, matriculaMedico, matriculaEnfermero);
                                        }
                                    }

                                }

                            }

                        }


                        if (txtConsultaNombreEnfermero.Text != "" && txtConsultaApellidoEnfermero.Text == "" && txtConsultaNombreMedico.Text == "" && txtConsultaApellidoMedico.Text != "")
                        {
                            var medicos = ViajesBD.getMedicosCompletoSoloApellido(txtConsultaApellidoMedico.Text);

                            var enfermeros = ViajesBD.getEnfermerosSoloNombre(txtConsultaNombreEnfermero.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasEnfermerosYMedicos(medicos, enfermeros);

                            var viajes = ViajesBD.getViajesXFechas(fechas);

                            foreach (var viaje in viajes)
                            {
                                foreach (var medico in medicos)
                                {

                                    int matriculaMedico = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, medico);

                                    foreach (var enfermero in enfermeros)
                                    {
                                        int matriculaEnfermero = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, enfermero);

                                        if (matriculaMedico == medico && matriculaEnfermero == enfermero)
                                        {
                                            AgregarViajeEquipoNoRepetido(viaje, matriculaMedico, matriculaEnfermero);
                                        }
                                    }

                                }

                            }

                        }

                        if (txtConsultaNombreEnfermero.Text == "" && txtConsultaApellidoEnfermero.Text != "" && txtConsultaNombreMedico.Text != "" && txtConsultaApellidoMedico.Text == "")
                        {
                            var medicos = ViajesBD.getMedicosCompletoSoloNombre(txtConsultaNombreMedico.Text);

                            var enfermeros = ViajesBD.getEnfermerosSoloApellido(txtConsultaApellidoEnfermero.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasEnfermerosYMedicos(medicos, enfermeros);

                            var viajes = ViajesBD.getViajesXFechas(fechas);

                            foreach (var viaje in viajes)
                            {
                                foreach (var medico in medicos)
                                {

                                    int matriculaMedico = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, medico);

                                    foreach (var enfermero in enfermeros)
                                    {
                                        int matriculaEnfermero = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, enfermero);

                                        if (matriculaMedico == medico && matriculaEnfermero == enfermero)
                                        {
                                            AgregarViajeEquipoNoRepetido(viaje, matriculaMedico, matriculaEnfermero);
                                        }
                                    }

                                }

                            }

                        }

                        if (txtConsultaNombreEnfermero.Text == "" && txtConsultaApellidoEnfermero.Text != "" && txtConsultaNombreMedico.Text == "" && txtConsultaApellidoMedico.Text != "")
                        {
                            var medicos = ViajesBD.getMedicosCompletoSoloApellido(txtConsultaApellidoMedico.Text);

                            var enfermeros = ViajesBD.getEnfermerosSoloApellido(txtConsultaApellidoEnfermero.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasEnfermerosYMedicos(medicos, enfermeros);

                            var viajes = ViajesBD.getViajesXFechas(fechas);

                            foreach (var viaje in viajes)
                            {
                                foreach (var medico in medicos)
                                {

                                    int matriculaMedico = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, medico);

                                    foreach (var enfermero in enfermeros)
                                    {
                                        int matriculaEnfermero = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, enfermero);

                                        if (matriculaMedico == medico && matriculaEnfermero == enfermero)
                                        {
                                            AgregarViajeEquipoNoRepetido(viaje, matriculaMedico, matriculaEnfermero);
                                        }
                                    }

                                }

                            }

                        }


                        if (txtConsultaNombreEnfermero.Text != "" && txtConsultaApellidoEnfermero.Text != "" && txtConsultaNombreMedico.Text != "" && txtConsultaApellidoMedico.Text == "")
                        {
                            var medicos = ViajesBD.getMedicosCompletoSoloNombre(txtConsultaNombreMedico.Text);

                            var enfermeros = ViajesBD.getEnfermerosCompleto(txtConsultaNombreEnfermero.Text, txtConsultaApellidoEnfermero.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasEnfermerosYMedicos(medicos, enfermeros);

                            var viajes = ViajesBD.getViajesXFechas(fechas);

                            foreach (var viaje in viajes)
                            {
                                foreach (var medico in medicos)
                                {

                                    int matriculaMedico = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, medico);

                                    foreach (var enfermero in enfermeros)
                                    {
                                        int matriculaEnfermero = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, enfermero);

                                        if (matriculaMedico == medico && matriculaEnfermero == enfermero)
                                        {
                                            AgregarViajeEquipoNoRepetido(viaje, matriculaMedico, matriculaEnfermero);
                                        }
                                    }

                                }

                            }

                        }

                        if (txtConsultaNombreEnfermero.Text != "" && txtConsultaApellidoEnfermero.Text != "" && txtConsultaNombreMedico.Text == "" && txtConsultaApellidoMedico.Text != "")
                        {
                            var medicos = ViajesBD.getMedicosCompletoSoloApellido(txtConsultaApellidoMedico.Text);

                            var enfermeros = ViajesBD.getEnfermerosCompleto(txtConsultaNombreEnfermero.Text, txtConsultaApellidoEnfermero.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasEnfermerosYMedicos(medicos, enfermeros);

                            var viajes = ViajesBD.getViajesXFechas(fechas);

                            foreach (var viaje in viajes)
                            {
                                foreach (var medico in medicos)
                                {

                                    int matriculaMedico = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, medico);

                                    foreach (var enfermero in enfermeros)
                                    {
                                        int matriculaEnfermero = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, enfermero);

                                        if (matriculaMedico == medico && matriculaEnfermero == enfermero)
                                        {
                                            AgregarViajeEquipoNoRepetido(viaje, matriculaMedico, matriculaEnfermero);
                                        }
                                    }

                                }

                            }

                        }

                        if (txtConsultaNombreEnfermero.Text == "" && txtConsultaApellidoEnfermero.Text != "" && txtConsultaNombreMedico.Text != "" && txtConsultaApellidoMedico.Text != "")
                        {
                            var medicos = ViajesBD.getMedicosCompleto(txtConsultaNombreMedico.Text, txtConsultaApellidoMedico.Text);

                            var enfermeros = ViajesBD.getEnfermerosSoloApellido(txtConsultaApellidoEnfermero.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasEnfermerosYMedicos(medicos, enfermeros);

                            var viajes = ViajesBD.getViajesXFechas(fechas);

                            foreach (var viaje in viajes)
                            {
                                foreach (var medico in medicos)
                                {

                                    int matriculaMedico = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, medico);

                                    foreach (var enfermero in enfermeros)
                                    {
                                        int matriculaEnfermero = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, enfermero);

                                        if (matriculaMedico == medico && matriculaEnfermero == enfermero)
                                        {
                                            AgregarViajeEquipoNoRepetido(viaje, matriculaMedico, matriculaEnfermero);
                                        }
                                    }

                                }

                            }


                        }

                        if (txtConsultaNombreEnfermero.Text != "" && txtConsultaApellidoEnfermero.Text == "" && txtConsultaNombreMedico.Text != "" && txtConsultaApellidoMedico.Text != "")
                        {
                            var medicos = ViajesBD.getMedicosCompleto(txtConsultaNombreMedico.Text, txtConsultaApellidoMedico.Text);

                            var enfermeros = ViajesBD.getEnfermerosSoloNombre(txtConsultaNombreEnfermero.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasEnfermerosYMedicos(medicos, enfermeros);

                            var viajes = ViajesBD.getViajesXFechas(fechas);

                            foreach (var viaje in viajes)
                            {
                                foreach (var medico in medicos)
                                {

                                    int matriculaMedico = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, medico);

                                    foreach (var enfermero in enfermeros)
                                    {
                                        int matriculaEnfermero = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, enfermero);

                                        if (matriculaMedico == medico && matriculaEnfermero == enfermero)
                                        {
                                            AgregarViajeEquipoNoRepetido(viaje, matriculaMedico, matriculaEnfermero);
                                        }
                                    }

                                }

                            }



                        }

                        if (txtConsultaNombreEnfermero.Text != "" && txtConsultaApellidoEnfermero.Text != "" && txtConsultaNombreMedico.Text != "" && txtConsultaApellidoMedico.Text != "")
                        {
                            var medicos = ViajesBD.getMedicosCompleto(txtConsultaNombreMedico.Text, txtConsultaApellidoMedico.Text);

                            var enfermeros = ViajesBD.getEnfermerosCompleto(txtConsultaNombreEnfermero.Text, txtConsultaApellidoEnfermero.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasEnfermerosYMedicos(medicos, enfermeros);

                            var viajes = ViajesBD.getViajesXFechas(fechas);

                            foreach (var viaje in viajes)
                            {
                                foreach (var medico in medicos)
                                {

                                    int matriculaMedico = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, medico);

                                    foreach (var enfermero in enfermeros)
                                    {
                                        int matriculaEnfermero = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, enfermero);

                                        if (matriculaMedico == medico && matriculaEnfermero == enfermero)
                                        {
                                            AgregarViajeEquipoNoRepetido(viaje, matriculaMedico, matriculaEnfermero);
                                        }
                                    }

                                }

                            }



                        }


                    }

                    else
                    {

                        if (txtConsultaNombreEnfermero.Text != "" && txtConsultaApellidoEnfermero.Text != "" && txtConsultaNombreMedico.Text == "" && txtConsultaApellidoMedico.Text == "")
                        {
                            var enfermeros = ViajesBD.getEnfermerosCompleto(txtConsultaNombreEnfermero.Text, txtConsultaApellidoEnfermero.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasEnfermeros(enfermeros);

                            var viajes = ViajesBD.getViajesXFechasCheckBox(fechas, dtFechaViaje.Value);

                            foreach (var enfermero in enfermeros)
                            {

                                foreach (var viaje in viajes)
                                {

                                    int matricula = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, enfermero);

                                    if (enfermero == matricula)
                                    {
                                        AgregarViajeEnfermeroNoRepetido(viaje, matricula);
                                    }


                                }



                            }


                        }

                        if (txtConsultaNombreMedico.Text != "" && txtConsultaApellidoMedico.Text != "" && txtConsultaNombreEnfermero.Text == "" && txtConsultaApellidoEnfermero.Text == "")
                        {
                            var medicos = ViajesBD.getMedicosCompleto(txtConsultaNombreMedico.Text, txtConsultaApellidoMedico.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasMedicos(medicos);

                            var viajes = ViajesBD.getViajesXFechasCheckBox(fechas, dtFechaViaje.Value);

                            foreach (var medico in medicos)
                            {

                                foreach (var viaje in viajes)
                                {

                                    int matricula = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, medico);

                                    if (medico == matricula)
                                    {
                                        AgregarViajeMedicoNoRepetido(viaje, matricula);
                                    }


                                }


                            }

                        }

                        if (txtConsultaNombreEnfermero.Text != "" && txtConsultaApellidoEnfermero.Text == "" && txtConsultaNombreMedico.Text == "" && txtConsultaApellidoMedico.Text == "")
                        {
                            var enfermeros = ViajesBD.getEnfermerosSoloNombre(txtConsultaNombreEnfermero.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasEnfermeros(enfermeros);

                            var viajes = ViajesBD.getViajesXFechasCheckBox(fechas, dtFechaViaje.Value);

                            foreach (var enfermero in enfermeros)
                            {

                                foreach (var viaje in viajes)
                                {

                                    int matricula = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, enfermero);

                                    if (enfermero == matricula)
                                    {
                                        AgregarViajeEnfermeroNoRepetido(viaje, matricula);
                                    }


                                }
                            }

                        }

                        if (txtConsultaNombreEnfermero.Text == "" && txtConsultaApellidoEnfermero.Text != "" && txtConsultaNombreMedico.Text == "" && txtConsultaApellidoMedico.Text == "")
                        {

                            var enfermeros = ViajesBD.getEnfermerosSoloApellido(txtConsultaApellidoEnfermero.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasEnfermeros(enfermeros);

                            var viajes = ViajesBD.getViajesXFechasCheckBox(fechas, dtFechaViaje.Value);

                            foreach (var enfermero in enfermeros)
                            {

                                foreach (var viaje in viajes)
                                {

                                    int matricula = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, enfermero);

                                    if (enfermero == matricula)
                                    {
                                        AgregarViajeEnfermeroNoRepetido(viaje, matricula);
                                    }


                                }

                            }

                        }


                        if (txtConsultaNombreEnfermero.Text == "" && txtConsultaApellidoEnfermero.Text == "" && txtConsultaNombreMedico.Text != "" && txtConsultaApellidoMedico.Text == "")
                        {
                            var medicos = ViajesBD.getMedicosCompletoSoloNombre(txtConsultaNombreMedico.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasMedicos(medicos);

                            var viajes = ViajesBD.getViajesXFechasCheckBox(fechas, dtFechaViaje.Value);

                            foreach (var medico in medicos)
                            {

                                foreach (var viaje in viajes)
                                {

                                    int matricula = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, medico);

                                    if (medico == matricula)
                                    {
                                        AgregarViajeMedicoNoRepetido(viaje, matricula);
                                    }


                                }


                            }



                        }



                        if (txtConsultaNombreEnfermero.Text == "" && txtConsultaApellidoEnfermero.Text == "" && txtConsultaNombreMedico.Text == "" && txtConsultaApellidoMedico.Text != "")
                        {
                            var medicos = ViajesBD.getMedicosCompletoSoloApellido(txtConsultaApellidoMedico.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasMedicos(medicos);

                            var viajes = ViajesBD.getViajesXFechasCheckBox(fechas, dtFechaViaje.Value);

                            foreach (var medico in medicos)
                            {

                                foreach (var viaje in viajes)
                                {

                                    int matricula = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, medico);

                                    if (medico == matricula)
                                    {
                                        AgregarViajeMedicoNoRepetido(viaje, matricula);
                                    }


                                }


                            }



                        }


                        if (txtConsultaNombreEnfermero.Text != "" && txtConsultaApellidoEnfermero.Text == "" && txtConsultaNombreMedico.Text != "" && txtConsultaApellidoMedico.Text == "")
                        {
                            var medicos = ViajesBD.getMedicosCompletoSoloNombre(txtConsultaNombreMedico.Text);

                            var enfermeros = ViajesBD.getEnfermerosSoloNombre(txtConsultaNombreEnfermero.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasEnfermerosYMedicos(medicos, enfermeros);

                            var viajes = ViajesBD.getViajesXFechasCheckBox(fechas, dtFechaViaje.Value);

                            foreach (var viaje in viajes)
                            {
                                foreach (var medico in medicos)
                                {

                                    int matriculaMedico = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, medico);

                                    foreach (var enfermero in enfermeros)
                                    {
                                        int matriculaEnfermero = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, enfermero);

                                        if (matriculaMedico == medico && matriculaEnfermero == enfermero)
                                        {
                                            AgregarViajeEquipoNoRepetido(viaje, matriculaMedico, matriculaEnfermero);
                                        }
                                    }

                                }

                            }

                        }


                        if (txtConsultaNombreEnfermero.Text != "" && txtConsultaApellidoEnfermero.Text == "" && txtConsultaNombreMedico.Text == "" && txtConsultaApellidoMedico.Text != "")
                        {
                            var medicos = ViajesBD.getMedicosCompletoSoloApellido(txtConsultaApellidoMedico.Text);

                            var enfermeros = ViajesBD.getEnfermerosSoloNombre(txtConsultaNombreEnfermero.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasEnfermerosYMedicos(medicos, enfermeros);

                            var viajes = ViajesBD.getViajesXFechasCheckBox(fechas, dtFechaViaje.Value);

                            foreach (var viaje in viajes)
                            {
                                foreach (var medico in medicos)
                                {

                                    int matriculaMedico = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, medico);

                                    foreach (var enfermero in enfermeros)
                                    {
                                        int matriculaEnfermero = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, enfermero);

                                        if (matriculaMedico == medico && matriculaEnfermero == enfermero)
                                        {
                                            AgregarViajeEquipoNoRepetido(viaje, matriculaMedico, matriculaEnfermero);
                                        }
                                    }

                                }

                            }

                        }

                        if (txtConsultaNombreEnfermero.Text == "" && txtConsultaApellidoEnfermero.Text != "" && txtConsultaNombreMedico.Text != "" && txtConsultaApellidoMedico.Text == "")
                        {
                            var medicos = ViajesBD.getMedicosCompletoSoloNombre(txtConsultaNombreMedico.Text);

                            var enfermeros = ViajesBD.getEnfermerosSoloApellido(txtConsultaApellidoEnfermero.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasEnfermerosYMedicos(medicos, enfermeros);

                            var viajes = ViajesBD.getViajesXFechasCheckBox(fechas, dtFechaViaje.Value);

                            foreach (var viaje in viajes)
                            {
                                foreach (var medico in medicos)
                                {

                                    int matriculaMedico = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, medico);

                                    foreach (var enfermero in enfermeros)
                                    {
                                        int matriculaEnfermero = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, enfermero);

                                        if (matriculaMedico == medico && matriculaEnfermero == enfermero)
                                        {
                                            AgregarViajeEquipoNoRepetido(viaje, matriculaMedico, matriculaEnfermero);
                                        }
                                    }

                                }

                            }

                        }

                        if (txtConsultaNombreEnfermero.Text == "" && txtConsultaApellidoEnfermero.Text != "" && txtConsultaNombreMedico.Text == "" && txtConsultaApellidoMedico.Text != "")
                        {
                            var medicos = ViajesBD.getMedicosCompletoSoloApellido(txtConsultaApellidoMedico.Text);

                            var enfermeros = ViajesBD.getEnfermerosSoloApellido(txtConsultaApellidoEnfermero.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasEnfermerosYMedicos(medicos, enfermeros);

                            var viajes = ViajesBD.getViajesXFechasCheckBox(fechas, dtFechaViaje.Value);

                            foreach (var viaje in viajes)
                            {
                                foreach (var medico in medicos)
                                {

                                    int matriculaMedico = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, medico);

                                    foreach (var enfermero in enfermeros)
                                    {
                                        int matriculaEnfermero = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, enfermero);

                                        if (matriculaMedico == medico && matriculaEnfermero == enfermero)
                                        {
                                            AgregarViajeEquipoNoRepetido(viaje, matriculaMedico, matriculaEnfermero);
                                        }
                                    }

                                }

                            }

                        }


                        if (txtConsultaNombreEnfermero.Text != "" && txtConsultaApellidoEnfermero.Text != "" && txtConsultaNombreMedico.Text != "" && txtConsultaApellidoMedico.Text == "")
                        {
                            var medicos = ViajesBD.getMedicosCompletoSoloNombre(txtConsultaNombreMedico.Text);

                            var enfermeros = ViajesBD.getEnfermerosCompleto(txtConsultaNombreEnfermero.Text, txtConsultaApellidoEnfermero.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasEnfermerosYMedicos(medicos, enfermeros);

                            var viajes = ViajesBD.getViajesXFechasCheckBox(fechas, dtFechaViaje.Value);

                            foreach (var viaje in viajes)
                            {
                                foreach (var medico in medicos)
                                {

                                    int matriculaMedico = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, medico);

                                    foreach (var enfermero in enfermeros)
                                    {
                                        int matriculaEnfermero = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, enfermero);

                                        if (matriculaMedico == medico && matriculaEnfermero == enfermero)
                                        {
                                            AgregarViajeEquipoNoRepetido(viaje, matriculaMedico, matriculaEnfermero);
                                        }
                                    }

                                }

                            }

                        }

                        if (txtConsultaNombreEnfermero.Text != "" && txtConsultaApellidoEnfermero.Text != "" && txtConsultaNombreMedico.Text == "" && txtConsultaApellidoMedico.Text != "")
                        {
                            var medicos = ViajesBD.getMedicosCompletoSoloApellido(txtConsultaApellidoMedico.Text);

                            var enfermeros = ViajesBD.getEnfermerosCompleto(txtConsultaNombreEnfermero.Text, txtConsultaApellidoEnfermero.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasEnfermerosYMedicos(medicos, enfermeros);

                            var viajes = ViajesBD.getViajesXFechasCheckBox(fechas, dtFechaViaje.Value);

                            foreach (var viaje in viajes)
                            {
                                foreach (var medico in medicos)
                                {

                                    int matriculaMedico = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, medico);

                                    foreach (var enfermero in enfermeros)
                                    {
                                        int matriculaEnfermero = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, enfermero);

                                        if (matriculaMedico == medico && matriculaEnfermero == enfermero)
                                        {
                                            AgregarViajeEquipoNoRepetido(viaje, matriculaMedico, matriculaEnfermero);
                                        }
                                    }

                                }

                            }

                        }

                        if (txtConsultaNombreEnfermero.Text == "" && txtConsultaApellidoEnfermero.Text != "" && txtConsultaNombreMedico.Text != "" && txtConsultaApellidoMedico.Text != "")
                        {
                            var medicos = ViajesBD.getMedicosCompleto(txtConsultaNombreMedico.Text, txtConsultaApellidoMedico.Text);

                            var enfermeros = ViajesBD.getEnfermerosSoloApellido(txtConsultaApellidoEnfermero.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasEnfermerosYMedicos(medicos, enfermeros);

                            var viajes = ViajesBD.getViajesXFechasCheckBox(fechas, dtFechaViaje.Value);

                            foreach (var viaje in viajes)
                            {
                                foreach (var medico in medicos)
                                {

                                    int matriculaMedico = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, medico);

                                    foreach (var enfermero in enfermeros)
                                    {
                                        int matriculaEnfermero = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, enfermero);

                                        if (matriculaMedico == medico && matriculaEnfermero == enfermero)
                                        {
                                            AgregarViajeEquipoNoRepetido(viaje, matriculaMedico, matriculaEnfermero);
                                        }
                                    }

                                }

                            }


                        }

                        if (txtConsultaNombreEnfermero.Text != "" && txtConsultaApellidoEnfermero.Text == "" && txtConsultaNombreMedico.Text != "" && txtConsultaApellidoMedico.Text != "")
                        {
                            var medicos = ViajesBD.getMedicosCompleto(txtConsultaNombreMedico.Text, txtConsultaApellidoMedico.Text);

                            var enfermeros = ViajesBD.getEnfermerosSoloNombre(txtConsultaNombreEnfermero.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasEnfermerosYMedicos(medicos, enfermeros);

                            var viajes = ViajesBD.getViajesXFechasCheckBox(fechas, dtFechaViaje.Value);

                            foreach (var viaje in viajes)
                            {
                                foreach (var medico in medicos)
                                {

                                    int matriculaMedico = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, medico);

                                    foreach (var enfermero in enfermeros)
                                    {
                                        int matriculaEnfermero = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, enfermero);

                                        if (matriculaMedico == medico && matriculaEnfermero == enfermero)
                                        {
                                            AgregarViajeEquipoNoRepetido(viaje, matriculaMedico, matriculaEnfermero);
                                        }
                                    }

                                }

                            }



                        }

                        if (txtConsultaNombreEnfermero.Text != "" && txtConsultaApellidoEnfermero.Text != "" && txtConsultaNombreMedico.Text != "" && txtConsultaApellidoMedico.Text != "")
                        {
                            var medicos = ViajesBD.getMedicosCompleto(txtConsultaNombreMedico.Text, txtConsultaApellidoMedico.Text);

                            var enfermeros = ViajesBD.getEnfermerosCompleto(txtConsultaNombreEnfermero.Text, txtConsultaApellidoEnfermero.Text);

                            var fechas = ViajesBD.getFechasViajesXMatriculasEnfermerosYMedicos(medicos, enfermeros);

                            var viajes = ViajesBD.getViajesXFechasCheckBox(fechas, dtFechaViaje.Value);

                            foreach (var viaje in viajes)
                            {
                                foreach (var medico in medicos)
                                {

                                    int matriculaMedico = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, medico);

                                    foreach (var enfermero in enfermeros)
                                    {
                                        int matriculaEnfermero = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, enfermero);

                                        if (matriculaMedico == medico && matriculaEnfermero == enfermero)
                                        {
                                            AgregarViajeEquipoNoRepetido(viaje, matriculaMedico, matriculaEnfermero);
                                        }
                                    }

                                }

                            }



                        }

                    }


                    LimpiarCampos();
                }
                catch(Exception ex)
                {
                    ErroresForm v = new ErroresForm();
                    v.show("Se ha producido un error");
                }
            }
                
        }

        private void btnBuscarPorMatricula_Click(object sender, EventArgs e)
        {
            if(txtMatriculaEnfermero.Text == "" && txtMatriculaMedico.Text == "")
            {
                ErroresForm vent = new ErroresForm();
                vent.show("Ingrese una matrícula a buscar");
            }
            else
            {
                try
                {
                    gbViajes.Rows.Clear();

                    var resultado = new List<Viajes>();
                    DataGridViewRow fila = new DataGridViewRow();

                    if (!(chkIncluirFechas.Checked))
                    {
                        if (txtMatriculaEnfermero.Text != "" && txtMatriculaMedico.Text == "")
                        {

                            var fechas = ViajesBD.getFechasxEnfermero(int.Parse(txtMatriculaEnfermero.Text));

                            var viajes = ViajesBD.getViajesXFechas(fechas);


                            foreach (var viaje in viajes)
                            {
                                int matricula = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, int.Parse(txtMatriculaEnfermero.Text));

                                if (matricula == int.Parse(txtMatriculaEnfermero.Text))
                                {
                                    AgregarViajeEnfermeroNoRepetido(viaje, int.Parse(txtMatriculaEnfermero.Text));
                                }
                            }
                        }

                        if (txtMatriculaMedico.Text != "" && txtMatriculaEnfermero.Text == "")
                        {

                            var fechas = ViajesBD.getFechasxMedico(int.Parse(txtMatriculaMedico.Text));

                            var viajes = ViajesBD.getViajesXFechas(fechas);


                            foreach (var viaje in viajes)
                            {
                                int matricula = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, int.Parse(txtMatriculaMedico.Text));

                                if (matricula == int.Parse(txtMatriculaMedico.Text))
                                {
                                    AgregarViajeMedicoNoRepetido(viaje, int.Parse(txtMatriculaMedico.Text));
                                }
                            }

                        }


                        if (txtMatriculaMedico.Text != "" && txtMatriculaEnfermero.Text != "")
                        {
                            var fechas = ViajesBD.getFechasxMedicoxEnfermero(int.Parse(txtMatriculaEnfermero.Text), int.Parse(txtMatriculaMedico.Text));

                            var viajes = ViajesBD.getViajesXFechas(fechas);

                            foreach (var viaje in viajes)
                            {
                                int matriculaMedico = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, int.Parse(txtMatriculaMedico.Text));
                                int matriculaEnfermero = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, int.Parse(txtMatriculaEnfermero.Text));

                                if (matriculaMedico == int.Parse(txtMatriculaMedico.Text) && matriculaEnfermero == int.Parse(txtMatriculaEnfermero.Text))
                                {
                                    AgregarViajeEquipoNoRepetido(viaje, int.Parse(txtMatriculaMedico.Text), int.Parse(txtMatriculaEnfermero.Text));
                                }
                            }

                        }


                    }


                    else
                    {

                        if (txtMatriculaEnfermero.Text != "" && txtMatriculaMedico.Text == "")
                        {

                            var fechas = ViajesBD.getFechasxEnfermero(int.Parse(txtMatriculaEnfermero.Text));

                            var viajes = ViajesBD.getViajesXFechasCheckBox(fechas, dtFechaViaje.Value);


                            foreach (var viaje in viajes)
                            {
                                int matricula = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, int.Parse(txtMatriculaEnfermero.Text));

                                if (matricula == int.Parse(txtMatriculaEnfermero.Text))
                                {
                                    AgregarViajeEnfermeroNoRepetido(viaje, int.Parse(txtMatriculaEnfermero.Text));
                                }
                            }
                        }

                        if (txtMatriculaMedico.Text != "" && txtMatriculaEnfermero.Text == "")
                        {

                            var fechas = ViajesBD.getFechasxMedico(int.Parse(txtMatriculaMedico.Text));

                            var viajes = ViajesBD.getViajesXFechasCheckBox(fechas, dtFechaViaje.Value);


                            foreach (var viaje in viajes)
                            {
                                int matricula = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, int.Parse(txtMatriculaMedico.Text));

                                if (matricula == int.Parse(txtMatriculaMedico.Text))
                                {
                                    AgregarViajeMedicoNoRepetido(viaje, int.Parse(txtMatriculaMedico.Text));
                                }
                            }

                        }


                        if (txtMatriculaMedico.Text != "" && txtMatriculaEnfermero.Text != "")
                        {
                            var fechas = ViajesBD.getFechasxMedicoxEnfermero(int.Parse(txtMatriculaEnfermero.Text), int.Parse(txtMatriculaMedico.Text));

                            var viajes = ViajesBD.getViajesXFechasCheckBox(fechas, dtFechaViaje.Value);

                            foreach (var viaje in viajes)
                            {
                                int matriculaMedico = ViajesBD.obtenerMatriculaMedicoNoRepetido(viaje.Fecha, int.Parse(txtMatriculaMedico.Text));
                                int matriculaEnfermero = ViajesBD.obtenerMatriculaEnfermeroNoRepetido(viaje.Fecha, int.Parse(txtMatriculaEnfermero.Text));

                                if (matriculaMedico == int.Parse(txtMatriculaMedico.Text) && matriculaEnfermero == int.Parse(txtMatriculaEnfermero.Text))
                                {
                                    AgregarViajeEquipoNoRepetido(viaje, int.Parse(txtMatriculaMedico.Text), int.Parse(txtMatriculaEnfermero.Text));
                                }
                            }

                        }



                    }

                    LimpiarCampos();
                }
                catch(Exception ex)
                {
                    ErroresForm ven = new ErroresForm();
                    ven.show("Se ha producido un error");
                }
                
            }
            
        }

        private void btnLimpiarGrilla_Click(object sender, EventArgs e)
        {
            gbViajes.Rows.Clear();
        }

        private void gbViajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (gbViajes.SelectedRows.Count == 1)
            {
                
                    DataGridViewRow filaSeleccionada = gbViajes.Rows[indice];
                    DateTime fecha = (DateTime)filaSeleccionada.Cells[0].Value;


                    DataGridViewRow filaSeleccionada2 = gbViajes.Rows[indice];
                    TimeSpan hora = (TimeSpan)filaSeleccionada2.Cells[1].Value;

                    Viajes viaje = ViajesBD.getViajesParaModificar(fecha, hora);

                    Modificar_Viaje ventana = new Modificar_Viaje(viaje, this);



                    ventana.Show();

                    ventana.setearTurno(viaje);



                 
            }
            else if (gbViajes.SelectedRows.Count > 1)
            {
                ErroresForm mensaje = new ErroresForm();
                mensaje.show("Seleccione un solo viaje");

            }
            else if(gbViajes.SelectedRows.Count == 0)    
            {
                ErroresForm mensaje = new ErroresForm();
                mensaje.show("Seleccione un viaje");
            }

            
        }
        private void btnEliminar_Click(object sender, EventArgs e)
            {
               
                if (gbViajes.SelectedRows.Count == 1)
                {

                    DataGridViewRow filaSeleccionada = gbViajes.Rows[indice];
                    DateTime fecha = (DateTime)filaSeleccionada.Cells[0].Value;


                    DataGridViewRow filaSeleccionada2 = gbViajes.Rows[indice];
                    TimeSpan hora = (TimeSpan)filaSeleccionada2.Cells[1].Value;

                    Viajes viaje = ViajesBD.getViajesParaModificar(fecha, hora);

                    EliminarViaje ventana = new EliminarViaje(viaje, this);



                    ventana.Show();

                    ventana.setearTurno(viaje);




                }
                else if (gbViajes.SelectedRows.Count > 1)
                {
                    ErroresForm mensaje = new ErroresForm();
                    mensaje.show("Seleccione un solo viaje");

                }
                else if (gbViajes.SelectedRows.Count == 0)
                {
                    ErroresForm mensaje = new ErroresForm();
                    mensaje.show("Seleccione un viaje");
                }

            
        }

            private void ConsultarViaje_Load(object sender, EventArgs e)
            {

            }

        private DataGridViewRow AgregarViajeConTuplas(Viajes viaje)
        {
            DataGridViewRow fila = new DataGridViewRow();

            DataGridViewTextBoxCell celdaFecha = new DataGridViewTextBoxCell();
            celdaFecha.Value = viaje.Fecha;
            fila.Cells.Add(celdaFecha);

            DataGridViewTextBoxCell celdaHoraSalida = new DataGridViewTextBoxCell();
            celdaHoraSalida.Value = viaje.HoraSalida;
            fila.Cells.Add(celdaHoraSalida);

            DataGridViewTextBoxCell celdaTipoViaje = new DataGridViewTextBoxCell();

            if (viaje.IdTipoViaje == 2)
            {
                celdaTipoViaje.Value = "Viaje a hospital";
                fila.Cells.Add(celdaTipoViaje);
            }

            if (viaje.IdTipoViaje == 4)
            {
                celdaTipoViaje.Value = "Viaje a domicilio";
                fila.Cells.Add(celdaTipoViaje);
            }

            if (viaje.IdTipoViaje == 6)
            {
                celdaTipoViaje.Value = "Viaje punto a punto";
                fila.Cells.Add(celdaTipoViaje);
            }

            if (viaje.IdTipoViaje == 8)
            {
                celdaTipoViaje.Value = "Viaje en ambulancia";
                fila.Cells.Add(celdaTipoViaje);
            }


            DataGridViewTextBoxCell celdaPatente = new DataGridViewTextBoxCell();
            String movil = ViajesBD.obtenerPatente(viaje.IdMovil);
            celdaPatente.Value = movil;
            fila.Cells.Add(celdaPatente);

            DataGridViewTextBoxCell celdaTurnoRotativo = new DataGridViewTextBoxCell();
            if (viaje.IdTurnoRotativo == 0)
            {
                celdaTurnoRotativo.Value = "Mañana";
                fila.Cells.Add(celdaTurnoRotativo);
            }

            if (viaje.IdTurnoRotativo == 1)
            {
                celdaTurnoRotativo.Value = "Tarde";
                fila.Cells.Add(celdaTurnoRotativo);
            }

            if (viaje.IdTurnoRotativo == 2)
            {
                celdaTurnoRotativo.Value = "Noche";
                fila.Cells.Add(celdaTurnoRotativo);
            }


            DataGridViewTextBoxCell celdaMedico = new DataGridViewTextBoxCell();
            List<int> matriculaMedico = ViajesBD.obtenerMatriculaMedicoTupla(viaje.Fecha, viaje.HoraSalida);
            var matriculas = "";
            var j = 0;
            foreach (var matricula in matriculaMedico)
            {
                if (j != 0)
                {
                    matriculas += " - ";
                }
                if (matricula == -1)
                {
                    matriculas += "---";

                }
                else
                {
                    matriculas += matricula.ToString();

                }
                j++;
            }

            celdaMedico.Value = matriculas;
            fila.Cells.Add(celdaMedico);


            DataGridViewTextBoxCell celdaEnfermero = new DataGridViewTextBoxCell();
            List<int> matriculaEnfermero = ViajesBD.obtenerMatriculaEnfermeroTupla(viaje.Fecha, viaje.HoraSalida);
            var matriculas2 = "";
            var i = 0;
            foreach (var matricula in matriculaEnfermero)
            {
                if (i != 0)
                {
                    matriculas2 += " - ";
                }

                if (matricula == -1)
                {
                    matriculas2 += "---";

                }
                else
                {
                    matriculas2 += matricula.ToString();

                }
                i++;
            }

            celdaEnfermero.Value = matriculas2;
            fila.Cells.Add(celdaEnfermero);

            gbViajes.Rows.Add(fila);

            return fila;


        }

        private void txtMatriculaEnfermero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMatriculaMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtConsultaNombreEnfermero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtConsultaNombreMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtConsultaApellidoEnfermero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtConsultaApellidoMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCargarGrilla_Click(object sender, EventArgs e)
        {
            CargarTodos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            principio.Show();
            this.Dispose();
        }

        private void LimpiarCampos()
        {
            cmbMoviles.SelectedIndex = -1;
            txtMatriculaEnfermero.Text = "";
            txtMatriculaMedico.Text = "";
            txtConsultaApellidoEnfermero.Text = "";
            txtConsultaApellidoMedico.Text = "";
            txtConsultaNombreEnfermero.Text = "";
            txtConsultaNombreMedico.Text = "";
        }
    }
    }
    

