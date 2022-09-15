using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED.Models
{
    public partial class Medicosxviajes
    {
        public int NumeroMatriculaMedico { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public int IdMovil { get; set; }

        public virtual Medicos NumeroMatriculaMedicoNavigation { get; set; }
        public virtual Viajes Viajes { get; set; }
    }
}
