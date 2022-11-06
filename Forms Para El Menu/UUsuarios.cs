using SIMED_V1.Entidades;
using SIMED_V1.Forms_Para_ABM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMED_V1
{
    public partial class UUsuarios : UserControl
    {
        Usuarios usuario = new Usuarios();
        PrincipalForm principalmenu;
        public UUsuarios(Usuarios usu, PrincipalForm menuprincipal)
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (usuario.IdPerfil == 1)
            {
                ConsultaUsuarios ventana = new ConsultaUsuarios();
                ventana.Show();
            }
            else
            {
                 ConsultarUsuarioNoAdmin ventana = new ConsultarUsuarioNoAdmin(usuario,principalmenu);
                 ventana.Show();
            }
            
            
        }
    }
}
