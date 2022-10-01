using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED.Models
{
    public partial class RelacionesLaborales
    {
        public RelacionesLaborales()
        {
            Medicos = new HashSet<Medicos>();
        }

        public int IdRelacionLaboral { get; set; }
        public string DescripcionRelacionLaboral { get; set; }

        public virtual ICollection<Medicos> Medicos { get; set; }
    }
}
