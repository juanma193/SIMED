using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED_V1.Entidades
{
    public partial class MedicosxDiasLaborales
    {
        public int NumeroMatricula { get; set; }
        public int IdDiaLaboral { get; set; }

        public virtual DiasLaborales IdDiaLaboralNavigation { get; set; }
        public virtual Medicos NumeroMatriculaNavigation { get; set; }
    }
}
