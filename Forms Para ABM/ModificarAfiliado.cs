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
    public partial class ModificarAfiliado : Form
    {
       
        public ModificarAfiliado(Afiliados afiliado)
        {
            InitializeComponent();
            ComboTipoDoc();
            ComboBarrio();
            ComboPlan();
            if(afiliado.NumeroDocumento != null)
            {
                ModAfiliado(afiliado);
            }
        }

        private void btnModificarAfiliado_Click(object sender, EventArgs e)
        {
            var afiliado = new Afiliados();
            var resultado = new bool();
            var valNombre = true;
            var valCalle = true;
            var valTel = true;
            var valPlan = true;
            var valSexo = true;

            if (txtApellido.Text == "" || txtNombre.Text == "")
            {
                valNombre = false;
                ErroresForm mensaje = new ErroresForm();
                mensaje.show("Ingrese nombre y apellido del afiliado");
            }

            else if (txtCalle.Text == "" || txtNroCalle.Text == "" || cmbBarrios.SelectedIndex == 0)
            {
                valCalle = false;
                ErroresForm mensaje = new ErroresForm();
                mensaje.show("Ingrese la dirección del afiliado");
            }

            else if (txtNroTel.Text == "")
            {
                valTel = false;
                ErroresForm mensaje = new ErroresForm();
                mensaje.show("Ingrese el número de teléfono del afiliado");
            }

            else if (cmbPlanes.SelectedIndex == 0)
            {
                valPlan = false;
                ErroresForm mensaje = new ErroresForm();
                mensaje.show("Seleccione el plan");
            }

            else if (btnFemenino.Checked == false && btnMasculino.Checked == false && btnOtro.Checked == false)
            {
                valSexo = false;
                ErroresForm mensaje = new ErroresForm();
                mensaje.show("Ingrese el sexo del afiliado");
            }

            if (valSexo == true && valPlan == true && valNombre == true && valCalle == true && valTel == true)
            {

                afiliado.Apellido = txtApellido.Text;
                afiliado.Nombre = txtNombre.Text;
                afiliado.Calle = txtCalle.Text;
                afiliado.NroCalle = int.Parse(txtNroCalle.Text);
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

                resultado = AfiliadosBD.modificarAfiliado(afiliado);

                if (!resultado)
                {
                    ErroresForm mensaje = new ErroresForm();
                    mensaje.show("Error al modificar el afiliado");
                }
                else
                {
                    CorrectoForm msj = new CorrectoForm();
                    msj.show("Afiliado modificado exitosamente");
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

        private void ModAfiliado(Afiliados afiliado)
        {
            txtApellido.Text = afiliado.Apellido;
            txtNombre.Text = afiliado.Nombre;
            txtCalle.Text = afiliado.Calle;
            txtNroCalle.Text = afiliado.NroCalle.ToString();
            txtNroDoc.Text = afiliado.NumeroDocumento.ToString();
            txtNroTel.Text = afiliado.NumeroTelefono.ToString();
            cmbBarrios.SelectedIndex = afiliado.IdBarrio;
            cmbPlanes.SelectedIndex = afiliado.IdPlan;
            if (afiliado.IdSexo == 1)
            {
                btnFemenino.Checked = true;
            }
            if (afiliado.IdSexo == 2)
            {
                btnMasculino.Checked = true;
            }
            if (afiliado.IdSexo == 3)
            {
                btnOtro.Checked = true;
            }
            cmbTipoDocumento.SelectedIndex = afiliado.IdTipoDocumento;
            fechaNac.Value = afiliado.FechaNacimiento;
            fechaInscripcion.Value = afiliado.FechaInscripcion;
        }

        private void txtNroTel_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNroCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla no numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void ModificarAfiliado_Load(object sender, EventArgs e)
        {

        }
    }
}
