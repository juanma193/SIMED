using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED.Models
{
    public partial class TurnosPuntoAPunto
    {
        public int NumeroAfiliado { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraDelTurno { get; set; }
        public int IdBarrioDestino { get; set; }
        public int IdBarrioOrigen { get; set; }
        public int IdMovil { get; set; }
        public string CalleDestino { get; set; }
        public int NroCalleDestino { get; set; }
        public string CalleOrigen { get; set; }
        public int NroCalleOrigen { get; set; }

        public virtual Barrios IdBarrioDestinoNavigation { get; set; }
        public virtual Barrios IdBarrioOrigenNavigation { get; set; }
        public virtual Ambulancias IdMovilNavigation { get; set; }
        public virtual Afiliados NumeroAfiliadoNavigation { get; set; }
    }
}
