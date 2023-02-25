using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftAssist
{
    public partial class keysForm : Form
    {
        public keysForm()
        {
            InitializeComponent();
            vScrollBar1.Visible = false;
        }

        private void keysForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Installbuttonx64_Click(object sender, EventArgs e)
        {
             Installer installer = new Installer();
            installer.DescomprimirArchivoZip("Activadores\\KMSpico.zip");
        }
    }
}
