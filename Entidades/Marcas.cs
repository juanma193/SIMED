using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED_V1.Entidades
{
    public partial class Marcas
    {
        public Marcas()
        {
            Modelos = new HashSet<Modelos>();
        }

        public int IdMarca { get; set; }
        public string NombreMarca { get; set; }

        public virtual ICollection<Modelos> Modelos { get; set; }
    }
}
