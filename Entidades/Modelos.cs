using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED_V1.Entidades
{
    public partial class Modelos
    {
        public Modelos()
        {
            Ambulancias = new HashSet<Ambulancias>();
        }

        public int IdModelo { get; set; }
        public string NombreModelo { get; set; }
        public int IdMarca { get; set; }

        public virtual Marcas IdMarcaNavigation { get; set; }
        public virtual ICollection<Ambulancias> Ambulancias { get; set; }
    }
}
