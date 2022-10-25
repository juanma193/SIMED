using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using SIMED_V1.Bases_de_datos;

namespace SIMED_V1
{
    public partial class EnviarCodigoFormcs : Form
    {
        string randomCode;
        public static string to;
        LoginUsuarios l;
        string mail;

        public EnviarCodigoFormcs(LoginUsuarios lu)
        {
            InitializeComponent();
            l = lu;
            txtCodigo.Visible = false;
            btnCodigo.Visible = false;

        }

        private void btnIngresarMail_Click(object sender, EventArgs e)
        {
            string email = txtMail.Text;
            Regex regex = new Regex(@"^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-za-za-z]{2,3})+$");
            Match match = regex.Match(email);


            string usermail = txtMail.Text;
            bool resultado = false;

            if (match.Success) 
            {

                resultado = UsuarioBD.ValidarEmail(usermail);
                if (resultado == true)
                {

                    string from, pass, messageBody;
                    Random rand = new Random();
                    randomCode = (rand.Next(99999)).ToString();
                    to = (txtMail.Text.Trim()).ToString();
                    messageBody = "Tu codigo de verificacion es:" + " " + randomCode;

                   

                
                    
                    try
                    {
                        if (Util.EmailSender(messageBody, to))
                        {
                            mail = txtMail.Text.Trim();
                            CorrectoForm co = new CorrectoForm();
                            co.show("Codigo de verificacion enviado exitosamente");

                            txtCodigo.Enabled = true;
                            btnCodigo.Enabled = true;
                            txtCodigo.Visible = true;
                            btnCodigo.Visible = true;
                        }
                        
                       
                        
                       
                    }
                    catch (Exception ex)
                    {

                        ErroresForm window = new ErroresForm();
                        window.show("Error al mandar el email. Pruebe nuevamente");
                    }
                }
                else
                {
                    ErroresForm window = new ErroresForm();
                    window.show("Error: no hay ningún usuario registrado con dicho correo electrónico. Ingrese uno válido");
                }


            }

            else 
            {
                ErroresForm window = new ErroresForm();
                window.show("Error: el formato del correo ingresado no es válido");
            }
            

            
            
            
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            
            bool nonumero = false;
            string input = txtCodigo.Text;
            try
            {
                int result = Int32.Parse(input);
                Console.WriteLine(result);
            }
            catch (FormatException)
            {
                nonumero = true;
                ErroresForm window = new ErroresForm();
                window.show("Error: debe ingresar un código de tipo numérico. No se admiten caracteres diferentes");
                txtCodigo.Focus();
              
            }

            if (nonumero == false)
            {
                if (randomCode == (txtCodigo.Text).ToString())
                {
                    to = txtMail.Text;
                    ReiniciarContraseña rc = new ReiniciarContraseña(mail,this);
                    this.Hide();
                    rc.Show();
                }
                else
                {
                    ErroresForm window = new ErroresForm();
                    window.show("Error: codigo invalido");
                }
            }

            
           
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            l.Show();
            this.Dispose();
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void EnviarCodigoFormcs_Load(object sender, EventArgs e)
        {
            txtMail.Focus();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoginUsuarios ventana = new LoginUsuarios();
            ventana.Show();
            this.Dispose();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
           
        }

        private void lblNuevaContraseña_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
