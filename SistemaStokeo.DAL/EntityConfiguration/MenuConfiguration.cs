using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaStokeo.MODELS;

namespace SistemaStokeo.DAL.DBContext
{
    public partial class DbsystemSContext { public virtual DbSet<Menu> Menus { get; set; } }
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.ToTable("menu");

            builder.HasKey(e => e.IdMenu).HasName("PK__Menu__4D7EA8E17A006C80");

            builder.Property(m => m.IdMenu).HasColumnName("id_menu");

            builder.Property(e => e.Icono)
                .IsUnicode(false)
                .HasColumnName("icono");

            builder.Property(e => e.Nombre).HasColumnName("nombre");

            builder.Property(e => e.Url)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("url");
        }
    }
}
