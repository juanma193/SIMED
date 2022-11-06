using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED_V1.Entidades
{
    public partial class Empleados
    {
        public Empleados()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public int IdSexo { get; set; }
        public int Legajo { get; set; }

        public virtual Sexos IdSexoNavigation { get; set; }
        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
