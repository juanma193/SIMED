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
    public partial class Modificar_Viaje : Form
    {
        public Modificar_Viaje(Viajes viaje)
        {
            InitializeComponent();
            CargarComboMoviles();
            CargarComboTiposViaje();


            dtFechaViaje.Value = viaje.Fecha;
            dtHoraSalida.Value = DateTime.Parse(ConvertirTimeSpanAFecha(viaje.HoraSalida,viaje.Fecha));
            dtHoraLlegada.Value = DateTime.Parse(ConvertirTimeSpanAFecha(viaje.HoraLlegada, viaje.Fecha));
            cmbMoviles.SelectedValue = (viaje.IdMovil);
            txtKilometros.Text = viaje.KilometrosRealizados.ToString();
            txtCombustiblePrevio.Text = viaje.CantCombustiblePrevio.ToString();
            txtCombustiblePost.Text = viaje.CantCombustiblePost.ToString();
            cmbTiposViaje.SelectedValue = viaje.IdTipoViaje;

            if (viaje.IdTurnoRotativo == 0)
            {
                rdMañana.Checked = true;
            }
            else if (viaje.IdTurnoRotativo == 1)
            {
                rdTarde.Checked = true;
            }
            else if (viaje.IdTurnoRotativo == 2)
            {
                rdNoche.Checked = true;
            }

            List<Enfermerosxviajes> listaEnfermeros = ViajesBD.obtenerViajesDeLosEnfermeros(viaje.Fecha, viaje.HoraSalida);

            List<Enfermeros> nurses = ViajesBD.obtenerEnfermeros(listaEnfermeros);

            foreach (var nurse in nurses)
            {
                AgregarEnfermeros(nurse);
            }

            List<Medicosxviajes> listaMedicos = ViajesBD.obtenerViajesDeLosMedicos(viaje.Fecha, viaje.HoraSalida);

            List<Medicos> medicos = ViajesBD.obtenerMedicos(listaMedicos);

            foreach (var medico in medicos)
            {
                AgregarMedicos(medico);
            }
        }

        private DataGridViewRow AgregarEnfermeros(Enfermeros nurse)
        {
            DataGridViewRow fila = new DataGridViewRow();

            DataGridViewTextBoxCell celdaMatricula= new DataGridViewTextBoxCell();
           
            celdaMatricula.Value = nurse.NumeroMatricula;
            fila.Cells.Add(celdaMatricula);

            DataGridViewTextBoxCell celdaNombre = new DataGridViewTextBoxCell();
            celdaNombre.Value = nurse.Nombre;
            fila.Cells.Add(celdaNombre);

            DataGridViewTextBoxCell celdaApellido = new DataGridViewTextBoxCell();
            celdaApellido.Value = nurse.Apellido;
            fila.Cells.Add(celdaApellido);

            grdEnfermeros.Rows.Add(fila);

            return fila;


        }

        private DataGridViewRow AgregarMedicos(Medicos medic)
        {
            DataGridViewRow fila = new DataGridViewRow();

            DataGridViewTextBoxCell celdaMatricula = new DataGridViewTextBoxCell();

            celdaMatricula.Value = medic.NumeroMatricula;
            fila.Cells.Add(celdaMatricula);

            DataGridViewTextBoxCell celdaNombre = new DataGridViewTextBoxCell();
            celdaNombre.Value = medic.Nombre;
            fila.Cells.Add(celdaNombre);

            DataGridViewTextBoxCell celdaApellido = new DataGridViewTextBoxCell();
            celdaApellido.Value = medic.Apellido;
            fila.Cells.Add(celdaApellido);

            grdMedicos.Rows.Add(fila);

            return fila;


        }

        private String ConvertirTimeSpanAFecha(TimeSpan hora, DateTime fecha)
        {
            String horafinal = hora.Hours.ToString();
            if (horafinal.Length == 1)
                horafinal = "0" + horafinal;

            String minutos = hora.Minutes.ToString();
            if (minutos.Length == 1)
                minutos += "0";

            var fechayHora = fecha.ToString("yyyy-MM-dd") + " " + horafinal + ":" + minutos;

            return fechayHora;
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

        private void CargarComboTiposViaje()
        {
            try
            {
                cmbTiposViaje.DisplayMember = "descripcionTipoViaje";
                cmbTiposViaje.ValueMember = "id_tipoViaje";
                cmbTiposViaje.DataSource = ViajesBD.ObtenerTiposViajes();
                cmbTiposViaje.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error " + ex);
            }
        }


        private void Modificar_Viaje_Load(object sender, EventArgs e)
        {

        }
    }
}
