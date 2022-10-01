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
    public partial class AltaAfiliado : Form
    {
        public AltaAfiliado()
        {
            InitializeComponent();
            ComboTipoDoc();
            ComboBarrio();
            ComboPlan();
        }

        private void btnCrearAfiliado_Click(object sender, EventArgs e)
        {
            var afiliado = new Afiliados();
            var valNombre = true;
            var valCalle = true;
            var valTel = true;
            var valPlan = true;
            var valDoc = true;
            var valSexo = true;

            if(txtApellido.Text == "" || txtNombre.Text == "")
            {
                valNombre = false;
                ErroresForm mensaje = new ErroresForm();
                mensaje.show("Ingrese nombre y apellido del afiliado");
            }

            else if(txtCalle.Text == "" || txtNroCalle.Text == "" || cmbBarrios.SelectedIndex == 0)
            {
                valCalle = false;
                ErroresForm mensaje = new ErroresForm();
                mensaje.show("Ingrese la dirección del afiliado");
            }

            else if(txtNroTel.Text == "")
            {
                valTel = false;
                ErroresForm mensaje = new ErroresForm();
                mensaje.show("Ingrese el número de teléfono del afiliado");
            }

            else if(cmbPlanes.SelectedIndex == 0)
            {
                valPlan = false;
                ErroresForm mensaje = new ErroresForm();
                mensaje.show("Seleccione el plan");
            }

            else if(cmbTipoDocumento.SelectedIndex == 0 || txtNroDoc.Text == "")
            {
                valDoc = false;
                ErroresForm mensaje = new ErroresForm();
                mensaje.show("Ingrese el tipo y el número de documento");
            }

            else if(btnFemenino.Checked == false && btnMasculino.Checked == false && btnOtro.Checked == false)
            {
                valSexo = false;
                ErroresForm mensaje = new ErroresForm();
                mensaje.show("Ingrese el sexo del afiliado");
            }

            if (valSexo == true && valPlan == true && valNombre == true && valDoc == true && valCalle == true && valTel == true)
            {
                afiliado.Apellido = txtApellido.Text;
                afiliado.Nombre = txtNombre.Text;
                afiliado.Calle = txtCalle.Text;
                afiliado.NroCalle = Convert.ToInt32(txtNroCalle.Text);
                afiliado.NumeroDocumento = int.Parse(txtNroDoc.Text);
                afiliado.NumeroTelefono = txtNroTel.Text;
                afiliado.IdBarrio = cmbBarrios.SelectedIndex;
                afiliado.IdPlan = cmbPlanes.SelectedIndex;
                if (btnFemenino.Checked == true)
                {
                    afiliado.IdSexo = 1;
                }
                if (btnMasculino.Checked == true)
                {
                    afiliado.IdSexo = 2;
                }
                if (btnOtro.Checked == true)
                {
                    afiliado.IdSexo = 3;
                }
                afiliado.IdTipoDocumento = cmbTipoDocumento.SelectedIndex;
                afiliado.FechaNacimiento = fechaNac.Value;
                afiliado.FechaInscripcion = fechaInscripcion.Value;

                var resultado = AfiliadosBD.insertarAfiliado(afiliado);

                if (!resultado)
                {
                    ErroresForm mensaje = new ErroresForm();
                    mensaje.show("Error al dar de alta el afiliado");
                }
                else
                {
                    CorrectoForm msj = new CorrectoForm();
                    msj.show("Afiliado dado de alta exitosamente");
                }
            }

        }
        private void ComboTipoDoc()
        {
            var tiposDoc = TiposDocBD.getTiposDoc();
            string defaultCmbItem = "Tipo de documento";
            cmbTipoDocumento.Items.Add(defaultCmbItem);
            cmbTipoDocumento.SelectedItem = defaultCmbItem;
            foreach (var tipoDocument in tiposDoc)
            {
                cmbTipoDocumento.Items.Add(tipoDocument.DescripcionTipoDocumento);
            }
        }
        private void ComboBarrio()
        {
            var barrios = BarriosBD.getBarrios();
            string defaultCmbItem = "Barrio";
            cmbBarrios.Items.Add(defaultCmbItem);
            cmbBarrios.SelectedItem = defaultCmbItem;
            foreach (var barrio in barrios)
            {
                cmbBarrios.Items.Add(barrio.NombreBarrio);
            }
        }
        private void ComboPlan()
        {
            var planes = PlanesBD.getPlanes();
            string defaultCmbItem = "Plan";
            cmbPlanes.Items.Add(defaultCmbItem);
            cmbPlanes.SelectedItem = defaultCmbItem;
            foreach (var plan in planes)
            {
                cmbPlanes.Items.Add(plan.NombrePlan);
            }
        }

        private void txtNroTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla no numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtNroCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla no numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtNroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla no numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void fechaInscripcion_ValueChanged(object sender, EventArgs e)
        {
            this.Text = fechaInscripcion.Value.ToString();
        }

        private void fechaInscripcioDropDown(object sender, EventArgs e)
        {
            fechaInscripcion.ValueChanged -= fechaInscripcion_ValueChanged;
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            fechaInscripcion.ValueChanged += fechaInscripcion_ValueChanged;
            fechaInscripcion_ValueChanged(sender, e);
        }
    }
}
