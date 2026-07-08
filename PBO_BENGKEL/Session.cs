using System.Data;

namespace PBO_BENGKEL
{
    internal static class Session
    {
        public static string Username { get; set; }
        public static string Role { get; set; }
        public static string NamaLengkap { get; set; }
        public static string FotoPath { get; set; }

        public static void Clear()
        {
            Username = null;
            Role = null;
            NamaLengkap = null;
            FotoPath = null;
        }
    }
}
