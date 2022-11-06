using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED_V1.Entidades
{
    public partial class Planes
    {
        public Planes()
        {
            Afiliados = new HashSet<Afiliados>();
        }

        public int IdPlan { get; set; }
        public string NombrePlan { get; set; }
        public int IdTipoPlan { get; set; }
        public double Precio { get; set; }
        public int IdRangoEtario { get; set; }

        public virtual RangosEtarios IdRangoEtarioNavigation { get; set; }
        public virtual TiposPlan IdTipoPlanNavigation { get; set; }
        public virtual ICollection<Afiliados> Afiliados { get; set; }
    }
}
