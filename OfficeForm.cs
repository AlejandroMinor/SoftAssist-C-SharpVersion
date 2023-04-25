using System.Threading;

namespace SoftAssist
{
    public partial class OfficeForm : Form
    {
        Installer installer = new Installer();
        private Thread thread;
        public OfficeForm()
        {
            InitializeComponent();
        }

        private void office2019radioButton_CheckedChanged(object sender, EventArgs e)
        {

            if (office2019radioButton.Checked)
            {

                // Preguntar si esta seguro de realizar la accion
                DialogResult dialogResult = MessageBox.Show("¿Estas seguro de installar Office 2019?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    // iniciar un nuevo hilo para ejecutar la instalacion
                    thread = new Thread(() => 
                    installer.InstallProgram("Office\\Office-2019\\OInstall.exe", "", "OInstall.exe"));
                    thread.Start();


                }
                else
                {
                    office2019radioButton.Checked = false;
                }
            }


        }

        private void office2016radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (office2016radioButton.Checked)
            {

                // Preguntar si esta seguro de realizar la accion
                DialogResult dialogResult = MessageBox.Show("¿Estas seguro de installar Office 2016?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    
                    thread= new Thread(() =>
                    installer.InstallProgram("Office\\Office-2016\\64\\setup.exe", "", "setup.exe"));
                    thread.Start();

                }
                else
                {
                    office2016radioButton.Checked = false;
                }
            }
        }

        private void office2013radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (office2013radioButton.Checked)
            {

                // Preguntar si esta seguro de realizar la accion
                DialogResult dialogResult = MessageBox.Show("¿Estas seguro de installar Office 2013?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    thread= new Thread(() =>
                    installer.InstallProgram("Office\\Office-2013\\64\\setup.exe", "", "setup.exe"));
                    thread.Start();

                }
                else
                {
                    office2013radioButton.Checked = false;
                }
            }
        }

        private void office2010x64radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (office2010x64radioButton.Checked)
            {

                // Preguntar si esta seguro de realizar la accion
                DialogResult dialogResult = MessageBox.Show("¿Estas seguro de installar Office 2010 x64?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    thread= new Thread(() =>
                    installer.InstallProgram("Office\\Office-2010\\64\\setup.exe", "", "setup.exe"));
                    thread.Start();

                }
                else
                {
                    office2010x64radioButton.Checked = false;
                }
            }
        }

        private void office2010x32radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (office2010x32radioButton.Checked)
            {

                // Preguntar si esta seguro de realizar la accion
                DialogResult dialogResult = MessageBox.Show("¿Estas seguro de installar Office 2010 x32?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    thread= new Thread(() =>
                    installer.InstallProgram("Office\\Office-2010\\32\\setup.exe", "", "setup.exe"));
                    thread.Start();

                }
                else
                {
                    office2010x32radioButton.Checked = false;
                }
            }
        }

        private void office2007radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (office2007radioButton.Checked)
            {

                // Preguntar si esta seguro de realizar la accion
                DialogResult dialogResult = MessageBox.Show("¿Estas seguro de installar Office 2007?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    thread= new Thread(() =>
                    installer.InstallProgram("Office\\Office-2007\\OFFICEENTERPRISE\\SETUP.exe", "", "SETUP.exe"));
                    thread.Start();

                }
                else
                {
                    office2010x64radioButton.Checked = false;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
