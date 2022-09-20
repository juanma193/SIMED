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

        private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbBarrios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearAmbulancia_Click(object sender, EventArgs e)
        {
            var afiliado = new Afiliados();
            var resultado = new bool();

            afiliado.Apellido = txtApellido.Text;
            afiliado.Nombre = txtNombre.Text;
            afiliado.Calle = txtCalle.Text;
            afiliado.NroCalle = int.Parse(txtNroCalle.Text);
            afiliado.NumeroDocumento = int.Parse(txtNroDoc.Text);
            afiliado.NumeroTelefono = int.Parse(txtNroTel.Text);
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
            CorrectoForm msj = new CorrectoForm();
            msj.show("Afiliado modificado exitosamente");


        }
        private void ComboTipoDoc()
        {
            var tiposDoc = TiposDocBD.getTiposDoc();
            string defaultCmbItem = "Tipo de documento";
            cmbTipoDocumento.Items.Add(defaultCmbItem);
            cmbTipoDocumento.SelectedItem = defaultCmbItem;
            foreach (var tipoDocument in tiposDoc)
            {
                cmbTipoDocumento.Items.Add(tipoDocument.Descripcion);
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

    }
}
