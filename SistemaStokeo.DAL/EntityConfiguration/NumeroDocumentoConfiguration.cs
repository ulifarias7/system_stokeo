using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaStokeo.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaStokeo.DAL.EntityConfiguration
{
    public class NumeroDocumentoConfiguration : IEntityTypeConfiguration<NumeroDocumento>
    {
        public void Configure(EntityTypeBuilder<NumeroDocumento> builder)
        {
            builder.HasKey(e => e.IdNumeroDocumento).HasName("PK__NumeroDo__471E421AD9410032");

            builder.ToTable("NumeroDocumento");

            builder.Property(e => e.IdNumeroDocumento).HasColumnName("idNumeroDocumento");
            builder.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            builder.Property(e => e.UltimoNumero).HasColumnName("ultimo_Numero");
        }
    }
}
