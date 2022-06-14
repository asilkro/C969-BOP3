using System;
using System.IO;
using Silkroski_C969;

namespace Silkroski_C969.Models
{
    public class Log
    {
        
        public static string logpath = System.AppDomain.CurrentDomain.BaseDirectory + "AppLog.txt"; // PWD + a filename?
        public static void LogMessage(string userId, bool isConnected) // Create a file to write to.
        {
            string message = null;
            // Check if isConnected; if succeeded message = user logged in @ datetime
            // if failed, user unable to login @ datetime
            if (!File.Exists(logpath))
            {
                using (StreamWriter writer = File.CreateText(logpath))
                {
                    writer.WriteLine(message + " at " + System.DateTime.UtcNow + ".\n");
                    writer.WriteLine("New log file created at: " + System.DateTime.UtcNow + " UTC.\n");
                }
            }

            if (isConnected == true)
            {
                using (StreamWriter writer = File.AppendText(logpath))
                {
                    writer.WriteLine("User: " + userId + " logged in at: " + System.DateTime.UtcNow + " UTC.\n");
                }
            }

            if (isConnected == false)
            {
                using (StreamWriter writer = File.AppendText(logpath))
                {
                    writer.WriteLine("User: " + userId + " failed to login at: " + System.DateTime.UtcNow + " UTC.\n");
                }
            }
        }
    }
}
