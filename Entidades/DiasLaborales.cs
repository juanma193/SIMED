using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED.Models
{
    public partial class DiasLaborales
    {
        public DiasLaborales()
        {
            Medicos = new HashSet<Medicos>();
            MedicosxDiasLaborales = new HashSet<MedicosxDiasLaborales>();
        }

        public int IdDiaLaboral { get; set; }
        public string DescripcionDiaLaboral { get; set; }

        public virtual ICollection<Medicos> Medicos { get; set; }
        public virtual ICollection<MedicosxDiasLaborales> MedicosxDiasLaborales { get; set; }
    }
}
