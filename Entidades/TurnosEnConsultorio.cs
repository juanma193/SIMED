using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED_V1.Entidades
{
    public partial class TurnosEnConsultorio
    {
        public DateTime FechaHora { get; set; }
        public int NumMatriculaMedico { get; set; }
        public int NumeroAfiliado { get; set; }
        public string NombreNoAfiliado { get; set; }
        public string ApellidoNoAfiliado { get; set; }
        public int? TelefonoNoAfiliado { get; set; }
        public int IdObraSocial { get; set; }
        public double Precio { get; set; }
        public DateTime FechaCancelacion { get; set; }

        public virtual ObrasSociales IdObraSocialNavigation { get; set; }
        public virtual Medicos NumMatriculaMedicoNavigation { get; set; }
        public virtual Afiliados NumeroAfiliadoNavigation { get; set; }
    }
}
