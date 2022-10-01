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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMED_V1.Forms_Para_ABM
{
    public partial class ModificarEmpleado : Form
    {
        bool bandera = false;
        new Empleados empl = new Empleados();
        new Usuarios usu = new Usuarios();
        new ConsultaUsuarios consu;
        public ModificarEmpleado(Empleados empleado, Usuarios usuario, ConsultaUsuarios cons)
        {
            InitializeComponent();

            ModEmpleados(empleado);
            ModUsuario(usuario);
            consu = cons;

            lblNombreUsuario.Visible = false;
            lblEmail.Visible = false;
            lblNombre.Visible = false;
            lblEdad.Visible = false;
            lblApellido.Visible = false;
            lblSexo.Visible = false;

            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtEdad.Enabled = false;
            txtSexo.Enabled = false;
            btnModEmpleado.Enabled = false; 

            txtNombreUsuario.Enabled = false;
            txtMail.Enabled = false;
            btnModificarUsuario.Enabled = false;

            empl.Nombre = empleado.Nombre;
            empl.Apellido = empleado.Apellido;
            empl.Edad = empleado.Edad;
            empl.IdSexo = empleado.IdSexo;
            empl.Legajo = empleado.Legajo;

            usu.IdUsuario = usuario.IdUsuario;
            usu.NombreDeUsuario = usuario.NombreDeUsuario;
            usu.Email = usuario.Email;
            usu.Contraseña = usuario.Contraseña;


        }

        private void ModificarEmpleado_Load(object sender, EventArgs e)
        {

            lblNombreUsuario.Visible = false;
            lblEmail.Visible = false;
            lblNombre.Visible = false;
            lblEdad.Visible = false;
            lblApellido.Visible = false;
            lblSexo.Visible = false;


        }

        private void ModEmpleados(Empleados empleado)
        {
            txtNombre.Text = empleado.Nombre;
            txtApellido.Text = empleado.Apellido;
            txtEdad.Text = empleado.Edad.ToString();
          
            if (empleado.IdSexo == 1)
            {
                txtSexo.Text = "Femenino";
            }
            if (empleado.IdSexo == 2)
            {
                txtSexo.Text = "Masculino";
            }
            if (empleado.IdSexo == 3)
            {
                txtSexo.Text = "Otro";
            }

        }

        private void ModUsuario(Usuarios usuario)
        {
            

            txtNombreUsuario.Text = usuario.NombreDeUsuario;
            txtMail.Text = usuario.Email;

        }

        private void btnModEmpleado_Click(object sender, EventArgs e)
        {
            SeguroModificar window = new SeguroModificar();
            if (window.ShowDialog() == DialogResult.OK)
            {
                var resultado = new bool();


                lblNombreUsuario.Visible = false;
                lblEmail.Visible = false;
                lblNombre.Visible = false;
                lblEdad.Visible = false;
                lblApellido.Visible = false;
                lblSexo.Visible = false;



                bandera = true;

                bool flag = ErorresEnRojo(bandera);



                if (flag == true)
                {
                    string nombre = EmpleadosBD.UpperCaseFirstChar(txtNombre.Text);
                    string apellido = EmpleadosBD.UpperCaseFirstChar(txtApellido.Text);
                    string sexo = EmpleadosBD.UpperCaseFirstChar(txtSexo.Text);

                    empl.Nombre = nombre;
                    empl.Apellido = apellido;

                    empl.Edad = int.Parse(txtEdad.Text);


                    if (sexo == "Femenino")
                    {
                        empl.IdSexo = 1;
                    }
                    else if (sexo == "Masculino")
                    {
                        empl.IdSexo = 2;
                    }
                    else
                    {
                        empl.IdSexo = 3;
                    }




                    resultado = EmpleadosBD.modificarEmpleado(empl);

                    if (!resultado)
                    {
                        ErroresForm mensaje = new ErroresForm();
                        mensaje.show("Error al modificar el empleado");
                    }
                    else
                    {
                        CorrectoForm msj = new CorrectoForm();
                        msj.show("Empleado modificado exitosamente");
                    }
                }


            }





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
         
            if (txtNombre.Text.Equals("") && bandera == true)
            {
                lblNombre.Visible = true;
                lblNombre.Text = "Nombre obligatorio";
                flag = false;
            }
            if (txtApellido.Text.Equals("") && bandera == true)
            {
                lblApellido.Visible = true;
                lblApellido.Text = "Apellido obligatorio";
                flag = false;
            }
            if (txtEdad.Text.Equals("") && bandera == true)
            {
                lblEdad.Visible = true;
                lblEdad.Text = "Edad obligatoria";
                flag = false;
            }

            if (txtEdad.Text.Equals("") && bandera == true)
            {
                lblEdad.Visible = true;
                lblEdad.Text = "Edad obligatoria";
                flag = false;
            }

            if (txtSexo.Text.Equals("") && bandera == true)
            {
                lblEdad.Visible = true;
                lblEdad.Text = "Sexo obligatorio";
                flag = false;
            }

            return flag;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                lblNombre.Visible = true;
                lblNombre.Text = "Nombre obligatorio";
            }
            else { lblNombre.Visible = false; }
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            if (txtEdad.Text.Equals(""))
            {
                lblEdad.Visible = true;
                lblEdad.Text = "Edad obligatoria";
            }
            else { lblEdad.Visible = false; }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text.Equals(""))
            {
                lblApellido.Visible = true;
                lblApellido.Text = "Apellido Obligatorio";
            }
            else { lblEdad.Visible = false; }
        }

        private void txtSexo_TextChanged(object sender, EventArgs e)
        {
            if (txtSexo.Text.Equals(""))
            {
                lblSexo.Visible = true;
                lblSexo.Text = "Sexo obligatorio";
            }
            else { lblSexo.Visible = false; }

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

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            if (txtMail.Text.Equals(""))
            {
                lblEmail.Visible = true;
                lblEmail.Text = "Correo obligatorio";
            }
            else { lblEmail.Visible = false; }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            SeguroModificar window = new SeguroModificar();
            if (window.ShowDialog() == DialogResult.OK)
            {
                var resultado2 = new bool();

                string email = txtMail.Text;
                Regex regex = new Regex(@"^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-za-za-z]{2,3})+$");
                Match match = regex.Match(email);

                lblNombreUsuario.Visible = false;
                lblEmail.Visible = false;
                lblNombre.Visible = false;
                lblEdad.Visible = false;
                lblApellido.Visible = false;
                lblSexo.Visible = false;



                bandera = true;

                bool flag = ErorresEnRojo(bandera);
                bool flag2 = true;

                bool existeusuario = UsuarioBD.ValidarUsername(txtNombreUsuario.Text);
                bool existemail = UsuarioBD.ValidarEmail(txtMail.Text);
                bool mismousuario = false;
                bool mismomail = false;

                if (existeusuario && (txtNombreUsuario.Text == usu.NombreDeUsuario))
                {
                    mismousuario = true;
                }
                if (existemail && (txtMail.Text == usu.Email))
                {
                    mismomail = true;
                }


                if (existeusuario && existemail && !mismomail && !mismousuario)
                {
                    string error = "Campos incorrectos";
                    string errorAdicional = "El nombre de usuario ya se encuentra en uso \n " + "El mail ya se encuentra en uso";
                    MultiplesErrores ventana = new MultiplesErrores(error, errorAdicional);
                    ventana.Show();
                    flag2 = false;

                }

                else
                {
                    if (existeusuario == true & !mismousuario)
                    {
                        ErroresForm ventana = new ErroresForm();
                        ventana.show("El nombre de usuario ya se encuentra en uso");
                        flag2 = false;
                    }
                    if (existemail == true && !mismomail)
                    {
                        ErroresForm ventana = new ErroresForm();
                        ventana.show("El mail ya se encuentra en uso");
                        flag2 = false;
                    }
                }





                if (flag && flag2)
                {

                    if (match.Success)
                    {
                        usu.NombreDeUsuario = txtNombreUsuario.Text;
                        usu.Email = txtMail.Text;






                        resultado2 = EmpleadosBD.modificarUsuario(usu);

                        if (!resultado2)
                        {
                            ErroresForm mensaje = new ErroresForm();
                            mensaje.show("Error al modificar el usuario");
                        }
                        else
                        {
                            CorrectoForm msj = new CorrectoForm();
                            msj.show("Usuario modificado exitosamente");
                        }
                    }
                    else
                    {
                        ErroresForm ventana = new ErroresForm();
                        ventana.show("El formato del mail no es correcto");
                    }


                }

            }




        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblSexo_Click(object sender, EventArgs e)
        {

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCrearCuenta_Click(object sender, EventArgs e)
        {

        }

        private void chkEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEmpleado.Checked)
            {
                txtNombre.Enabled = true;
                txtApellido.Enabled = true;
                txtEdad.Enabled = true;
                txtSexo.Enabled = true;
                btnModEmpleado.Enabled = true;

            }
            else
            {

                txtNombre.Text = empl.Nombre;
                txtApellido.Text = empl.Apellido;
                txtEdad.Text = empl.Edad.ToString();

                if (empl.IdSexo == 1)
                {
                    txtSexo.Text = "Femenino";
                }
                if (empl.IdSexo == 2)
                {
                    txtSexo.Text = "Masculino";
                }
                if (empl.IdSexo == 3)
                {
                    txtSexo.Text = "Otro";
                }

                btnModEmpleado.Enabled = false;

            }

        }

        private void chkUsuario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUsuario.Checked)
            {
                txtNombreUsuario.Enabled = true;
                txtMail.Enabled = true;
                btnModificarUsuario.Enabled = true;

            }
            else
            {
                txtNombreUsuario.Enabled = false;
                txtMail.Enabled = false;



                txtNombreUsuario.Text = usu.NombreDeUsuario;

                txtMail.Text = usu.Email;
                



            }

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            ConsultaUsuarios ventana = new ConsultaUsuarios();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            consu.Show();
        }
    }
}
