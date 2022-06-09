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

        public static void MakeLogFile()
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory + "AppLog.txt";

            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter writer = File.CreateText(path))
                {
                    writer.WriteLine("New log file created.\n");
                }
            }

            // Open the file to read from.
            using (StreamReader reader = File.OpenText(path))
            {
                string s = "";
                while ((s = reader.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public void AddLogMessage()
        {

        }
    }
}
