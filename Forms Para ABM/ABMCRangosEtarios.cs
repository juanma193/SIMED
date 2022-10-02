using Guna.UI2.WinForms;
using SIMED.Models;
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
    public partial class ABMCRangosEtarios : Form
    {
        public ABMCRangosEtarios()
        {
            InitializeComponent();
            lblDescripcionRangoEtario.Visible = false;
            btnEliminarRangoEtario.Enabled = false;
            btnModificarRango.Enabled = false;

        }

        private void btnCrearRangoEtario_Click(object sender, EventArgs e)
        {
            SeguroModificar seguro = new SeguroModificar();
            seguro.btnModificar.Text = "Crear";
            seguro.lblMensaje.Text = "¿Está seguro de que desea crear un nuevo rango etario?";
            if(seguro.ShowDialog() == DialogResult.OK)
            {
                LimpiarCampos();
                btnModificarRango.Enabled = false;
                btnEliminarRangoEtario.Enabled = false;
                try
                {
                    RangosEtarios rango = new RangosEtarios();
                    bool valDesc = true;

                    if (txtDescripcionRangoEtario.Text == "")
                    {
                        valDesc = false;
                        ErroresForm mensaje = new ErroresForm();
                        mensaje.show("Ingrese la descripción del rango etario a crear");
                        txtDescripcionRangoEtario.Focus();
                        lblDescripcionRangoEtario.Visible = true;
                    }
                    if (txtIdRangoEtario.Text != "")
                    {
                        ErroresForm mensaje = new ErroresForm();
                        mensaje.show("No es necesario ingresar id de rango en su creación");
                    }

                    if (valDesc)
                    {
                        rango.DescripcionRangoEtario = txtDescripcionRangoEtario.Text;
                        bool resultado = RangoEtarioBD.InsertarRangoEtario(rango);

                        if (resultado)
                        {
                            CorrectoForm ventana = new CorrectoForm();
                            ventana.show("Se ha registrado el rango etario con éxito");
                            CargarGrillaConsultaRangosEtarios();
                            lblDescripcionRangoEtario.Visible = false;
                        }
                        else
                        {
                            ErroresForm ventana = new ErroresForm();
                            ventana.show("El rango etario ingresado ya existe");
                        }
                    }


                }
                catch (Exception ex)
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Error " + ex);
                }
            }
            
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (btnModificarRango.Enabled)
            {
                RangosEtarios rango = new RangosEtarios();
                rango.IdRangoEtario = int.Parse(txtIdRangoEtario.Text);
                rango.DescripcionRangoEtario = txtDescripcionRangoEtario.Text;
                bool resultado = RangoEtarioBD.ObtenerRangoEtario(rango).Rows.Count != 0;
                if (resultado)
                {
                    this.Dispose();
                }
                else
                {
                    SeguroModificar seguro = new SeguroModificar();
                    seguro.btnModificar.Text = "Aceptar";
                    seguro.lblMensaje.Text = "¿Está seguro que no desea guardar los cambios?";
                    if (seguro.ShowDialog() == DialogResult.OK)
                    {
                        this.Dispose();
                    }
                }
                
            }
            else
            {
                this.Dispose();
            }

        }


        private void txtDescripcionRangoEtario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar)) e.Handled = false;
            else
            {
                if (e.KeyChar == '\b') e.Handled = false; //Tecla de borrado
                else
                {
                    if (e.KeyChar == '-') e.Handled = false;
                    else if(!char.IsSeparator(e.KeyChar)) e.Handled = true;
                }
            }

        }


        public void CargarGrillaConsultaRangosEtarios()
        {
            grdRangosEtarios.DataSource = RangoEtarioBD.ObtenerRangoEtario();
        }


        private void btnEliminarRangoEtario_Click(object sender, EventArgs e)
        {
            SeguroEliminar seguro = new SeguroEliminar();
            seguro.lblMensaje.Text = "¿Está seguro que desea eliminar este registro?";
            if (seguro.ShowDialog() == DialogResult.OK)
            {
                btnModificarRango.Enabled = false;
                btnEliminarRangoEtario.Enabled = false;
                try
                {
                    DataGridViewRow fila = grdRangosEtarios.CurrentRow;
                    RangosEtarios rango = new RangosEtarios();
                    bool resultado = false;


                    if (txtIdRangoEtario.Text != "" && txtDescripcionRangoEtario.Text != "")
                    {
                        rango.IdRangoEtario = int.Parse(txtIdRangoEtario.Text.ToString());
                        rango.DescripcionRangoEtario = txtDescripcionRangoEtario.Text;
                        resultado = RangoEtarioBD.EliminarRangoEtario(rango);

                    }
                    else if (txtIdRangoEtario.Text == "" && txtDescripcionRangoEtario.Text != "")
                    {
                        string desc = txtDescripcionRangoEtario.Text;
                        resultado = RangoEtarioBD.EliminarRangoEtario(desc);
                    }
                    else if (txtIdRangoEtario.Text != "" && txtDescripcionRangoEtario.Text == "")
                    {
                        int id = int.Parse(txtIdRangoEtario.Text.ToString());
                        resultado = RangoEtarioBD.EliminarRangoEtario(id);
                    }


                    if (resultado)
                    {
                        CorrectoForm ventana = new CorrectoForm();
                        ventana.show("Se ha eliminado el rango etario con éxito");
                        CargarGrillaConsultaRangosEtarios();
                        btnEliminarRangoEtario.Enabled = false;
                        btnModificarRango.Enabled = false;

                    }
                    else
                    {
                        ErroresForm ventana = new ErroresForm();
                        ventana.show("No existe el rango etario especificado");
                    }



                }
                catch (Exception ex)
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Error " + ex);
                }

                LimpiarCampos();
            }
            
        }


        private void btnBuscarRangoEtario_Click(object sender, EventArgs e)
        {

            btnEliminarRangoEtario.Enabled = false;
            btnModificarRango.Enabled = false;
            lblDescripcionRangoEtario.Visible = false;

            //Primer caso, seleccionan buscar sin ingresar nada. Se refresca la grilla mostrando todos los
            //rangos etarios existentes
            if (txtDescripcionRangoEtario.Text == "" && txtIdRangoEtario.Text == "")
            {
                CargarGrillaConsultaRangosEtarios();
                chkMostrarTodosRangos.Visible = false;
                lblDescripcionRangoEtario.Visible = false;
            }

            //Segundo caso, buscan por descripción de rango etario
            else if (txtDescripcionRangoEtario.Text != "" && txtIdRangoEtario.Text == "")
            {
                grdRangosEtarios.DataSource = RangoEtarioBD.ObtenerRangoEtario(txtDescripcionRangoEtario.Text);

                chkMostrarTodosRangos.Visible = true;
                chkMostrarTodosRangos.Checked = false;
            }

            //Tercer caso, seleccionan un rango de la grilla, borran la descripción que aparece y buscan solo por id
            else if(txtDescripcionRangoEtario.Text == "" && txtIdRangoEtario.Text != "")
            {
                grdRangosEtarios.DataSource = RangoEtarioBD.ObtenerRangoEtario(int.Parse(txtIdRangoEtario.Text.ToString()));

                chkMostrarTodosRangos.Visible = true;
                chkMostrarTodosRangos.Checked = false;
            }
            else
            {
                RangosEtarios rango = new RangosEtarios();
                rango.IdRangoEtario = int.Parse(txtIdRangoEtario.Text);
                rango.DescripcionRangoEtario = txtDescripcionRangoEtario.Text;
                grdRangosEtarios.DataSource = RangoEtarioBD.ObtenerRangoEtario(rango);
            }

            LimpiarCampos();
        }


        private void LimpiarCampos()
        {
            txtDescripcionRangoEtario.Text = "";
            txtIdRangoEtario.Text = "";

        }


        private void ABMCRangosEtarios_Load(object sender, EventArgs e)
        {
            CargarGrillaConsultaRangosEtarios();
        }


        private void chkMostrarTodosRangos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarTodosRangos.Checked)
            {
                CargarGrillaConsultaRangosEtarios();
                chkMostrarTodosRangos.Visible = false;
            }
            btnEliminarRangoEtario.Enabled = false;
            btnModificarRango.Enabled = false;
            LimpiarCampos();
        }


        private void grdRangosEtarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminarRangoEtario.Enabled = true;
            btnModificarRango.Enabled = true;
            DataGridViewRow fila = grdRangosEtarios.CurrentRow;
            txtIdRangoEtario.Text = fila.Cells[0].Value.ToString();
            txtDescripcionRangoEtario.Text = fila.Cells[1].Value.ToString();

        }


        private void btnModificarRango_Click(object sender, EventArgs e)
        {
            SeguroModificar seguro = new SeguroModificar();
            seguro.lblMensaje.Text = "¿Está seguro que desea modificar este registro?";
            if (seguro.ShowDialog() == DialogResult.OK)
            {
                btnEliminarRangoEtario.Enabled = false;
                btnModificarRango.Enabled = false;
                if (txtDescripcionRangoEtario.Text == "")
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Ingrese un rango etario en la casilla de descripción para modificar el registro seleccionado");
                }
                else
                {
                    DataGridViewRow fila = grdRangosEtarios.CurrentRow;
                    RangosEtarios rango = new RangosEtarios();
                    rango.IdRangoEtario = int.Parse(fila.Cells[0].Value.ToString());
                    rango.DescripcionRangoEtario = txtDescripcionRangoEtario.Text;

                    bool resultado = RangoEtarioBD.ModificarRangoEtario(rango);

                    if (resultado)
                    {
                        CorrectoForm ventana = new CorrectoForm();
                        ventana.show("Se ha modificado el rango etario con éxito");
                        CargarGrillaConsultaRangosEtarios();
                        btnEliminarRangoEtario.Enabled = false;
                        btnModificarRango.Enabled = false;
                        chkMostrarTodosRangos.Visible = false;

                    }
                    else
                    {
                        ErroresForm ventana = new ErroresForm();
                        ventana.show("El rango etario ingresado ya existe");
                    }
                }
                LimpiarCampos();
            }
           
        }

        private void txtDescripcionRangoEtario_TextChanged(object sender, EventArgs e)
        {
            if(txtDescripcionRangoEtario.Text != "")
            {
                lblDescripcionRangoEtario.Visible = false;
            }
            else if(txtDescripcionRangoEtario.Text == "" && txtIdRangoEtario.Text == "")
            {
                btnModificarRango.Enabled = false;
                btnEliminarRangoEtario.Enabled = false;
            }
            else if (txtIdRangoEtario.Text == "" || txtDescripcionRangoEtario.Text == "")
            {
                btnEliminarRangoEtario.Enabled = false;
                btnModificarRango.Enabled = false;
            }
            else if(txtDescripcionRangoEtario.Text != "" && txtIdRangoEtario.Text != "")
            {
                btnEliminarRangoEtario.Enabled = true;
                btnModificarRango.Enabled = true;
            }

        }

        private void txtIdRangoEtario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            if (btnModificarRango.Enabled)
            {
                RangosEtarios rango = new RangosEtarios();
                rango.IdRangoEtario = int.Parse(txtIdRangoEtario.Text);
                rango.DescripcionRangoEtario = txtDescripcionRangoEtario.Text;
                bool resultado = RangoEtarioBD.ObtenerRangoEtario(rango).Rows.Count != 0;
                if (resultado)
                {
                    this.Dispose();
                }
                else
                {
                    SeguroModificar seguro = new SeguroModificar();
                    seguro.btnModificar.Text = "Aceptar";
                    seguro.lblMensaje.Text = "¿Está seguro que no desea guardar los cambios?";
                    if (seguro.ShowDialog() == DialogResult.OK)
                    {
                        this.Dispose();
                    }
                }

            }
            else
            {
                this.Dispose();
            }

        }

        private void txtIdRangoEtario_TextChanged(object sender, EventArgs e)
        {
            if (txtIdRangoEtario.Text == "" || txtDescripcionRangoEtario.Text == "")
            {
                btnEliminarRangoEtario.Enabled = false;
                btnModificarRango.Enabled = false;
            }
            else if(txtDescripcionRangoEtario.Text != "" && txtIdRangoEtario.Text != "")
            {
                btnEliminarRangoEtario.Enabled = true;
                btnModificarRango.Enabled = true;
            }
        }
    }
}
