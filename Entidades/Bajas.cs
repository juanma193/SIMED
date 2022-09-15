using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED.Models
{
    public partial class Bajas
    {
        public int NroBaja { get; set; }
        public DateTime FechaBaja { get; set; }
        public int NumeroAfiliado { get; set; }
        public double DeudaPendiente { get; set; }
        public int IdMotivoBaja { get; set; }

        public virtual MotivosDeBaja IdMotivoBajaNavigation { get; set; }
        public virtual Afiliados NumeroAfiliadoNavigation { get; set; }
    }
}
