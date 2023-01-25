using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace AtrinGol.Finance.EntityFrameworkCore;

public static class FinanceDbContextModelCreatingExtensions
{
    public static void ConfigureFinance(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
        
        builder.Entity<Models.Finances.Finance>(b =>
        {
            b.ToTable(FinanceDbProperties.DbTablePrefix + nameof(Models.Finances), FinanceDbProperties.DbSchema);
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
