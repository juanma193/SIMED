using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED_V1.Entidades
{
    public partial class Barrios
    {
        public Barrios()
        {
            Afiliados = new HashSet<Afiliados>();
            Enfermeros = new HashSet<Enfermeros>();
            Medicos = new HashSet<Medicos>();
            TurnosPuntoAPuntoIdBarrioDestinoNavigation = new HashSet<TurnosPuntoAPunto>();
            TurnosPuntoAPuntoIdBarrioOrigenNavigation = new HashSet<TurnosPuntoAPunto>();
        }

        public int IdBarrio { get; set; }
        public int IdCiudad { get; set; }
        public string NombreBarrio { get; set; }

        public virtual Ciudades IdCiudadNavigation { get; set; }
        public virtual ICollection<Afiliados> Afiliados { get; set; }
        public virtual ICollection<Enfermeros> Enfermeros { get; set; }
        public virtual ICollection<Medicos> Medicos { get; set; }
        public virtual ICollection<TurnosPuntoAPunto> TurnosPuntoAPuntoIdBarrioDestinoNavigation { get; set; }
        public virtual ICollection<TurnosPuntoAPunto> TurnosPuntoAPuntoIdBarrioOrigenNavigation { get; set; }
    }
}
