using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED.Models
{
    public partial class RangosEtarios
    {
        public RangosEtarios()
        {
            Planes = new HashSet<Planes>();
        }

        public int IdRangoEtario { get; set; }
        public string DescripcionRangoEtario { get; set; }

        public virtual ICollection<Planes> Planes { get; set; }
    }
}
