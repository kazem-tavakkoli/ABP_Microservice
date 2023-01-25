using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AtrinGol.Contract.EntityFrameworkCore;

public class ContractHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<ContractHttpApiHostMigrationsDbContext>
{
    public ContractHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ContractHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Contract"));

        return new ContractHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
