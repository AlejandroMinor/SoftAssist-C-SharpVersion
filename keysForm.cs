using System.Diagnostics;

namespace SoftAssist
{
    public partial class keysForm : Form
    {
        // Creacion de objeto para ejecutar metodos de la clase Installer
        Installer installer = new Installer();
        private Thread thread;
        public keysForm()
        {
            InitializeComponent();
            vScrollBar1.Visible = false;
            windowsProgressBar.Visible = false;
            officeProgressBar.Visible = false;


        }

        private void keysForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void win10radioButton_CheckedChanged(object sender, EventArgs e)
        {

            // iniciar un nuevo hilo para ejecutar la instalacion
            thread = new Thread(() =>
            installer.unzipAndInstall(win10radioButton, "KMSpico", windowsProgressBar));
            thread.Start();

        }

        private void win7radioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Iniciar un nuevo hilo para ejecutar la instalacion
            thread = new Thread(() =>
            installer.unzipAndInstall(win7radioButton, "RemoveWAT", windowsProgressBar));
            thread.Start();

        }


        private void windows7bradioButton_CheckedChanged(object sender, EventArgs e)
        {

            installer.unzipAndInstall(windows7bradioButton, "windows7loader", windowsProgressBar);

            Thread.Sleep(3000);
            // Iniciar un nuevo hilo para ejecutar la instalacion
            thread = new Thread(() =>
            installer.InstallProgram("Activadores\\windows7loader.exe", "", "windows7loader.exe"));
            thread.Start();
        }

        private void office1316radioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Iniciar un nuevo hilo para ejecutar la instalacion
            thread = new Thread(() => 
            installer.unzipAndInstall(office1316radioButton, "KMSpico", officeProgressBar));
            thread.Start();
        }

        private void office360radioButton_CheckedChanged(object sender, EventArgs e)
        {
            installer.unzipAndInstall(office360radioButton, "OInstall", officeProgressBar);
            Thread.Sleep(3000);
            // Iniciar un nuevo hilo para ejecutar la instalacion
            thread = new Thread(() =>
            installer.InstallProgram("Activadores\\OInstall.exe", "", "OInstall.exe"));
            thread.Start();
        }

        private void office2010radioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Iniciar un nuevo hilo para ejecutar la instalacion
            thread = new Thread(() =>
            installer.unzipAndInstall(office2010radioButton, "Office10", officeProgressBar));
            thread.Start();
        }

        private void winrarX64radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (winrarX64radioButton.Checked)
            {

                // Preguntar si esta seguro de realizar la accion
                DialogResult dialogResult = MessageBox.Show($"¿Estas seguro de ejecutar Winrar Crack x64?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    windowsProgressBar.Visible = true;
                    Installer installer = new Installer();
                    IProgress<int> progreso = new Progress<int>(valor =>
                    {
                        windowsProgressBar.Value = valor;
                    });
                    // Iniciar un nuevo hilo para ejecutar la instalacion
                    thread = new Thread(() =>
                    installer.InstallProgram("Activadores\\WinrarCrackX64.exe", "", "WinrarCrackX64.exe"));
                    thread.Start();
                }
                else
                {
                    winrarX64radioButton.Checked = false;

                }
            }



        }

        private void winrarX32radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (winrarX32radioButton.Checked)
            {

                // Preguntar si esta seguro de realizar la accion
                DialogResult dialogResult = MessageBox.Show($"¿Estas seguro de ejecutar Winrar Crack x32?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    windowsProgressBar.Visible = true;
                    Installer installer = new Installer();
                    IProgress<int> progreso = new Progress<int>(valor =>
                    {
                        windowsProgressBar.Value = valor;
                    });
                    // Iniciar un nuevo hilo para ejecutar la instalacion
                    thread = new Thread(() =>
                    installer.InstallProgram("Activadores\\WinrarCrackX32.exe", "", "WinrarCrackX32.exe"));
                    thread.Start();
                }
                else
                {
                    winrarX32radioButton.Checked = false;

                }
            }
        }

        private void nitro8radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (nitro8radioButton.Checked)
            {

                // Preguntar si esta seguro de realizar la accion
                DialogResult dialogResult = MessageBox.Show($"¿Estas seguro de ejecutar esta acción?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    windowsProgressBar.Visible = true;
                    Installer installer = new Installer();
                    IProgress<int> progreso = new Progress<int>(valor =>
                    {
                        windowsProgressBar.Value = valor;
                    });
                    // Iniciar un nuevo hilo para ejecutar la instalacion
                    thread = new Thread(() =>
                    installer.InstallProgram("Activadores\\Nitro.txt", "", "Nitro.txt"));
                    thread.Start();
                }
                else
                {
                    nitro8radioButton.Checked = false;

                }
            }
        }

        private void corelhostradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (corelhostradioButton.Checked)
            {

                // Preguntar si esta seguro de realizar la accion
                DialogResult dialogResult = MessageBox.Show($"¿Estas seguro de ejecutar esta acción?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    
                    windowsProgressBar.Visible = true;
                    Installer installer = new Installer();
                    IProgress<int> progreso = new Progress<int>(valor =>
                    {
                        windowsProgressBar.Value = valor;
                    });
                    string rutaCarpeta = @"C:\Windows\System32\drivers\etc";
                    Process.Start("explorer.exe", rutaCarpeta);
                    // Iniciar un nuevo hilo para ejecutar la instalacion
                    thread = new Thread(() =>
                    installer.InstallProgram("Activadores\\corel_hosts.txt", "", "corel_hosts.txt"));
                    thread.Start();

                }
                else
                {
                    corelhostradioButton.Checked = false;

                }
            }
        }

        private void openPathbutton_Click(object sender, EventArgs e)
        {
            // Obtener la ubicación actual donde se está ejecutando el programa
            string rutaActual = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);

            // Abrir ventana del explorador de archivos en la ubicación actual
            Process.Start("explorer.exe", $"{rutaActual}\\Activadores");
        }
    }
}
