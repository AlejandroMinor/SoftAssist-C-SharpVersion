using System.Diagnostics;
using System.IO.Compression;

namespace SoftAssist
{
    internal class Installer
    {

        public void InstallProgram(String software, String Silent, String processName)
        {
            //Software es el nombre del programa con su extensión .exe o msi
            //Silent es el comando para ejecutar el programa en modo silencioso
            //processName es el nombre del proceso que se ejecuta al instalar el programa osea, es el mismo nombre del programa con su extensión .exe o msi

            //Crea instancia del proceso y ejecuta el comando cmd.exe para mandar la orden de ejecutar el programa
            Process process = new Process();
            process.StartInfo.Verb = "runas";
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"/c  start /wait {software} {Silent}";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();

            // Mientras el proceso no termine, se ejecuta el metodo IsProcessRunning
            while (!process.HasExited)
            {
                if (IsProcessRunning(processName))
                {
                    Console.WriteLine("Proceso en ejecucion");
                }
            }

            // Se obtiene el nombre del proceso y se separa por el punto para obtener el nombre del programa
            string[] partes = processName.Split('.');
            string resultado = partes[0];

            // Se verifica si el proceso termino con exito o no y se escribe en el log
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
            // Se crea una instancia del proceso y se ejecuta el comando tasklist.exe para obtener los procesos en ejecucion
            Process process = new Process();
            process.StartInfo.FileName = "tasklist.exe";
            process.StartInfo.Arguments = "/FO CSV /FI \"IMAGENAME eq " + serviceName + "\"";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();

            // Se obtiene la salida del proceso y se verifica si el nombre del proceso esta en la salida
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
                 //Funcion para descomprimir, mandanddo datos para la barra de progreso
                 // rutaString es la ruta del archivo zip 
                 // rutaDestino es donde se va a descomprimir el archivo zip
                 // progress es la barra de progreso

                int totalEntradas = archivoZip.Entries.Count;
                int entradasDescomprimidas = 0;

                // Recorre cada entrada del archivo zip y la descomprime

                foreach (ZipArchiveEntry entrada in archivoZip.Entries)
                {
                    string rutaCompleta = Path.Combine(rutaDestino, entrada.FullName);
                    string nombreDirectorio = Path.GetDirectoryName(rutaCompleta);

                    // Si el directorio no existe, se crea
                    if (!string.IsNullOrEmpty(nombreDirectorio))
                    {
                        Directory.CreateDirectory(nombreDirectorio);
                    }

                    // Si la entrada es un archivo, se descomprime
                    entrada.ExtractToFile(rutaCompleta, true);

                    // Se incrementa el contador de entradas descomprimidas
                    entradasDescomprimidas++;

                    if (progress != null)
                    {
                        // Se calcula el porcentaje de descompresion y se reporta
                        int porcentajeCompletado = (int)((double)entradasDescomprimidas / totalEntradas * 100);
                        progress.Report(porcentajeCompletado);
                    }
                }
            }
        }

        public void unzipAndInstall(System.Windows.Forms.RadioButton radioButton, String programName, ProgressBar barraProgreso)
        {

            // Funcion para descomprimir y despues ejecutar el programa
            // radioButton es el radioButton que se selecciona para ejecutar el programa
            // programName es el nombre del programa
            // barraProgreso es la barra de progreso que se muestra mientras se descomprime el archivo zip



            if (radioButton.Checked)
            {
                barraProgreso.Value = 0;
                // Preguntar si esta seguro de realizar la accion
                DialogResult dialogResult = MessageBox.Show($"¿Estas seguro de ejecutar {programName}?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Crea un hilo para evitar que se bloquee la interfaz
                    Thread thread;
                    // Muestra la barra de progreso
                    barraProgreso.Visible = true;
                    // Crea una instancia de la clase Installer
                    Installer installer = new Installer();
                    // Crea una instancia de la clase Progress
                    IProgress<int> progreso = new Progress<int>(valor =>
                    {
                        barraProgreso.Value = valor;
                    });

                    // Crea un hilo para descomprimir el archivo zip
                    thread = new Thread(() =>
                    {
                        installer.DescomprimirArchivoZip($"Activadores\\{programName}.zip", "Activadores", progreso);
                    });
                    // Inicia el hilo para descomprimir el archivo zip
                    thread.Start();

                    // Mientras el hilo no termine, se ejecuta el metodo IsProcessRunning
                    installer.InstallProgram($"Activadores\\{programName}.exe", "", $"{programName}.exe");
                }
                else
                {
                    // Si no esta seguro de realizar la accion, se desmarca el radioButton
                    radioButton.Checked = false;

                }
            }

        }

        public void excuteCommand(string command) 
        {
            // Ejecuta un comando en la consola de windows
            // command es el comando que se va a ejecutar en la consola de windows
            {
            // Crea una instancia del proceso y ejecuta el comando cmd.exe para mandar la orden de ejecutar el programa
            Process process = new Process();
            process.StartInfo.Verb = "runas";
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"/c  start /wait {command}";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            
            }
        
        
        }


    }
}
