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
    public partial class ConsultaModelos : Form
    {
        private static bool bandera = false;
        public ConsultaModelos()
        {
            InitializeComponent();
        }

        private void ConsultaModelos_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla();
            CargarComboMarcas();
            btnActualizarModelo.Enabled = false;
            btnEliminarModelo.Enabled = false;
            lblNroIdModelo.Enabled = false;
            lblIdModelo.Visible = false;
            lblNombreModelo.Visible = false;

        }

        private void CargarGrilla()
        {
            try
            {
                gdrModelos.DataSource = ModelosMarcasBD.ObtenerListadoModelos();
            }
            catch (Exception)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error al cargar grilla");
            }
        }

        private void CargarGrilla(string nombreModelo)
        {
            try
            {
                gdrModelos.DataSource = ModelosMarcasBD.ObtenerListadoModelos(nombreModelo);
            }
            catch (Exception)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error al cargar grilla");
            }
        }

        private void CargarGrilla(int idMarca)
        {
            try
            {
                gdrModelos.DataSource = ModelosMarcasBD.ObtenerListadoModelos(idMarca);
            }
            catch (Exception)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error al cargar grilla");
            }
        }

        private void CargarGrilla(string nombreModelo, int idMarca)
        {
            try
            {
                gdrModelos.DataSource = ModelosMarcasBD.ObtenerListadoModelos(nombreModelo, idMarca);
            }
            catch (Exception)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error al cargar grilla");
            }
        }

        private void gdrModelos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizarModelo.Enabled = true;
            btnEliminarModelo.Enabled = true;
            int indice = e.RowIndex;
            DataGridViewRow fila = gdrModelos.Rows[indice];
            string nombreModelo = fila.Cells["nombreModelo"].Value.ToString();
            Modelos m = ModelosMarcasBD.ObtenerModelo(nombreModelo);
            lblIdModelo.Text = m.IdModelo.ToString();
            lblIdModelo.Visible = true;
            lblNroIdModelo.Enabled = true;
            LimpiarCampos();
            CargarCampos(m);
        }

        private bool ValidarCampos()
        {
            bool resultado = false;
            //VALIDACIONES
            if (txtNombreModelo.Text.Equals("") || cmbMarcaModelo.SelectedIndex == -1)
            {
                //No hay nombre ni marca
                if (txtNombreModelo.Text.Equals("") && cmbMarcaModelo.SelectedIndex == -1)
                {
                    string error = "Campos incompletos";
                    string errorAdicional = "Ingrese nombre de modelo \n" + "Ingrese marca de modelo";
                    MultiplesErrores ventana = new MultiplesErrores(error, errorAdicional);
                    ventana.Show();
                }
                //No hay nombre
                else if (txtNombreModelo.Text.Equals("") && cmbMarcaModelo.SelectedIndex != -1)
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Ingrese nombre de modelo");
                }
                //No hay marca
                else if (!txtNombreModelo.Text.Equals("") && cmbMarcaModelo.SelectedIndex == -1)
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Ingrese marca de modelo");
                }
            }
            else
            {
                resultado = true;
            }
            return resultado;
        }

        private void btnActualizarModelo_Click(object sender, EventArgs e)
        {
            bool r = ValidarCampos();
            if (r)
            {
                Modelos m = ObtenerDatosModelo();
                bool resultado = ModelosMarcasBD.ActualizarModelo(m);
                if (resultado)
                {
                    CorrectoForm cf = new CorrectoForm();
                    cf.show("Modelo actualizado con éxito");
                    LimpiarCampos();
                    CargarGrilla();
                    CargarComboMarcas();
                }
                else
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Error al actualizar");
                }
            }
        }

        private void CargarCampos(Modelos m)
        {
            LimpiarCampos();
            CargarComboMarcas();
            txtNombreModelo.Text = m.NombreModelo;
            cmbMarcaModelo.SelectedValue = m.IdMarca;
        }

        private void LimpiarCampos()
        {
            bandera = true;
            txtNombreModelo.Text = "";
            cmbMarcaModelo.SelectedIndex = -1;
            bandera = false;
        }

        private void CargarComboMarcas()
        {
            try
            {
                cmbMarcaModelo.DataSource = ModelosMarcasBD.ObtenerMarcas();
                cmbMarcaModelo.DisplayMember = "nombre_marca";
                cmbMarcaModelo.ValueMember = "id_marca";
                cmbMarcaModelo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error al cargar marcas");
            }
        }
        
        private Modelos ObtenerDatosModelo()
        {
            Modelos m = new Modelos();
            m.NombreModelo = txtNombreModelo.Text;
            m.IdMarca = (int)cmbMarcaModelo.SelectedValue;
            m.IdModelo = int.Parse(lblIdModelo.Text.ToString());

            return m;
        }

        private void btnBuscarModelo_Click(object sender, EventArgs e)
        {
            Modelos m = new Modelos();
            if (!txtNombreModelo.Text.Equals("") && cmbMarcaModelo.SelectedIndex == -1)
            {
                m.NombreModelo = txtNombreModelo.Text;
                CargarGrilla(m.NombreModelo);
            }
            else if (txtNombreModelo.Text.Equals("") && cmbMarcaModelo.SelectedIndex != -1)
            {
                m.IdMarca = (int)cmbMarcaModelo.SelectedValue;
                CargarGrilla(m.IdMarca);
            }
            else if (!txtNombreModelo.Text.Equals("") && cmbMarcaModelo.SelectedIndex != -1)
            {
                m.NombreModelo = txtNombreModelo.Text;
                m.IdMarca = (int)cmbMarcaModelo.SelectedValue;
                CargarGrilla(m.NombreModelo, m.IdMarca);
            }
            else
            {
                CargarGrilla();
            }
        }

        private void btnEliminarModelo_Click(object sender, EventArgs e)
        {
            var ConfirmResult = MessageBox.Show("Desea eliminar", "Confirmar borrado", MessageBoxButtons.YesNo);
            if (ConfirmResult == DialogResult.Yes)
            {
                
                try
                {
                    Modelos m = ObtenerDatosModelo();
                    bool resultado = ModelosMarcasBD.EliminarModelo(m);
                    if (resultado)
                    {
                        LimpiarCampos();
                        CargarGrilla();
                    }
                }
                catch (Exception)
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Error al eliminar persona");
                }
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            UModelosMarcas ventana = new UModelosMarcas();
            ventana.Show();
            this.Dispose();
        }

        private void txtNombreModelo_TextChanged(object sender, EventArgs e)
        {
            if(!bandera)
            {
                if (txtNombreModelo.Text.Equals(""))
                {
                    lblNombreModelo.Visible = true;
                    lblNombreModelo.Text = "Nombre de modelo obligatorio";
                }
                else
                {
                    lblNombreModelo.Visible = false;
                }
            }
        }
    }
}
