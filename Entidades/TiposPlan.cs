using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED.Models
{
    public partial class TiposPlan
    {
        public TiposPlan()
        {
            Planes = new HashSet<Planes>();
        }

        public int IdTipoPlan { get; set; }
        public string DescripcionTipoPlan { get; set; }
        public int CantAtenConsultorios { get; set; }
        public int CantAsistAmbulanciaDomicilio { get; set; }
        public int CantVistasDomiciliarias { get; set; }
        public int CantTrasladosProgramados { get; set; }

        public virtual ICollection<Planes> Planes { get; set; }
    }
}
