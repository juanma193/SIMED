using SIMED_V1.Entidades;
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
    public partial class ConsultaEnfermero : Form
    {
        PrincipalForm principalForm;
        public ConsultaEnfermero(PrincipalForm ventanaPrincipal)
        {
            InitializeComponent();
            principalForm = ventanaPrincipal;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            principalForm.Show();
            this.Dispose();
        }
        private void txtConsultaMatriculaEnfermero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla no numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtConsultaNombreEnfermero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla numerica
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtConsultaApellidoEnfermero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla numerica
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnBuscarEnfermero_Click(object sender, EventArgs e)
        {
            if (txtConsultaMatriculaEnfermero.Text == "" && txtConsultaNombreEnfermero.Text == "" && txtConsultaApellidoEnfermero.Text == "")
            {
                grdConsultaEnfermero.DataSource = EnfermeroBD.ObtenerEnfermeros();
                chkEnfermeros.Visible = false;
            }
            else
            {
                if (txtConsultaMatriculaEnfermero.Text == "")
                {
                    txtConsultaMatriculaEnfermero.Text = "-1";
                    grdConsultaEnfermero.DataSource = EnfermeroBD.ObtenerEnfermeros(int.Parse(txtConsultaMatriculaEnfermero.Text), txtConsultaNombreEnfermero.Text, txtConsultaApellidoEnfermero.Text);
                }
                else
                {
                    grdConsultaEnfermero.DataSource = EnfermeroBD.ObtenerEnfermeros(int.Parse(txtConsultaMatriculaEnfermero.Text), txtConsultaNombreEnfermero.Text, txtConsultaApellidoEnfermero.Text);
                }
                chkEnfermeros.Visible = true;
                chkEnfermeros.Checked = false;
            }

            LimpiarCampos();

        }

        public void LimpiarCampos()
        {
            txtConsultaMatriculaEnfermero.Text = "";
            txtConsultaNombreEnfermero.Text = "";
            txtConsultaApellidoEnfermero.Text = "";
        } 

        private void ConsultaEnfermero_Load(object sender, EventArgs e)
        {
            CargarGrillaConsultaEnfermero();
        }

        public void CargarGrillaConsultaEnfermero()
        {
            grdConsultaEnfermero.DataSource = EnfermeroBD.ObtenerEnfermeros();

        }

        private void grdConsultaEnfermero_CellDoubleClick(Object sender, DataGridViewCellEventArgs e)
        {
            ConsultaEnfermero consulta = this;
            DatosEnfermero ventana = new DatosEnfermero(consulta);
            //Es necesario poner la prop. Modifiers de los txt del form en Public!
            ventana.txtMatriculaEnfermeroDato.PlaceholderText = grdConsultaEnfermero.Rows[e.RowIndex].Cells[0].Value.ToString();
            ventana.txtNombreEnfermeroDato.PlaceholderText = grdConsultaEnfermero.Rows[e.RowIndex].Cells[1].Value.ToString();
            ventana.txtApellidoEnfermeroDato.PlaceholderText = grdConsultaEnfermero.Rows[e.RowIndex].Cells[2].Value.ToString();

            // Para los datos que no están en la gdr
            DataTable tabla = EnfermeroBD.ObtenerEnfermeroCompleto(int.Parse(grdConsultaEnfermero.Rows[e.RowIndex].Cells[0].Value.ToString()));

            ventana.txtTelefonoEnfermeroDato.PlaceholderText = tabla.Rows[0]["telefono"].ToString();
            ventana.txtCalleEnfermeroDato.PlaceholderText = tabla.Rows[0]["calle"].ToString();
            ventana.txtNumeroCalleEnfermeroDato.PlaceholderText = tabla.Rows[0]["nroCalle"].ToString();
            int sexo = int.Parse(tabla.Rows[0]["id_sexo"].ToString());
            if (sexo == 1) { ventana.rdFemeninoEnfermeroDato.Checked = true; }
            if (sexo == 2) { ventana.rdMasculinoEnfermeroDato.Checked = true; }
            if (sexo == 3) { ventana.rdOtroEnfermeroDato.Checked = true; }
            ventana.txtTipoDocEnfermeroDato.PlaceholderText = tabla.Rows[0]["descripcionTipoDocumento"].ToString();
            ventana.txtNumeroDocEnfermeroDato.PlaceholderText = tabla.Rows[0]["numeroDocumento"].ToString();
            ventana.txtCiudadEnfermeroDato.PlaceholderText = tabla.Rows[0]["descripcionCiudad"].ToString();
            ventana.txtEspecialidadEnfermeroDato.PlaceholderText = tabla.Rows[0]["descripcionEspecialidad"].ToString();
            ventana.txtBarrioEnfermeroDato.PlaceholderText = tabla.Rows[0]["nombre_barrio"].ToString();
            ventana.dtFechaNacimientoEnfermeroDato.Value = DateTime.Parse(tabla.Rows[0]["fechaNacimiento"].ToString());
            ventana.Show();
        }

        
        private void gdrConsultaEnfermero_CellClick(Object sender, DataGridViewCellEventArgs e) 
        {
            int indice = e.RowIndex;
            if (indice.Equals(-1))
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Seleccione una celda válida");
            }
            else
            {
                btnEliminarEnfermero.Enabled = true;
                btnModificarEnfermero.Enabled = true;
            }
        }

        private void btnEliminarEnfermero_Click(object sender, EventArgs e)
        {
            // NO VA ConsultaEnfermero ventanaCons = new ConsultaEnfermero();    
            DatosEnfermero ventana = new DatosEnfermero(this);
            ventana.lblDatosEnfermero.Text = "Eliminar enfermero";
            ventana.btnEliminarEnfermeroDato.Visible = true;
            ventana.btnEliminarEnfermeroDato.Enabled = true;
            //Es necesario poner la prop. Modifiers de los txt del form en Public!
            DataGridViewRow fila = grdConsultaEnfermero.CurrentRow;
            ventana.txtMatriculaEnfermeroDato.PlaceholderText = fila.Cells[0].Value.ToString();
            ventana.txtNombreEnfermeroDato.PlaceholderText = fila.Cells[1].Value.ToString();
            ventana.txtApellidoEnfermeroDato.PlaceholderText = fila.Cells[2].Value.ToString();
            // Para los datos que no están en la gdr
            DataTable tabla = EnfermeroBD.ObtenerEnfermeroCompleto(int.Parse(fila.Cells[0].Value.ToString()));

            ventana.txtTelefonoEnfermeroDato.PlaceholderText = tabla.Rows[0]["telefono"].ToString();
            ventana.txtCalleEnfermeroDato.PlaceholderText = tabla.Rows[0]["calle"].ToString();
            ventana.txtNumeroCalleEnfermeroDato.PlaceholderText = tabla.Rows[0]["nroCalle"].ToString();
            int sexo = int.Parse(tabla.Rows[0]["id_sexo"].ToString());
            if (sexo == 1) { ventana.rdFemeninoEnfermeroDato.Checked = true; }
            if (sexo == 2) { ventana.rdMasculinoEnfermeroDato.Checked = true; }
            if (sexo == 3) { ventana.rdOtroEnfermeroDato.Checked = true; }
            ventana.txtTipoDocEnfermeroDato.PlaceholderText = tabla.Rows[0]["descripcionTipoDocumento"].ToString();
            ventana.txtNumeroDocEnfermeroDato.PlaceholderText = tabla.Rows[0]["numeroDocumento"].ToString();
            ventana.txtCiudadEnfermeroDato.PlaceholderText = tabla.Rows[0]["descripcionCiudad"].ToString();
            ventana.txtEspecialidadEnfermeroDato.PlaceholderText = tabla.Rows[0]["descripcionEspecialidad"].ToString();
            ventana.txtBarrioEnfermeroDato.PlaceholderText = tabla.Rows[0]["nombre_barrio"].ToString();
            ventana.dtFechaNacimientoEnfermeroDato.Value = DateTime.Parse(tabla.Rows[0]["fechaNacimiento"].ToString());
            ventana.Show();

        }

        private void btnModificarEnfermero_Click(object sender, EventArgs e)
        {
            //NO VA ConsultaEnfermero ventanaCons = new ConsultaEnfermero();
            ModificarEnfermero ventana = new ModificarEnfermero(this);
            
            ventana.txtMatriculaEnfermero.Enabled = false;
            //Es necesario poner la prop. Modifiers de los txt del form en Public!
            DataGridViewRow fila = grdConsultaEnfermero.CurrentRow;
            ventana.txtMatriculaEnfermero.Text = fila.Cells[0].Value.ToString();
            ventana.txtNombreEnfermero.Text = fila.Cells[1].Value.ToString();
            ventana.txtApellidoEnfermero.Text = fila.Cells[2].Value.ToString();
            // Para los datos que no están en la gdr
            DataTable tabla = EnfermeroBD.ObtenerEnfermeroCompleto(int.Parse(fila.Cells[0].Value.ToString()));

            ventana.txtTelefonoEnfermero.Text = tabla.Rows[0]["telefono"].ToString();
            ventana.txtCalleEnfermero.Text = tabla.Rows[0]["calle"].ToString();
            ventana.txtNumeroCalleEnfermero.Text = tabla.Rows[0]["nroCalle"].ToString();
            int sexo = int.Parse(tabla.Rows[0]["id_sexo"].ToString());
            if (sexo == 1) { ventana.rdFemeninoEnfermero.Checked = true; }
            if (sexo == 2) { ventana.rdMasculinoEnfermero.Checked = true; }
            if (sexo == 3) { ventana.rdOtroEnfermero.Checked = true; }
            ventana.cmbTipoDocEnfermero.Text = tabla.Rows[0]["descripcionTipoDocumento"].ToString();
            ventana.txtNumeroDocEnfermero.Text = tabla.Rows[0]["numeroDocumento"].ToString();
            ventana.cmbCiudadesEnfermero.Text = tabla.Rows[0]["descripcionCiudad"].ToString();
            ventana.cmbEspecialidadEnfermero.Text = tabla.Rows[0]["descripcionEspecialidad"].ToString();
            ventana.cmbBarrioEnfermero.Text = tabla.Rows[0]["nombre_barrio"].ToString();
            ventana.dtFechaNacimientoEnfermero.Value = DateTime.Parse(tabla.Rows[0]["fechaNacimiento"].ToString());
            ventana.Show();

        }

        private void chkEnfermeros_CheckedChanged(Object sender, EventArgs e)
        {
            if (chkEnfermeros.Checked)
            {
                grdConsultaEnfermero.DataSource = EnfermeroBD.ObtenerEnfermeros();
                chkEnfermeros.Visible = false;
            }
            
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            // Hace lo mismo que volver
            principalForm.Show();
            this.Dispose();
        }
    }
}
