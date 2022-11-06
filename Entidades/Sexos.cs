using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED_V1.Entidades
{
    public partial class Sexos
    {
        public Sexos()
        {
            Afiliados = new HashSet<Afiliados>();
            Empleados = new HashSet<Empleados>();
            Enfermeros = new HashSet<Enfermeros>();
            Medicos = new HashSet<Medicos>();
        }

        public int IdSexo { get; set; }
        public string DescripcionSexo { get; set; }

        public virtual ICollection<Afiliados> Afiliados { get; set; }
        public virtual ICollection<Empleados> Empleados { get; set; }
        public virtual ICollection<Enfermeros> Enfermeros { get; set; }
        public virtual ICollection<Medicos> Medicos { get; set; }
    }
}
