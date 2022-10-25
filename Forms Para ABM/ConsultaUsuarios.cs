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
    public partial class ConsultaUsuarios : Form
    {
        int indice = -1;
       

        public ConsultaUsuarios()
        {
            InitializeComponent();
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

        private void ConsultaUsuarios_Load(object sender, EventArgs e)
        {

            MostrarTodo();
        }

        private void MostrarTodo()
        {
            var resultadoUsuarios = new List<Usuarios>();

            DataGridViewRow fila = new DataGridViewRow();
            var empleados = EmpleadosBD.getTodo();

            foreach (var empleado in empleados)
            {
                var users = EmpleadosBD.getUsuariosDesdeEmpleado(empleado.Legajo);

                resultadoUsuarios.AddRange(users);

            }
            int cont = 0;

            foreach (var empleado in empleados)
            {
                fila = AgregarEmpleado(empleado);

                foreach (var usuario in resultadoUsuarios)
                {

                    AgregarUsuariosDesdeEmpleados(resultadoUsuarios[cont], fila);
                    cont++;
                    break;

                }
            }

        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {

            gbUsuarios.Rows.Clear();

            var resultado = new List<Empleados>();
            DataGridViewRow fila = new DataGridViewRow();

            var usuarios = EmpleadosBD.getUsuarios(txtNombreUsu.Text, txtCorreo.Text);

            foreach (var usuario in usuarios)
            {
                var empleados = EmpleadosBD.getEmpleadosDesdeUsuarios(usuario.LegajoEmpleado);

                resultado.AddRange(empleados);

            }
            int cont = 0;

            foreach (var usuario in usuarios)
            {
                fila = AgregarUsuarios(usuario);

                foreach (var empleado in resultado)
                 {

                    AgregarEmpleadosDesdeUsuarios(resultado[cont], fila);
                    cont++;
                   break;

                 }
            }

        }

        private DataGridViewRow AgregarEmpleado(Empleados empleado)
        {
            DataGridViewRow fila = new DataGridViewRow();

            DataGridViewTextBoxCell celdaLegajo = new DataGridViewTextBoxCell();
            celdaLegajo.Value = empleado.Legajo;
            fila.Cells.Add(celdaLegajo);

            DataGridViewTextBoxCell celdaNombre = new DataGridViewTextBoxCell();
            celdaNombre.Value = empleado.Nombre;
            fila.Cells.Add(celdaNombre);

            DataGridViewTextBoxCell celdaApellido = new DataGridViewTextBoxCell();
            celdaApellido.Value = empleado.Apellido;
            fila.Cells.Add(celdaApellido);

            DataGridViewTextBoxCell celdaEdad = new DataGridViewTextBoxCell();
            celdaEdad.Value = empleado.Edad;
            fila.Cells.Add(celdaEdad);

            DataGridViewTextBoxCell celdaSexo = new DataGridViewTextBoxCell();
            if (empleado.IdSexo == 1)
            {
                celdaSexo.Value = "Femenino";
                fila.Cells.Add(celdaSexo);
            }
            else if (empleado.IdSexo == 2)
            {
                celdaSexo.Value = "Masculino";
                fila.Cells.Add(celdaSexo);
            }
            else
            {
                celdaSexo.Value = "Otro";
                fila.Cells.Add(celdaSexo);
            }

            


            gbUsuarios.Rows.Add(fila);

            return fila;
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            gbUsuarios.Rows.Clear();

            var resultado = new List<Usuarios>();
            DataGridViewRow fila = new DataGridViewRow();

            var empleados = EmpleadosBD.getEmpleados(txtNombre.Text, txtApellido.Text);

            foreach (var empleado in empleados)
            {
                var users = EmpleadosBD.getUsuariosDesdeEmpleado(empleado.Legajo);

                resultado.AddRange(users);

            }
            int cont = 0;

            foreach (var empleado in empleados)
            {
                fila = AgregarEmpleado(empleado);

                foreach (var usuario in resultado)
                {

                    AgregarUsuariosDesdeEmpleados(resultado[cont], fila);
                    cont++;
                    break;
                    
                }
            }
        }

      

        private DataGridViewRow AgregarUsuarios(Usuarios usuario)
        {
            DataGridViewRow fila = new DataGridViewRow();
            int nulo = 0;

            DataGridViewTextBoxCell celdaLegajo = new DataGridViewTextBoxCell();
            celdaLegajo.Value = nulo;
            fila.Cells.Add(celdaLegajo);

            DataGridViewTextBoxCell celdaNombre = new DataGridViewTextBoxCell();
            celdaNombre.Value = nulo;
            fila.Cells.Add(celdaNombre);

            DataGridViewTextBoxCell celdaApellido = new DataGridViewTextBoxCell();
            celdaApellido.Value = nulo;
            fila.Cells.Add(celdaApellido);

            DataGridViewTextBoxCell celdaEdad = new DataGridViewTextBoxCell();
            celdaEdad.Value = nulo;
            fila.Cells.Add(celdaEdad);

            DataGridViewTextBoxCell celdaSexo = new DataGridViewTextBoxCell();
                celdaSexo.Value = nulo;
                fila.Cells.Add(celdaSexo);


            DataGridViewTextBoxCell celdaIdUsuario = new DataGridViewTextBoxCell();
            celdaIdUsuario.Value = usuario.IdUsuario;
            fila.Cells.Add(celdaIdUsuario);

            DataGridViewTextBoxCell celdaNombreUsuario = new DataGridViewTextBoxCell();
            celdaNombreUsuario.Value = usuario.NombreDeUsuario;
            fila.Cells.Add(celdaNombreUsuario);

            DataGridViewTextBoxCell celdaEmail = new DataGridViewTextBoxCell();
            celdaEmail.Value = usuario.Email;
            fila.Cells.Add(celdaEmail);





            gbUsuarios.Rows.Add(fila);

            return fila;
        }

        private void AgregarUsuariosDesdeEmpleados(Usuarios usuario, DataGridViewRow fila)
        {
            fila.Cells[5].Value = usuario.IdUsuario;
            fila.Cells[6].Value = usuario.NombreDeUsuario;
            fila.Cells[7].Value = usuario.Email;
        }

        private void AgregarEmpleadosDesdeUsuarios(Empleados empleado, DataGridViewRow fila)
        {
            fila.Cells[0].Value = empleado.Legajo;
            fila.Cells[1].Value = empleado.Nombre;
            fila.Cells[2].Value = empleado.Apellido;
            fila.Cells[3].Value = empleado.Edad;

            if (empleado.IdSexo == 1)
            {
                fila.Cells[4].Value = "Femenino";
            }
            else if (empleado.IdSexo == 2)
            {
                fila.Cells[4].Value = "Masculino";
            }
            else
            {
                fila.Cells[4].Value = "Otro";
            }
        }



        

        private void btnModificarEmpleado_Click_1(object sender, EventArgs e)
        {
            SeguroModificar window = new SeguroModificar();
            
           
            if (window.ShowDialog() == DialogResult.OK)
            {
                if (indice >= 0)
                {
                    DataGridViewRow filaSeleccionada = gbUsuarios.Rows[indice];
                    int legajo = int.Parse(filaSeleccionada.Cells["Legajo"].Value.ToString());
                    Empleados empleado = EmpleadosBD.obtenerEmpleado(legajo);

                    DataGridViewRow filaSeleccionada2 = gbUsuarios.Rows[indice];
                    int id = int.Parse(filaSeleccionada2.Cells["IdUsuario"].Value.ToString());
                    Usuarios usuario = EmpleadosBD.obtenerUsuario(id);

                    ConsultaUsuarios cons = this;

                    ModificarEmpleado ventana = new ModificarEmpleado(empleado, usuario, cons);
                    ventana.Show();
                    this.Hide();
                }
                else
                {
                    ErroresForm mensaje = new ErroresForm();
                    mensaje.show("Seleccione un usuario");
                }
            }
            
            
        }

        private void gbUsuarios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice.Equals(-1))
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Seleccione una celda válida");
            }
            }

        private void btnElminar_Click(object sender, EventArgs e)
        {
           SeguroEliminar window = new SeguroEliminar();
           
            if (window.ShowDialog() == DialogResult.OK)
            {
                if (indice >= 0)
                {
                    DataGridViewRow filaSeleccionada2 = gbUsuarios.Rows[indice];
                    int id = int.Parse(filaSeleccionada2.Cells["IdUsuario"].Value.ToString());
                    bool resultado2 = EmpleadosBD.eliminarUsuario(id);

                    DataGridViewRow filaSeleccionada = gbUsuarios.Rows[indice];
                    int legajo = int.Parse(filaSeleccionada.Cells["Legajo"].Value.ToString());
                    bool resultado = EmpleadosBD.eliminarEmpleado(legajo);



                    if (!resultado || !resultado2)
                    {
                        ErroresForm mensaje = new ErroresForm();
                        mensaje.show("Error al eliminar el usuario");
                    }
                    else
                    {
                        CorrectoForm msj = new CorrectoForm();
                        msj.show("Usuario eliminado exitosamente");
                    }

                }
                else
                {
                    ErroresForm mensaje = new ErroresForm();
                    mensaje.show("Seleccione un afiliado");
                }
            }
            
            
        }

        private void todoVacio()
        { 
            

            if (txtNombreUsu.Text == "" && txtCorreo.Text == "" && txtNombre.Text == "" && txtApellido.Text == "" && txtNombre.Text == "" && txtApellido.Text == "" )
            {
                MostrarTodo();
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

        private void txtNombreUsu_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                todoVacio();
            }

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                todoVacio();
            }

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                todoVacio();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar)) e.Handled = true;
        
    }

        private void lblConsultarEnfermero_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {

        }

        private void gbUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {

        }
    }
}
