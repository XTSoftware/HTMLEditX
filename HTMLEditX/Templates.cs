using System;
using System.Windows.Forms;

namespace HTMLEditX
{
    public partial class Templates : Form
    {
        public Templates()
        {
            InitializeComponent();
        }

        private void btnSaveAsTemp_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter(@"C:/Users/Public/customtemplate.html");
            writer.Write(darkTextBox1.Text.ToString());
            writer.Close();
            writer.Dispose();
        }
    }
}
