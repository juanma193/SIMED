using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED.Models
{
    public partial class MotivosDeBaja
    {
        public MotivosDeBaja()
        {
            Bajas = new HashSet<Bajas>();
        }

        public int IdMotivoBaja { get; set; }
        public string Desrcipcion { get; set; }

        public virtual ICollection<Bajas> Bajas { get; set; }
    }
}
