using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ExtremeHelp.Api.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DatabaseContext>();

            // ==================================================================
            // !! TESTE DE DIAGNÓSTICO: A STRING DE CONEXÃO ESTÁ DIRETO AQUI !!
            // ==================================================================
            var connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=ExtremeHelpDB;Trusted_Connection=True;TrustServerCertificate=True;";

            builder.UseSqlServer(connectionString);

            return new DatabaseContext(builder.Options);
        }
    }
}