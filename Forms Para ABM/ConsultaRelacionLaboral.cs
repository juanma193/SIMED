using SIMED.Models;
using SIMED_V1.Bases_de_datos;
using SIMED_V1.Forms_Mensajes_Personalizados;
using SIMED_V1.Forms_Para_El_Menu;
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
    public partial class ConsultaRelacionLaboral : Form
    {
        public ConsultaRelacionLaboral()
        {
            InitializeComponent();
        }

        private void ConsultaRelacionLaboral_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla();
            btnActualizarRL.Enabled = false;
            btnEliminarRL.Enabled = false;
            lblNroIdRL.Enabled = false;
            lblIdRL.Visible = false;
        }

        private void LimpiarCampos()
        {
            txtDescRL.Text = "";
        }

        private void CargarGrilla()
        {
            try
            {
                gdrRL.DataSource = ModelosMarcasRLBD.ObtenerListadoRL();
            }
            catch (Exception)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error al cargar grilla");
            }
        }

        private void txtDescRL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (Keys)e.KeyChar != Keys.Back && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void CargarGrilla(string descRL)
        {
            try
            {
                gdrRL.DataSource = ModelosMarcasRLBD.ObtenerListadoRL(descRL);
            }
            catch (Exception)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error al cargar grilla");
            }
        }

        private void btnBuscarRL_Click(object sender, EventArgs e)
        {
            if (!txtDescRL.Text.Equals(""))
            {
                CargarGrilla(txtDescRL.Text);
            }
            else
            {
                CargarGrilla();
            }
        }

        private RelacionesLaborales ObtenerDatosRL()
        {
            RelacionesLaborales rl = new RelacionesLaborales();
            rl.DescripcionRelacionLaboral = txtDescRL.Text;
            rl.IdRelacionLaboral = int.Parse(lblIdRL.Text.ToString());

            return rl;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            URelacionesLaborales ventana = new URelacionesLaborales();
            ventana.Show();
        }

        private void CargarCampos(RelacionesLaborales rl)
        {
            LimpiarCampos();
            txtDescRL.Text = rl.DescripcionRelacionLaboral.ToString();
        }

        private void gdrRL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizarRL.Enabled = true;
            btnEliminarRL.Enabled = true;
            int indice = e.RowIndex;
            DataGridViewRow fila = gdrRL.Rows[indice];
            string descRL = fila.Cells["descRL"].Value.ToString();
            RelacionesLaborales rl = ModelosMarcasRLBD.ObtenerRL(descRL);
            lblIdRL.Text = rl.IdRelacionLaboral.ToString();
            lblIdRL.Visible = true;
            lblNroIdRL.Enabled = true;
            LimpiarCampos();
            CargarCampos(rl);
        }

        private void btnActualizarRL_Click(object sender, EventArgs e)
        {
            if (txtDescRL.Text.Equals(""))
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Ingrese nombre de relacion laboral");
            }
            else
            {
                RelacionesLaborales rl = ObtenerDatosRL();
                bool resultado = ModelosMarcasRLBD.ActualizarRL(rl);
                if (resultado)
                {
                    CorrectoForm cf = new CorrectoForm();
                    cf.show("Relacion laboral actualizada con éxito");
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Error al actualizar relacion laboral");
                }
            }
        }

        private void btnEliminarRL_Click(object sender, EventArgs e)
        {
            SeguroModificar window = new SeguroModificar();
            if (window.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    RelacionesLaborales rl = ObtenerDatosRL();
                    bool resultado = ModelosMarcasRLBD.EliminarRL(rl);
                    if (resultado)
                    {
                        LimpiarCampos();
                        CargarGrilla();
                        CorrectoForm cor = new CorrectoForm();
                        cor.show("Relacion laboral eliminada con éxito");
                    }
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("No puede eliminar una relación laboral relacionada con algun médico\nPorfavor elimine los médicos asociados primero");
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            URelacionesLaborales nue = new URelacionesLaborales();
            nue.Show();
            this.Dispose();
        }
    }
}
