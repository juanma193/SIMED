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
    public partial class AltaAfiliado : Form
    {
        bool cambios = false;
        public AltaAfiliado()
        {
            InitializeComponent();
            ComboTipoDoc();
            ComboCiudad();
            ComboBarrio();
            ComboPlan();
            cambios = false;
            lblNombre.Visible = false;
            lblApellido.Visible = false;
            lblSexo.Visible = false;
            lblFechaNac.Visible = false;
            lblNumTelefono.Visible = false;
            lblTipoDoc.Visible = false;
            lblNumeroDoc.Visible = false;
            lblPlan.Visible = false;
            lblFechaInscripcion.Visible = false;
            lblCalle.Visible = false;
            lblNumeroCalle.Visible = false;
            lblCiudad.Visible = false;
            lblBarrio.Visible = false;
        }

        private void ComboCiudad()
        {
            var ciudades = BarriosBD.getCiudades();
            string defaultCmbItem = "Ciudad";
            cmbCiudad.Items.Add(defaultCmbItem);
            cmbCiudad.SelectedItem = defaultCmbItem;
            foreach (var ciudad in ciudades)
            {
                cmbCiudad.Items.Add(ciudad.DescripcionCiudad);
            }
        }

        private void btnCrearAfiliado_Click(object sender, EventArgs e)
        {
            var afiliado = new Afiliados();


           

            bool flag = ErroresEnRojo();

            if (!flag)
            {
                afiliado.Apellido = EmpleadosBD.UpperCaseFirstChar(txtApellido.Text);
                afiliado.Nombre = EmpleadosBD.UpperCaseFirstChar(txtNombre.Text);
                afiliado.Calle = txtCalle.Text;
                afiliado.NroCalle = Convert.ToInt32(txtNroCalle.Text);
                
                afiliado.NumeroDocumento = int.Parse(txtNroDoc.Text);
                afiliado.NumeroTelefono = txtNroTel.Text;
                int id = AfiliadosBD.ObtenerBarrioXDescripcion(cmbBarrios.SelectedItem.ToString());
                
                afiliado.IdBarrio = id;
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

        private bool ErroresEnRojo()
        {
            bool flag = false;


            if (txtNombre.Text == "")
            {
                flag = true;
                lblNombre.Visible = true;
                lblNombre.Text = "Nombre obligatorio";


            }

            if (txtCalle.Text == "")
            {
                flag = true;
                lblCalle.Visible = true;
                lblCalle.Text = "Calle obligatoria";
            }

            if (txtNroCalle.Text == "")
            {
                flag = true;
                lblNumeroCalle.Visible = true;
                lblNumeroCalle.Text = "Numero de calle obligatorio";
            }

            if (txtNroTel.Text == "")
            {
                flag = true;
                lblNumTelefono.Visible = true;
                lblNumTelefono.Text = "Número de teléfono obligatorio";
            }

            if (txtNroDoc.Text == "")
            {
                flag = true;
                lblNumeroDoc.Visible = true;
                lblNumeroDoc.Text = "Numero de documento obligatorio";

            }

            if (txtApellido.Text == "")
            {
                flag = true;
                lblApellido.Visible = true;
                lblApellido.Text = "Apellido obligatorio";
            }

            if (!btnFemenino.Checked && !btnMasculino.Checked && !btnOtro.Checked )
            {
                flag = true;
                lblSexo.Visible = true;
                lblSexo.Text = "Sexo obligatorio";
            }
            

            if (cmbBarrios.SelectedIndex == 0)
            {
                flag = true;
                lblBarrio.Visible = true;
                lblBarrio.Text = "Debe seleccionar un barrio";
            }
            if (cmbCiudad.SelectedIndex == 0)
            {
                flag = true;
                lblCiudad.Visible = true;
                lblCiudad.Text = "Debe seleccionar una ciudad";
            }

            if (cmbTipoDocumento.SelectedItem == "Tipo de documento")
            {
                flag = true;
                lblTipoDoc.Visible = true;
                lblTipoDoc.Text = "Debe seleccionar un tipo de documento";
            }

            if (cmbPlanes.SelectedIndex == 0)
            {
                flag = true;
                lblPlan.Visible = true;
                lblPlan.Text = "Debe seleccionar un plan";
            }


            return flag;
        
        
        
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
            cmbBarrios.Enabled = false;
            string defaultCmbItem = "Barrio";
          

 
                cmbBarrios.Enabled = false;
              
                cmbBarrios.Items.Add(defaultCmbItem);
                cmbBarrios.SelectedItem = defaultCmbItem;
           
            
            
        }
        private void LimpiarBarrio()
        {
            if (cmbBarrios.Items.Count > 0)
            {
                cmbBarrios.Items.Clear();
            }
            
        
        }
        private void FiltroBarrio()
        {

            cmbBarrios.Enabled = true;
            string defaultCmbItem = "Barrio";



            
            cmbBarrios.SelectedItem = defaultCmbItem;

            if (cmbCiudad.SelectedIndex == 0)
            {

                cmbBarrios.Enabled = false;
                cmbBarrios.Items.Add(defaultCmbItem);
                cmbBarrios.SelectedItem = defaultCmbItem;

            }

            if (cmbCiudad.SelectedIndex == 1)
            {
                
                cmbBarrios.Enabled = true;
                LimpiarBarrio();
                cmbBarrios.Items.Add(defaultCmbItem);
                cmbBarrios.SelectedItem = defaultCmbItem;
                var barrios = BarriosBD.getBarriosDesdeCiudad(1);

               
                foreach (var barrio in barrios)
                {
                    cmbBarrios.Items.Add(barrio.NombreBarrio);
                }
            }
            else
            {
                if (cmbCiudad.SelectedIndex == 2)
                {
                    cmbBarrios.Enabled = true;
                    LimpiarBarrio();
                    cmbBarrios.Items.Add(defaultCmbItem);
                    cmbBarrios.SelectedItem = defaultCmbItem;
                    var barrios = BarriosBD.getBarriosDesdeCiudad(2);

                   
                    foreach (var barrio in barrios)
                    {
                        cmbBarrios.Items.Add(barrio.NombreBarrio);
                    }
                }
                if (cmbCiudad.SelectedIndex == 3)
                {
                    cmbBarrios.Enabled = true;
                    LimpiarBarrio();
                    cmbBarrios.Items.Add(defaultCmbItem);
                    cmbBarrios.SelectedItem = defaultCmbItem;
                    var barrios = BarriosBD.getBarriosDesdeCiudad(3);

                   
                    foreach (var barrio in barrios)
                    {
                        cmbBarrios.Items.Add(barrio.NombreBarrio);
                    }
                }
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNroCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtNroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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

        private void txtCalle_TextChanged(object sender, EventArgs e)
        {
            cambios = true;
            txtCalle.MaxLength = 35;
            if (txtCalle.Text == "")
            {
                lblCalle.Visible= true;
                lblCalle.Text = "Calle obligatoria";

            }
            else
            {
                lblCalle.Visible = false;
                
            }
          
        }

        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar)) e.Handled = false;
            else
            {
                if (e.KeyChar == '\b') e.Handled = false; //Tecla de borrado
                else
                {
                    if ((e.KeyChar == '-' || e.KeyChar == '.' || e.KeyChar == '_' || e.KeyChar == ',' || e.KeyChar == ';') || Char.IsControl(e.KeyChar)) e.Handled = true;
                    else if (!char.IsSeparator(e.KeyChar)) e.Handled = true;
                }
            }
        }

        private void AltaAfiliado_Load(object sender, EventArgs e)
        {
            this.fechaNac.MaxDate = DateTime.Today;
            this.fechaInscripcion.MaxDate = DateTime.Today;

            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            cambios = true;
            txtNombre.MaxLength = 30;
            if (txtNombre.Text == "")
            {
                lblNombre.Visible = true;
                lblNombre.Text = "Nombre obligatorio";

            }
            else
            {
                lblNombre.Visible = false;
                
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            cambios = true;
            txtApellido.MaxLength = 50;
            if (txtApellido.Text == "")
            {
                lblApellido.Visible = true;
                lblApellido.Text = "Apellido obligatorio";

            }
            else
            {
                lblApellido.Visible = false;

            }
        }

        private void txtNroTel_TextChanged(object sender, EventArgs e)
        {
            cambios = true;
            txtNroTel.MaxLength = 10;
            if (txtNroTel.Text == "")
            {
                lblNumTelefono.Visible = true;
                lblNumTelefono.Text = "Número de teléfono obligatorio";

            }
            else
            {
                lblNumTelefono.Visible = false;

            }
        }

        private void txtNroDoc_TextChanged(object sender, EventArgs e)
        {
            cambios = true;
            if (txtNroDoc.Text == "")
            {
                lblNumeroDoc.Visible = true;
                lblNumeroDoc.Text = "Numero de documento obligatorio";
            }
            else
            {
                lblNumeroDoc.Visible = false;

            }
        }

        private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cambios = true;
            if (cmbTipoDocumento.SelectedItem == "Tipo de documento")
            {
                lblTipoDoc.Visible = true;
                lblTipoDoc.Text = "Debe seleccionar un tipo de documento";

            }
            if (!(txtNroDoc.Text == ""))
            {
                txtNroDoc.Text = "";
            }
            else
            {
                lblTipoDoc.Visible = false;
            }
            if (cmbTipoDocumento.SelectedIndex == 1)
            {
                txtNroDoc.MaxLength = 8;
            }
            else if (cmbTipoDocumento.SelectedIndex == 2)
            {
                txtNroDoc.MaxLength = 11;
            }
            else if (cmbTipoDocumento.SelectedIndex == 3)
            {
                txtNroDoc.MaxLength = 9;

            }
        }

        

        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            cambios =true;
            FiltroBarrio();
            if (cmbCiudad.SelectedItem == "Ciudad")
            {
                lblCiudad.Visible = true;
                lblCiudad.Text = "Debe seleccionar una ciudad";

            }
            else
            {
                lblCiudad.Visible = false;
            }
        }

        private void txtNroCalle_TextChanged_1(object sender, EventArgs e)
        {
            cambios = true;
            txtNroCalle.MaxLength = 5000;
            if (txtNroCalle.Text == "")
            {
                lblNumeroCalle.Visible = true;
                lblNumeroCalle.Text = "Número de calle obligatorio";

            }
            else
            {
                lblNumeroCalle.Visible = false;

            }
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnFemenino_CheckedChanged(object sender, EventArgs e)
        {
            cambios = true;
        }

        private void btnMasculino_CheckedChanged(object sender, EventArgs e)
        {
            cambios = true;
        }

        private void btnOtro_CheckedChanged(object sender, EventArgs e)
        {
            cambios = true;
        }

        private void cmbPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cambios = true;

            if (cmbPlanes.SelectedItem == "Plan")
            {
                lblPlan.Visible = true;
                lblPlan.Text = "Debe seleccionar un plan";

            }
            else
            {
                lblPlan.Visible = false;
            }

        }

        private void cmbCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cmbBarrios_SelectedIndexChanged(object sender, EventArgs e)
        {
            cambios = true;
            if (cmbBarrios.SelectedItem == "Barrio")
            {
                lblBarrio.Visible = true;
                lblBarrio.Text = "Debe seleccionar un barrio";

            }
            else
            {
                lblBarrio.Visible = false;
            }
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            if (cambios)
            {

                SeguroModificar ventana = new SeguroModificar();
                ventana.lblMensaje.Text = "¿Está seguro de que desea perder todos los cambios?";
                ventana.btnModificar.Text = "Salir";
                if (ventana.ShowDialog() == DialogResult.OK)
                {
                    this.Dispose();
                    

                }
            }
            else
            {
                this.Dispose();
                
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (cambios)
            {

                SeguroModificar ventana = new SeguroModificar();
                ventana.lblMensaje.Text = "¿Está seguro de que desea perder todos los cambios?";
                ventana.btnModificar.Text = "Salir";
                if (ventana.ShowDialog() == DialogResult.OK)
                {
                    this.Dispose();


                }
            }
            else
            {
                this.Dispose();

            }
        }

        private void cmbBarrios_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
