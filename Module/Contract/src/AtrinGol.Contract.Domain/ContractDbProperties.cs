namespace AtrinGol.Contract;

public static class ContractDbProperties
{
    public static string DbTablePrefix { get; set; } = "";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Contract";
}
