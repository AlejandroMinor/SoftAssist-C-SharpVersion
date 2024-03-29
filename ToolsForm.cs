﻿using System.Management;

namespace SoftAssist
{
    public partial class ToolsForm : Form
    {
        public ToolsForm()
        {
            InitializeComponent();
            vScrollBar1.Hide();
        }

        private void crystalDiskradioButton_CheckedChanged(object sender, EventArgs e)
        {

            if (crystalDiskradioButton.Checked == true)
            {
                // Pregunta si se desea ejecutar la accion
                DialogResult dialogResult = MessageBox.Show($"¿Estas seguro de ejecutar esta acción?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Hilo para ejecutar el programa
                    Thread thread;
                    thread = new Thread(() =>
                    {
                        Installer installer = new Installer();
                        installer.InstallProgram("Extras\\CrystalDiskInfo\\DiskInfo64.exe", "", "DiskInfo64.exe");
                    });
                    thread.Start();
                }
                else
                {
                    crystalDiskradioButton.Checked = false;
                }
            }

        }

        private void saludhddradioButton_CheckedChanged(object sender, EventArgs e)
        {

            if (saludhddradioButton.Checked)
            {
                // Preguntar si esta seguro de realizar la accion
                DialogResult dialogResult = MessageBox.Show($"¿Estas seguro de ejecutar esta acción?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {


                    ManagementScope scope = new ManagementScope("\\\\.\\root\\cimv2");
                    scope.Connect();

                    // Query para obtener la información del estado de salud del disco duro
                    ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_DiskDrive");

                    ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
                    ManagementObjectCollection queryCollection = searcher.Get();


                    Installer installer = new Installer();
                    List<string> healthList = new List<string>();

                    foreach (ManagementObject m in queryCollection)
                    {
                        string health = m["Status"].ToString();
                        string model = m["Model"].ToString();


                        installer.writeLog($" ➡ Disco: {model}, Estado de salud: {health}  \n");

                        healthList.Add("💾 " + model + " Estado: " + health);

                    }
                    // Mostrar message box con los resultados guardados en la lista healthlist
                    string message = string.Join(Environment.NewLine, healthList);
                    MessageBox.Show("Resumen de el test. Puede ver el resultado completo en la sección de Log \n" + message, "Estado de salud del disco duro", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

                else
                {
                    saludhddradioButton.Checked = false;
                }

            }

        }

        private void diagnosticogroupBox_Enter(object sender, EventArgs e)
        {



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Todos los radiobuttons de la seccion se quitan de seleccion
            crystalDiskradioButton.Checked = false;
            saludhddradioButton.Checked = false;
            saludBateriaradioButton.Checked = false;
        }

        private void AdminDispositivosradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AdminDispositivosradioButton.Checked)
            {
                
                // Pregunta si se desea ejecutar la accion
                DialogResult dialogResult = MessageBox.Show($"¿Estas seguro de ejecutar esta acción?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) 
                {
                    Installer installer = new Installer();
                    installer.excuteCommand("devmgmt.msc");

                }
                else
                {
                    AdminDispositivosradioButton.Checked = false;
                }
                
            }

        }

        private void ControlPermisosradioButton_CheckedChanged(object sender, EventArgs e)
        {

            if (ControlPermisosradioButton.Checked)
            {

                // Pregunta si se desea ejecutar la accion
                DialogResult dialogResult = MessageBox.Show($"¿Estas seguro de ejecutar esta acción?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Installer installer = new Installer();
                    installer.excuteCommand("%windir%\\System32\\UserAccountControlSettings.exe");

                }
                else
                {
                    ControlPermisosradioButton.Checked = false;
                }

            }

        }

        private void AdminDiscosradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AdminDiscosradioButton.Checked)
            {

                // Pregunta si se desea ejecutar la accion
                DialogResult dialogResult = MessageBox.Show($"¿Estas seguro de ejecutar esta acción?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Installer installer = new Installer();
                    installer.excuteCommand("diskmgmt.msc");

                }
                else
                {
                    AdminDiscosradioButton.Checked = false;
                }

            }

            
        }
    }
}
