using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED.Models
{
    public partial class Enfermeros
    {
        public Enfermeros()
        {
            Enfermerosxviajes = new HashSet<Enfermerosxviajes>();
            TurnosRotativosxEnfermeros = new HashSet<TurnosRotativosxEnfermeros>();
        }

        public int NumeroMatricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Telefono { get; set; }
        public int NumeroDocumento { get; set; }
        public int IdTipoDocumento { get; set; }
        public int? IdEspecialidad { get; set; }
        public string Calle { get; set; }
        public int NroCalle { get; set; }
        public int IdBarrio { get; set; }

        public virtual Barrios IdBarrioNavigation { get; set; }
        public virtual TiposDocumentos IdTipoDocumentoNavigation { get; set; }
        public virtual ICollection<Enfermerosxviajes> Enfermerosxviajes { get; set; }
        public virtual ICollection<TurnosRotativosxEnfermeros> TurnosRotativosxEnfermeros { get; set; }
    }
}
