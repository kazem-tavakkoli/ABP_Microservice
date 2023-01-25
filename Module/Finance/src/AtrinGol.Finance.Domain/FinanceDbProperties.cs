namespace AtrinGol.Finance;

public static class FinanceDbProperties
{
    public static string DbTablePrefix { get; set; } = "";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Finance";
}
