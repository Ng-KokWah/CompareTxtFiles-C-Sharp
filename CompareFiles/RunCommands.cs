using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareFiles
{
    class RunCommands
    {
        private static String result;
        public static String RunCmdAndGetOutput(String command)
        {
            try
            {
                ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + command);
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;
                Process proc = new Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                result = proc.StandardOutput.ReadToEnd();
            }
            catch (Exception objException)
            {
                Console.WriteLine("obj Exception occurred!");
            }
            return result;
        }
    }
}
