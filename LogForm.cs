namespace SoftAssist
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();

        }

        private void logForm_Load(object sender, EventArgs e)
        {

        }

        public RichTextBox RichTextBoxControl
        {
            get { return richTextBox; }
        }

    }
}
