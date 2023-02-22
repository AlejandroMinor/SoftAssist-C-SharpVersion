using SoftAssist.Properties;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SoftAssist
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            

            SelectedItemImage.BackColor= Color.Transparent;
            SelectedItemImage.Visible= false;
            selectedForm.Visible = false;

            changeImages(x64button, "monitor", 0);
            changeImages(x86button, "monitor", 50);
            changeImages(officeSuiteButton, "office-365", 97);
            changeImages(keysbutton, "key-security", 144);
            changeImages(toolsButton, "tools", 191);
            changeImages(backupButton, "save", 232);
            changeImages(systemInfoButton, "system-information", 278);
            changeImages(logButton, "log", 325);


        }
        private void changeImages(Button buttonName, String buttonImgName, int ejeY) {

            Point currentLocation = SelectedItemImage.Location;

            buttonName.FlatAppearance.BorderSize = 0;
            buttonName.MouseEnter += (sender, e) =>
            {
                buttonName.ForeColor = Color.FromArgb(255, 76, 52);

                string dir = Path.GetDirectoryName(Application.ExecutablePath);
                string nombreArchivo = Path.Combine(dir, $@"img\icons8-{buttonImgName}-24B.png");
                buttonName.Image = Image.FromFile(nombreArchivo);
                SelectedItemImage.Visible = true;
                SelectedItemImage.Location = new Point(currentLocation.X, currentLocation.Y + ejeY);
                

            };

            buttonName.MouseLeave += (sender, e) =>
            {
                buttonName.ForeColor = Color.FromArgb(255, 255, 255);

                string dir = Path.GetDirectoryName(Application.ExecutablePath);
                string nombreArchivo = Path.Combine(dir, $@"img\icons8-{buttonImgName}-24A.png");
                buttonName.Image = Image.FromFile(nombreArchivo);
                SelectedItemImage.Visible = false;
            };

        }

        private void x64button_Click_1(object sender, EventArgs e)
        {
            // Crear una instancia del formulario a mostrar
            x64Form x64form = new x64Form();

            // Establecer el tamaño y la posición del formulario
            x64form.TopLevel = false;
            x64form.Size = centroMainForm.Size;
            x64form.Location = new Point(0, 0);

            // Agregar el formulario como un control secundario del panel
            centroMainForm.Controls.Add(x64form);

            // Quitar marco al formulario
            x64form.FormBorderStyle = FormBorderStyle.None;

            // Mostrar el formulario
            x64form.Show();

            focusButton(x64button);

        }

        private void focusButton(Button buttonID) {

            if (buttonID == x64button)
            {
                x64button.Focus();
                x64button.FlatAppearance.BorderSize = 1;

                selectedForm.Visible = true;
                selectedForm.Location = new Point(122, 24);
            }
            else {
                x64button.FlatAppearance.BorderSize = 0;
            }
            if (buttonID == x86button)
            {
                x86button.Focus();
                x86button.FlatAppearance.BorderSize = 1;

                selectedForm.Visible = true;
                selectedForm.Location = new Point(122, 76);

            }
            else { 
                x86button.FlatAppearance.BorderSize = 0;
            }
            if (buttonID == officeSuiteButton)
            {
                officeSuiteButton.Focus();
                officeSuiteButton.FlatAppearance.BorderSize = 1;

                selectedForm.Visible = true;
                selectedForm.Location = new Point(122, 121);
            }
            else
            {
                officeSuiteButton.FlatAppearance.BorderSize = 0;
            }
            if (buttonID == keysbutton)
            {
                keysbutton.Focus();
                keysbutton.FlatAppearance.BorderSize = 1;

                selectedForm.Visible = true;
                selectedForm.Location = new Point(122, 167);
            }
            else 
            { 
                keysbutton.FlatAppearance.BorderSize = 0;
            }
            if (buttonID == toolsButton)
            {
                toolsButton.Focus();
                toolsButton.FlatAppearance.BorderSize = 1;

                selectedForm.Visible = true;
                selectedForm.Location = new Point(122, 213);
            }
            else 
            { 
                toolsButton.FlatAppearance.BorderSize = 0;
            }
            if (buttonID == backupButton)
            {
                backupButton.Focus();
                backupButton.FlatAppearance.BorderSize = 1;

                selectedForm.Visible = true;
                selectedForm.Location = new Point(122, 259);
            }
            else
            {
                backupButton.FlatAppearance.BorderSize = 0;
            }
            if (buttonID == systemInfoButton)
            {
                systemInfoButton.Focus();
                systemInfoButton.FlatAppearance.BorderSize = 1;

                selectedForm.Visible = true;
                selectedForm.Location = new Point(122, 305);
            }
            else
            {
                systemInfoButton.FlatAppearance.BorderSize = 0;
            }
            if (buttonID == logButton)
            {
                logButton.Focus();
                logButton.FlatAppearance.BorderSize = 1;

                selectedForm.Visible = true;
                selectedForm.Location = new Point(122, 351);
            }
            else
            {
                logButton.FlatAppearance.BorderSize = 0;
            }



        }


        private void officeSuiteButton_Click(object sender, EventArgs e)
        {
            focusButton(officeSuiteButton);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            focusButton(keysbutton);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void x86button_Click(object sender, EventArgs e)
        {
            focusButton(x86button);
        }

        private void toolsButton_Click(object sender, EventArgs e)
        {
            focusButton(toolsButton);
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            focusButton(backupButton);
        }

        private void systemInfoButton_Click(object sender, EventArgs e)
        {
            focusButton(systemInfoButton);
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            focusButton(logButton);
        }
    }
}