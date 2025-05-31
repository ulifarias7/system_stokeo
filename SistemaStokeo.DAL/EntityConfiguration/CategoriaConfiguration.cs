using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaStokeo.MODELS;

namespace SistemaStokeo.DAL.EntityConfiguration 
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("categoria");

            builder.HasKey(e => e.IdCategoria).HasName("PK__Categori__A3C02A109FEFD495");

            builder.Property(e => e.IdCategoria).HasColumnName("id_categoria");

            builder.Property(e => e.Nombre).HasColumnName("nombre");

            builder.Property(e => e.EsActivo)
                .HasDefaultValueSql("((1))")
                .HasColumnName("es_activo");

            builder.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");

            builder.HasIndex(e => e.Nombre)
                .HasDatabaseName(name: "ux_categoria_nombre")
                .IsUnique();
        }
    }
}
