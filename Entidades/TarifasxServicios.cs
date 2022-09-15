using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED.Models
{
    public partial class TarifasxServicios
    {
        public int IdEspecialidad { get; set; }
        public double Precio { get; set; }

        public virtual Especialidades IdEspecialidadNavigation { get; set; }
    }
}
