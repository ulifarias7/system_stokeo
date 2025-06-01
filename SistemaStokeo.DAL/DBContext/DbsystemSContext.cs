using Microsoft.EntityFrameworkCore;

namespace SistemaStokeo.DAL.DBContext;

//Aunque están en archivos separados, el compilador de C# los une en una sola clase final en tiempo de compilación, y EF Core no sabe (ni le importa) que están divididos.
public partial class DbsystemSContext : DbContext 
{
    public DbsystemSContext(){}

    public DbsystemSContext(DbContextOptions<DbsystemSContext> options) : base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbsystemSContext).Assembly);
    }
}


//COSA POR HACER 
// ver si la base de datos quedo bien(fk,pk ,nombres ,y si falto algo)
//ver si la base esta igual que en el curso(me parece que esta ,al lo de documento)
//ver lo de las clases