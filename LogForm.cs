using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
