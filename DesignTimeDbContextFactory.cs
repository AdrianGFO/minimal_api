using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using minimal_api.infraestrutura.Db;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DbContexto>
{
    public DbContexto CreateDbContext(string[] args)
    {
        var connectionString = "Server=localhost;Port=3306;Database=minimal_api;Uid=root;Pwd=root;";

        var optionsBuilder = new DbContextOptionsBuilder<DbContexto>();
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

        return new DbContexto(optionsBuilder.Options);
    }
    
    
}