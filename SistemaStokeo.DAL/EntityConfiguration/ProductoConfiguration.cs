using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaStokeo.MODELS;

namespace SistemaStokeo.DAL.EntityConfiguration
{
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.HasKey(e => e.IdProducto).HasName("PK__Producto__07F4A1320141252F");

            builder.ToTable("Producto");

            builder.Property(e => e.IdProducto).HasColumnName("idProducto");
            builder.Property(e => e.EsActivo)
                .HasDefaultValueSql("((1))")
                .HasColumnName("esActivo");

            builder.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");

            builder.Property(e => e.IdCategoria).HasColumnName("idCategoria");
           
            builder.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");

            builder.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio");

            builder.Property(e => e.Stock).HasColumnName("stock");

            builder.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("FK__Producto__idCate__49C3F6B7");
        }
    }
}
