using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED_V1.Entidades
{
    public partial class Ciudades
    {
        public Ciudades()
        {
            Barrios = new HashSet<Barrios>();
        }

        public int IdCiudad { get; set; }
        public string DescripcionCiudad { get; set; }

        public virtual ICollection<Barrios> Barrios { get; set; }
    }
}
