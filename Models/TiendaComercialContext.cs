using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace datos_personales.Models;

public partial class TiendaComercialContext : DbContext
{
    public TiendaComercialContext()
    {
    }

    public TiendaComercialContext(DbContextOptions<TiendaComercialContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DatosPersonale> DatosPersonales { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
        }
    }
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    //      => optionsBuilder.UseSqlServer("server=DESKTOP-OL866KF\\SQLEXPRESS; database=TiendaComercial; integrated security=true; Encrypt=False; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DatosPersonale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__datos_pe__3213E83FA09BFBE9");

            entity.ToTable("datos_personales");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApellidoMaterno)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("apellido_materno");
            entity.Property(e => e.ApellidoPaterno)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("apellido_paterno");
            entity.Property(e => e.Carnet).HasColumnName("carnet");
            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Expededo).HasColumnName("expededo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono).HasColumnName("telefono");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
