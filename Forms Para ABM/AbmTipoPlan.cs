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
    public partial class AbmTipoPlan : Form
    {
        int indice = -1;
        public AbmTipoPlan()
        {
            InitializeComponent();
        }

        private void ConsultarAfiliado_Load(object sender, EventArgs e)
        {

        }

        private void btnModAfiliado_Click(object sender, EventArgs e)
        {
            if (indice >= 0)
            {
                DataGridViewRow filaSeleccionada = gbAfiliados.Rows[indice];
                int documento = int.Parse(filaSeleccionada.Cells["Documento"].Value.ToString());
                Afiliados afil = AfiliadosBD.obtenerAfiliado(documento);

                ModificarAfiliado ventana = new ModificarAfiliado(afil);
                ventana.Show();
                this.Hide();
            }
            else
            {
                ErroresForm mensaje = new ErroresForm();
                mensaje.show("Seleccione un usuario");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gbAfiliados.Rows.Clear();
            var nroAfiliado = 0;
            if(txtNroAfiliado.Text != "" && txtNroAfiliado.Text != null)
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
            else
            {
                ErroresForm mensaje = new ErroresForm();
                mensaje.show("Seleccione un afiliado");
            }
        }
    }
}
