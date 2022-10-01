using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED.Models
{
    public partial class TiposDocumentos
    {
        public TiposDocumentos()
        {
            Afiliados = new HashSet<Afiliados>();
            Enfermeros = new HashSet<Enfermeros>();
            Medicos = new HashSet<Medicos>();
        }

        public int IdTipoDocumento { get; set; }
        public string DescripcionTipoDocumento { get; set; }

        public virtual ICollection<Afiliados> Afiliados { get; set; }
        public virtual ICollection<Enfermeros> Enfermeros { get; set; }
        public virtual ICollection<Medicos> Medicos { get; set; }
    }
}
