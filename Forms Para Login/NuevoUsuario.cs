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
using SIMED_V1.Repositorio;

namespace SIMED_V1
{
    public partial class NuevoUsuario : Form

    {
        bool bandera = false;
        string randomCode;
        public static string to;
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            //player.SoundLocation = "C:\\Facultad\\Tercer Año\\PAV 1\\practicas\\archivos para proyecto\\sonidoPS2.wav";
            //player.Play();
            LoginUsuarios ventana = new LoginUsuarios();
            ventana.Show();
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            lblNombreUsuario.Visible = false;
            lblEmail.Visible = false;
            lblContraseña.Visible = false;
            lblRepetirContraseña.Visible = false;
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            lblNombreUsuario.Visible = false;
            lblEmail.Visible = false;
            lblContraseña.Visible = false;
            lblRepetirContraseña.Visible = false;

            string email = txtMail.Text;
            Regex regex = new Regex(@"^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-za-za-z]{2,3})+$");
            Match match = regex.Match(email);
            bandera = true;

            ErorresEnRojo(bandera);

            if (txtContraseña.Text.Equals(txtRepetirContraseña.Text) == true && match.Success)
                {
                    try
                    {
                        string nombreDeUsuario = txtNombreUsuario.Text;
               
                        string mail = txtMail.Text;
                        bool resultado = false;
                        resultado = UsuarioBD.ValidarUsername(nombreDeUsuario);
                        bool resultado2 = false;
                        resultado2 = ValidarCorreo(mail);

                        if (resultado == true)
                        {
                            ErroresForm window = new ErroresForm();
                            window.show("Error: el usuario ya existe, ingrese otro");
                        }

                        else 
                        {
                        if (resultado2 == true)
                        {
                            ErroresForm window = new ErroresForm();
                            window.show("Error: ese correo se encuentra en uso, ingrese otro");
                        }
                        else
                        {
                            string from, pass, messageBody;
                            Random rand = new Random();
                            randomCode = (rand.Next(99999)).ToString();
                            messageBody = "Tu codigo de verificacion es: " + "" + randomCode;
                            to = (txtMail.Text.Trim()).ToString();
                            Util.EmailSender(messageBody, to);
                            
                               
                               
                                
                                try
                                {
                                bool bandera = Util.EmailSender(messageBody, to);

                                if (bandera ==true)
                                {
                                    string enviarusu = txtNombreUsuario.Text;
                                    string enviarcontraseña = txtContraseña.Text;
                                    string correo = txtMail.Text;
                                    VerificarMailForm ventana = new VerificarMailForm(randomCode, enviarusu, enviarcontraseña, correo);
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
                else
                {
                    if (txtContraseña.Text.Equals(txtRepetirContraseña.Text) == false)
                    {
                        ErroresForm window = new ErroresForm();
                        window.show("Error: las contraseñas deben ser iguales");
                    }
                    if(!match.Success)
                    {
                        ErroresForm window = new ErroresForm();
                        window.show("Error: el formato del mail no es correcto. Ingrese uno válido");
                    }
                }
            
        }

        private void ErorresEnRojo(bool bandera) 
        {

            if (txtNombreUsuario.Text.Equals("") && bandera == true)
            {
                lblNombreUsuario.Visible = true;
                lblNombreUsuario.Text = "Nombre de usuario obligatorio";
            }
            if (txtMail.Text.Equals("") && bandera == true)
            {
                lblEmail.Visible = true;
                lblEmail.Text = "Correo obligatorio";
            }
            if (txtContraseña.Text.Equals("") && bandera == true)
            {
                lblContraseña.Visible = true;
                lblContraseña.Text = "Contraseña obligatoria";
            }
            if (txtRepetirContraseña.Text.Equals("") && bandera == true)
            {
                lblRepetirContraseña.Visible = true;
                lblRepetirContraseña.Text = "Contraseña obligatoria";
            }


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
            if (txtMail.Text.Equals(""))
            {
                lblEmail.Visible = true;
                lblEmail.Text = "Correo obligatorio";
            }
            else { lblEmail.Visible = false; }
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
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
            if (txtContraseña.Text.Equals(""))
            {
                lblContraseña.Visible = true;
                lblContraseña.Text = "Contraseña obligatoria";
            }
            else { lblContraseña.Visible = false; }


        }

        private void txtRepetirContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtRepetirContraseña.Text.Equals(""))
            {
                lblRepetirContraseña.Visible = true;
                lblRepetirContraseña.Text = "Contraseña obligatoria";
            }
            else { lblRepetirContraseña.Visible = false; }
        }
    }
}
