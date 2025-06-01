using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaStokeo.MODELS;

namespace SistemaStokeo.DAL.DBContext
{
    public partial class DbsystemSContext { public virtual DbSet<NumeroDocumento> NumeroDocumentos { get; set; } }
    public class NumeroDocumentoConfiguration : IEntityTypeConfiguration<NumeroDocumento>
    {
        public void Configure(EntityTypeBuilder<NumeroDocumento> builder)
        {
            builder.ToTable("numero_documento");

            builder.HasKey(e => e.IdNumeroDocumento).HasName("PK__NumeroDo__471E421AD9410032");

            builder.Property(e => e.IdNumeroDocumento).HasColumnName("id_numero_documento");

            builder.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");

            builder.Property(e => e.UltimoNumero).HasColumnName("ultimo_numero");
        }
    }
}
