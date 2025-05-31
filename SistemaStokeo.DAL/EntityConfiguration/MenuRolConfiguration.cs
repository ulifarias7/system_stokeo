using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaStokeo.MODELS;

namespace SistemaStokeo.DAL.EntityConfiguration
{
    public class MenuRolConfiguration : IEntityTypeConfiguration<MenuRol>
    {
        public void Configure(EntityTypeBuilder<MenuRol> builder)
        {
            builder.ToTable("menu_rol");

            builder.HasKey(e => e.IdMenuRol).HasName("PK__MenuRol__9D6D61A45301E146");

            builder.Property(e => e.IdMenuRol).HasColumnName("id_menu_rol");
            builder.Property(e => e.IdMenu).HasColumnName("id_menu");
            builder.Property(e => e.IdRol).HasColumnName("id_rol");

            builder.HasOne(d => d.IdMenuNavigation)
                .WithMany(p => p.MenuRols)
                .HasForeignKey(d => d.IdMenu)
                .HasConstraintName("FK__MenuRol__idMenu__3D5E1FD2");

            builder.HasOne(d => d.IdRolNavigation)
                .WithMany(p => p.MenuRols)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("FK__MenuRol__idRol__3E52440B");
        }
    }
}
