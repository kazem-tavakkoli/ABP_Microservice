using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AtrinGol.Finance.EntityFrameworkCore;

public class FinanceHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<FinanceHttpApiHostMigrationsDbContext>
{
    public FinanceHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<FinanceHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Finance"));

        return new FinanceHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
