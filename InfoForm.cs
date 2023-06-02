using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftAssist
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
            richTextBox1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            // Empezar a construir el string con la información del sistema con unos saltos de linea
            sb.AppendLine("\n                               💻 Información del sistema 💻\n");

            // Información del procesador
            var processor = new ManagementObjectSearcher("SELECT Name FROM Win32_Processor")
                .Get()
                .OfType<ManagementObject>()
                .Select(mo => mo["Name"].ToString())
                .FirstOrDefault();
            sb.AppendLine($"➡ Procesador: {processor}");


            // Información de RAM
            var ramCapacity = new ManagementObjectSearcher("SELECT TotalPhysicalMemory FROM Win32_ComputerSystem")
                .Get()
                .OfType<ManagementObject>()
                .Select(mo => ulong.Parse(mo["TotalPhysicalMemory"].ToString()))
                .FirstOrDefault();
            var totalRAM = ramCapacity / (1024 * 1024); // Convertir de bytes a megabytes
            sb.AppendLine($"➡ RAM total: {totalRAM} MB");

            // Información del sistema operativo
            var osInfo = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem")
                .Get()
                .OfType<ManagementObject>()
                .FirstOrDefault();
            var osName = osInfo["Caption"].ToString();
            var osVersion = osInfo["Version"].ToString();
            var osArchitecture = osInfo["OSArchitecture"].ToString();
            sb.AppendLine($"➡ Sistema operativo: {osName}");
            sb.AppendLine($"➡ Versión del sistema operativo: {osVersion}");
            sb.AppendLine($"➡ Arquitectura del sistema operativo: {osArchitecture}");

            // Información de la tarjeta madre
            var motherboardManufacturer = new ManagementObjectSearcher("SELECT Manufacturer FROM Win32_BaseBoard")
                .Get()
                .OfType<ManagementObject>()
                .Select(mo => mo["Manufacturer"].ToString())
                .FirstOrDefault();
            sb.AppendLine($"➡ Fabricante de la tarjeta madre: {motherboardManufacturer}");

            var motherboardModel = new ManagementObjectSearcher("SELECT Product FROM Win32_BaseBoard")
                .Get()
                .OfType<ManagementObject>()
                .Select(mo => mo["Product"].ToString())
                .FirstOrDefault();
            sb.AppendLine($"➡ Modelo de la tarjeta madre: {motherboardModel}");

            string systemInfoString = sb.ToString();
            Console.WriteLine(systemInfoString);


            // Mostrar información del sistema en el cuadro de texto richTextBox
            richTextBox1.Text = systemInfoString;


        }
    }
}
