using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silkroski_C969.Models
{
    public class Log
    {

        public static void MakeLogFile() // Create a file to write to.
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory + "AppLog.txt"; // PWD + a filename?

            if (!File.Exists(path))
            {
                
                using (StreamWriter writer = File.CreateText(path))
                {
                    writer.WriteLine("New log file created at: " + System.DateTime.UtcNow + ".\n");
                }
            }

        }

        public void AddLogMessage()
        {
            //TODO
        }
    }
}
