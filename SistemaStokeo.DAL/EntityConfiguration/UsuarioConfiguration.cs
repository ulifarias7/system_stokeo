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
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(e => e.IdUsuario).HasName("PK__Usuario__645723A609CC3DA2");

            builder.ToTable("Usuario");

            builder.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            builder.Property(e => e.Clave)
                .HasMaxLength(40)
                .IsUnicode(false) //deberia ser unica
                .HasColumnName("clave");

            builder.Property(e => e.Correo)
                .HasMaxLength(40)
                .IsUnicode(false)//verdadero deberia ser (unica)
                .HasColumnName("correo");

            builder.Property(e => e.EsActivo)
                .HasDefaultValueSql("((1))")
                .HasColumnName("esActivo");

            builder.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");

            builder.Property(e => e.NombreCompleto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombreCompleto");

            builder.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("FK__Usuario__IdRol__412EB0B6");
        }
    }
}
