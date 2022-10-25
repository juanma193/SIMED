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
    public partial class AbmTipoViaje : Form
    {
        int indice = -1;
        public AbmTipoViaje()
        {
            InitializeComponent();
            gbViajes.Rows.Clear();
            var afiliados = TiposViajesBD.getTiposViaje();
            foreach (var afiliado in afiliados)
            {
                AgregarViaje(afiliado);
            }
        }

        private void ConsultarAfiliado_Load(object sender, EventArgs e)
        {

        }

        private void btnModAfiliado_Click(object sender, EventArgs e)
        {
            if (indice >= 0)
            {
                DataGridViewRow filaSeleccionada = gbViajes.Rows[indice];
                int id = int.Parse(filaSeleccionada.Cells["Id"].Value.ToString());
                TiposViaje tipoViaje = TiposViajesBD.obtenerTipoViaje(id);
                if (txtDescripcion.Text != "")
                {
                    SeguroModificar window = new SeguroModificar();
                    if (window.ShowDialog() == DialogResult.OK)
                    {
                        tipoViaje.DescripcionTipoViaje = txtDescripcion.Text;
                        var resultado = TiposViajesBD.modificarViaje(tipoViaje);

                        if (!resultado)
                        {
                            ErroresForm mensaje = new ErroresForm();
                            mensaje.show("Error al modificar el tipo de viaje");
                        }
                        else
                        {
                            CorrectoForm msj = new CorrectoForm();
                            msj.show("Tipo de viaje modificado exitosamente");
                            gbViajes.Rows.Clear();
                            var afiliados = TiposViajesBD.getTiposViaje();
                            foreach (var afiliado in afiliados)
                            {
                                AgregarViaje(afiliado);
                            }
                            txtDescripcion.Text = "";
                        }
                    }

                }
                else
                {
                    ErroresForm mensaje = new ErroresForm();
                    mensaje.show("La descripción del tipo de viaje no puede estar vacia");
                }
            }
            else
            {
                ErroresForm mensaje = new ErroresForm();
                mensaje.show("Seleccione un tipo de viaje");
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gbViajes.Rows.Clear();
            if (txtDescripcion.Text == "")
            {
                var afiliados = TiposViajesBD.getTiposViaje();
                foreach (var afiliado in afiliados)
                {
                    AgregarViaje(afiliado);
                }
            }
            else
            {
                var tipoViaje = TiposViajesBD.getTipoViajeByDesc(txtDescripcion.Text);
                if(tipoViaje.DescripcionTipoViaje != null)
                { 
                    AgregarViaje(tipoViaje);
                }
            }
        }
        private void AgregarViaje(TiposViaje viaje)
        {
            DataGridViewRow fila = new DataGridViewRow();

            DataGridViewTextBoxCell celdaId = new DataGridViewTextBoxCell();
            celdaId.Value = viaje.IdTipoViaje;
            fila.Cells.Add(celdaId);

            DataGridViewTextBoxCell celdaDescripcion = new DataGridViewTextBoxCell();
            celdaDescripcion.Value = viaje.DescripcionTipoViaje;
            fila.Cells.Add(celdaDescripcion);

            gbViajes.Rows.Add(fila);
        }

        private void gbAfiliados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice.Equals(-1))
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Seleccione una celda válida");
            }
            else
            {
                DataGridViewRow fila = gbViajes.Rows[indice];
                string descripcionViaje = fila.Cells["tiposViajes"].Value.ToString();
                txtDescripcion.Text = descripcionViaje;
            }
        }

        private void btnElimAfiliado_Click(object sender, EventArgs e)
        {
            if (indice >= 0)
            {
                SeguroEliminar window = new SeguroEliminar();
                if (window.ShowDialog() == DialogResult.OK)
                {
                    DataGridViewRow filaSeleccionada = gbViajes.Rows[indice];
                    int id = int.Parse(filaSeleccionada.Cells["Id"].Value.ToString());
                    bool resultado = TiposViajesBD.eliminarTipoViaje(id);

                    if (!resultado)
                    {
                        ErroresForm mensaje = new ErroresForm();
                        mensaje.show("Error al eliminar el tipo de viaje");
                    }
                    CorrectoForm msj = new CorrectoForm();
                    msj.show("Tipo de viaje eliminado exitosamente");

                    gbViajes.Rows.Clear();
                    var afiliados = TiposViajesBD.getTiposViaje();
                    foreach (var afiliado in afiliados)
                    {
                        AgregarViaje(afiliado);
                    }
                    txtDescripcion.Text = "";
                }
            }
            else
            {
                ErroresForm mensaje = new ErroresForm();
                mensaje.show("Seleccione un tipo de viaje");
            }
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            TiposViaje tipoViaje = new TiposViaje();
            tipoViaje.DescripcionTipoViaje = txtDescripcion.Text;

            if (txtDescripcion.Text != "")
            {

                var resultado = TiposViajesBD.insertarViaje(tipoViaje);

                if (!resultado)
                {
                    ErroresForm mensaje = new ErroresForm();
                    mensaje.show("Error al modificar el tipo de viaje");
                }
                else
                {
                    CorrectoForm msj = new CorrectoForm();
                    msj.show("Tipo de viaje modificado exitosamente");
                    gbViajes.Rows.Clear();
                    var afiliados = TiposViajesBD.getTiposViaje();
                    foreach (var afiliado in afiliados)
                    {
                        AgregarViaje(afiliado);
                    }
                    txtDescripcion.Text = "";
                }

            }
            else
            {
                ErroresForm mensaje = new ErroresForm();
                mensaje.show("La descripción del tipo de viaje no puede estar vacia");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
