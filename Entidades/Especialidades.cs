using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED_V1.Entidades
{
    public partial class Especialidades
    {
        public Especialidades()
        {
            Medicos = new HashSet<Medicos>();
            TarifasxServicios = new HashSet<TarifasxServicios>();
        }

        public int IdEspecialidad { get; set; }
        public string DescripcionEspecialidad { get; set; }

        public virtual ICollection<Medicos> Medicos { get; set; }
        public virtual ICollection<TarifasxServicios> TarifasxServicios { get; set; }
    }
}
