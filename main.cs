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

            x64button.FlatAppearance.BorderSize= 0;
            x64button.MouseEnter += (sender, e) => {
                x64button.ForeColor = Color.FromArgb(78, 70, 133);
               


            };

            x64button.MouseLeave += (sender, e) => {
                x64button.ForeColor = Color.FromArgb(146, 146, 174);
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
    }
}