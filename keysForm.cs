using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SoftAssist
{
    public partial class keysForm : Form
    {
        public keysForm()
        {
            InitializeComponent();
            vScrollBar1.Visible = false;
            barraProgreso.Visible = false;
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

        private void unzipAndInstall(System.Windows.Forms.RadioButton radioButton, String programName) {

            if (radioButton.Checked)
            {

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

        private void win10radioButton_CheckedChanged(object sender, EventArgs e)
        {
            unzipAndInstall(win10radioButton, "KMSpico");

        }

        private void win7radioButton_CheckedChanged(object sender, EventArgs e)
        {
            unzipAndInstall(win7radioButton, "RemoveWAT");
        }


        private void windows7bradioButton_CheckedChanged(object sender, EventArgs e)
        {
            unzipAndInstall(windows7bradioButton, "windows7loader");
            Installer installer = new Installer();
            Thread.Sleep(3000);

            installer.InstallProgram("Activadores\\windows7loader.exe", "", "windows7loader.exe");
        }

        private void office1316radioButton_CheckedChanged(object sender, EventArgs e)
        {
            unzipAndInstall(office1316radioButton, "KMSpico");
        }

        private void office360radioButton_CheckedChanged(object sender, EventArgs e)
        {
            unzipAndInstall(office360radioButton, "OInstall");
            Installer installer = new Installer();
            Thread.Sleep(3000);

            installer.InstallProgram("Activadores\\OInstall.exe", "", "OInstall.exe");
        }

        private void office2010radioButton_CheckedChanged(object sender, EventArgs e)
        {
            unzipAndInstall(office2010radioButton, "Office10");
        }

        private void winrarX64radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (winrarX64radioButton.Checked)
            {

                // Preguntar si esta seguro de realizar la accion
                DialogResult dialogResult = MessageBox.Show($"¿Estas seguro de ejecutar Winrar Crack x64?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Thread thread;
                    barraProgreso.Visible = true;
                    Installer installer = new Installer();
                    IProgress<int> progreso = new Progress<int>(valor =>
                    {
                        barraProgreso.Value = valor;
                    });

                    installer.InstallProgram("Activadores\\WinrarCrackX64.exe", "", "WinrarCrackX64.exe");
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
                    Thread thread;
                    barraProgreso.Visible = true;
                    Installer installer = new Installer();
                    IProgress<int> progreso = new Progress<int>(valor =>
                    {
                        barraProgreso.Value = valor;
                    });

                    installer.InstallProgram("Activadores\\WinrarCrackX32.exe", "", "WinrarCrackX32.exe");
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
                    Thread thread;
                    barraProgreso.Visible = true;
                    Installer installer = new Installer();
                    IProgress<int> progreso = new Progress<int>(valor =>
                    {
                        barraProgreso.Value = valor;
                    });

                    installer.InstallProgram("Activadores\\Nitro.txt", "", "Nitro.txt");
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
                    Thread thread;
                    barraProgreso.Visible = true;
                    Installer installer = new Installer();
                    IProgress<int> progreso = new Progress<int>(valor =>
                    {
                        barraProgreso.Value = valor;
                    });
                    string rutaCarpeta = @"C:\Windows\System32\drivers\etc";
                    Process.Start("explorer.exe", rutaCarpeta);

                    installer.InstallProgram("Activadores\\corel_hosts.txt", "", "corel_hosts.txt");


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
