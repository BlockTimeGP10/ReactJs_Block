using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BlockTime_Tracking.Domains;

#nullable disable

namespace BlockTime_Tracking.Contexts
{
    public partial class BlockTrackingContext : DbContext
    {
        public BlockTrackingContext()
        {
        }

        public BlockTrackingContext(DbContextOptions<BlockTrackingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Equipamento> Equipamentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=NOTE0113D2\\SQLEXPRESS; initial catalog=BLOCKTIME_TRACKING; user Id=sa; pwd=Senai@132;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa)
                    .HasName("PK__EMPRESA__75D2CED47802F4C6");

                entity.ToTable("EMPRESA");

                entity.Property(e => e.IdEmpresa)
                    .ValueGeneratedNever()
                    .HasColumnName("idEmpresa");

                entity.Property(e => e.NomeEmpresa)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nomeEmpresa");
            });

            modelBuilder.Entity<Equipamento>(entity =>
            {
                entity.HasKey(e => e.IdEquipamento)
                    .HasName("PK__EQUIPAME__75940D3425179720");

                entity.ToTable("EQUIPAMENTOS");

                entity.HasIndex(e => e.NomeNotebook, "UQ__EQUIPAME__ADB7247D68667D2E")
                    .IsUnique();

                entity.Property(e => e.IdEquipamento)
                    .ValueGeneratedNever()
                    .HasColumnName("idEquipamento");

                entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

                entity.Property(e => e.Lat)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("lat");

                entity.Property(e => e.Lng)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("lng");

                entity.Property(e => e.NomeNotebook)
                    .IsRequired()
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("nomeNotebook")
                    .IsFixedLength(true);

                entity.Property(e => e.UltimaAtt)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ultimaAtt");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.Equipamentos)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("FK__EQUIPAMEN__idEmp__398D8EEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
