using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using apiTesteSimples.Domains;

#nullable disable

namespace apiTesteSimples.Contexts
{
    public partial class BlocktimeContext : DbContext
    {
        public BlocktimeContext()
        {
        }

        public BlocktimeContext(DbContextOptions<BlocktimeContext> options)
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
                    .HasName("PK__EMPRESA__75D2CED4A3D3E588");

                entity.ToTable("EMPRESA");

                entity.Property(e => e.IdEmpresa)
                    .ValueGeneratedNever()
                    .HasColumnName("idEmpresa");

                entity.Property(e => e.NomeEmpresa)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nomeEmpresa");
            });

            modelBuilder.Entity<Equipamento>(entity =>
            {
                entity.HasKey(e => e.IdEquipamentos)
                    .HasName("PK__EQUIPAME__05C45F544EEB0135");

                entity.ToTable("EQUIPAMENTOS");

                entity.Property(e => e.IdEquipamentos).HasColumnName("idEquipamentos");

                entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

                entity.Property(e => e.Lat)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("lat");

                entity.Property(e => e.Lng)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("lng");

                entity.Property(e => e.Mac)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("mac");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.Equipamentos)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("FK__EQUIPAMEN__idEmp__38996AB5");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
