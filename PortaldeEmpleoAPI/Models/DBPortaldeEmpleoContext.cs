using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PortaldeEmpleoAPI.Models
{
    public partial class DBPortaldeEmpleoContext : DbContext
    {
        public DBPortaldeEmpleoContext()
        {
        }

        public DBPortaldeEmpleoContext(DbContextOptions<DBPortaldeEmpleoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admiempresa> Admiempresa { get; set; }
        public virtual DbSet<Areaestudio> Areaestudio { get; set; }
        public virtual DbSet<Areatrabajo> Areatrabajo { get; set; }
        public virtual DbSet<Candidato> Candidato { get; set; }
        public virtual DbSet<Detpostuof> Detpostuof { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Estadocivil> Estadocivil { get; set; }
        public virtual DbSet<Explabcand> Explabcand { get; set; }
        public virtual DbSet<Formaccand> Formaccand { get; set; }
        public virtual DbSet<Genero> Genero { get; set; }
        public virtual DbSet<Giroempresa> Giroempresa { get; set; }
        public virtual DbSet<Habconocimcand> Habconocimcand { get; set; }
        public virtual DbSet<Idioma> Idioma { get; set; }
        public virtual DbSet<Idiomacandid> Idiomacandid { get; set; }
        public virtual DbSet<Jornada> Jornada { get; set; }
        public virtual DbSet<Niveloralidi> Niveloralidi { get; set; }
        public virtual DbSet<Nivescrid> Nivescrid { get; set; }
        public virtual DbSet<Ofertalaboral> Ofertalaboral { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Personaladmin> Personaladmin { get; set; }
        public virtual DbSet<Tipoestudio> Tipoestudio { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-NFO7N8G\\SQLEXPRESS;Database=DBPortaldeEmpleo; MultipleActiveResultSets=true; Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Admiempresa>(entity =>
            {
                entity.ToTable("admiempresa");

                entity.HasIndex(e => e.EmpresaId, "admiempresa__idx")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(30)
                    .HasColumnName("apellidos");

                entity.Property(e => e.Contraseña)
                    .HasMaxLength(30)
                    .HasColumnName("contraseña");

                entity.Property(e => e.Correo)
                    .HasMaxLength(30)
                    .HasColumnName("correo");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .HasColumnName("direccion");

                entity.Property(e => e.EmpresaId).HasColumnName("empresa_id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .HasColumnName("nombre");

                entity.Property(e => e.SalAdmiEmpresa).HasColumnName("salAdmiEmpresa");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(30)
                    .HasColumnName("telefono");

                entity.HasOne(d => d.Empresa)
                    .WithOne(p => p.Admiempresa)
                    .HasForeignKey<Admiempresa>(d => d.EmpresaId)
                    .HasConstraintName("admiempresa_empresa_fk");
            });

            modelBuilder.Entity<Areaestudio>(entity =>
            {
                entity.ToTable("areaestudio");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(40)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Areatrabajo>(entity =>
            {
                entity.ToTable("areatrabajo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(40)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Candidato>(entity =>
            {
                entity.HasKey(e => e.Idcandidat)
                    .HasName("candidato_pk");

                entity.ToTable("candidato");

                entity.Property(e => e.Idcandidat).HasColumnName("idcandidat");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(100)
                    .HasColumnName("apellidos");

                entity.Property(e => e.Contraseña)
                    .HasMaxLength(100)
                    .HasColumnName("contraseña");

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .HasColumnName("correo");

                entity.Property(e => e.Descrpperfil)
                    .HasMaxLength(100)
                    .HasColumnName("descrpperfil");

                entity.Property(e => e.Dni)
                    .HasMaxLength(50)
                    .HasColumnName("dni");

                entity.Property(e => e.Dochojavida)
                    .HasMaxLength(30)
                    .HasColumnName("dochojavida");

                entity.Property(e => e.EstadocivilIdestciv).HasColumnName("estadocivil_idestciv");

                entity.Property(e => e.Fechanacim)
                    .HasColumnType("date")
                    .HasColumnName("fechanacim");

                entity.Property(e => e.Foto).HasColumnName("foto");

                entity.Property(e => e.GeneroIdgenero).HasColumnName("genero_idgenero");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .HasColumnName("nombres");

                entity.Property(e => e.SalCandidato).HasColumnName("salCandidato");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(40)
                    .HasColumnName("telefono");

                entity.HasOne(d => d.EstadocivilIdestcivNavigation)
                    .WithMany(p => p.Candidato)
                    .HasForeignKey(d => d.EstadocivilIdestciv)
                    .HasConstraintName("candidato_estadocivil_fk");

                entity.HasOne(d => d.GeneroIdgeneroNavigation)
                    .WithMany(p => p.Candidato)
                    .HasForeignKey(d => d.GeneroIdgenero)
                    .HasConstraintName("candidato_genero_fk");
            });

            modelBuilder.Entity<Detpostuof>(entity =>
            {
                entity.ToTable("detpostuof");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CandidatoIdcandidat).HasColumnName("candidato_idcandidat");

                entity.Property(e => e.OfertalaboralId).HasColumnName("ofertalaboral_id");

                entity.HasOne(d => d.CandidatoIdcandidatNavigation)
                    .WithMany(p => p.Detpostuof)
                    .HasForeignKey(d => d.CandidatoIdcandidat)
                    .HasConstraintName("detpostuof_candidato_fk");

                entity.HasOne(d => d.Ofertalaboral)
                    .WithMany(p => p.Detpostuof)
                    .HasForeignKey(d => d.OfertalaboralId)
                    .HasConstraintName("detpostuof_ofertalaboral_fk");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.ToTable("empresa");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcionempr)
                    .HasMaxLength(30)
                    .HasColumnName("descripcionempr");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .HasColumnName("email");

                entity.Property(e => e.Industria)
                    .HasMaxLength(30)
                    .HasColumnName("industria");

                entity.Property(e => e.Logoempresa).HasColumnName("logoempresa");

                entity.Property(e => e.Razonsocial)
                    .HasMaxLength(30)
                    .HasColumnName("razonsocial");

                entity.Property(e => e.Ruc)
                    .HasMaxLength(30)
                    .HasColumnName("ruc");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(30)
                    .HasColumnName("telefono");

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(30)
                    .HasColumnName("ubicacion");
            });

            modelBuilder.Entity<Estadocivil>(entity =>
            {
                entity.HasKey(e => e.Idestciv)
                    .HasName("estadocivil_pk");

                entity.ToTable("estadocivil");

                entity.Property(e => e.Idestciv).HasColumnName("idestciv");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(30)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Explabcand>(entity =>
            {
                entity.HasKey(e => e.Idexplabcand)
                    .HasName("experiencialabcandidato_pk");

                entity.ToTable("explabcand");

                entity.Property(e => e.Idexplabcand).HasColumnName("idexplabcand");

                entity.Property(e => e.AreatrabajoId).HasColumnName("areatrabajo_id");

                entity.Property(e => e.CandidatoIdcandidat).HasColumnName("candidato_idcandidat");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(50)
                    .HasColumnName("cargo");

                entity.Property(e => e.Descripfuncion)
                    .HasMaxLength(100)
                    .HasColumnName("descripfuncion");

                entity.Property(e => e.Empresaexp)
                    .HasMaxLength(50)
                    .HasColumnName("empresaexp");

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("estado")
                    .IsFixedLength(true);

                entity.Property(e => e.FechaFin)
                    .HasColumnType("date")
                    .HasColumnName("fecha_fin");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("date")
                    .HasColumnName("fecha_inicio");

                entity.Property(e => e.GiroempresaId).HasColumnName("giroempresa_id");

                entity.HasOne(d => d.Areatrabajo)
                    .WithMany(p => p.Explabcand)
                    .HasForeignKey(d => d.AreatrabajoId)
                    .HasConstraintName("explabcand_areatrabajo_fk");

                entity.HasOne(d => d.CandidatoIdcandidatNavigation)
                    .WithMany(p => p.Explabcand)
                    .HasForeignKey(d => d.CandidatoIdcandidat)
                    .HasConstraintName("explabcand_candidato_fk");

                entity.HasOne(d => d.Giroempresa)
                    .WithMany(p => p.Explabcand)
                    .HasForeignKey(d => d.GiroempresaId)
                    .HasConstraintName("explabcand_giroempresa_fk");
            });

            modelBuilder.Entity<Formaccand>(entity =>
            {
                entity.HasKey(e => e.Idformacadem)
                    .HasName("formacionacademicacand_pk");

                entity.ToTable("formaccand");

                entity.Property(e => e.Idformacadem).HasColumnName("idformacadem");

                entity.Property(e => e.AreaestudioId).HasColumnName("areaestudio_id");

                entity.Property(e => e.CandidatoIdcandidat).HasColumnName("candidato_idcandidat");

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("estado")
                    .IsFixedLength(true);

                entity.Property(e => e.Fechafin)
                    .HasColumnType("date")
                    .HasColumnName("fechafin");

                entity.Property(e => e.Fechainicio)
                    .HasColumnType("date")
                    .HasColumnName("fechainicio");

                entity.Property(e => e.Nombrecentroed)
                    .HasMaxLength(50)
                    .HasColumnName("nombrecentroed");

                entity.Property(e => e.PaisId).HasColumnName("pais_id");

                entity.Property(e => e.TipoestudioId).HasColumnName("tipoestudio_id");

                entity.Property(e => e.Titulocarrera)
                    .HasMaxLength(80)
                    .HasColumnName("titulocarrera");

                entity.HasOne(d => d.Areaestudio)
                    .WithMany(p => p.Formaccand)
                    .HasForeignKey(d => d.AreaestudioId)
                    .HasConstraintName("formaccand_areaestudio_fk");

                entity.HasOne(d => d.CandidatoIdcandidatNavigation)
                    .WithMany(p => p.Formaccand)
                    .HasForeignKey(d => d.CandidatoIdcandidat)
                    .HasConstraintName("formaccand_candidato_fk");

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.Formaccand)
                    .HasForeignKey(d => d.PaisId)
                    .HasConstraintName("formaccand_pais_fk");

                entity.HasOne(d => d.Tipoestudio)
                    .WithMany(p => p.Formaccand)
                    .HasForeignKey(d => d.TipoestudioId)
                    .HasConstraintName("formaccand_tipoestudio_fk");
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.HasKey(e => e.Idgenero)
                    .HasName("genero_pk");

                entity.ToTable("genero");

                entity.Property(e => e.Idgenero).HasColumnName("idgenero");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(30)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Giroempresa>(entity =>
            {
                entity.ToTable("giroempresa");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(40)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Habconocimcand>(entity =>
            {
                entity.ToTable("habconocimcand");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CandidatoIdcandidat).HasColumnName("candidato_idcandidat");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(40)
                    .HasColumnName("descripcion");

                entity.HasOne(d => d.CandidatoIdcandidatNavigation)
                    .WithMany(p => p.Habconocimcand)
                    .HasForeignKey(d => d.CandidatoIdcandidat)
                    .HasConstraintName("habconocimcand_candidato_fk");
            });

            modelBuilder.Entity<Idioma>(entity =>
            {
                entity.ToTable("idioma");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(40)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Idiomacandid>(entity =>
            {
                entity.HasKey(e => e.Ididioma)
                    .HasName("idiomacandid_pk");

                entity.ToTable("idiomacandid");

                entity.Property(e => e.Ididioma).HasColumnName("ididioma");

                entity.Property(e => e.CandidatoIdcandidat).HasColumnName("candidato_idcandidat");

                entity.Property(e => e.IdiomaId).HasColumnName("idioma_id");

                entity.Property(e => e.NiveloralidiId).HasColumnName("niveloralidi_id");

                entity.Property(e => e.NivescridId).HasColumnName("nivescrid_id");

                entity.HasOne(d => d.CandidatoIdcandidatNavigation)
                    .WithMany(p => p.Idiomacandid)
                    .HasForeignKey(d => d.CandidatoIdcandidat)
                    .HasConstraintName("idiomacandid_candidato_fk");

                entity.HasOne(d => d.Idioma)
                    .WithMany(p => p.Idiomacandid)
                    .HasForeignKey(d => d.IdiomaId)
                    .HasConstraintName("idiomacandid_idioma_fk");

                entity.HasOne(d => d.Niveloralidi)
                    .WithMany(p => p.Idiomacandid)
                    .HasForeignKey(d => d.NiveloralidiId)
                    .HasConstraintName("idiomacandid_niveloralidi_fk");

                entity.HasOne(d => d.Nivescrid)
                    .WithMany(p => p.Idiomacandid)
                    .HasForeignKey(d => d.NivescridId)
                    .HasConstraintName("idiomacandid_nivescrid_fk");
            });

            modelBuilder.Entity<Jornada>(entity =>
            {
                entity.ToTable("jornada");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(30)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Niveloralidi>(entity =>
            {
                entity.ToTable("niveloralidi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(40)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Nivescrid>(entity =>
            {
                entity.ToTable("nivescrid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(40)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Ofertalaboral>(entity =>
            {
                entity.ToTable("ofertalaboral");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcionpuesto)
                    .HasMaxLength(50)
                    .HasColumnName("descripcionpuesto");

                entity.Property(e => e.Detalleoferta)
                    .HasMaxLength(100)
                    .HasColumnName("detalleoferta");

                entity.Property(e => e.EmpresaId).HasColumnName("empresa_id");

                entity.Property(e => e.Fechafin)
                    .HasColumnType("date")
                    .HasColumnName("fechafin");

                entity.Property(e => e.Fechapublicacion)
                    .HasColumnType("date")
                    .HasColumnName("fechapublicacion");

                entity.Property(e => e.JornadaId).HasColumnName("jornada_id");

                entity.Property(e => e.Perfilcandidato)
                    .HasMaxLength(100)
                    .HasColumnName("perfilcandidato");

                entity.Property(e => e.Requisitos)
                    .HasMaxLength(100)
                    .HasColumnName("requisitos");

                entity.Property(e => e.Salario)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("salario");

                entity.Property(e => e.Titulooferta)
                    .HasMaxLength(50)
                    .HasColumnName("titulooferta");

                entity.HasOne(d => d.Empresa)
                    .WithMany(p => p.Ofertalaboral)
                    .HasForeignKey(d => d.EmpresaId)
                    .HasConstraintName("ofertalaboral_empresa_fk");

                entity.HasOne(d => d.Jornada)
                    .WithMany(p => p.Ofertalaboral)
                    .HasForeignKey(d => d.JornadaId)
                    .HasConstraintName("ofertalaboral_jornada_fk");
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.ToTable("pais");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(40)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Personaladmin>(entity =>
            {
                entity.ToTable("personaladmin");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Contraseña)
                    .HasMaxLength(50)
                    .HasColumnName("contraseña");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<Tipoestudio>(entity =>
            {
                entity.ToTable("tipoestudio");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(40)
                    .HasColumnName("descripcion");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
