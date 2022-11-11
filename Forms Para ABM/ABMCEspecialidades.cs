using SIMED_V1.Entidades;
using SIMED_V1.Bases_de_datos;
using SIMED_V1.Forms_Mensajes_Personalizados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMED_V1.Forms_Para_ABM
{
    public partial class ABMCEspecialidades : Form
    {

        public ABMCEspecialidades()
        {
            InitializeComponent();
            lblDescripcionEspecialidad.Visible = false;

        }

        private void btnCrearEspecialidad_Click(object sender, EventArgs e)
        {
            btnModificarEspecialidad.Enabled = false;
            btnEliminarEspecialidad.Enabled = false;
            bool valDes = true;
            try
            {
                Especialidades especialidad = new Especialidades();
                
                if (txtDescripcionEspecialidad.Text == "")
                {
                    lblDescripcionEspecialidad.Visible = true;
                    valDes = false;
                    ErroresForm mensaje = new ErroresForm();
                    mensaje.show("Ingrese la descripción de la especialidad.");
                }

                if (txtIdEspecialidad.Text != "")
                {
                    ErroresForm mensaje = new ErroresForm();
                    mensaje.show("No es necesario ingresar id de especialidad para su creación");
                }
                if (valDes)
                {
                    especialidad.DescripcionEspecialidad = txtDescripcionEspecialidad.Text;

                    bool resultado = EspecialidadBD.InsertarEspecialidad(especialidad);

                    if (resultado)
                    {
                        CorrectoForm window = new CorrectoForm();
                        window.show("Se ha creado la especialidad con éxito.");
                        lblDescripcionEspecialidad.Visible = false;
                        LimpiarCampos();
                        CargarGrillaEspecialidades();
                    }
                    else 
                    {
                        ErroresForm window = new ErroresForm();
                        window.show("La especialidad ya existe.");
                        LimpiarCampos();
                    }

                }
            }
            catch (Exception ex)
            {
                ErroresForm window = new ErroresForm();
                window.show("Error" + " " + ex);
            }
        }

        private void ABMCEspecialidades_Load(object sender, EventArgs e)
        {
            CargarGrillaEspecialidades();
        }

        public void CargarGrillaEspecialidades()
        {
            grdEspecialidades.DataSource = EspecialidadBD.ObtenerEspecialidades();

        }

        private void btnBuscarEspecialidad_Click(object sender, EventArgs e)
        {
                btnEliminarEspecialidad.Enabled = false;
                btnModificarEspecialidad.Enabled = false;
                lblDescripcionEspecialidad.Visible = false;
                // Si busca sin ingresar nada, se refresca la grilla mostrando todas las especialidades.
                if (txtDescripcionEspecialidad.Text == "" && txtIdEspecialidad.Text == "")
                {
                    CargarGrillaEspecialidades();
                    chkEspecialidades.Visible = false;
                    lblDescripcionEspecialidad.Visible = false;
                }
                else
                {
                    //Busca sólo por descripción
                    if (txtIdEspecialidad.Text == "" && txtDescripcionEspecialidad.Text != "")
                    {
                        grdEspecialidades.DataSource = EspecialidadBD.ObtenerEspecialidades(txtDescripcionEspecialidad.Text);
                    }
                    // Busca sólo por id
                    else if (txtIdEspecialidad.Text != "" && txtDescripcionEspecialidad.Text == "")
                    {
                        grdEspecialidades.DataSource = EspecialidadBD.ObtenerEspecialidades(int.Parse(txtIdEspecialidad.Text));
                    }
                    // Busca por id y descripción
                    else
                    {
                        Especialidades esp = new Especialidades();
                        esp.IdEspecialidad = int.Parse(txtIdEspecialidad.Text);
                        esp.DescripcionEspecialidad = txtDescripcionEspecialidad.Text;
                        grdEspecialidades.DataSource = EspecialidadBD.ObtenerEspecialidades(esp);
                    }
                    chkEspecialidades.Visible = true;
                    chkEspecialidades.Checked = false;
                }

                LimpiarCampos();

            

        }

        
        private void LimpiarCampos()
        {
            txtIdEspecialidad.Text = "";
            txtDescripcionEspecialidad.Text = "";
        }

        private void chkEspecialidades_CheckedChanged(Object sender, EventArgs e)
        {
            btnModificarEspecialidad.Enabled = false;
            btnEliminarEspecialidad.Enabled = false;
            
            if (chkEspecialidades.Checked)
            {
                grdEspecialidades.DataSource = EspecialidadBD.ObtenerEspecialidades();
                chkEspecialidades.Visible = false;

            }
            LimpiarCampos();

        }
        private void gdrEspecialidad_CellClick(Object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice.Equals(-1))
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Seleccione una celda válida");
            }
            else
            {
                btnEliminarEspecialidad.Enabled = true;
                btnModificarEspecialidad.Enabled = true;
                DataGridViewRow fila = grdEspecialidades.CurrentRow;
                txtIdEspecialidad.Text = fila.Cells[0].Value.ToString();
                txtDescripcionEspecialidad.Text = fila.Cells[1].Value.ToString();

            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (btnModificarEspecialidad.Enabled)
            {
                Especialidades esp = new Especialidades();
                if(txtIdEspecialidad.Text != "")
                {
                    esp.IdEspecialidad = int.Parse(txtIdEspecialidad.Text);
                    esp.DescripcionEspecialidad = txtDescripcionEspecialidad.Text;
                    bool resultado = EspecialidadBD.ObtenerEspecialidades(esp).Rows.Count != 0;
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
            else
            {
                this.Dispose();
            }


        }

        private void btnModificarEspecialidad_Click(object sender, EventArgs e)
        {
            SeguroModificar seguro = new SeguroModificar();
            seguro.lblMensaje.Text = "¿Está seguro que desea modificar este registro?";
            if (seguro.ShowDialog() == DialogResult.OK) 
            {
                btnModificarEspecialidad.Enabled = false;
                btnEliminarEspecialidad.Enabled = false;
                DataGridViewRow fila = grdEspecialidades.CurrentRow;
                Especialidades esp = new Especialidades();
                esp.IdEspecialidad = int.Parse(txtIdEspecialidad.Text);

                if (txtDescripcionEspecialidad.Text == "")
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Descripción de especialidad obligatoria.");
                    LimpiarCampos();
                }
                else
                {
                    esp.IdEspecialidad = int.Parse(txtIdEspecialidad.Text);
                    esp.DescripcionEspecialidad = txtDescripcionEspecialidad.Text;
                    bool res = EspecialidadBD.ModificarEspecialidad(esp);
                    if (res)
                    {
                        CorrectoForm ventana = new CorrectoForm();
                        ventana.show("Se modificó la especialidad.");
                        LimpiarCampos();
                        CargarGrillaEspecialidades();
                    }
                    else
                    {
                        ErroresForm ventana = new ErroresForm();
                        ventana.show("La especialidad ya existe.");
                    }
                }
                LimpiarCampos();
            }            
        }

        private void btnEliminarEspecialidad_Click(object sender, EventArgs e)
        {

            SeguroEliminar seguro = new SeguroEliminar();
            seguro.lblMensaje.Text = "¿Está seguro que desea eliminar este registro?";
            if (seguro.ShowDialog() == DialogResult.OK)
            {
                btnModificarEspecialidad.Enabled = false;
                btnEliminarEspecialidad.Enabled = false;
                bool res = false;
                // Si selecciona la coluna pero borra todo
                if (txtDescripcionEspecialidad.Text == "" && txtIdEspecialidad.Text == "")
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("No hay una especialidad para eliminar.");
                }
                else
                {
                    //Elimina sólo con descipción
                    if (txtIdEspecialidad.Text == "" && txtDescripcionEspecialidad.Text != "")
                    {
                        res = EspecialidadBD.EliminarEspecialidad(txtDescripcionEspecialidad.Text);
                    }
                    // Elimina sólo por id
                    else if (txtIdEspecialidad.Text != "" && txtDescripcionEspecialidad.Text == "")
                    {
                        res = EspecialidadBD.EliminarEspecialidad(int.Parse(txtIdEspecialidad.Text));
                    }
                    // Elimina por id y descripción
                    else
                    {
                        Especialidades esp = new Especialidades();
                        esp.IdEspecialidad = int.Parse(txtIdEspecialidad.Text);
                        esp.DescripcionEspecialidad = txtDescripcionEspecialidad.Text;
                        res = EspecialidadBD.EliminarEspecialidad(esp);
                    }
                    chkEspecialidades.Visible = true;
                    chkEspecialidades.Checked = false;
                }
            LimpiarCampos();

            if (res)
            {
                CorrectoForm ventana = new CorrectoForm();
                ventana.show("Se eliminó la especialidad.");
                LimpiarCampos();
                CargarGrillaEspecialidades();
            }
            else
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("No existe la especialidad especificada.");
            }

            }
        }

        private void txtDescripcionEspecialidad_TextChanged(object sender, EventArgs e)
        {
            if (txtDescripcionEspecialidad.Text != "")
            {
                lblDescripcionEspecialidad.Visible = false;
            }
            else if (txtDescripcionEspecialidad.Text == "" && txtIdEspecialidad.Text == "")
            {
                btnModificarEspecialidad.Enabled = false;
                btnEliminarEspecialidad.Enabled = false;
            }

        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            if (btnModificarEspecialidad.Enabled)
            {
                Especialidades esp = new Especialidades();
                if(txtIdEspecialidad.Text != "")
                {
                    esp.IdEspecialidad = int.Parse(txtIdEspecialidad.Text);
                    esp.DescripcionEspecialidad = txtDescripcionEspecialidad.Text;
                    bool resultado = EspecialidadBD.ObtenerEspecialidades(esp).Rows.Count != 0;
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
            else
            {
                this.Dispose();
            }
        }


        private void txtIdEspecialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla no numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDescripcionEspecialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla numerica
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
    
}
