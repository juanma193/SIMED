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
    
    public partial class ConsultarUsuarioNoAdmin : Form
    {
        Usuarios usuario = new Usuarios();
        Empleados empl = new Empleados();
        PrincipalForm principalmenu;
        bool cambios = false;
        public ConsultarUsuarioNoAdmin(Usuarios usu, PrincipalForm menuprincipal)
        {
            InitializeComponent();
            usuario.NombreDeUsuario = usu.NombreDeUsuario;
            usuario.IdUsuario = usu.IdUsuario;
            usuario.Contraseña = usu.Contraseña;
            usuario.Email = usu.Email;
            usuario.IdPerfil = usu.IdPerfil;
            usuario.LegajoEmpleado = usu.LegajoEmpleado;
            principalmenu = menuprincipal;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ConsultarUsuarioNoAdmin_Load(object sender, EventArgs e)
        {
            lblNombreUsuario.Visible = false;
            lblMail.Visible = false;

            lblErrorNombre.Visible = false;
            lblErrorEdad.Visible = false;
            lblErrorApellido.Visible = false;
            lblErrorSexo.Visible = false;

            txtNombreUsu.Enabled = false;

            txtCorreo.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtEdad.Enabled = false;
            txtSexo.Enabled = false;

            txtNombreUsu.Text = usuario.NombreDeUsuario;

            txtCorreo.Text = usuario.Email;



            int legajo = usuario.LegajoEmpleado;

            empl = EmpleadosBD.obtenerEmpleado(legajo);

            txtNombre.Text = empl.Nombre;
            txtApellido.Text = empl.Apellido;
            txtEdad.Text = empl.Edad.ToString();

            if (empl.IdSexo == 1)
            {
                txtSexo.Text = "Femnino";
            }
            else if (empl.IdSexo == 2)
            {
                txtSexo.Text = "Masculino";
            }
            else
            {
                txtSexo.Text = "Otro";
            }
            btnModificarEmpleado.Enabled = false;
            cambios = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblErrorEdad_Click(object sender, EventArgs e)
        {

        }

        private void lblErrorSexo_Click(object sender, EventArgs e)
        {

        }

        private void lblErrorApellido_Click(object sender, EventArgs e)
        {

        }

        private void lblErrorNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblMail_Click(object sender, EventArgs e)
        {

        }
        private void lblEdad_Click(object sender, EventArgs e)
        {

        }

        private void lblSexo_Click(object sender, EventArgs e)
        {

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
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
                btnModificarEmpleado.Enabled = true;

            }
            else
            {

                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                txtEdad.Enabled = false;
                txtSexo.Enabled = false;


                Empleados empl = new Empleados();

                int legajo = usuario.LegajoEmpleado;

                empl = EmpleadosBD.obtenerEmpleado(legajo);

                txtNombre.Text = empl.Nombre;
                txtApellido.Text = empl.Apellido;
                txtEdad.Text = empl.Edad.ToString();

                if (empl.IdSexo == 1)
                {
                    txtSexo.Text = "Femnino";
                }
                else if (empl.IdSexo == 2)
                {
                    txtSexo.Text = "Masculino";
                }
                else
                {
                    txtSexo.Text = "Otro";
                }

                if (!chkUsuarios.Checked)
                {
                    btnModificarEmpleado.Enabled = false;

                }

            }
        }

        private void txtNombreUsu_TextChanged(object sender, EventArgs e)
        {
            cambios = true;
            if (txtNombreUsu.Text.Equals(""))
            {
                lblNombreUsuario.Visible = true;
                lblNombreUsuario.Text = "Nombre de usuario obligatorio";
            }
            else { lblNombreUsuario.Visible = false; }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            cambios = true;
            if (txtCorreo.Text.Equals(""))
            {
                lblMail.Visible = true;
                lblMail.Text = "Correo obligatorio";
            }
            else { lblMail.Visible = false; }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            cambios = true;
            if (txtNombre.Text.Equals(""))
            {
                lblErrorNombre.Visible = true;
                lblErrorNombre.Text = "Nombre obligatorio";
            }
            else { lblErrorNombre.Visible = false; }

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            cambios = true;
            if (txtApellido.Text.Equals(""))
            {
                lblErrorApellido.Visible = true;
                lblErrorApellido.Text = "Apellido obligatorio";
            }
            else { lblErrorApellido.Visible = false; }

        }
        private void txtSexo_TextChanged(object sender, EventArgs e)
        {
            cambios = true;
            if (txtSexo.Text.Equals(""))
            {
                lblErrorSexo.Visible = true;
                lblErrorSexo.Text = "Sexo obligatorio";
            }
            else { lblErrorSexo.Visible = false; }

        }
        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            cambios = true;
            if (txtEdad.Text.Equals(""))
            {
                lblErrorEdad.Visible = true;
                lblErrorEdad.Text = "Edad obligatoria";
            }
            else 
            { 
                lblErrorEdad.Visible = false;

                int edad = int.Parse(txtEdad.Text);
                txtEdad.MaxLength = 3;

                if (edad < 18 || edad > 80)
                {
                    lblErrorEdad.Visible = true;
                    lblErrorEdad.Text = "Edad no permitida. Mínima 18, máxima 80";

                }

            }

        }


        private bool ErorresEnRojo(bool bandera)
        {
            bool flag = true;

            if (txtNombreUsu.Text.Equals("") && bandera == true)
            {
                lblNombreUsuario.Visible = true;
                lblNombreUsuario.Text = "Nombre de usuario obligatorio";
                flag = false;
            }
            if (txtCorreo.Text.Equals("") && bandera == true)
            {
                lblMail.Visible = true;
                lblMail.Text = "Correo obligatorio";
                flag = false;
            }

            if (txtNombre.Text.Equals("") && bandera == true)
            {
                lblErrorNombre.Visible = true;
                lblErrorNombre.Text = "Nombre obligatorio";
                flag = false;
            }
            if (txtApellido.Text.Equals("") && bandera == true)
            {
                lblErrorApellido.Visible = true;
                lblErrorApellido.Text = "Apellido obligatorio";
                flag = false;
            }
            if (txtEdad.Text.Equals("") && bandera == true)
            {
                lblErrorEdad.Visible = true;
                lblErrorEdad.Text = "Edad obligatoria";
                flag = false;
            }



            if (txtSexo.Text.Equals("") && bandera == true)
            {
                lblErrorSexo.Visible = true;
                lblErrorSexo.Text = "Sexo obligatorio";
                flag = false;
            }

            return flag;
        }


        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            bool bandera = true;

            bool flag = true;
            flag = ErorresEnRojo(bandera);
            if (flag)
            {
                SeguroModificar window = new SeguroModificar();
                if (window.ShowDialog() == DialogResult.OK)
                {
                    window.Dispose();
                    var resultado = new bool();


                    bool modusuario = false;
                    bool modempleado = false;

                    lblNombreUsuario.Visible = false;
                    lblMail.Visible = false;

                    lblErrorNombre.Visible = false;
                    lblErrorEdad.Visible = false;
                    lblErrorApellido.Visible = false;
                    lblErrorSexo.Visible = false;







                    if (flag == true && chkEmpleado.Checked)
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
                            modempleado = false;

                        }
                        else
                        {

                            modempleado = true;
                        }

                    }

                    if (chkUsuarios.Checked)
                    {
                        resultado = EmpleadosBD.modificarEmpleado(empl);

                        var resultado2 = new bool();


                        string email = txtCorreo.Text;
                        Regex regex = new Regex(@"^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-za-za-z]{2,3})+$");
                        Match match = regex.Match(email);

                        lblNombreUsuario.Visible = false;
                        lblMail.Visible = false;
                        lblErrorNombre.Visible = false;
                        lblErrorEdad.Visible = false;
                        lblErrorApellido.Visible = false;
                        lblErrorSexo.Visible = false;



                        bandera = true;

                        bool flag2 = ErorresEnRojo(bandera);
                        bool flag3 = true;

                        bool existeusuario = UsuarioBD.ValidarUsername(txtNombreUsu.Text);
                        bool existemail = UsuarioBD.ValidarEmail(txtCorreo.Text);
                        bool mismousuario = false;
                        bool mismomail = false;

                        if (existeusuario && (txtNombreUsu.Text == usuario.NombreDeUsuario))
                        {
                            mismousuario = true;
                        }
                        if (existemail && (txtCorreo.Text == usuario.Email))
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
                            if (existeusuario == true && !mismousuario)
                            {
                                ErroresForm ventana = new ErroresForm();
                                ventana.show("El nombre de usuario ya se encuentra en uso");
                                flag2 = false;
                            }
                            if (existemail == true && !mismomail)
                            {
                                ErroresForm ventana = new ErroresForm();
                                ventana.show("El mail ya se encuentra en uso");
                                flag3 = false;
                            }
                        }





                        if (flag2 && flag3)
                        {

                            if (match.Success)
                            {
                                usuario.NombreDeUsuario = txtNombreUsu.Text;
                                usuario.Email = txtCorreo.Text;






                                resultado2 = EmpleadosBD.modificarUsuario(usuario);


                                if (!resultado2 || !resultado)
                                {

                                    modusuario = false;
                                }
                                else
                                {

                                    modusuario = true;
                                }
                            }
                            else
                            {
                                ErroresForm ventana = new ErroresForm();
                                ventana.show("El formato del mail no es correcto");
                            }
                        }


                    }

                    if (modempleado && modusuario)
                    {
                        CorrectoForm msj = new CorrectoForm();
                        msj.show("Su usuario y sus datos fueron modificados correctamente");
                    }
                    else
                    {

                        if (modempleado)
                        {
                            CorrectoForm msj = new CorrectoForm();
                            msj.show("Sus datos fueron modificados correctamente");
                        }
                        if (modusuario)
                        {
                            CorrectoForm msj = new CorrectoForm();
                            msj.show("Su usuario fue modificado correctamente");
                        }


                    }


                    if (!modusuario && !modempleado)
                    {
                        ErroresForm mensaje = new ErroresForm();
                        mensaje.show("Error al modificar el empleado");
                    }
                    else
                    {
                        if (!modusuario && chkUsuarios.Checked)
                        {
                            ErroresForm mensaje = new ErroresForm();
                            mensaje.show("Error al modificar el usuario");
                        }
                        if (!modempleado && chkEmpleado.Checked)
                        {
                            ErroresForm mensaje = new ErroresForm();
                            mensaje.show("Error al modificar el empleado");
                        }
                    }
                }

            }








        }
        private bool ErorrEnRojo(bool bandera)
        {
            bool flag = true;

            if (txtNombreUsu.Text.Equals("") && bandera == true)
            {
                lblNombreUsuario.Visible = true;
                lblNombreUsuario.Text = "Nombre de usuario obligatorio";
                flag = false;
            }
            if (txtCorreo.Text.Equals("") && bandera == true)
            {
                lblMail.Visible = true;
                lblMail.Text = "Correo obligatorio";
                flag = false;
            }

            if (txtNombre.Text.Equals("") && bandera == true)
            {
                lblErrorNombre.Visible = true;
                lblErrorNombre.Text = "Nombre obligatorio";
                flag = false;
            }
            if (txtApellido.Text.Equals("") && bandera == true)
            {
                lblErrorApellido.Visible = true;
                lblErrorApellido.Text = "Nombre obligatorio";
                flag = false;
            }
            if (txtEdad.Text.Equals("") && bandera == true)
            {
                lblErrorEdad.Visible = true;
                lblErrorEdad.Text = "Edad obligatoria";
                flag = false;
            }

            return flag;

        }
        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void chkUsuarios_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUsuarios.Checked)
            {
                txtNombreUsu.Enabled = true;
                txtCorreo.Enabled = true;
                btnModificarEmpleado.Enabled = true;

            }
            else
            {
                txtNombreUsu.Enabled = false;
                txtCorreo.Enabled = false;



                txtNombreUsu.Text = usuario.NombreDeUsuario;

                txtCorreo.Text = usuario.Email;
                if (!chkEmpleado.Checked)
                {
                    btnModificarEmpleado.Enabled = false;

                }
              


            }
        }

        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            SeguroEliminar window = new SeguroEliminar();
            

            if (window.ShowDialog() == DialogResult.OK)
            {
                if (chkEmpleado.Checked || chkUsuarios.Checked)
                {
                    chkEmpleado.Checked = false;
                    chkUsuarios.Checked = false;
                    bool resultado2 = EmpleadosBD.eliminarUsuario(usuario.IdUsuario);
                    bool resultado = EmpleadosBD.eliminarEmpleado(usuario.LegajoEmpleado);


                    if (!resultado || !resultado2)
                    {
                        ErroresForm mensaje = new ErroresForm();
                        mensaje.show("Error al eliminar el usuario");
                    }
                    else
                    {
                        CorrectoForm msj = new CorrectoForm();
                        msj.show("Usuario eliminado exitosamente");
                        this.Close();
                        principalmenu.Close();
                        LoginUsuarios ventana = new LoginUsuarios();
                        ventana.Show();



                    }
                }
                else
                {
                    bool resultado2 = EmpleadosBD.eliminarUsuario(usuario.IdUsuario);
                    bool resultado = EmpleadosBD.eliminarEmpleado(usuario.LegajoEmpleado);


                    if (!resultado || !resultado2)
                    {
                        ErroresForm mensaje = new ErroresForm();
                        mensaje.show("Error al eliminar el usuario");
                    }
                    else
                    {
                        CorrectoForm msj = new CorrectoForm();
                        msj.show("Usuario eliminado exitosamente");
                        this.Close();
                        principalmenu.Close();
                        LoginUsuarios ventana = new LoginUsuarios();
                        ventana.Show();


                    }
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

        private void txtSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) e.Handled = false;
            else
            {
                if (e.KeyChar == '\b') e.Handled = false; //Tecla de borrado
                else
                {
                    if ((e.KeyChar == '-' || e.KeyChar == '.' || e.KeyChar == '_' || e.KeyChar == ',' || e.KeyChar == ';') || Char.IsDigit(e.KeyChar)) e.Handled = true;
                    else if (char.IsSeparator(e.KeyChar)) e.Handled = true;
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

        private void txtNombreUsu_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar)) e.Handled = true;
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
    }
}
