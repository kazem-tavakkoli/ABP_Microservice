using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace AtrinGol.Contract.EntityFrameworkCore;

public static class ContractDbContextModelCreatingExtensions
{
    public static void ConfigureContract(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        
        builder.Entity<Models.Contracts.Contract>(b =>
        {
            b.ToTable(ContractDbProperties.DbTablePrefix + nameof(Models.Contracts), ContractDbProperties.DbSchema);
            b.ConfigureByConvention();
            b.Property(q => q.Title)
                .IsRequired()
                .HasMaxLength(70);
            b.Property(x => x.Description)
                .IsRequired(false)
                .HasMaxLength(500);
        });
    }
}
