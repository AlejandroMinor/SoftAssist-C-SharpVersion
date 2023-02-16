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
            // Obtiene la posición actual del botón
            Point currentLocation = SelectedItemImage.Location;

            buttonName.FlatAppearance.BorderSize = 0;
            buttonName.MouseEnter += (sender, e) =>
            {
                buttonName.ForeColor = Color.FromArgb(78, 70, 133);

                string dir = Path.GetDirectoryName(Application.ExecutablePath);
                string nombreArchivo = Path.Combine(dir, $@"img\icons8-{buttonImgName}-24B.png");
                buttonName.Image = Image.FromFile(nombreArchivo);
                SelectedItemImage.Visible = true;
                SelectedItemImage.Location = new Point(currentLocation.X, currentLocation.Y + ejeY);
                

            };

            buttonName.MouseLeave += (sender, e) =>
            {
                buttonName.ForeColor = Color.FromArgb(146, 146, 174);

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



        }

        private void officeSuiteButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}