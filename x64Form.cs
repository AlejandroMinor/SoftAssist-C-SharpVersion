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

        private void changeImages(PictureBox imgName, String imgPath)
        {

                imgName.Image = Image.FromFile(imgPath);

        }

        private void x64Form_Load(object sender, EventArgs e)
        {

        }

        private void Installbuttonx64_Click(object sender, EventArgs e)
        {
            Installer installer = new Installer();
            
            installer.InstallProgram("x64\\chromeX64.exe","", "chromeX64.exe");
            installer.InstallProgram("x64\\JavaX64.exe","", "JavaX64.exe");

        }

        private void selectionCheckBoxx64_CheckedChanged(object sender, EventArgs e)
        {
            // Si esta seleccionado el checkbox de seleccionar todo entonces selecciona todos los checkbox de los programas
            if (selectionCheckBoxx64.Checked == true)
            {   
                changeImages(selectionimgx64, "img\\index-48.png");
                selectionCheckBoxx64.Text = "Deseleccionar todos";
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
                changeImages(selectionimgx64, "img\\index-48B.png");
                selectionCheckBoxx64.Text= "Seleccionar todos";
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

        private void ChromeCheckBoxx64_CheckedChanged(object sender, EventArgs e)
        {
            if (ChromeCheckBoxx64.Checked == true)
            {

                changeImages(chromeImgx64, "img\\chrome-48.png");
            }

            else changeImages(chromeImgx64, "img\\chrome-48B.png");

        }

        private void vlcCheckBoxx64_CheckedChanged(object sender, EventArgs e)
        {
            if (vlcCheckBoxx64.Checked == true)
            {

                changeImages(vlcImgx64, "img\\vlc-48.png");
            }

            else changeImages(vlcImgx64, "img\\vlc-48B.png");
        }

        private void winrarCheckBoxx64_CheckedChanged(object sender, EventArgs e)
        {
            if (winrarCheckBoxx64.Checked == true)
            {
                changeImages(winrarImgx64, "img\\winrar-48.png");
            }
            else changeImages(winrarImgx64, "img\\winrar-48B.png");
        }

        private void javaCheckBoxx64_CheckedChanged(object sender, EventArgs e)
        {
            if (javaCheckBoxx64.Checked == true)
            {

                changeImages(javaImgx64, "img\\java-48.png");
                
            }
            else changeImages(javaImgx64, "img\\java-48B.png");
               
        }

        private void firefoxCheckBoxx64_CheckedChanged(object sender, EventArgs e)
        {
            if (firefoxCheckBoxx64.Checked == true)
            {
                changeImages(firefoxImgx64, "img\\firefox-48.png");
            }
            else changeImages(firefoxImgx64, "img\\firefox-48B.png");
        }

        private void adobeCheckBoxx64_CheckedChanged(object sender, EventArgs e)
        {
            if (adobeCheckBoxx64.Checked == true)
            {
                changeImages(adobeImgx64, "img\\pdf-48.png");

            }
            else changeImages(adobeImgx64, "img\\pdf-48B.png");
        }

        private void codecpackCheckBoxx64_CheckedChanged(object sender, EventArgs e)
        {
            if (codecpackCheckBoxx64.Checked == true)
            {

                changeImages(codepackImgx64, "img\\codec-48.png");

            }
            else changeImages(codepackImgx64, "img\\codec-48B.png");
        }

        private void avastCheckBoxx64_CheckedChanged(object sender, EventArgs e)
        {
            if (avastCheckBoxx64.Checked == true)
            {

                changeImages(avastImgx64, "img\\avast-48.png");

            }

            else changeImages(avastImgx64, "img\\avast-48B.png");
        }

        private void nitroCheckBoxx64_CheckedChanged(object sender, EventArgs e)
        {
            if (nitroCheckBoxx64.Checked == true)
            {
                changeImages(nitroImgx64, "img\\nitro-48.png");
            }
            else changeImages(nitroImgx64, "img\\nitro-48B.png");
        }

        private void teamviewerCheckBoxx64_CheckedChanged(object sender, EventArgs e)
        {
            if (teamviewerCheckBoxx64.Checked == true)
            {

                changeImages(teamviewerImgx64, "img\\teamviewer-48.png");

            }
            else changeImages(teamviewerImgx64, "img\\teamviewer-48B.png");
        }

    }
}
