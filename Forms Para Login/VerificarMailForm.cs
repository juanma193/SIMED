using SIMED.Models;
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

        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            string codigo = code;
            bool nonumero = false;
            string input = txtCodigo.Text;
            Usuarios usuario = new Usuarios();
            Empleados empleado = new Empleados();
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
                if (codigo == (txtCodigo.Text).ToString())
                {

               

                    //Primero creamos el empleado y lo insertamos
                    empleado.Nombre = nameusu;
                    empleado.Apellido = apellidousu;
                    empleado.Edad = age;
                    empleado.IdSexo = sex;
                    bool resultado1 = UsuarioBD.InsertarEmpleado(empleado);

                    //Creamos el usuario y le asignamos el numero de legajo del ultimo empleado creado
                    usuario.NombreDeUsuario = user;
                    usuario.Contraseña = Util.Encrypt.GetSHA256(contraseña);
                    usuario.Email = email;
                    usuario.IdPerfil = 2;
                    usuario.LegajoEmpleado = UsuarioBD.BuscarLegajo();
                    bool resultado2 = UsuarioBD.InsertarUsuario(usuario);
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
    }
}
