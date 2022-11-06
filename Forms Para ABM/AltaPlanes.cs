using SIMED_V1.Entidades;
using SIMED_V1.Bases_de_datos;
using SIMED_V1.Forms_Para_El_Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Speech.Synthesis.TtsEngine;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMED_V1.Forms_Para_ABM
{
    public partial class AltaPlanes : Form
    {
        private static bool bandera = false;
        public AltaPlanes()
        {
            InitializeComponent();
        }

        

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!bandera)
            {
                if (txtPrecio.Text.Equals(""))
                {
                    lbl6.Visible = true;
                    lbl6.Text = "* Campo obligatorio";
                }
                else
                {
                    lbl6.Visible = false;
                }
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (!bandera)
            {
                if (txtNombrePlan.Text.Equals(""))
                {
                    lbl1.Visible = true;
                    lbl1.Text = "* Campo obligatorio";
                }
                else
                {
                    lbl1.Visible = false;
                }
            }
        }


        private void AltaPlanes_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtNombrePlan.Focus();
            lbl1.Visible = false;
            lbl6.Visible = false;
            try
            {
                CargarComboRE();
            }
            catch (Exception ex)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error al cargar rangos etarios");
            }
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
            bandera = true;
            txtNombrePlan.Text = "";
            txtPrecio.Text = "";
            rbPlanBasico.Checked = false;
            rbPlanPremium.Checked = false;
            cmbRangoEtario.SelectedIndex = -1;
            bandera = false;
        }

        private void txtNombrePlan_KeyPress(object sender, KeyPressEventArgs e)
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

        private bool CheckeoRB()
        {
            bool resultado = true;
            if(!rbPlanBasico.Checked && !rbPlanPremium.Checked)
            {
                resultado = false;
            }
            return resultado;
        }

        private bool ValidacionCampos()
        {
            bool resultado = true;
            {
                if (txtNombrePlan.Text.Equals("") || txtPrecio.Text.Equals("") || (!CheckeoRB()) || cmbRangoEtario.SelectedIndex == -1)
                {
                    resultado = false;
                    if (txtNombrePlan.Text.Equals(""))
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
            p.NombrePlan = txtNombrePlan.Text;
            p.Precio = float.Parse(txtPrecio.Text.ToString());
            p.IdRangoEtario = int.Parse(cmbRangoEtario.SelectedValue.ToString());

            if(rbPlanBasico.Checked)
            {
                p.IdTipoPlan = 1;
            }
            if(rbPlanPremium.Checked)
            {
                p.IdTipoPlan = 2;
            }

            return p;
        }

        private void btnCrearAmbulancia_Click(object sender, EventArgs e)
        { 
            if(ValidacionCampos())
            {
                Planes p = ObtenerDatosPlan();
                try
                {
                    bool rdo = PlanesBD.PlanYaExiste(p);
                    if (rdo)
                    {
                        ErroresForm ventana = new ErroresForm();
                        ventana.show("El plan ya existe");
                    }
                    else
                    {
                        bool resultado = PlanesBD.AgregarPlanABD(p);
                        if (resultado)
                        {
                            CorrectoForm cf = new CorrectoForm();
                            cf.show("Plan agregado con éxito");
                            LimpiarCampos();
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
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
