using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED_V1.Entidades
{
    public partial class Facturas
    {
        public int IdFactura { get; set; }
        public int NumeroAfiliado { get; set; }
        public DateTime FechaFactura { get; set; }
        public int NumCbu { get; set; }
        public double Importe { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaPago { get; set; }

        public virtual Afiliados NumeroAfiliadoNavigation { get; set; }
    }
}
