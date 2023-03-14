namespace SoftAssist
{
    public partial class x64Form : Form
    {
        private bool stopLoop = false;
        private Thread thread;
        public x64Form()
        {
            InitializeComponent();
            Stopbuttonx64.Visible = false;

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
            thread = new Thread(new ThreadStart(RunLoop));
            thread.Start();
            Installbuttonx64.Visible = false;
            Stopbuttonx64.Visible = true;
            disableAllCheckBox();


        }

        // Funcion para desactivar todos los checkbox  
        private void disableAllCheckBox()
        {
            this.ChromeCheckBoxx64.Enabled = false;
            this.vlcCheckBoxx64.Enabled = false;
            this.winrarCheckBoxx64.Enabled = false;
            this.javaCheckBoxx64.Enabled = false;
            this.firefoxCheckBoxx64.Enabled = false;
            this.adobeCheckBoxx64.Enabled = false;
            this.codecpackCheckBoxx64.Enabled = false;
            this.avastCheckBoxx64.Enabled = false;
            this.nitroCheckBoxx64.Enabled = false;
            this.teamviewerCheckBoxx64.Enabled = false;
        }

        // Funcion para activar todos los checkbox
        private void enableAllCheckBox()
        {
            this.ChromeCheckBoxx64.Enabled = true;
            this.vlcCheckBoxx64.Enabled = true;
            this.winrarCheckBoxx64.Enabled = true;
            this.javaCheckBoxx64.Enabled = true;
            this.firefoxCheckBoxx64.Enabled = true;
            this.adobeCheckBoxx64.Enabled = true;
            this.codecpackCheckBoxx64.Enabled = true;
            this.avastCheckBoxx64.Enabled = true;
            this.nitroCheckBoxx64.Enabled = true;
            this.teamviewerCheckBoxx64.Enabled = true;
        }

        private void RunLoop()
        {

            stopLoop = false;

            Installer installer = new Installer();

            // Definir los datos de cada programa en un array de objetos
            var programas = new[] {
            new { Checkbox = ChromeCheckBoxx64, Filename = "ChromeX64.exe" , itsSilence = "", arch = "x64"},
            new { Checkbox = vlcCheckBoxx64, Filename = "Vlc.exe", itsSilence = "/S" , arch = "x32" },
            new { Checkbox = winrarCheckBoxx64, Filename = "WinrarX64.exe", itsSilence = "/S", arch = "x64" },
            new { Checkbox = javaCheckBoxx64, Filename = "JavaX64.exe", itsSilence = "", arch = "x64" },
            new { Checkbox = firefoxCheckBoxx64, Filename = "FirefoxX64.exe", itsSilence = "", arch = "x64" },
            new { Checkbox = adobeCheckBoxx64, Filename = "Adobe.exe", itsSilence = "", arch = "x32" },
            new { Checkbox = codecpackCheckBoxx64, Filename = "CodecPack.exe", itsSilence = "", arch = "x32" },
            new { Checkbox = avastCheckBoxx64, Filename = "Avast.exe", itsSilence = "", arch = "x32" },
            new { Checkbox = nitroCheckBoxx64, Filename = "NitroX64.exe", itsSilence = "", arch = "x64" },
            new { Checkbox = teamviewerCheckBoxx64, Filename = "Teamviewer.exe", itsSilence = "", arch = "x32" }

            };

            installer.writeLog("➡ INSTALACIÓN X64....................🔄");

            // Iterar sobre el array y llamar a InstallProgram para cada programa seleccionado 
            foreach (var programa in programas)
            {
                if (stopLoop) { break; }

                if (programa.Checkbox.Checked)
                {
                    installer.InstallProgram($"{programa.arch}\\{programa.Filename}", programa.itsSilence, programa.Filename);
                }
            }

            Installbuttonx64.Visible = true;
            Stopbuttonx64.Visible = false;
            MessageBox.Show("Instalacion Finalizada");
            enableAllCheckBox();


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
                selectionCheckBoxx64.Text = "Seleccionar todos";
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

        private void Stopbuttonx64_Click(object sender, EventArgs e)
        {

            // Preguntar si esta seguro de realizar la accion
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro de realizar esta acción?", "Confirmación", MessageBoxButtons.YesNo);
            // Si esta seguro de realizar la accion entonces ejecuta el codigo
            if (dialogResult == DialogResult.Yes)
            {
                stopLoop = true;
                MessageBox.Show("La instalación se detuvo");
                Stopbuttonx64.Visible = false;
                Installbuttonx64.Visible = true;
                enableAllCheckBox();

            }

        }
    }
}
