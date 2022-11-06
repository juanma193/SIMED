using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED_V1.Entidades
{
    public partial class TurnosRotativosxEnfermeros
    {
        public int NumeroMatriculaEnfermero { get; set; }
        public DateTime Fecha { get; set; }
        public int IdTurnoRotativo { get; set; }

        public virtual TurnosRotativos IdTurnoRotativoNavigation { get; set; }
        public virtual Enfermeros NumeroMatriculaEnfermeroNavigation { get; set; }
    }
}
