using NexusDigital.Debugging;

namespace NexusDigital;

public class NexusDigitalConsts
{
    public const string LocalizationSourceName = "NexusDigital";

    public const string ConnectionStringName = "Default";

    public const bool MultiTenancyEnabled = true;


    /// <summary>
    /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
    /// </summary>
    public static readonly string DefaultPassPhrase =
        DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "e4d7f4f62e4f4df4a71a6e2f9fb74607";
}
