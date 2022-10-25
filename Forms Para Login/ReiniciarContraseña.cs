using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using SIMED_V1.Bases_de_datos;

namespace SIMED_V1
{
    public partial class ReiniciarContraseña : Form
    {
        string correo;
        LoginUsuarios lu = new LoginUsuarios();
        Form anterior;
        
        public ReiniciarContraseña(string mail,Form f)
        {
            InitializeComponent();
            correo = mail;
            anterior = f;
        }

        private void btnReestablecerContraseña_Click(object sender, EventArgs e)
        {
            string usermail = correo;

            if (txtContraseña.Text.Equals("") || txtRepetirContraseña.Text.Equals(""))
            {
                ErroresForm window = new ErroresForm();
                window.show("Error: debe rellenar todos los campos que solicitan contraseña");


            }

            else
            {

                if (txtContraseña.Text == txtRepetirContraseña.Text)
                {
                    string userpass = Util.Encrypt.GetSHA256(txtContraseña.Text);

                    if (UsuarioBD.ActualizarContraseña(usermail,userpass))
                    {
                        CorrectoForm co = new CorrectoForm();
                        co.show("Contraseña modificada con éxito");
                        LoginUsuarios lu = new LoginUsuarios();
                        this.Hide();
                        lu.Show();
                    }
                    else
                    {
                        ErroresForm window = new ErroresForm();
                        window.show("Error: no se pudo modificar la contraseña");
                    }
                    
                }
                else
                {
                    ErroresForm window = new ErroresForm();
                    window.show("Error: las contraseñas ingresadas no coinciden, deben ser iguales");
                }
            }

        }

        

        private void ReiniciarContraseña_Load(object sender, EventArgs e)
        {
            txtContraseña.Focus();
        }

        private void lblNuevaContraseña_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoginUsuarios ventana = new LoginUsuarios();
            ventana.Show();
            this.Dispose();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.anterior.Show();
            this.Dispose();

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
