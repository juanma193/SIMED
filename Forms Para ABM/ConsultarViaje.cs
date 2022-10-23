using SIMED.Models;
using SIMED_V1.Bases_de_datos;
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
        public ConsultarViaje()
        {
            InitializeComponent();
            CargarComboMoviles();
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


        private void cmbMoviles_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dtFechaViaje_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarViaje_Click(object sender, EventArgs e)
        {
            gbViajes.Rows.Clear();

            var resultado = new List<Viajes>();
            DataGridViewRow fila = new DataGridViewRow();

            var viajes = ViajesBD.getViajes(dtFechaViaje.Value);

            foreach (var viaje in viajes)
            {
                AgregarViaje(viaje);
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
            celdaMedico.Value = matriculaMedico;
            fila.Cells.Add(celdaMedico);

            DataGridViewTextBoxCell celdaEnfermero = new DataGridViewTextBoxCell();
            int matriculaEnfermero = ViajesBD.obtenerMatriculaEnfermero(viaje.Fecha);
            celdaEnfermero.Value = matriculaEnfermero;
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
            gbViajes.Rows.Clear();

            if (!(chkIncluirFechas.Checked))
            {
                Ambulancias movil = ViajesBD.obtenerMovil((int)cmbMoviles.SelectedValue);

                var resultado = new List<Viajes>();
                DataGridViewRow fila = new DataGridViewRow();

                var viajes = ViajesBD.getViajesXPatente(movil);

                foreach (var viaje in viajes)
                {
                    AgregarViaje(viaje);
                }
            }
            else {
                Ambulancias movil = ViajesBD.obtenerMovil((int)cmbMoviles.SelectedValue);

         

                var resultado = new List<Viajes>();
                DataGridViewRow fila = new DataGridViewRow();

                var viajes = ViajesBD.getViajesXPatenteXFecha(dtFechaViaje.Value, movil);

                foreach (var viaje in viajes)
                {
                    AgregarViaje(viaje);
                }


            }
          

        }

      
        private void btnBuscarPorMatricula_Click(object sender, EventArgs e)
        {


            var resultado = new List<Viajes>();
            DataGridViewRow fila = new DataGridViewRow();

            if (txtMatriculaEnfermero.Text != "" && txtMatriculaMedico.Text == "")
            {

                var fechas = ViajesBD.getFechasxEnfermero(int.Parse(txtMatriculaEnfermero.Text));

                var viajes = ViajesBD.getViajesXFechas(fechas);


                foreach (var viaje in viajes)
                {
                    AgregarViaje(viaje);
                }
            }

            if (txtMatriculaMedico.Text != "" && txtMatriculaEnfermero.Text == "")
            {

                var fechas = ViajesBD.getFechasxMedico(int.Parse(txtMatriculaMedico.Text));

                var viajes = ViajesBD.getViajesXFechas(fechas);


                foreach (var viaje in viajes)
                {
                    AgregarViaje(viaje);
                }

            }


            if (txtMatriculaMedico.Text != "" && txtMatriculaEnfermero.Text != "")
            {
                var fechas = ViajesBD.getFechasxMedicoxEnfermero(int.Parse(txtMatriculaEnfermero.Text), int.Parse(txtMatriculaMedico.Text));

                var viajes = ViajesBD.getViajesXFechas(fechas);

                foreach (var viaje in viajes)
                {
                    AgregarViaje(viaje);
                }

            }

        }
    }

}
