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
    public partial class ConsultarAfiliado : Form
    {
        int indice = -1;
        public ConsultarAfiliado()
        {
            InitializeComponent();
        }

        private void ConsultarAfiliado_Load(object sender, EventArgs e)
        {
            cargarTodo();
        }

        private void todoVacio()
        {
            if (txtNombre.Text == "" && txtApellido.Text == "" && txtNroAfiliado.Text == "")
            {
                cargarTodo();
            }


        }

        private void cargarTodo()
        {
            gbAfiliados.Rows.Clear();

            var afiliados = AfiliadosBD.getAfiliadosInicio();


            foreach (var afiliado in afiliados)
            {
                AgregarAfiliado(afiliado);
            }

        }

        private void btnModAfiliado_Click(object sender, EventArgs e)
        {

            if (indice >= 0)
            {
                SeguroModificar window = new SeguroModificar();
                if (window.ShowDialog() == DialogResult.OK)
                {
                    DataGridViewRow filaSeleccionada = gbAfiliados.Rows[indice];
                    int documento = int.Parse(filaSeleccionada.Cells["Documento"].Value.ToString());
                    Afiliados afil = AfiliadosBD.obtenerAfiliado(documento);
                    ConsultarAfiliado consu = this;
                    ModificarAfiliado ventana = new ModificarAfiliado(afil, consu);
                    ventana.Show();
                    this.Hide();
                }
            }
            else
            {
                ErroresForm mensaje = new ErroresForm();
                mensaje.show("Seleccione un afiliado");
            }
            



        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gbAfiliados.Rows.Clear();
            var nroAfiliado = 0;
            if (txtNroAfiliado.Text != "" && txtNroAfiliado.Text != null)
            {
                nroAfiliado = int.Parse(txtNroAfiliado.Text);
            }
            var afiliados = AfiliadosBD.getAfiliados(nroAfiliado, txtNombre.Text, txtApellido.Text);
            foreach (var afiliado in afiliados)
            {
                AgregarAfiliado(afiliado);
            }
        }
        private void AgregarAfiliado(Afiliados afiliado)
        {
            DataGridViewRow fila = new DataGridViewRow();

            DataGridViewTextBoxCell celdaDocumento = new DataGridViewTextBoxCell();
            celdaDocumento.Value = afiliado.NumeroDocumento;
            fila.Cells.Add(celdaDocumento);

            DataGridViewTextBoxCell celdaApellido = new DataGridViewTextBoxCell();
            celdaApellido.Value = afiliado.Apellido;
            fila.Cells.Add(celdaApellido);

            DataGridViewTextBoxCell celdaNombre = new DataGridViewTextBoxCell();
            celdaNombre.Value = afiliado.Nombre;
            fila.Cells.Add(celdaNombre);

            gbAfiliados.Rows.Add(fila);
        }

        private void gbAfiliados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }

        private void btnElimAfiliado_Click(object sender, EventArgs e)
        {

            if (indice >= 0)
            {
                SeguroEliminar seguro = new SeguroEliminar();
                seguro.lblMensaje.Text = "¿Está seguro que desea eliminar el afiliado seleccionado?";

                if (seguro.ShowDialog() == DialogResult.OK)
                {
                    DataGridViewRow filaSeleccionada = gbAfiliados.Rows[indice];
                    int documento = int.Parse(filaSeleccionada.Cells["Documento"].Value.ToString());
                    bool resultado = AfiliadosBD.eliminarAfiliado(documento);

                    if (!resultado)
                    {
                        ErroresForm mensaje = new ErroresForm();
                        mensaje.show("Error al eliminar el afiliado");
                    }
                    CorrectoForm msj = new CorrectoForm();
                    msj.show("Afiliado eliminado exitosamente");
                }
            }
            else
            {
                ErroresForm mensaje = new ErroresForm();
                mensaje.show("Seleccione un afiliado");
            }
        }

        private void gbAfiliados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNroAfiliado_TextChanged(object sender, EventArgs e)
        {
            if (txtNroAfiliado.Text == "")
            {
                todoVacio();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                todoVacio();
            }

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                todoVacio();
            }

        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroAfiliado.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            todoVacio();
        }

        private void txtNroAfiliado_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) e.Handled = false;
            else
            {
                if (e.KeyChar == '\b') e.Handled = false; //Tecla de borrado
                else
                {
                    if ((e.KeyChar == '-' || e.KeyChar == '.' || e.KeyChar == '_' || e.KeyChar == ',' || e.KeyChar == ';') || Char.IsDigit(e.KeyChar)) e.Handled = true;
                    else if (!char.IsSeparator(e.KeyChar)) e.Handled = true;
                }
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) e.Handled = false;
            else
            {
                if (e.KeyChar == '\b') e.Handled = false; //Tecla de borrado
                else
                {
                    if ((e.KeyChar == '-' || e.KeyChar == '.' || e.KeyChar == '_' || e.KeyChar == ',' || e.KeyChar == ';') || Char.IsDigit(e.KeyChar)) e.Handled = true;
                    else if (!char.IsSeparator(e.KeyChar)) e.Handled = true;
                }
            }
        }
    }
}
