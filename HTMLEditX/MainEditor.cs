/* HTMLEditX - A web development IDE from XT Software
    Copyright (C) 2022 XT Software
    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see https://www.gnu.org/licenses/. */
using System;
using System.IO;
using System.Windows.Forms;

namespace HTMLEditX
{
    public partial class MainEditor : Form
    {
        public MainEditor()
        {
            InitializeComponent();

        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            DialogResult FontResult = fontDialog1.ShowDialog();

            if (FontResult != DialogResult.Cancel)
            {
                rtbEditor.Font = fontDialog1.Font;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Save";
            saveDialog.Filter = "Hypertext Markup Language (HTML) Files (*.html)|*.html" + "|" +

                                "Plain Text Files (*.txt)|*.txt" + "|" + "All files (*.*)|*.*";
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

        private void btnExperimental_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter(@"C:/Users/Public/preview.html");
            writer.Write(rtbEditor.Text.ToString());
            writer.Close();
            writer.Dispose();
            ExperimentalFeatures ef = new ExperimentalFeatures();
            ef.ShowDialog();
        }

        private void darkSectionPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
