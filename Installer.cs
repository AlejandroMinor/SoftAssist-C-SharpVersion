using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SoftAssist
{
    internal class Installer
    {

        public void InstallProgram(String software, String Silent){

            Process process = new Process();
            process.StartInfo.Verb = "runas";
            process.StartInfo.FileName = "cmd.exe";
            //process.StartInfo.Arguments= $"/c  start /wait {software} {Silent}";
            process.StartInfo.Arguments = $"/c  start /wait {software} {Silent}";
            process.StartInfo.UseShellExecute= false;
            process.StartInfo.RedirectStandardOutput = true;
            //process.StartInfo.CreateNoWindow = true;
            process.Start();



            // Obtener la identidad actual del usuario
            WindowsIdentity identity = WindowsIdentity.GetCurrent();

            // Obtener los detalles del grupo al que pertenece el usuario
            WindowsPrincipal principal = new WindowsPrincipal(identity);

            // Verificar si el usuario es un administrador
            bool isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);

            if (isAdmin)
            {
                Console.WriteLine("El proceso actual se está ejecutando con permisos de administrador.");
            }
            else
            {
                MessageBox.Show("El programa necesita ser ejecutado como administrador para evitar conflictos en su funcionamiento. Por favor, ejecute el programa con permisos de administrador.");
            }




            //process.WaitForExit();
            //if (process.ExitCode == 0)
            //{
            //    MessageBox.Show("El programa se instaló correctamente.");
            //}
            //else
            //{
            //    MessageBox.Show("Ocurrió un error al instalar el programa.");
            //}
        }
    }
}
