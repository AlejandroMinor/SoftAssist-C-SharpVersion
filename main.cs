using SoftAssist.Properties;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SoftAssist
{
    public partial class main : Form
    {

        // Crear una instancia de los formularios a mostrar
        x64Form x64form = new x64Form();
        x32Form x32form = new x32Form();
        keysForm keysform = new keysForm();

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
            changeImages(keysbutton, "key-security", 143);
            changeImages(toolsButton, "tools", 189);
            changeImages(backupButton, "save", 235);
            changeImages(systemInfoButton, "system-information", 281);
            changeImages(logButton, "log", 327);


        }
        private void changeImages(Button buttonName, String buttonImgName, int ejeY) {

            changeSelectecForm(buttonName);

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
            x32form.Hide();
            keysform.Hide();

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

        private void changeSelectecForm(Button buttonID) {
            buttonID.MouseEnter += (sender, e) =>
            {
                string dir = Path.GetDirectoryName(Application.ExecutablePath);
                string pathselectedForm = Path.Combine(dir, $@"img\icons8-chevron-left-24B.png");
                selectedForm.Image = Image.FromFile(pathselectedForm);
            };

            buttonID.MouseLeave += (sender, e) =>
            {
                string dir = Path.GetDirectoryName(Application.ExecutablePath);
                string pathselectedForm = Path.Combine(dir, $@"img\icons8-chevron-left-24.png");
                selectedForm.Image = Image.FromFile(pathselectedForm);
            };


        }


        private void officeSuiteButton_Click(object sender, EventArgs e)
        {
            focusButton(officeSuiteButton);
        }

        private void keysbutton_Click(object sender, EventArgs e)
        {
            focusButton(keysbutton);
            // Establecer el tamaño y la posición del formulario
            keysform.TopLevel = false;
            keysform.Size = centroMainForm.Size;
            keysform.Location = new Point(0,0);

            // Agregar el formulario como un control secundario del panel
            centroMainForm.Controls.Add(keysform);

            // Quitar marco al formulario
            keysform.FormBorderStyle = FormBorderStyle.None;

            // Mostrar el formulario
            keysform.Show();

            focusButton(keysbutton);

            x64form.Hide();
            x32form.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void x86button_Click(object sender, EventArgs e)
        {



            // Establecer el tamaño y la posición del formulario
            x32form.TopLevel = false;
            x32form.Size = centroMainForm.Size;
            x32form.Location = new Point(0, 0);

            // Agregar el formulario como un control secundario del panel
            centroMainForm.Controls.Add(x32form);

            // Quitar marco al formulario
            x32form.FormBorderStyle = FormBorderStyle.None;

            // Mostrar el formulario
            x32form.Show();

            focusButton(x86button);
            x64form.Hide();
            keysform.Hide();
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

        private void centroMainForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}