using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED.Models
{
    public partial class ObrasSociales
    {
        public ObrasSociales()
        {
            TurnosEnConsultorio = new HashSet<TurnosEnConsultorio>();
        }

        public int IdObraSocial { get; set; }
        public string DescripcionObraSocial { get; set; }
        public int DescuentoPorServicio { get; set; }

        public virtual ICollection<TurnosEnConsultorio> TurnosEnConsultorio { get; set; }
    }
}
