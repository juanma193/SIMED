using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED.Models
{
    public partial class Afiliados
    {
        public Afiliados()
        {
            Bajas = new HashSet<Bajas>();
            Facturas = new HashSet<Facturas>();
            TurnosEnConsultorio = new HashSet<TurnosEnConsultorio>();
            TurnosPuntoAPunto = new HashSet<TurnosPuntoAPunto>();
        }

        public int NumeroAfiliado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IdSexo { get; set; }
        public long NumeroDocumento { get; set; }
        public int IdTipoDocumento { get; set; }
        public int IdBarrio { get; set; }
        public string NumeroTelefono { get; set; }
        public int IdPlan { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Calle { get; set; }
        public int NroCalle { get; set; }
        public DateTime FechaInscripcion { get; set; }

        public virtual Barrios IdBarrioNavigation { get; set; }
        public virtual Planes IdPlanNavigation { get; set; }
        public virtual Sexos IdSexoNavigation { get; set; }
        public virtual TiposDocumentos IdTipoDocumentoNavigation { get; set; }
        public virtual ICollection<Bajas> Bajas { get; set; }
        public virtual ICollection<Facturas> Facturas { get; set; }
        public virtual ICollection<TurnosEnConsultorio> TurnosEnConsultorio { get; set; }
        public virtual ICollection<TurnosPuntoAPunto> TurnosPuntoAPunto { get; set; }
    }
}
