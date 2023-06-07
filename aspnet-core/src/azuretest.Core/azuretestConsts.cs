using azuretest.Debugging;

namespace azuretest
{
    public class azuretestConsts
    {
        public const string LocalizationSourceName = "azuretest";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "56ff751a9458481ea8bdbf74b7150702";
    }
}
