using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMED_V1.Entidades
{
    public class Usuarios
    {
        private string NombreUsu;
        private string Pass;
        private string Email;

        public Usuarios(string nombreUsuario, string passowrd, string email)
        { 
            NombreUsu = nombreUsuario;
            Pass = passowrd;
            Email = email;

        }
        public string NombreDeUsuario
        { 
            get => NombreUsu;
            set => NombreUsu = value;
        }

        public string Password
        {
            get => Pass;
            set => Pass = value;
        }

        public string Correo
        {
            get => Email;
            set => Email = value;
        }
    }
}
