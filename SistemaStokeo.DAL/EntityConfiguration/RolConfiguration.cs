using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaStokeo.MODELS;

namespace SistemaStokeo.DAL.EntityConfiguration
{
    public class RolConfiguration : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.ToTable("rol");

            builder.HasKey(r => r.IdRol).HasName("PK__Rol__2A49584CDBF2A9B6");

            builder.Property(r => r.IdRol).HasColumnName("id_rol");

            builder.Property(r => r.fechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");

            builder.Property(r => r.nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");

            builder.HasIndex(r => r.nombre)
                .HasDatabaseName(name: "ux_rol_name")
                .IsUnique();
        }
    }
}
