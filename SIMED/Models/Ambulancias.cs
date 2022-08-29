using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED.Models
{
    public partial class Ambulancias
    {
        public Ambulancias()
        {
            TurnosPuntoAPunto = new HashSet<TurnosPuntoAPunto>();
            Viajes = new HashSet<Viajes>();
        }

        public int IdMovil { get; set; }
        public string Patente { get; set; }
        public int IdModelo { get; set; }
        public int IdCategoria { get; set; }

        public virtual Categorias IdCategoriaNavigation { get; set; }
        public virtual Modelos IdModeloNavigation { get; set; }
        public virtual ICollection<TurnosPuntoAPunto> TurnosPuntoAPunto { get; set; }
        public virtual ICollection<Viajes> Viajes { get; set; }
    }
}
