using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProyectoPajov.Infrastructure.ModelsCLS
{
    public partial class ConfeccionesPajovContext : DbContext
    {
        public ConfeccionesPajovContext()
        {
        }

        public ConfeccionesPajovContext(DbContextOptions<ConfeccionesPajovContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Arl> Arls { get; set; } = null!;
        public virtual DbSet<CajaCompensacion> CajaCompensacions { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Contrato> Contratos { get; set; } = null!;
        public virtual DbSet<Departamento> Departamentos { get; set; } = null!;
        public virtual DbSet<Empleado> Empleados { get; set; } = null!;
        public virtual DbSet<Ep> Eps { get; set; } = null!;
        public virtual DbSet<FondoPensione> FondoPensiones { get; set; } = null!;
        public virtual DbSet<Genero> Generos { get; set; } = null!;
        public virtual DbSet<Municipio> Municipios { get; set; } = null!;
        public virtual DbSet<Orden> Ordens { get; set; } = null!;
        public virtual DbSet<OrdenDetalle> OrdenDetalles { get; set; } = null!;
        public virtual DbSet<Pai> Pais { get; set; } = null!;
        public virtual DbSet<Proeevedor> Proeevedors { get; set; } = null!;
        public virtual DbSet<Remision> Remisions { get; set; } = null!;
        public virtual DbSet<RemisionDetalle> RemisionDetalles { get; set; } = null!;
        public virtual DbSet<TipoContrato> TipoContratos { get; set; } = null!;
        public virtual DbSet<TipoIdentificacion> TipoIdentificacions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-ST0LLHE2\\SQLEXPRESS;Database=ConfeccionesPajov;Integrated Security=True;TrustServerCertificate=true; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Arl>(entity =>
            {
                entity.HasKey(e => e.IdArl)
                    .HasName("PK__arl__6BE928C168934892");

                entity.ToTable("arl");

                entity.Property(e => e.IdArl)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_arl");

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.NombreArl)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nombre_arl");
            });

            modelBuilder.Entity<CajaCompensacion>(entity =>
            {
                entity.HasKey(e => e.IdCaja)
                    .HasName("PK__caja_com__C71E2476036C204B");

                entity.ToTable("caja_compensacion");

                entity.Property(e => e.IdCaja)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_caja");

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.NombreCaja)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_caja");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__cliente__677F38F590C9E601");

                entity.ToTable("cliente");

                entity.Property(e => e.IdCliente)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_cliente");

                entity.Property(e => e.CiudadCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ciudad_cliente");

                entity.Property(e => e.ContactoCliente)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("contacto_cliente");

                entity.Property(e => e.DepartamentoCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("departamento_cliente");

                entity.Property(e => e.DirrecionCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dirrecion_cliente");

                entity.Property(e => e.EmailCliente)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("email_cliente");

                entity.Property(e => e.NitCliente)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("nit_cliente");

                entity.Property(e => e.NombreCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_cliente");

                entity.Property(e => e.PaisCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pais_cliente");

                entity.Property(e => e.TelefonoCliente)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("telefono_cliente");
            });

            modelBuilder.Entity<Contrato>(entity =>
            {
                entity.HasKey(e => e.IdContrato)
                    .HasName("PK__contrato__FF5F2A56E3413903");

                entity.ToTable("contrato");

                entity.Property(e => e.IdContrato)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_contrato");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_fin");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_inicio");

                entity.Property(e => e.IdEmpleado)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("id_empleado");

                entity.Property(e => e.IdTipoContrato)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("id_tipo_contrato");

                entity.Property(e => e.Salario)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salario");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.HasKey(e => e.IdDepartamento);

                entity.ToTable("departamento");

                entity.Property(e => e.IdDepartamento)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_departamento");

                entity.Property(e => e.EstadoDepartamento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("estado_departamento");

                entity.Property(e => e.IdPais)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("id_pais");

                entity.Property(e => e.NombreDepartamento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_departamento");

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.Departamentos)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_departamento_pais");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado)
                    .HasName("PK__empleado__88B51394684CAC8B");

                entity.ToTable("empleado");

                entity.Property(e => e.IdEmpleado)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_empleado");

                entity.Property(e => e.CorreoElectronicoPersonalEmpleado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo_electronico_personal_empleado");

                entity.Property(e => e.DireccionEmpleado)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("direccion_empleado");

                entity.Property(e => e.FechaNacimientoEmpleado)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_nacimiento_empleado");

                entity.Property(e => e.IdArl)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("id_arl");

                entity.Property(e => e.IdCaja)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("id_caja");

                entity.Property(e => e.IdEps)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("id_eps");

                entity.Property(e => e.IdGenero)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("id_genero");

                entity.Property(e => e.IdPension)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("id_pension");

                entity.Property(e => e.IdTipoidentificacion)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("id_tipoidentificacion");

                entity.Property(e => e.IdentificacionEmpleado)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("identificacion_empleado");

                entity.Property(e => e.MunicipioResidenciaEmpleado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("municipio_residencia_empleado");

                entity.Property(e => e.PrimerApellidoEmpleado)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("primer_apellido_empleado");

                entity.Property(e => e.PrimerNombreEmpleado)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("primer_nombre_empleado");

                entity.Property(e => e.SegundoApellidoEmpleado)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("segundo_apellido_empleado");

                entity.Property(e => e.SegundoNombreEmpleado)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("segundo_nombre_empleado");

                entity.Property(e => e.TelefonoEmpleado)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("telefono_empleado");

                entity.Property(e => e.TelefonoEmpleadoEmpleado)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("telefono_empleado_empleado");

                entity.HasOne(d => d.IdArlNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdArl)
                    .HasConstraintName("FK__empleado__id_arl__74AE54BC");

                entity.HasOne(d => d.IdCajaNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdCaja)
                    .HasConstraintName("FK__empleado__id_caj__73BA3083");

                entity.HasOne(d => d.IdEpsNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdEps)
                    .HasConstraintName("FK__empleado__id_eps__71D1E811");

                entity.HasOne(d => d.IdGeneroNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdGenero)
                    .HasConstraintName("FK__empleado__id_gen__6FE99F9F");

                entity.HasOne(d => d.IdPensionNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdPension)
                    .HasConstraintName("FK__empleado__id_pen__72C60C4A");

                entity.HasOne(d => d.IdTipoidentificacionNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdTipoidentificacion)
                    .HasConstraintName("FK__empleado__id_tip__70DDC3D8");
            });

            modelBuilder.Entity<Ep>(entity =>
            {
                entity.HasKey(e => e.IdEps)
                    .HasName("PK__eps__D52A4DB694D5BD2A");

                entity.ToTable("eps");

                entity.Property(e => e.IdEps)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_eps");

                entity.Property(e => e.Estado)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.NombreEps)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nombre_eps");
            });

            modelBuilder.Entity<FondoPensione>(entity =>
            {
                entity.HasKey(e => e.IdPension)
                    .HasName("PK__fondo_pe__A098353F20090AC2");

                entity.ToTable("fondo_pensiones");

                entity.Property(e => e.IdPension)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_pension");

                entity.Property(e => e.Estado)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.NombrePension)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_pension");
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.HasKey(e => e.IdGenero)
                    .HasName("PK__genero__99A8E4F98376E419");

                entity.ToTable("genero");

                entity.Property(e => e.IdGenero)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_genero");

                entity.Property(e => e.EstadoGenero)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("estado_genero");

                entity.Property(e => e.NombreGenero)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_genero");
            });

            modelBuilder.Entity<Municipio>(entity =>
            {
                entity.HasKey(e => e.IdMunicipio);

                entity.ToTable("municipio");

                entity.Property(e => e.IdMunicipio)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_municipio");

                entity.Property(e => e.EstadoDepartamento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("estado_departamento");

                entity.Property(e => e.IdDepartamento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("id_departamento");

                entity.Property(e => e.NombreMunicipio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_municipio");

                entity.HasOne(d => d.IdDepartamentoNavigation)
                    .WithMany(p => p.Municipios)
                    .HasForeignKey(d => d.IdDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_municipio_departamento");
            });

            modelBuilder.Entity<Orden>(entity =>
            {
                entity.HasKey(e => e.IdOrden)
                    .HasName("PK__orden__DD5B8F330FAF3B4F");

                entity.ToTable("orden");

                entity.Property(e => e.IdOrden)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_orden");

                entity.Property(e => e.CantidadTotalOrden)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("cantidad_total_orden");

                entity.Property(e => e.FechaElaboracion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_elaboracion");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_entrega");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("observacion");

                entity.Property(e => e.ValorPago)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("valor_pago");
            });

            modelBuilder.Entity<OrdenDetalle>(entity =>
            {
                entity.HasKey(e => e.IdOrdenDetalle)
                    .HasName("PK__orden_de__2AA6E1340BB3810F");

                entity.ToTable("orden_detalle");

                entity.Property(e => e.IdOrdenDetalle)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_orden_detalle");

                entity.Property(e => e.CantidadOrdenDetalle)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("cantidad_orden_detalle");

                entity.Property(e => e.DescripcionOrdenDetalle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion_orden_detalle");

                entity.Property(e => e.IdOrden)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("id_orden");

                entity.Property(e => e.PrecioUnidad)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("precio_unidad");

                entity.Property(e => e.TotalOrdenDetalle)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("total_orden_detalle");

                entity.HasOne(d => d.IdOrdenNavigation)
                    .WithMany(p => p.OrdenDetalles)
                    .HasForeignKey(d => d.IdOrden)
                    .HasConstraintName("FK__orden_det__id_or__5EBF139D");
            });

            modelBuilder.Entity<Pai>(entity =>
            {
                entity.HasKey(e => e.IdPais);

                entity.ToTable("pais");

                entity.Property(e => e.IdPais)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_pais");

                entity.Property(e => e.CodigoTelefonicoPais)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codigo_telefonico_pais");

                entity.Property(e => e.EstadoPais)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("estado_pais");

                entity.Property(e => e.NombrePais)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_pais");
            });

            modelBuilder.Entity<Proeevedor>(entity =>
            {
                entity.HasKey(e => e.IdProeevedor)
                    .HasName("PK__proeeved__B517792A04218E43");

                entity.ToTable("proeevedor");

                entity.Property(e => e.IdProeevedor)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_proeevedor");

                entity.Property(e => e.CiudadProeevedor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ciudad_proeevedor");

                entity.Property(e => e.ContactoProeevedor)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("contacto_proeevedor");

                entity.Property(e => e.DepartamentoProeevedor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("departamento_proeevedor");

                entity.Property(e => e.DirrecionProeevedor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dirrecion_proeevedor");

                entity.Property(e => e.EmailProeevedor)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("email_proeevedor");

                entity.Property(e => e.NitProeevedor)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("nit_proeevedor");

                entity.Property(e => e.NombreProeevedor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_proeevedor");

                entity.Property(e => e.PaisProeevedor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pais_proeevedor");

                entity.Property(e => e.TelefonoProeevedor)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("telefono_proeevedor");
            });

            modelBuilder.Entity<Remision>(entity =>
            {
                entity.HasKey(e => e.IdRemision)
                    .HasName("PK__remision__6A1AF9F9412667F3");

                entity.ToTable("remision");

                entity.Property(e => e.IdRemision)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_remision");

                entity.Property(e => e.CantidadRemision)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("cantidad_remision");

                entity.Property(e => e.CategoriaRemision)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("categoria_remision");

                entity.Property(e => e.FechaRemision)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_remision");

                entity.Property(e => e.IdCliente)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("id_cliente");

                entity.Property(e => e.IdOrden)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("id_orden");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Remisions)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK__remision__id_cli__619B8048");

                entity.HasOne(d => d.IdOrdenNavigation)
                    .WithMany(p => p.Remisions)
                    .HasForeignKey(d => d.IdOrden)
                    .HasConstraintName("FK__remision__id_ord__628FA481");
            });

            modelBuilder.Entity<RemisionDetalle>(entity =>
            {
                entity.HasKey(e => e.IdRemisionDetalle)
                    .HasName("PK__remision__07FBB9A7E09148C5");

                entity.ToTable("remision_detalle");

                entity.Property(e => e.IdRemisionDetalle)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_remision_detalle");

                entity.Property(e => e.CantidadRemisionDetalle)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("cantidad_remision_detalle");

                entity.Property(e => e.DescripcionRemisionDetalle)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("descripcion_remision_detalle");

                entity.Property(e => e.IdRemision)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("id_remision");

                entity.Property(e => e.ReferenciaRemisionDetalle)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("referencia_remision_detalle");

                entity.Property(e => e.TallaRemisionDetalle)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("talla_remision_detalle");

                entity.HasOne(d => d.IdRemisionNavigation)
                    .WithMany(p => p.RemisionDetalles)
                    .HasForeignKey(d => d.IdRemision)
                    .HasConstraintName("FK__remision___id_re__656C112C");
            });

            modelBuilder.Entity<TipoContrato>(entity =>
            {
                entity.HasKey(e => e.IdTipoContrato)
                    .HasName("PK__tipo_con__4CF5141B1EDB526F");

                entity.ToTable("tipo_contrato");

                entity.Property(e => e.IdTipoContrato)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_tipo_contrato");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.NombreContrato)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nombre_contrato");

                entity.Property(e => e.TipoContracto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo_contracto");
            });

            modelBuilder.Entity<TipoIdentificacion>(entity =>
            {
                entity.HasKey(e => e.IdTipoidentificacion)
                    .HasName("PK__tipo_ide__A47E36BE62C0F21A");

                entity.ToTable("tipo_identificacion");

                entity.Property(e => e.IdTipoidentificacion)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_tipoidentificacion");

                entity.Property(e => e.EstadoTipoidentificacion)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("estado_tipoidentificacion");

                entity.Property(e => e.NombreTipoidentificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_tipoidentificacion");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
