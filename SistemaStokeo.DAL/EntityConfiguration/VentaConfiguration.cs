﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaStokeo.MODELS;

namespace SistemaStokeo.DAL.DBContext
{
    public partial class DbsystemSContext { public virtual DbSet<Venta> Venta { get; set; } }
    public class VentaConfiguration : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.ToTable("venta");

            builder.HasKey(e => e.IdVenta).HasName("PK__Venta__077D5614E34BBCE8");

            builder.Property(e => e.IdVenta).HasColumnName("id_venta");

            builder.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");

            builder.Property(e => e.NumeroDocumento)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("numero_documento");
            
            builder.Property(e => e.TipoPago)
                .HasColumnName("tipo_pago");

            builder.Property(e => e.Total)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total");
        }
    }
}
