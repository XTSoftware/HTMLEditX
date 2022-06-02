using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTMLEditX
{
    public partial class MainEditor : Form
    {
        public MainEditor()
        {
            InitializeComponent();
        }

        private void rtbEditor_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnTemplate_Click(object sender, EventArgs e)
        {
            //Bodged approach to adding new lines, don't ask why

            string newLine = Environment.NewLine;
            rtbEditor.AppendText(" <!DOCTYPE html>" + newLine);
            rtbEditor.AppendText("<html>" + newLine);
            rtbEditor.AppendText("<head>" + newLine);
            rtbEditor.AppendText("<title>Hello World!</title>" + newLine);
            rtbEditor.AppendText("</head>" + newLine);
            rtbEditor.AppendText("<body>" + newLine);
            rtbEditor.AppendText(newLine);
            rtbEditor.AppendText("<h1>Hello World</h1>");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            System.IO.StreamWriter writer = new System.IO.StreamWriter(@"C:/Users/Public/preview.html");
            writer.Write(rtbEditor.Text.ToString());
            writer.Close();
            writer.Dispose();
            PreviewPane previewPane = new PreviewPane();
            previewPane.ShowDialog();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Save";
            saveDialog.Filter = "Hypertext Markup Language (HTML) Files (*.html)|*.html" + "|" +

                                "Plain Text Files (*.txt)|*.txt";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string filetosave = saveDialog.FileName;
                System.IO.StreamWriter writer = new System.IO.StreamWriter(filetosave);
                writer.Write(rtbEditor.Text.ToString());
                writer.Close();
                writer.Dispose();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    rtbEditor.Text = text;
                }
                catch (IOException)
                {
                }
            }
        }
    }
}
