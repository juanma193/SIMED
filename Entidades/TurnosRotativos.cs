using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED_V1.Entidades
{
    public partial class TurnosRotativos
    {
        public TurnosRotativos()
        {
            TurnosRotativosxEnfermeros = new HashSet<TurnosRotativosxEnfermeros>();
            Viajes = new HashSet<Viajes>();
        }

        public int IdTurnoRotativo { get; set; }
        public string DescripcionTurnoRotativo { get; set; }

        public virtual ICollection<TurnosRotativosxEnfermeros> TurnosRotativosxEnfermeros { get; set; }
        public virtual ICollection<Viajes> Viajes { get; set; }
    }
}
