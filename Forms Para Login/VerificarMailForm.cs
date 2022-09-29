using SIMED_V1.Bases_de_datos;
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

namespace SIMED_V1
{
    public partial class VerificarMailForm : Form
    {
        string code;
        string user;
        string contraseña;
        string email;
        string nameusu;
        string apellidousu;
        int age;
        int sex;
        public VerificarMailForm(string randomCode, string nombreUsu, string password, string correo, string nombre, string apellido, int edad, int sexo)
        {
            InitializeComponent();
            code = randomCode;
            user = nombreUsu;
            contraseña = password;
            email = correo;
            nameusu = nombre;
            apellidousu = apellido;
            age = edad;
            sex = sexo;

        }

        private void VerificarMailForm_Load(object sender, EventArgs e)
        {
            txtCodigo.Focus();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            string codigo = code;
            
            string input = txtCodigo.Text;
            

            
            
                if (codigo == (txtCodigo.Text).ToString())
                {
                    string username = user;
                    string userpass = Util.Encrypt.GetSHA256(contraseña);
                    string usermail = email;
                    bool resultado1 = UsuarioBD.InsertarEmpleado(nameusu,apellidousu,age,sex);
                    int legajo = UsuarioBD.BuscarLegajo();

                    bool resultado2 = UsuarioBD.InsertarUsuario(username, userpass, usermail,legajo);
                    if (resultado2 && resultado1)
                    {
                        CorrectoForm co = new CorrectoForm();
                        co.show("Usuario dado de alta con éxito");
                        LoginUsuarios ventana = new LoginUsuarios();
                        ventana.Show();
                        this.Hide();
                    }
                    else
                    {
                        ErroresForm window = new ErroresForm();
                        window.show("Error: ocurrio un error al momento de dar de alta al nuevo usuario");

                    }


                }
                else
                {
                    ErroresForm window = new ErroresForm();
                    window.show("Error: codigo invalido");
                }
            

            


        }

        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoginUsuarios ventana = new LoginUsuarios();
            ventana.Show();
            this.Dispose();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            LoginUsuarios ventana = new LoginUsuarios();
            ventana.Show();
            this.Dispose();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NuevoUsuario nue = new NuevoUsuario();
            nue.Show();
            this.Dispose();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
