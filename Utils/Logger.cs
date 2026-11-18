using System;
using System.IO;

namespace GreenLifeOrganicStore.Utils
{

    public static class Logger
    {

        private static string LogPath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "system_log.txt");

        public static void LogInfo(string message)
        {
            WriteLog("INFO", message);
        }

        public static void LogError(string message, Exception ex = null)
        {
            string fullMsg = message + (ex != null ? " | EX: " + ex.Message : "");
            WriteLog("ERROR", fullMsg);
        }

        private static void WriteLog(string level, string msg)
        {
            try {
                string line = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " [" + level + "] " + msg;
                File.AppendAllLines(LogPath, new[] { line });
            } catch { }
        }
    }
}
