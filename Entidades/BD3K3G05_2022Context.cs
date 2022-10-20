using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SIMED.Models
{
    public partial class BD3K3G05_2022Context : DbContext
    {
        public BD3K3G05_2022Context()
        {
        }

        public BD3K3G05_2022Context(DbContextOptions<BD3K3G05_2022Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Afiliados> Afiliados { get; set; }
        public virtual DbSet<Ambulancias> Ambulancias { get; set; }
        public virtual DbSet<Bajas> Bajas { get; set; }
        public virtual DbSet<Barrios> Barrios { get; set; }
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Ciudades> Ciudades { get; set; }
        public virtual DbSet<DiasLaborales> DiasLaborales { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<Enfermeros> Enfermeros { get; set; }
        public virtual DbSet<Enfermerosxviajes> Enfermerosxviajes { get; set; }
        public virtual DbSet<Especialidades> Especialidades { get; set; }
        public virtual DbSet<Facturas> Facturas { get; set; }
        public virtual DbSet<Marcas> Marcas { get; set; }
        public virtual DbSet<Medicos> Medicos { get; set; }
        public virtual DbSet<MedicosxDiasLaborales> MedicosxDiasLaborales { get; set; }
        public virtual DbSet<Medicosxviajes> Medicosxviajes { get; set; }
        public virtual DbSet<Modelos> Modelos { get; set; }
        public virtual DbSet<MotivosDeBaja> MotivosDeBaja { get; set; }
        public virtual DbSet<ObrasSociales> ObrasSociales { get; set; }
        public virtual DbSet<Perfiles> Perfiles { get; set; }
        public virtual DbSet<Planes> Planes { get; set; }
        public virtual DbSet<RangosEtarios> RangosEtarios { get; set; }
        public virtual DbSet<RelacionesLaborales> RelacionesLaborales { get; set; }
        public virtual DbSet<Sexos> Sexos { get; set; }
        public virtual DbSet<TarifasxServicios> TarifasxServicios { get; set; }
        public virtual DbSet<TiposDocumentos> TiposDocumentos { get; set; }
        public virtual DbSet<TiposPlan> TiposPlan { get; set; }
        public virtual DbSet<TiposViaje> TiposViaje { get; set; }
        public virtual DbSet<TurnosEnConsultorio> TurnosEnConsultorio { get; set; }
        public virtual DbSet<TurnosPuntoAPunto> TurnosPuntoAPunto { get; set; }
        public virtual DbSet<TurnosRotativos> TurnosRotativos { get; set; }
        public virtual DbSet<TurnosRotativosxEnfermeros> TurnosRotativosxEnfermeros { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Viajes> Viajes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=200.69.137.167,11333;Initial Catalog=BD3K3G05_2022;User ID=BD3K3G05_2022;Password=CLV05_25089");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Afiliados>(entity =>
            {
                entity.HasKey(e => e.NumeroAfiliado)
                    .HasName("pk_afiliados");

                entity.ToTable("AFILIADOS");

                entity.Property(e => e.NumeroAfiliado).HasColumnName("numeroAfiliado").ValueGeneratedOnAdd();

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasColumnName("apellido")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Calle)
                    .IsRequired()
                    .HasColumnName("calle")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.FechaInscripcion)
                    .HasColumnName("fechaInscripcion")
                    .HasColumnType("date");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("fechaNacimiento")
                    .HasColumnType("date");

                entity.Property(e => e.IdBarrio).HasColumnName("id_barrio");

                entity.Property(e => e.IdPlan).HasColumnName("id_plan");

                entity.Property(e => e.IdSexo).HasColumnName("id_sexo");

                entity.Property(e => e.IdTipoDocumento).HasColumnName("id_tipoDocumento");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NroCalle).HasColumnName("nroCalle");

                entity.Property(e => e.NumeroDocumento).HasColumnName("numero_documento");

                entity.Property(e => e.NumeroTelefono)
                    .IsRequired()
                    .HasColumnName("numeroTelefono")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdBarrioNavigation)
                    .WithMany(p => p.Afiliados)
                    .HasForeignKey(d => d.IdBarrio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_afiliado_barrio");

                entity.HasOne(d => d.IdPlanNavigation)
                    .WithMany(p => p.Afiliados)
                    .HasForeignKey(d => d.IdPlan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_afiliado_plan");

                entity.HasOne(d => d.IdSexoNavigation)
                    .WithMany(p => p.Afiliados)
                    .HasForeignKey(d => d.IdSexo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_afiliado_sexo");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.Afiliados)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_afiliado_tipoDocumento");
            });

            modelBuilder.Entity<Ambulancias>(entity =>
            {
                entity.HasKey(e => e.IdMovil)
                    .HasName("pk_ambulancias");

                entity.ToTable("AMBULANCIAS");

                entity.Property(e => e.IdMovil).HasColumnName("id_movil").ValueGeneratedOnAdd();

                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");

                entity.Property(e => e.IdModelo).HasColumnName("id_modelo");

                entity.Property(e => e.Patente)
                    .IsRequired()
                    .HasColumnName("patente")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Ambulancias)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ambulancia_categoria");

                entity.HasOne(d => d.IdModeloNavigation)
                    .WithMany(p => p.Ambulancias)
                    .HasForeignKey(d => d.IdModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ambulancia_modelo");
            });

            modelBuilder.Entity<Bajas>(entity =>
            {
                entity.HasKey(e => e.NroBaja)
                    .HasName("pk_bajas");

                entity.ToTable("BAJAS");

                entity.Property(e => e.NroBaja).HasColumnName("nro_baja").ValueGeneratedOnAdd();

                entity.Property(e => e.DeudaPendiente).HasColumnName("deudaPendiente");

                entity.Property(e => e.FechaBaja)
                    .HasColumnName("fecha_baja")
                    .HasColumnType("date");

                entity.Property(e => e.IdMotivoBaja).HasColumnName("id_motivoBaja");

                entity.Property(e => e.NumeroAfiliado).HasColumnName("numeroAfiliado");

                entity.HasOne(d => d.IdMotivoBajaNavigation)
                    .WithMany(p => p.Bajas)
                    .HasForeignKey(d => d.IdMotivoBaja)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_bajas_motivoBaja");

                entity.HasOne(d => d.NumeroAfiliadoNavigation)
                    .WithMany(p => p.Bajas)
                    .HasForeignKey(d => d.NumeroAfiliado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_bajas_afiliados");
            });

            modelBuilder.Entity<Barrios>(entity =>
            {
                entity.HasKey(e => e.IdBarrio)
                    .HasName("pk_BARRIOS");

                entity.ToTable("BARRIOS");

                entity.Property(e => e.IdBarrio).HasColumnName("id_barrio").ValueGeneratedOnAdd();

                entity.Property(e => e.IdCiudad).HasColumnName("id_ciudad");

                entity.Property(e => e.NombreBarrio)
                    .IsRequired()
                    .HasColumnName("nombre_barrio")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.Barrios)
                    .HasForeignKey(d => d.IdCiudad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_barrio_ciudad");
            });

            modelBuilder.Entity<Categorias>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("pk_categoria");

                entity.ToTable("CATEGORIAS");

                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria").ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ciudades>(entity =>
            {
                entity.HasKey(e => e.IdCiudad)
                    .HasName("pk_ciudades");

                entity.ToTable("CIUDADES");

                entity.Property(e => e.IdCiudad).HasColumnName("id_ciudad").ValueGeneratedOnAdd();

                entity.Property(e => e.DescripcionCiudad)
                    .IsRequired()
                    .HasColumnName("descripcionCiudad")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DiasLaborales>(entity =>
            {
                entity.HasKey(e => e.IdDiaLaboral)
                    .HasName("pk_diasLaborales");

                entity.ToTable("DIAS_LABORALES");

                entity.Property(e => e.IdDiaLaboral).HasColumnName("id_diaLaboral").ValueGeneratedOnAdd();

                entity.Property(e => e.DescripcionDiaLaboral)
                    .IsRequired()
                    .HasColumnName("descripcionDiaLaboral")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Empleados>(entity =>
            {
                entity.HasKey(e => e.Legajo);

                entity.ToTable("EMPLEADOS");

                entity.Property(e => e.Legajo).HasColumnName("legajo").ValueGeneratedOnAdd();

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdSexo).HasColumnName("id_sexo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdSexoNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdSexo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Empleados_Sexos");
            });

            modelBuilder.Entity<Enfermeros>(entity =>
            {
                entity.HasKey(e => e.NumeroMatricula)
                    .HasName("pk_enfermeros");

                entity.ToTable("ENFERMEROS");

                entity.Property(e => e.NumeroMatricula).HasColumnName("numeroMatricula").ValueGeneratedOnAdd();

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasColumnName("apellido")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Calle)
                    .IsRequired()
                    .HasColumnName("calle")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("fechaNacimiento")
                    .HasColumnType("date");

                entity.Property(e => e.IdBarrio).HasColumnName("id_barrio");

                entity.Property(e => e.IdEspecialidad).HasColumnName("id_especialidad");

                entity.Property(e => e.IdSexo).HasColumnName("id_sexo");

                entity.Property(e => e.IdTipoDocumento).HasColumnName("id_tipoDocumento");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NroCalle).HasColumnName("nroCalle");

                entity.Property(e => e.NumeroDocumento).HasColumnName("numeroDocumento");

                entity.Property(e => e.Telefono).HasColumnName("telefono");

                entity.HasOne(d => d.IdBarrioNavigation)
                    .WithMany(p => p.Enfermeros)
                    .HasForeignKey(d => d.IdBarrio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_enfermeros_barrios");

                entity.HasOne(d => d.IdSexoNavigation)
                    .WithMany(p => p.Enfermeros)
                    .HasForeignKey(d => d.IdSexo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_sexo");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.Enfermeros)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_enfermeros_tipoDocumento");
            });

            modelBuilder.Entity<Enfermerosxviajes>(entity =>
            {
                entity.HasKey(e => new { e.NumeroMatriculaEnfermero, e.Fecha, e.HoraSalida })
                    .HasName("pk_enfermerosxviajes");

                entity.ToTable("ENFERMEROSXVIAJES");

                entity.Property(e => e.NumeroMatriculaEnfermero).HasColumnName("numeroMatriculaEnfermero");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.HoraSalida).HasColumnName("hora_salida");

                entity.Property(e => e.IdMovil).HasColumnName("id_movil");

                entity.HasOne(d => d.NumeroMatriculaEnfermeroNavigation)
                    .WithMany(p => p.Enfermerosxviajes)
                    .HasForeignKey(d => d.NumeroMatriculaEnfermero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_enfermerosxviajes_enfermeros");

                entity.HasOne(d => d.Viajes)
                    .WithMany(p => p.Enfermerosxviajes)
                    .HasForeignKey(d => new { d.Fecha, d.IdMovil, d.HoraSalida })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_enfermerosxviajes_viajes");
            });

            modelBuilder.Entity<Especialidades>(entity =>
            {
                entity.HasKey(e => e.IdEspecialidad)
                    .HasName("pk_especialidades");

                entity.ToTable("ESPECIALIDADES");

                entity.Property(e => e.IdEspecialidad).HasColumnName("id_especialidad").ValueGeneratedOnAdd();

                entity.Property(e => e.DescripcionEspecialidad)
                    .IsRequired()
                    .HasColumnName("descripcionEspecialidad")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Facturas>(entity =>
            {
                entity.HasKey(e => e.IdFactura)
                    .HasName("pk_facturas");

                entity.ToTable("FACTURAS");

                entity.Property(e => e.IdFactura).HasColumnName("id_factura").ValueGeneratedOnAdd();

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("fechaFactura")
                    .HasColumnType("date");

                entity.Property(e => e.FechaPago)
                    .HasColumnName("fechaPago")
                    .HasColumnType("date");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnName("fechaVencimiento")
                    .HasColumnType("date");

                entity.Property(e => e.Importe).HasColumnName("importe");

                entity.Property(e => e.NumCbu).HasColumnName("numCBU");

                entity.Property(e => e.NumeroAfiliado).HasColumnName("numeroAfiliado");

                entity.HasOne(d => d.NumeroAfiliadoNavigation)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.NumeroAfiliado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_facturas_afiliados");
            });

            modelBuilder.Entity<Marcas>(entity =>
            {
                entity.HasKey(e => e.IdMarca)
                    .HasName("pk_marcas");

                entity.ToTable("MARCAS");

                entity.Property(e => e.IdMarca).HasColumnName("id_marca").ValueGeneratedOnAdd();

                entity.Property(e => e.NombreMarca)
                    .IsRequired()
                    .HasColumnName("nombre_marca")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Medicos>(entity =>
            {
                entity.HasKey(e => e.NumeroMatricula)
                    .HasName("pk_medicos");

                entity.ToTable("MEDICOS");

                entity.Property(e => e.NumeroMatricula).HasColumnName("numeroMatricula").ValueGeneratedOnAdd();

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasColumnName("apellido")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Calle)
                    .IsRequired()
                    .HasColumnName("calle")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("fechaNacimiento")
                    .HasColumnType("date");

                entity.Property(e => e.HorarioEgreso).HasColumnName("horarioEgreso");

                entity.Property(e => e.HorarioIngreso).HasColumnName("horarioIngreso");

                entity.Property(e => e.IdBarrio).HasColumnName("id_barrio");

                entity.Property(e => e.IdEspecialidad).HasColumnName("id_especialidad");

                entity.Property(e => e.IdRelacionLaboral).HasColumnName("id_relacionLaboral");

                entity.Property(e => e.IdSexo).HasColumnName("id_sexo");

                entity.Property(e => e.IdTipoDocumento).HasColumnName("id_tipoDocumento");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NroCalle).HasColumnName("nroCalle");

                entity.Property(e => e.NumDocumento).HasColumnName("numDocumento");

                entity.HasOne(d => d.IdBarrioNavigation)
                    .WithMany(p => p.Medicos)
                    .HasForeignKey(d => d.IdBarrio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MEDICOS_BARRIOS");

                entity.HasOne(d => d.IdEspecialidadNavigation)
                    .WithMany(p => p.Medicos)
                    .HasForeignKey(d => d.IdEspecialidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MEDICOS_ESPECIALIDADES");

                entity.HasOne(d => d.IdRelacionLaboralNavigation)
                    .WithMany(p => p.Medicos)
                    .HasForeignKey(d => d.IdRelacionLaboral)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MEDICOS_REL_LABORAL");

                entity.HasOne(d => d.IdSexoNavigation)
                    .WithMany(p => p.Medicos)
                    .HasForeignKey(d => d.IdSexo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MEDICOS_SEXOS");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.Medicos)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MEDICOS_TIPOS_DOC");
            });

            modelBuilder.Entity<MedicosxDiasLaborales>(entity =>
            {
                entity.HasKey(e => new { e.NumeroMatricula, e.IdDiaLaboral })
                    .HasName("pk_medicosxDiasLaborales");

                entity.ToTable("MEDICOSxDIAS_LABORALES");

                entity.Property(e => e.NumeroMatricula).HasColumnName("numeroMatricula");

                entity.Property(e => e.IdDiaLaboral).HasColumnName("id_diaLaboral");

                entity.HasOne(d => d.IdDiaLaboralNavigation)
                    .WithMany(p => p.MedicosxDiasLaborales)
                    .HasForeignKey(d => d.IdDiaLaboral)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_dia_diasLaborales");

                entity.HasOne(d => d.NumeroMatriculaNavigation)
                                    .WithMany(p => p.MedicosxDiasLaborales)
                                    .HasForeignKey(d => d.NumeroMatricula)
                                    .OnDelete(DeleteBehavior.ClientSetNull)
                                    .HasConstraintName("FK_DIAS_LAB_MEDICOS");
            });

            modelBuilder.Entity<Medicosxviajes>(entity =>
            {
                entity.HasKey(e => new { e.NumeroMatriculaMedico, e.Fecha, e.HoraSalida })
                    .HasName("pk_medicosxviajes");

                entity.ToTable("MEDICOSXVIAJES");

                entity.Property(e => e.NumeroMatriculaMedico).HasColumnName("numeroMatriculaMedico");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.HoraSalida).HasColumnName("hora_salida");

                entity.Property(e => e.IdMovil).HasColumnName("id_movil");

                entity.HasOne(d => d.NumeroMatriculaMedicoNavigation)
                    .WithMany(p => p.Medicosxviajes)
                    .HasForeignKey(d => d.NumeroMatriculaMedico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MEDICOS_MEDICOSXVIAJES");

                entity.HasOne(d => d.Viajes)
                    .WithMany(p => p.Medicosxviajes)
                    .HasForeignKey(d => new { d.Fecha, d.IdMovil, d.HoraSalida })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_medicosxviajes_viajes");
            });

            modelBuilder.Entity<Modelos>(entity =>
            {
                entity.HasKey(e => e.IdModelo)
                    .HasName("pk_modelos");

                entity.ToTable("MODELOS");

                entity.Property(e => e.IdModelo).HasColumnName("id_modelo").ValueGeneratedOnAdd();

                entity.Property(e => e.IdMarca).HasColumnName("id_marca");

                entity.Property(e => e.NombreModelo)
                    .IsRequired()
                    .HasColumnName("nombre_modelo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMarcaNavigation)
                    .WithMany(p => p.Modelos)
                    .HasForeignKey(d => d.IdMarca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_modelo_marca");
            });

            modelBuilder.Entity<MotivosDeBaja>(entity =>
            {
                entity.HasKey(e => e.IdMotivoBaja)
                    .HasName("pk_motivos");

                entity.ToTable("MOTIVOS_DE_BAJA");

                entity.Property(e => e.IdMotivoBaja).HasColumnName("id_motivoBaja").ValueGeneratedOnAdd();

                entity.Property(e => e.DesrcipcionMotivoBaja)
                    .IsRequired()
                    .HasColumnName("desrcipcionMotivoBaja")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ObrasSociales>(entity =>
            {
                entity.HasKey(e => e.IdObraSocial)
                    .HasName("pk_obrasSociales");

                entity.ToTable("OBRAS_SOCIALES");

                entity.Property(e => e.IdObraSocial).HasColumnName("id_ObraSocial").ValueGeneratedOnAdd();

                entity.Property(e => e.DescripcionObraSocial)
                    .IsRequired()
                    .HasColumnName("descripcionObraSocial")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescuentoPorServicio).HasColumnName("descuentoPorServicio");
            });

            modelBuilder.Entity<Perfiles>(entity =>
            {
                entity.HasKey(e => e.IdPerfil);

                entity.ToTable("PERFILES");

                entity.Property(e => e.IdPerfil).HasColumnName("id_perfil");

                entity.Property(e => e.DescripcionPerfil)
                    .IsRequired()
                    .HasColumnName("descripcionPerfil")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Planes>(entity =>
            {
                entity.HasKey(e => e.IdPlan)
                    .HasName("pk_planes");

                entity.ToTable("PLANES");

                entity.Property(e => e.IdPlan).HasColumnName("id_plan");

                entity.Property(e => e.IdRangoEtario).HasColumnName("id_rangoEtario");

                entity.Property(e => e.IdTipoPlan).HasColumnName("id_tipoPlan");

                entity.Property(e => e.NombrePlan)
                    .IsRequired()
                    .HasColumnName("nombrePlan")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Precio).HasColumnName("precio");

                entity.HasOne(d => d.IdRangoEtarioNavigation)
                    .WithMany(p => p.Planes)
                    .HasForeignKey(d => d.IdRangoEtario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_planes_rangoEtario");

                entity.HasOne(d => d.IdTipoPlanNavigation)
                    .WithMany(p => p.Planes)
                    .HasForeignKey(d => d.IdTipoPlan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_planes_id_tipoPlan");
            });
                modelBuilder.Entity<RangosEtarios>(entity =>
            {
                entity.HasKey(e => e.IdRangoEtario)
                    .HasName("pk_rangosEtarios");

                entity.ToTable("RANGOS_ETARIOS");

                entity.Property(e => e.IdRangoEtario).HasColumnName("id_rangoEtario").ValueGeneratedOnAdd();

                entity.Property(e => e.DescripcionRangoEtario)
                    .IsRequired()
                    .HasColumnName("descripcionRangoEtario")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RelacionesLaborales>(entity =>
            {
                entity.HasKey(e => e.IdRelacionLaboral)
                    .HasName("pk_relacionesLaborales");

                entity.ToTable("RELACIONES_LABORALES");

                entity.Property(e => e.IdRelacionLaboral).HasColumnName("id_relacionLaboral").ValueGeneratedOnAdd();

                entity.Property(e => e.DescripcionRelacionLaboral)
                    .IsRequired()
                    .HasColumnName("descripcionRelacionLaboral")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sexos>(entity =>
            {
                entity.HasKey(e => e.IdSexo)
                    .HasName("pk_sexos");

                entity.ToTable("SEXOS");

                entity.Property(e => e.IdSexo).HasColumnName("id_sexo");

                entity.Property(e => e.DescripcionSexo)
                    .IsRequired()
                    .HasColumnName("descripcionSexo")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TarifasxServicios>(entity =>
            {
                entity.HasKey(e => new { e.IdEspecialidad, e.Precio })
                    .HasName("pk_tarifasServicios");

                entity.ToTable("TARIFASxSERVICIOS");

                entity.Property(e => e.IdEspecialidad).HasColumnName("id_especialidad");

                entity.Property(e => e.Precio).HasColumnName("precio");

                entity.HasOne(d => d.IdEspecialidadNavigation)
                    .WithMany(p => p.TarifasxServicios)
                    .HasForeignKey(d => d.IdEspecialidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_especialidad_tarifa");
            });

            modelBuilder.Entity<TiposDocumentos>(entity =>
            {
                entity.HasKey(e => e.IdTipoDocumento)
                    .HasName("pk_tipoDocumento");

                entity.ToTable("TIPOS_DOCUMENTOS");

                entity.Property(e => e.IdTipoDocumento).HasColumnName("id_tipoDocumento").ValueGeneratedOnAdd();

                entity.Property(e => e.DescripcionTipoDocumento)
                    .IsRequired()
                    .HasColumnName("descripcionTipoDocumento")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposPlan>(entity =>
            {
                entity.HasKey(e => e.IdTipoPlan)
                    .HasName("pk_tiposPlan");

                entity.ToTable("TIPOS_PLAN");

                entity.Property(e => e.IdTipoPlan)
                .HasColumnName("id_tipoPlan")
                .ValueGeneratedOnAdd();

                entity.Property(e => e.CantAsistAmbulanciaDomicilio).HasColumnName("cantAsistAmbulanciaDomicilio");

                entity.Property(e => e.CantAtenConsultorios).HasColumnName("cantAtenConsultorios");

                entity.Property(e => e.CantTrasladosProgramados).HasColumnName("cantTrasladosProgramados");

                entity.Property(e => e.CantVistasDomiciliarias).HasColumnName("cantVistasDomiciliarias");

                entity.Property(e => e.DescripcionTipoPlan)
                    .IsRequired()
                    .HasColumnName("descripcionTipoPlan")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposViaje>(entity =>
            {
                entity.HasKey(e => e.IdTipoViaje)
                    .HasName("pk_tiposViaje");

                entity.ToTable("TIPOS_VIAJE");

                entity.Property(e => e.IdTipoViaje)
                    .HasColumnName("id_tipoViaje")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdTipoViaje).HasColumnName("id_tipoViaje");

                entity.Property(e => e.DescripcionTipoViaje)
                    .IsRequired()
                    .HasColumnName("descripcionTipoViaje")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TurnosEnConsultorio>(entity =>
            {
                entity.HasKey(e => new { e.FechaHora, e.NumMatriculaMedico })
                    .HasName("pk_turnos_en_consultorio");

                entity.ToTable("TURNOS_EN_CONSULTORIO");

                entity.Property(e => e.FechaHora)
                    .HasColumnName("fechaHora")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumMatriculaMedico).HasColumnName("numMatriculaMedico");

                entity.Property(e => e.ApellidoNoAfiliado)
                    .HasColumnName("apellido_noAfiliado")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCancelacion)
                    .HasColumnName("fechaCancelacion")
                    .HasColumnType("date");

                entity.Property(e => e.IdObraSocial).HasColumnName("id_obraSocial");

                entity.Property(e => e.NombreNoAfiliado)
                    .HasColumnName("nombre_noAfiliado")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroAfiliado).HasColumnName("numeroAfiliado");

                entity.Property(e => e.Precio).HasColumnName("precio");

                entity.Property(e => e.TelefonoNoAfiliado).HasColumnName("telefono_noAfiliado");

                entity.HasOne(d => d.IdObraSocialNavigation)
                    .WithMany(p => p.TurnosEnConsultorio)
                    .HasForeignKey(d => d.IdObraSocial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_turnos_e_c_obra_social");

                entity.HasOne(d => d.NumMatriculaMedicoNavigation)
                    .WithMany(p => p.TurnosEnConsultorio)
                    .HasForeignKey(d => d.NumMatriculaMedico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_turnos_e_c_medicos");

                entity.HasOne(d => d.NumeroAfiliadoNavigation)
                    .WithMany(p => p.TurnosEnConsultorio)
                    .HasForeignKey(d => d.NumeroAfiliado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_turnos_e_c_afiliados");
            });

            modelBuilder.Entity<TurnosPuntoAPunto>(entity =>
            {
                entity.HasKey(e => new { e.NumeroAfiliado, e.Fecha, e.HoraDelTurno })
                    .HasName("pk_turnos_punto_a_punto");

                entity.ToTable("TURNOS_PUNTO_A_PUNTO");

                entity.Property(e => e.NumeroAfiliado).HasColumnName("numeroAfiliado");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.HoraDelTurno).HasColumnName("horaDelTurno");

                entity.Property(e => e.CalleDestino)
                    .IsRequired()
                    .HasColumnName("calleDestino")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CalleOrigen)
                    .IsRequired()
                    .HasColumnName("calleOrigen")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.IdBarrioDestino).HasColumnName("id_barrioDestino");

                entity.Property(e => e.IdBarrioOrigen).HasColumnName("id_barrioOrigen");

                entity.Property(e => e.IdMovil).HasColumnName("id_movil");

                entity.Property(e => e.NroCalleDestino).HasColumnName("nroCalleDestino");

                entity.Property(e => e.NroCalleOrigen).HasColumnName("nroCalleOrigen");

                entity.HasOne(d => d.IdBarrioDestinoNavigation)
                    .WithMany(p => p.TurnosPuntoAPuntoIdBarrioDestinoNavigation)
                    .HasForeignKey(d => d.IdBarrioDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_turnos_p_a_p_barriosD");

                entity.HasOne(d => d.IdBarrioOrigenNavigation)
                    .WithMany(p => p.TurnosPuntoAPuntoIdBarrioOrigenNavigation)
                    .HasForeignKey(d => d.IdBarrioOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_turnos_p_a_p_barriosO");

                entity.HasOne(d => d.IdMovilNavigation)
                    .WithMany(p => p.TurnosPuntoAPunto)
                    .HasForeignKey(d => d.IdMovil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_turnos_p_a_p_ambulancias");

                entity.HasOne(d => d.NumeroAfiliadoNavigation)
                    .WithMany(p => p.TurnosPuntoAPunto)
                    .HasForeignKey(d => d.NumeroAfiliado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_turnos_p_a_p_afiliados");
            });

            modelBuilder.Entity<TurnosRotativos>(entity =>
            {
                entity.HasKey(e => e.IdTurnoRotativo)
                    .HasName("pk_turnosRotativos");

                entity.ToTable("TURNOS_ROTATIVOS");

                entity.Property(e => e.IdTurnoRotativo)
                    .HasColumnName("id_turnoRotativo")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DescripcionTurnoRotativo)
                    .IsRequired()
                    .HasColumnName("descripcionTurnoRotativo")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TurnosRotativosxEnfermeros>(entity =>
            {
                entity.HasKey(e => new { e.NumeroMatriculaEnfermero, e.Fecha })
                    .HasName("pk_turnosxEnfermeros");

                entity.ToTable("TURNOS_ROTATIVOSxENFERMEROS");

                entity.Property(e => e.NumeroMatriculaEnfermero).HasColumnName("numeroMatriculaEnfermero");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.IdTurnoRotativo).HasColumnName("id_turnoRotativo");

                entity.HasOne(d => d.IdTurnoRotativoNavigation)
                    .WithMany(p => p.TurnosRotativosxEnfermeros)
                    .HasForeignKey(d => d.IdTurnoRotativo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_turnoxRotativos");

                entity.HasOne(d => d.NumeroMatriculaEnfermeroNavigation)
                    .WithMany(p => p.TurnosRotativosxEnfermeros)
                    .HasForeignKey(d => d.NumeroMatriculaEnfermero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_enfermeroxTurno");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("USUARIOS");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("IdUsuario")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.IdPerfil).HasColumnName("id_perfil");

                entity.Property(e => e.LegajoEmpleado).HasColumnName("legajo_empleado");

                entity.Property(e => e.NombreDeUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USUARIOS_PERFILES");

                entity.HasOne(d => d.LegajoEmpleadoNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.LegajoEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USUARIOS_EMPLEADOS");
            });

            modelBuilder.Entity<Viajes>(entity =>
            {
                entity.HasKey(e => new { e.Fecha, e.IdMovil, e.HoraSalida })
                    .HasName("pk_viajes");

                entity.ToTable("VIAJES");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.IdMovil).HasColumnName("id_movil");

                entity.Property(e => e.HoraSalida).HasColumnName("hora_salida");

                entity.Property(e => e.CantCombustiblePost).HasColumnName("cantCombustiblePost");

                entity.Property(e => e.CantCombustiblePrevio).HasColumnName("cantCombustiblePrevio");

                entity.Property(e => e.HoraLlegada).HasColumnName("horaLlegada");

                entity.Property(e => e.IdTipoViaje).HasColumnName("id_tipoViaje");

                entity.Property(e => e.IdTurnoRotativo).HasColumnName("id_turnoRotativo");

                entity.Property(e => e.KilometrosRealizados).HasColumnName("kilometrosRealizados");

                entity.HasOne(d => d.IdMovilNavigation)
                    .WithMany(p => p.Viajes)
                    .HasForeignKey(d => d.IdMovil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_viajes_ambulancias");

                entity.HasOne(d => d.IdTipoViajeNavigation)
                    .WithMany(p => p.Viajes)
                    .HasForeignKey(d => d.IdTipoViaje)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_viajes_tipoViaje");

                entity.HasOne(d => d.IdTurnoRotativoNavigation)
                    .WithMany(p => p.Viajes)
                    .HasForeignKey(d => d.IdTurnoRotativo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_viajes_turnosRotativos");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
