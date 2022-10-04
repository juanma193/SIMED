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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMED_V1.Forms_Para_ABM
{
    public partial class ConsultaPlanes : Form
    {
        public ConsultaPlanes()
        {
            InitializeComponent();
        }

        private void ConsultaPlanes_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla();
            CargarComboRE();
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            lblNroIdPlan.Enabled = false;
            lblIdPlan.Visible = false;
        }

        private void CargarComboRE()
        {
            try
            {
                cmbRangoEtario.DataSource = PlanesBD.ObtenerRE();
                cmbRangoEtario.DisplayMember = "descripcionRangoEtario";
                cmbRangoEtario.ValueMember = "id_rangoEtario";
                cmbRangoEtario.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error al cargar rangos etarios");
            }
        }



        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            rbPlanBasico.Checked = false;
            rbPlanPremium.Checked = false;
            cmbRangoEtario.SelectedIndex = -1;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            {
                if (!txtNombre.Text.Equals(""))
                {
                    CargarGrilla(txtNombre.Text);
                }
                else
                {
                    CargarGrilla();
                }
            }
        }

        private void CargarGrilla()
        {
            try
            {
                gdrPlanes.DataSource = PlanesBD.ObtenerListadoPlanes();
            }
            catch (Exception)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error al cargar grilla");
            }
        }

        private void CargarGrilla(string nombrePlan)
        {
            try
            {
                gdrPlanes.DataSource = PlanesBD.ObtenerListadoPlanes(nombrePlan);
            }
            catch (Exception)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error al cargar grilla");
            }

        }

        private void gdrPlanes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            int indice = e.RowIndex;
            DataGridViewRow fila = gdrPlanes.Rows[indice];
            string nombreModelo = fila.Cells["nombrePlan"].Value.ToString();
            Planes p = PlanesBD.ObtenerPlan(nombreModelo);
            lblIdPlan.Visible = true;
            lblNroIdPlan.Enabled = true;
            LimpiarCampos();
            CargarCampos(p);
        }

        private void CargarCampos(Planes p)
        {
            LimpiarCampos();
            txtNombre.Text = p.NombrePlan;
            cmbRangoEtario.SelectedValue = p.IdRangoEtario;
            lblIdPlan.Text = p.IdPlan.ToString();
            txtPrecio.Text = p.Precio.ToString();

            if(p.IdTipoPlan == 1)
            {
                rbPlanBasico.Checked = true;
            }
            if (p.IdTipoPlan == 2)
            {
                rbPlanPremium.Checked = true;
            }
        }

        private bool CheckeoRB()
        {
            bool resultado = true;
            if (!rbPlanBasico.Checked && !rbPlanPremium.Checked)
            {
                resultado = false;
            }
            return resultado;
        }

        private bool ValidarCampos()
        {
            bool resultado = true;
            {
                if (txtNombre.Text.Equals("") || txtPrecio.Text.Equals("") || (!CheckeoRB()) || cmbRangoEtario.SelectedIndex == -1)
                {
                    resultado = false;
                    if (txtNombre.Text.Equals(""))
                    {
                        ErroresForm ventana = new ErroresForm();
                        ventana.show("Ingrese nombre de plan");
                    }
                    else if (!CheckeoRB())
                    {
                        ErroresForm ventana = new ErroresForm();
                        ventana.show("Seleccione tipo de plan");
                    }
                    else if (cmbRangoEtario.SelectedIndex == -1)
                    {
                        ErroresForm ventana = new ErroresForm();
                        ventana.show("Seleccione rango etario");
                    }
                    else if (txtPrecio.Text.Equals(""))
                    {
                        ErroresForm ventana = new ErroresForm();
                        ventana.show("Ingrese precio de plan");
                    }
                }
            }
            return resultado;
        }

        private Planes ObtenerDatosPlan()
        {
            Planes p = new Planes();
            p.NombrePlan = txtNombre.Text;
            p.Precio = float.Parse(txtPrecio.Text.ToString());
            p.IdRangoEtario = int.Parse(cmbRangoEtario.SelectedValue.ToString());
            p.IdPlan = int.Parse(lblIdPlan.Text.ToString());

            if (rbPlanBasico.Checked)
            {
                p.IdTipoPlan = 1;
            }
            if (rbPlanPremium.Checked)
            {
                p.IdTipoPlan = 2;
            }

            return p;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            bool r = ValidarCampos();
            if (r)
            {
                Planes p = ObtenerDatosPlan();
                bool resultado = PlanesBD.ActualizarPlan(p);
                if (resultado)
                {
                    CorrectoForm cf = new CorrectoForm();
                    cf.show("Plan actualizado con éxito");
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Error al actualizar plan");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SeguroModificar window = new SeguroModificar();
            if (window.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    Planes p = ObtenerDatosPlan();
                    bool resultado = PlanesBD.EliminarModelo(p);
                    if (resultado)
                    {
                        LimpiarCampos();
                        CargarGrilla();
                        CorrectoForm cor = new CorrectoForm();
                        cor.show("Plan eliminado con éxito");
                    }
                }
                catch (Exception)
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Error al eliminar plan");
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            UPlanes nue = new UPlanes();
            nue.Show();
            this.Dispose();
        }
    }
}