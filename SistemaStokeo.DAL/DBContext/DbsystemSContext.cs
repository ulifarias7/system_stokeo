using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SistemaStokeo.DAL.EntityConfiguration;
using SistemaStokeo.MODELS;

namespace SistemaStokeo.DAL.DBContext;

public partial class DbsystemSContext : DbContext 
{
    public DbsystemSContext(){}

    public DbsystemSContext(DbContextOptions<DbsystemSContext> options) : base(options){}

    public virtual DbSet<Categoria> Categoria { get; set; }

    public virtual DbSet<DetalleVenta> DetalleVenta { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<MenuRol> MenuRols { get; set; }

    public virtual DbSet<NumeroDocumento> NumeroDocumentos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Venta> Venta { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //Aunque están en archivos separados, el compilador de C# los une en una sola clase final en tiempo de compilación, y EF Core no sabe (ni le importa) que están divididos.
    {
        // modelBuilder.ApplyConfiguration(new CategoriaConfiguration());
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbsystemSContext).Assembly);
    }
}
