using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using SIMED_V1.Bases_de_datos;
using SIMED_V1.Forms_Mensajes_Personalizados;

namespace SIMED_V1
{
    public partial class NuevoUsuario : Form

    {
        bool resultado = false;
        bool resultado2 = false;
        bool bandera = false;
        string randomCode;
        int variablesexo;
        public static string to;
        bool cambios = false;
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            //player.SoundLocation = "C:\\Facultad\\Tercer Año\\PAV 1\\practicas\\archivos para proyecto\\sonidoPS2.wav";
            //player.Play();
            if (cambios)
            {

                SeguroModificar ventana = new SeguroModificar();
                ventana.lblMensaje.Text = "¿Está seguro de que desea perder todos los cambios?";
                ventana.btnModificar.Text = "Salir";
                if (ventana.ShowDialog() == DialogResult.OK)
                {
                    this.Dispose();
                    LoginUsuarios window = new LoginUsuarios();
                    window.Show();
                }
            }
            else
            {
                this.Dispose();
                LoginUsuarios window = new LoginUsuarios();
                window.Show();
            }
            
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            txtNombreUsuario.Focus();
            lblNombreUsuario.Visible = false;
            lblEmail.Visible = false;
            lblContraseña.Visible = false;
            lblRepetirContraseña.Visible = false;
            lblNombre.Visible = false;
            lblEdad.Visible = false;
            lblApellido.Visible = false;
            lblSexo.Visible = false;
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            lblNombreUsuario.Visible = false;
            lblEmail.Visible = false;
            lblContraseña.Visible = false;
            lblRepetirContraseña.Visible = false;
            lblNombre.Visible = false;
            lblApellido.Visible = false;
            lblEdad.Visible = false;
            lblSexo.Visible = false;

            string email = txtMail.Text;
            Regex regex = new Regex(@"^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-za-za-z]{2,3})+$");
            Match match = regex.Match(email);
            bandera = true;

            bool flag =ErorresEnRojo(bandera);


            //if ((txtMail.Text == "") || (txtContraseña.Text == "") || (txtRepetirContraseña.Text == "") || (txtNombreUsuario.Text == ""))
            //{
            //    vacio = true;
            //}
            //else
            //{ vacio = false; }

            if (flag)
            {
                try
                {
                    string nombreDeUsuario = txtNombreUsuario.Text;

                    string mail = txtMail.Text;

                    resultado = UsuarioBD.ValidarUsername(nombreDeUsuario);

                    resultado2 = ValidarCorreo(mail);

                    bool erroresif = Resultados(match);


                    if (erroresif)
                    {
                        string from, pass, messageBody;
                        Random rand = new Random();
                        randomCode = (rand.Next(99999)).ToString();
                        messageBody = "Tu codigo de verificacion es: " + "" + randomCode;
                        to = (txtMail.Text.Trim()).ToString();
                        Util.EmailSender(messageBody, to);

                        int edad = int.Parse(txtEdad.Text);
                        bool edadcorrecta = true;

                        if (edad < 18 || edad > 80)
                        {
                            lblEdad.Visible = true;
                            lblEdad.Text = "Edad no permitida. Mínima 18, máxima 80";
                            edadcorrecta = false;
                        }

                        if (edadcorrecta)
                        {
                            try
                            {
                                bool bandera = Util.EmailSender(messageBody, to);

                                if (bandera == true)
                                {


                                    if (btnFemenino.Checked)
                                    {
                                        variablesexo = 1;
                                    }

                                    if (btnMasculino.Checked)
                                    {
                                        variablesexo = 2;
                                    }

                                    if (btnOtro.Checked)
                                    {
                                        variablesexo = 3;
                                    }


                                    string enviarusu = txtNombreUsuario.Text;
                                    string enviarcontraseña = txtContraseña.Text;
                                    string correo = txtMail.Text;
                                    string enviarnombre = EmpleadosBD.UpperCaseFirstChar(txtNombre.Text);
                                    string enviarapellido = EmpleadosBD.UpperCaseFirstChar(txtApellido.Text);
                                    int enviaredad = int.Parse(txtEdad.Text);

                                    int enviarsexo = variablesexo;



                                    VerificarMailForm ventana = new VerificarMailForm(randomCode, enviarusu, enviarcontraseña, correo, enviarnombre, enviarapellido, enviaredad, enviarsexo);
                                    ventana.Show();
                                    this.Hide();

                                }
                                else
                                {
                                    ErroresForm window = new ErroresForm();
                                    window.show("Error al mandar mail: ");
                                }

                            }
                            catch (Exception ex)
                            {

                                throw;
                            }
                        }
                        
                    }
                }

                catch (Exception ex)
                {

                    ErroresForm window = new ErroresForm();
                    window.show("Error: " + ex);
                    txtNombreUsuario.Focus();
                }
            }
                
        }

        private bool Resultados(Match match)
        {
            bool results = false;

            //0000
            if (!resultado && !resultado2 && match.Success && txtContraseña.Text.Equals(txtRepetirContraseña.Text) == true)
            {
                results = true;
            }

            //0001
            if (!resultado && !resultado2 && match.Success && txtContraseña.Text.Equals(txtRepetirContraseña.Text) == false)
            {
                results = false;
                ErroresForm window = new ErroresForm();
                window.show("Error: las contraseñas deben ser iguales");
            }

            //0010
            if (!resultado && !resultado2 && !match.Success && txtContraseña.Text.Equals(txtRepetirContraseña.Text) == true)
            {
                results = false;
                ErroresForm window = new ErroresForm();
                window.show("Error: el formato del mail no es correcto");
            }


            //0011
            if (!resultado && !resultado2 && !match.Success && txtContraseña.Text.Equals(txtRepetirContraseña.Text) == false)
            {
                results = false;
                string error = "Uno o más campos no son correctos";
                string errorAdicional1 = "El formato del mail no es correcto. \n" + "Las contraseñas deben ser iguales";

                MultiplesErrores ventana = new MultiplesErrores(error, errorAdicional1);
                ventana.Show();

            }

            //0100
            if (!resultado && resultado2 && match.Success && txtContraseña.Text.Equals(txtRepetirContraseña.Text) == true)
            {
                results = false;
                ErroresForm window = new ErroresForm();
                window.show("Error: el email se encuentra en uso");
            }

            //0101
            if (!resultado && resultado2 && match.Success && txtContraseña.Text.Equals(txtRepetirContraseña.Text) == false)
            {
                results = false;
                string error = "Uno o más campos no son correctos";
                string errorAdicional1 = "El email se encuentra en uso. \n" + "Las contraseñas deben ser iguales";

                MultiplesErrores ventana = new MultiplesErrores(error, errorAdicional1);
                ventana.Show();

            }

            //0110
            if (!resultado && resultado2 && !match.Success && txtContraseña.Text.Equals(txtRepetirContraseña.Text) == true)
            {
                results = false;
                string error = "Uno o más campos no son correctos";
                string errorAdicional1 = "El email se encuentra en uso. \n" + "El formato de mail no es correcto";

                MultiplesErrores ventana = new MultiplesErrores(error, errorAdicional1);
                ventana.Show();

            }

            //0111
            if (!resultado && resultado2 && !match.Success && txtContraseña.Text.Equals(txtRepetirContraseña.Text) == false)
            {
                results = false;
                string error = "Uno o más campos no son correctos";
                string errorAdicional1 = "El email se encuentra en uso. \n" + "El formato de mail no es correcto \n" + "Las contraseñas deben ser iguales";

                MultiplesErrores ventana = new MultiplesErrores(error, errorAdicional1);
                ventana.Show();

            }

            //1000
            if (resultado && !resultado2 && match.Success && txtContraseña.Text.Equals(txtRepetirContraseña.Text) == true)
            {
                results = false;
                ErroresForm window = new ErroresForm();
                window.show("Error:  el nombre de usuario se encuentra en uso");

            }

            //1001
            if (resultado && !resultado2 && match.Success && txtContraseña.Text.Equals(txtRepetirContraseña.Text) == false)
            {
                results = false;
                string error = "Uno o más campos no son correctos";
                string errorAdicional1 = "El nombre de ususario se encuentra en uso. \n" + "Las contraseñas deben ser iguales";

                MultiplesErrores ventana = new MultiplesErrores(error, errorAdicional1);
                ventana.Show();

            }

            //1010

            if (resultado && !resultado2 && !match.Success && txtContraseña.Text.Equals(txtRepetirContraseña.Text) == true)
            {
                results = false;
                string error = "Uno o más campos no son correctos";
                string errorAdicional1 = "El nombre de usuario se encuentra en uso. \n" + "El formato de mail no es correcto";

                MultiplesErrores ventana = new MultiplesErrores(error, errorAdicional1);
                ventana.Show();

            }

            // 1011

            if (resultado && !resultado2 && !match.Success && txtContraseña.Text.Equals(txtRepetirContraseña.Text) == false)
            {
                results = false;
                string error = "Uno o más campos no son correctos";
                string errorAdicional1 = "El nombre de ususario se encuentra en uso. \n" + "El formato de mail no es correcto \n" + "Las contraseñas deben ser iguales";

                MultiplesErrores ventana = new MultiplesErrores(error, errorAdicional1);
                ventana.Show();

            }

            // 1100

            if (resultado && resultado2 && match.Success && txtContraseña.Text.Equals(txtRepetirContraseña.Text) == true)
            {
                results = false;
                string error = "Uno o más campos no son correctos";
                string errorAdicional1 = "El nombre de usuario se encuentra en uso. \n" + "El email se encuentra en uso";

                MultiplesErrores ventana = new MultiplesErrores(error, errorAdicional1);
                ventana.Show();

            }

            // 1101

            if (resultado && resultado2 && match.Success && txtContraseña.Text.Equals(txtRepetirContraseña.Text) == false)
            {
                results = false;
                string error = "Uno o más campos no son correctos";
                string errorAdicional1 = "El nombre de ususario se encuentra en uso. \n" + "El email se encuentra en uso \n" + "Las contraseñas deben ser iguales";

                MultiplesErrores ventana = new MultiplesErrores(error, errorAdicional1);
                ventana.Show();

            }

            // 1110

            if (resultado && resultado2 && !match.Success && txtContraseña.Text.Equals(txtRepetirContraseña.Text) == true)
            {
                results = false;
                string error = "Uno o más campos no son correctos";
                string errorAdicional1 = "El nombre de ususario se encuentra en uso. \n" + "El email se encuentra en uso \n" + "El formato del mail no es correcto";

                MultiplesErrores ventana = new MultiplesErrores(error, errorAdicional1);
                ventana.Show();

            }

            // 1111
            if (resultado && resultado2 && !match.Success && txtContraseña.Text.Equals(txtRepetirContraseña.Text) == false)
            {
                results = false;
                string error = "Uno o más campos no son correctos";
                string errorAdicional1 = "El nombre de usuario se encuentra en uso. \n" + "El email se encuentra en uso \n" + "El formato del mail no es correcto \n" + "Las contraseñas deben ser iguales";

                MultiplesErrores ventana = new MultiplesErrores(error, errorAdicional1);
                ventana.Show();

            }

            




            return results;

        }

        private bool ErorresEnRojo(bool bandera) 
        {
            bool flag = true;

            if (txtNombreUsuario.Text.Equals("") && bandera == true)
            {
                lblNombreUsuario.Visible = true;
                lblNombreUsuario.Text = "Nombre de usuario obligatorio";
                flag = false;
            }
            if (txtMail.Text.Equals("") && bandera == true)
            {
                lblEmail.Visible = true;
                lblEmail.Text = "Correo obligatorio";
                flag = false;
            }
            if (txtContraseña.Text.Equals("") && bandera == true)
            {
                lblContraseña.Visible = true;
                lblContraseña.Text = "Contraseña obligatoria";
                flag = false;
            }
            if (txtRepetirContraseña.Text.Equals("") && bandera == true)
            {
                lblRepetirContraseña.Visible = true;
                lblRepetirContraseña.Text = "Contraseña obligatoria";
                flag = false;
            }
            if (txtNombre.Text.Equals("") && bandera == true)
            {
                lblNombre.Visible = true;
                lblNombre.Text = "Nombre obligatorio";
                flag = false;
            }
            if (txtApellido.Text.Equals("") && bandera == true)
            {
                lblApellido.Visible = true;
                lblApellido.Text = "Nombre obligatorio";
                flag = false;
            }
            if (txtEdad.Text.Equals("") && bandera == true)
            {
                lblEdad.Visible = true;
                lblEdad.Text = "Edad obligatoria";
                flag = false;
            }

            if (!(btnFemenino.Checked || btnMasculino.Checked || btnOtro.Checked) && bandera == true)
            {
                lblSexo.Visible = true;
                lblSexo.Text = "Debe seleccionar un sexo";
                flag = false;
            }
            return flag;
        }

       

        private bool ValidarCorreo(string correo)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM USUARIOS WHERE Email like @mail";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@mail", correo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);


                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                    return resultado;
                }
                else
                {
                    resultado = false;
                    return resultado;
                }

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {

                cn.Close();

            }

            return resultado;

        }
        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            cambios = true;
            txtMail.MaxLength = 76;
            if (txtMail.Text.Equals(""))
            {
                lblEmail.Visible = true;
                lblEmail.Text = "Correo obligatorio";
            }
            else { lblEmail.Visible = false; }
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            cambios = true;
            txtNombreUsuario.MaxLength = 50;
            if (txtNombreUsuario.Text.Equals(""))
            {
                lblNombreUsuario.Visible = true;
                lblNombreUsuario.Text = "Nombre de usuario obligatorio";
            }
            else { lblNombreUsuario.Visible = false; }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoginUsuarios ventana = new LoginUsuarios();
            ventana.Show();
            this.Dispose();
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            cambios = true;
            txtContraseña.MaxLength = 15;
            if (txtContraseña.Text.Equals(""))
            {
                lblContraseña.Visible = true;
                lblContraseña.Text = "Contraseña obligatoria";
            }
            else { lblContraseña.Visible = false; }


        }

        private void txtRepetirContraseña_TextChanged(object sender, EventArgs e)
        {
            cambios = true;
            txtRepetirContraseña.MaxLength = 15;
            if (txtRepetirContraseña.Text.Equals(""))
            {
                lblRepetirContraseña.Visible = true;
                lblRepetirContraseña.Text = "Contraseña obligatoria";
            }
            else { lblRepetirContraseña.Visible = false; }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            cambios = true;
            txtNombre.MaxLength = 50;
            if (txtNombre.Text.Equals(""))
            {
                lblNombre.Visible = true;
                lblNombre.Text = "Nombre obligatorio";
            }
            else { lblNombre.Visible = false; }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            cambios = true;
            txtApellido.MaxLength = 50;
            if (txtApellido.Text.Equals(""))
            {
                lblApellido.Visible = true;
                lblApellido.Text = "Apellido obligatorio";
            }
            else { lblApellido.Visible = false; }
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            cambios = true;
            
            


            if (txtEdad.Text.Equals(""))
            {
                lblEdad.Visible = true;
                lblEdad.Text = "Edad obligatoria";
            }
            else 
            { lblEdad.Visible = false;

                int edad = int.Parse(txtEdad.Text);
                txtEdad.MaxLength = 3;

                if (edad < 18 || edad > 80)
                {
                    lblEdad.Visible = true;
                    lblEdad.Text = "Edad no permitida. Mínima 18, máxima 80";
                    
                }


            }

        }

        private void btnFemenino_CheckedChanged(object sender, EventArgs e)
        {
            lblSexo.Visible = false;
            cambios = true;
        }

        private void btnMasculino_CheckedChanged(object sender, EventArgs e)
        {
            lblSexo.Visible = false;
            cambios=true;
        }

        private void btnOtro_CheckedChanged(object sender, EventArgs e)
        {
            lblSexo.Visible = false;
            cambios = true;
        }

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsLetterOrDigit(e.KeyChar)) e.Handled = false;
            else
            {
                if (e.KeyChar == '\b') e.Handled = false; //Tecla de borrado
                else
                {
                    if (e.KeyChar == '-' || e.KeyChar == '.') e.Handled = false;
                    else if (char.IsSeparator(e.KeyChar)) e.Handled = true;
                }
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

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void grpSexo_Click(object sender, EventArgs e)
        {

        }

        private void txtEdad_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar)) e.Handled = false;
            else
            {
                if (e.KeyChar == '\b') e.Handled = false; //Tecla de borrado
                else
                {
                    if (e.KeyChar == '-' || e.KeyChar == '.') e.Handled = false;
                    else if (char.IsSeparator(e.KeyChar)) e.Handled = true;
                }
            }
        }

        private void txtRepetirContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar)) e.Handled = false;
            else
            {
                if (e.KeyChar == '\b') e.Handled = false; //Tecla de borrado
                else
                {
                    if (e.KeyChar == '-' || e.KeyChar == '.') e.Handled = false;
                    else if (char.IsSeparator(e.KeyChar)) e.Handled = true;
                }
            }
        }
    }
    }

