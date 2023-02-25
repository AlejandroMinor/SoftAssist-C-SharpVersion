using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Compression;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SoftAssist
{
    internal class Installer
    {

        public void InstallProgram(String software, String Silent,String processName)
        {

            Process process = new Process();
            process.StartInfo.Verb = "runas";
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"/c  start /wait {software} {Silent}";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();


            while (!process.HasExited)
            {
                if (IsProcessRunning(processName))
                {
                    Console.WriteLine("Proceso en ejecucion");
                }
            }

        }


        public static bool IsProcessRunning(string serviceName)
        {
            Process process = new Process();
            process.StartInfo.FileName = "tasklist.exe";
            process.StartInfo.Arguments = "/FO CSV /FI \"IMAGENAME eq " + serviceName + "\"";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();

            return output.Contains(serviceName);
        }


        

        public void DescomprimirArchivoZip(string rutaArchivoZip)
        {
        ZipFile.ExtractToDirectory(rutaArchivoZip, "Activadores");
        }

}
}
