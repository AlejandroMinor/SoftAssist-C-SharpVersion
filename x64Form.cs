using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftAssist
{
    public partial class x64Form : Form
    {
        public x64Form()
        {
            InitializeComponent();
        }

        private void x64Form_Load(object sender, EventArgs e)
        {

        }

        private void Installbuttonx64_Click(object sender, EventArgs e)
        {


        }

        private void selectionCheckBoxx64_CheckedChanged(object sender, EventArgs e)
        {
            // Si esta seleccionado el checkbox de seleccionar todo entonces selecciona todos los checkbox de los programas
            if (selectionCheckBoxx64.Checked == true)
            {
                // Selecciona todos los checkbox de los programas
                foreach (Control c in this.Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = true;
                    }
                }
            }
            else
            {
                // Deselecciona todos los checkbox de los programas
                foreach (Control c in this.Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
    }
}
