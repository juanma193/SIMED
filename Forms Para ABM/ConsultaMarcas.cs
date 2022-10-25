using Microsoft.Data.SqlClient;
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
    public partial class ConsultaMarcas : Form
    {
        public ConsultaMarcas()
        {
            InitializeComponent();
        }

        private void ConsultaMarcas_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla();
            btnActualizarMarca.Enabled = false;
            btnEliminarMarca.Enabled = false;
            lblNroIdMarca.Enabled = false;
            lblIdMarca.Visible = false;
        }

        private void LimpiarCampos()
        {
            txtNombreMarca.Text = "";
        }

        private void CargarGrilla()
        {
            try
            {
                gdrMarcas.DataSource = ModelosMarcasRLBD.ObtenerListadoMarcas();
            }
            catch (Exception)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error al cargar grilla");
            }
        }

        private void CargarGrilla(string nombreMarca)
        {
            try
            {
                gdrMarcas.DataSource = ModelosMarcasRLBD.ObtenerListadoMarcas(nombreMarca);
            }
            catch (Exception)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error al cargar grilla");
            }
        }

        private void btnBuscarMarca_Click(object sender, EventArgs e)
        {
            if (!txtNombreMarca.Text.Equals(""))
            {
                CargarGrilla(txtNombreMarca.Text);
            }
            else
            {
                CargarGrilla();
            }
        }

        private Marcas ObtenerDatosMarca()
        {
            Marcas m = new Marcas();
            m.NombreMarca = txtNombreMarca.Text;
            m.IdMarca = int.Parse(lblIdMarca.Text.ToString());

            return m;
        }

        private void btnActualizarMarca_Click(object sender, EventArgs e)
        {
            if(txtNombreMarca.Text.Equals(""))
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Ingrese marca de modelo");
            }
            else
            {
                Marcas m = ObtenerDatosMarca();
                bool rdo = ModelosMarcasRLBD.MarcaYaExiste(m);
                if(!rdo)
                {
                    bool resultado = ModelosMarcasRLBD.ActualizarMarca(m);
                    if (resultado)
                    {
                        CorrectoForm cf = new CorrectoForm();
                        cf.show("Marca actualizada con éxito");
                        LimpiarCampos();
                        CargarGrilla();
                    }
                    else
                    {
                        ErroresForm ventana = new ErroresForm();
                        ventana.show("Error al actualizar marca");
                    }
                }
                else
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Marca ya existe");
                }
            }
        }

        private void CargarCampos(Marcas m)
        {
            LimpiarCampos();
            txtNombreMarca.Text = m.NombreMarca;
        }

        private void gdrMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice.Equals(-1))
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Seleccione una celda válida");
            }
            else
            {
                btnActualizarMarca.Enabled = true;
                btnEliminarMarca.Enabled = true;
                DataGridViewRow fila = gdrMarcas.Rows[indice];
                string nombreMarca = fila.Cells["nombreMarca"].Value.ToString();
                Marcas m = ModelosMarcasRLBD.ObtenerMarca(nombreMarca);
                lblIdMarca.Text = m.IdMarca.ToString();
                lblIdMarca.Visible = true;
                lblNroIdMarca.Enabled = true;
                LimpiarCampos();
                CargarCampos(m);
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            UModelosMarcas ventana = new UModelosMarcas();
            ventana.Show();
            this.Dispose();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            SeguroModificar window = new SeguroModificar();
            if (window.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    Marcas m = ObtenerDatosMarca();
                    bool resultado = ModelosMarcasRLBD.EliminarMarca(m);
                    if (resultado)
                    {
                        LimpiarCampos();
                        CargarGrilla();
                        CorrectoForm cor = new CorrectoForm();
                        cor.show("Marca eliminada con éxito");
                    }
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("No puede eliminar una marca relacionada con algún modelo\nPorfavor elimine los modelos asociados primero");
                }
            }
        }

        private void txtNombreMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (Keys)e.KeyChar != Keys.Back && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            UModelosMarcas nue = new UModelosMarcas();
            nue.Show();
            this.Dispose();
        }
    }
}
