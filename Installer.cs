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

            string[] partes = processName.Split('.');
            string resultado = partes[0];

            if (process.ExitCode == 0)
            {
                writeLog($"{resultado}....................✅");
            }
            else
            {
                writeLog($"{resultado}....................❌");
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

        public void writeLog(String texto)
        {

            // Acceder al formulario que contiene el RichTextBox
            LogForm logform = Application.OpenForms.OfType<LogForm>().FirstOrDefault();

            if (logform != null)
            {
                // Escribir en el RichTextBox
                logform.RichTextBoxControl.AppendText($"{texto} \n");
            }

        }




        public void DescomprimirArchivoZip(string rutaArchivoZip, string rutaDestino, IProgress<int> progress = null)
        {
            using (ZipArchive archivoZip = ZipFile.OpenRead(rutaArchivoZip))
            {
                int totalEntradas = archivoZip.Entries.Count;
                int entradasDescomprimidas = 0;

                foreach (ZipArchiveEntry entrada in archivoZip.Entries)
                {
                    string rutaCompleta = Path.Combine(rutaDestino, entrada.FullName);
                    string nombreDirectorio = Path.GetDirectoryName(rutaCompleta);

                    if (!string.IsNullOrEmpty(nombreDirectorio))
                    {
                        Directory.CreateDirectory(nombreDirectorio);
                    }

                    entrada.ExtractToFile(rutaCompleta, true);

                    entradasDescomprimidas++;

                    if (progress != null)
                    {
                        int porcentajeCompletado = (int)((double)entradasDescomprimidas / totalEntradas * 100);
                        progress.Report(porcentajeCompletado);
                    }
                }
            }
        }

        public void unzipAndInstall(System.Windows.Forms.RadioButton radioButton, String programName, ProgressBar barraProgreso)
        {

            if (radioButton.Checked)
            {
                barraProgreso.Value = 0;
                // Preguntar si esta seguro de realizar la accion
                DialogResult dialogResult = MessageBox.Show($"¿Estas seguro de ejecutar {programName}?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Thread thread;
                    barraProgreso.Visible = true;
                    Installer installer = new Installer();
                    IProgress<int> progreso = new Progress<int>(valor =>
                    {
                        barraProgreso.Value = valor;
                    });

                    thread = new Thread(() =>
                    {
                        installer.DescomprimirArchivoZip($"Activadores\\{programName}.zip", "Activadores", progreso);
                    });
                    thread.Start();

                    installer.InstallProgram($"Activadores\\{programName}.exe", "", $"{programName}.exe");
                }
                else
                {
                    radioButton.Checked = false;

                }
            }

        }


    }
}
