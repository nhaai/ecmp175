using LTW.Nhom1.Debugging;

namespace LTW.Nhom1
{
    public class Nhom1Consts
    {
        public const string LocalizationSourceName = "Nhom1";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = false;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "4a90b01ada904f1790a5e6cc7dfc0c22";
    }
}
