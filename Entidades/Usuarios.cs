using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED.Models
{
    public partial class Usuarios
    {
        public int IdUsuario { get; set; }
        public string NombreDeUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Email { get; set; }
        public int LegajoEmpleado { get; set; }
        public int IdPerfil { get; set; }

        public virtual Perfiles IdPerfilNavigation { get; set; }
        public virtual Empleados LegajoEmpleadoNavigation { get; set; }

        
    }
}
