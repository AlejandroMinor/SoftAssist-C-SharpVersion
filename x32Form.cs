﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftAssist
{
    public partial class x32Form : Form
    {
        private bool stopLoop = false;
        private Thread thread;
        public x32Form()
        {
            InitializeComponent();
            Stopbuttonx32.Visible = false;

        }

        private void changeImages(PictureBox imgName, String imgPath)
        {

            imgName.Image = Image.FromFile(imgPath);

        }

        private void x32Form_Load(object sender, EventArgs e)
        {

        }

        private void Installbuttonx32_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(RunLoop));
            thread.Start();
            Installbuttonx32.Visible = false;
            Stopbuttonx32.Visible = true;


        }

        private void RunLoop() {

            stopLoop = false;

            Installer installer = new Installer();

            // Definir los datos de cada programa en un array de objetos
            var programas = new[] {
            new { Checkbox = ChromeCheckBoxx32, Filename = "Chromex32.exe" , itsSilence = "", arch = "x32"},
            new { Checkbox = vlcCheckBoxx32, Filename = "Vlc.exe", itsSilence = "/S" , arch = "x32" },
            new { Checkbox = winrarCheckBoxx32, Filename = "Winrarx32.exe", itsSilence = "/S", arch = "x32" },
            new { Checkbox = javaCheckBoxx32, Filename = "Javax32.exe", itsSilence = "", arch = "x32" },
            new { Checkbox = firefoxCheckBoxx32, Filename = "Firefoxx32.exe", itsSilence = "", arch = "x32" },
            new { Checkbox = adobeCheckBoxx32, Filename = "Adobe.exe", itsSilence = "", arch = "x32" },
            new { Checkbox = codecpackCheckBoxx32, Filename = "CodecPack.exe", itsSilence = "", arch = "x32" },
            new { Checkbox = avastCheckBoxx32, Filename = "Avast.exe", itsSilence = "", arch = "x32" },
            new { Checkbox = nitroCheckBoxx32, Filename = "Nitrox32.exe", itsSilence = "", arch = "x32" },
            new { Checkbox = teamviewerCheckBoxx32, Filename = "Teamviewer.exe", itsSilence = "", arch = "x32" }

            };

            // Iterar sobre el array y llamar a InstallProgram para cada programa seleccionado
            foreach (var programa in programas)
            {
                if (stopLoop) { break; }

                if (programa.Checkbox.Checked)
                {
                    installer.InstallProgram($"{programa.arch}\\{programa.Filename}", programa.itsSilence, programa.Filename);
                }
            }

            Installbuttonx32.Visible = true;
            Stopbuttonx32.Visible = false;
            MessageBox.Show("Instalacion finalizada");


        }

        private void selectionCheckBoxx32_CheckedChanged(object sender, EventArgs e)
        {
            // Si esta seleccionado el checkbox de seleccionar todo entonces selecciona todos los checkbox de los programas
            if (selectionCheckBoxx32.Checked == true)
            {
                changeImages(selectionimgx32, "img\\index-48.png");
                selectionCheckBoxx32.Text = "Deseleccionar todos";
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
                changeImages(selectionimgx32, "img\\index-48B.png");
                selectionCheckBoxx32.Text = "Seleccionar todos";
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

        private void ChromeCheckBoxx32_CheckedChanged(object sender, EventArgs e)
        {
            if (ChromeCheckBoxx32.Checked == true)
            {

                changeImages(chromeImgx32, "img\\chrome-48.png");
            }

            else changeImages(chromeImgx32, "img\\chrome-48B.png");

        }

        private void vlcCheckBoxx32_CheckedChanged(object sender, EventArgs e)
        {
            if (vlcCheckBoxx32.Checked == true)
            {

                changeImages(vlcImgx32, "img\\vlc-48.png");
            }

            else changeImages(vlcImgx32, "img\\vlc-48B.png");
        }

        private void winrarCheckBoxx32_CheckedChanged(object sender, EventArgs e)
        {
            if (winrarCheckBoxx32.Checked == true)
            {
                changeImages(winrarImgx32, "img\\winrar-48.png");
            }
            else changeImages(winrarImgx32, "img\\winrar-48B.png");
        }

        private void javaCheckBoxx32_CheckedChanged(object sender, EventArgs e)
        {
            if (javaCheckBoxx32.Checked == true)
            {

                changeImages(javaImgx32, "img\\java-48.png");

            }
            else changeImages(javaImgx32, "img\\java-48B.png");

        }

        private void firefoxCheckBoxx32_CheckedChanged(object sender, EventArgs e)
        {
            if (firefoxCheckBoxx32.Checked == true)
            {
                changeImages(firefoxImgx32, "img\\firefox-48.png");
            }
            else changeImages(firefoxImgx32, "img\\firefox-48B.png");
        }

        private void adobeCheckBoxx32_CheckedChanged(object sender, EventArgs e)
        {
            if (adobeCheckBoxx32.Checked == true)
            {
                changeImages(adobeImgx32, "img\\pdf-48.png");

            }
            else changeImages(adobeImgx32, "img\\pdf-48B.png");
        }

        private void codecpackCheckBoxx32_CheckedChanged(object sender, EventArgs e)
        {
            if (codecpackCheckBoxx32.Checked == true)
            {

                changeImages(codepackImgx32, "img\\codec-48.png");

            }
            else changeImages(codepackImgx32, "img\\codec-48B.png");
        }

        private void avastCheckBoxx32_CheckedChanged(object sender, EventArgs e)
        {
            if (avastCheckBoxx32.Checked == true)
            {

                changeImages(avastImgx32, "img\\avast-48.png");

            }

            else changeImages(avastImgx32, "img\\avast-48B.png");
        }

        private void nitroCheckBoxx32_CheckedChanged(object sender, EventArgs e)
        {
            if (nitroCheckBoxx32.Checked == true)
            {
                changeImages(nitroImgx32, "img\\nitro-48.png");
            }
            else changeImages(nitroImgx32, "img\\nitro-48B.png");
        }

        private void teamviewerCheckBoxx32_CheckedChanged(object sender, EventArgs e)
        {
            if (teamviewerCheckBoxx32.Checked == true)
            {

                changeImages(teamviewerImgx32, "img\\teamviewer-48.png");

            }
            else changeImages(teamviewerImgx32, "img\\teamviewer-48B.png");
        }

        private void Stopbuttonx32_Click(object sender, EventArgs e)
        {

            // Preguntar si esta seguro de realizar la accion
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro de realizar esta acción?", "Confirmación", MessageBoxButtons.YesNo);
            // Si esta seguro de realizar la accion entonces ejecuta el codigo
            if (dialogResult == DialogResult.Yes)
            {
                stopLoop = true;
                MessageBox.Show("La instalación se detuvo");
                Stopbuttonx32.Visible= false;
                Installbuttonx32.Visible= true;

            }
            
        }
    }
}
