using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED.Models
{
    public partial class TiposViaje
    {
        public TiposViaje()
        {
            Viajes = new HashSet<Viajes>();
        }

        public int IdTipoViaje { get; set; }
        public string DescripcionTipoViaje { get; set; }

        public virtual ICollection<Viajes> Viajes { get; set; }
    }
}
