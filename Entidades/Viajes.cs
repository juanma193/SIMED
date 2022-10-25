using System;
using System.Collections.Generic;
using System.Linq;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED.Models
{
    public partial class Viajes
    {
        public Viajes()
        {
            Enfermerosxviajes = new HashSet<Enfermerosxviajes>();
            Medicosxviajes = new HashSet<Medicosxviajes>();
        }

        public DateTime Fecha { get; set; }
        public int IdMovil { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public int IdTurnoRotativo { get; set; }
        public int IdTipoViaje { get; set; }
        public TimeSpan HoraLlegada { get; set; }
        public double CantCombustiblePrevio { get; set; }
        public double CantCombustiblePost { get; set; }
        public double KilometrosRealizados { get; set; }

        public virtual Ambulancias IdMovilNavigation { get; set; }
        public virtual TiposViaje IdTipoViajeNavigation { get; set; }
        public virtual TurnosRotativos IdTurnoRotativoNavigation { get; set; }
        public virtual ICollection<Enfermerosxviajes> Enfermerosxviajes { get; set; }
        public virtual ICollection<Medicosxviajes> Medicosxviajes { get; set; }

        
    }
}
