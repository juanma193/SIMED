using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED.Models
{
    public partial class Medicos
    {
        public Medicos()
        {
            MedicosxDiasLaborales = new HashSet<MedicosxDiasLaborales>();
            Medicosxviajes = new HashSet<Medicosxviajes>();
            TurnosEnConsultorio = new HashSet<TurnosEnConsultorio>();
        }

        public int NumeroMatricula { get; set; }
        public int IdDiaLaboral { get; set; }
        public int NumDocumento { get; set; }
        public int IdTipoDocumento { get; set; }
        public string Apellido { get; set; }
        public int IdSexo { get; set; }
        public string Nombre { get; set; }
        public int IdBarrio { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdRelacionLaboral { get; set; }
        public TimeSpan HorarioIngreso { get; set; }
        public TimeSpan HorarioEgreso { get; set; }
        public int IdEspecialidad { get; set; }
        public string Calle { get; set; }
        public int NroCalle { get; set; }

        public virtual Barrios IdBarrioNavigation { get; set; }
        public virtual DiasLaborales IdDiaLaboralNavigation { get; set; }
        public virtual Especialidades IdEspecialidadNavigation { get; set; }
        public virtual RelacionesLaborales IdRelacionLaboralNavigation { get; set; }
        public virtual Sexos IdSexoNavigation { get; set; }
        public virtual TiposDocumentos IdTipoDocumentoNavigation { get; set; }
        public virtual ICollection<MedicosxDiasLaborales> MedicosxDiasLaborales { get; set; }
        public virtual ICollection<Medicosxviajes> Medicosxviajes { get; set; }
        public virtual ICollection<TurnosEnConsultorio> TurnosEnConsultorio { get; set; }
    }
}
