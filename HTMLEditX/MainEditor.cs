/* Copyright (c) 2022 XT Software

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions: */
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
            PreviewLoad();
            ExperimentalFeatures ef = new ExperimentalFeatures();
            ef.ShowDialog();
        }

        public void PreviewLoad()
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter(@"C:/Users/Public/preview.html");
            writer.Write(rtbEditor.Text.ToString());
            writer.Close();
            writer.Dispose();
        }
        private void darkSectionPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHTMLTempl_Click(object sender, EventArgs e)
        {
            //Bodged approach to adding new lines, don't ask why

            string newLine = Environment.NewLine;
            rtbEditor.AppendText(" <!DOCTYPE html>" + newLine);
            rtbEditor.AppendText("<html>" + newLine);
            rtbEditor.AppendText("<head>" + newLine);
            rtbEditor.AppendText("<title>This is displayed as the title</title>" + newLine);
            rtbEditor.AppendText("</head>" + newLine);
            rtbEditor.AppendText("<body>" + newLine);
            rtbEditor.AppendText(newLine);
            rtbEditor.AppendText("<h1>Hello World</h1>");
        }

        private void btnJSTemp_Click(object sender, EventArgs e)
        {
            string newLine = Environment.NewLine;
            rtbEditor.AppendText(newLine + "<script type = 'text/javascript'>");
            rtbEditor.AppendText(newLine + "   document.write('Hello, World!');       // Write Javascript code here");
            rtbEditor.AppendText(newLine + "</script>");
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            PreviewLoad();
            PreviewPane previewPane = new PreviewPane();
            previewPane.ShowDialog();
        }

        private void btnAddbtn_Click(object sender, EventArgs e)
        {
            // Makes new button in HTML with text "Button"
            string newLine = Environment.NewLine;
            rtbEditor.AppendText(newLine + " <button type=\"button\">button</button>");
        }

        private void btnAddHtmlComment_Click(object sender, EventArgs e)
        {
            string newLine = Environment.NewLine;
            rtbEditor.AppendText(newLine + "<!-- This is an example comment -->");
        }

        private void btnJScomment_Click(object sender, EventArgs e)
        {
            string newLine = Environment.NewLine;
            rtbEditor.AppendText(newLine + "// This is an example comment");
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            string nlbold = Environment.NewLine;
            rtbEditor.AppendText(nlbold + "<p><strong>This text is bold</strong></p>");
        }

        private void btnCustomTemp_Click(object sender, EventArgs e)
        {
            string CustomTEMP = File.ReadAllText("C:/Users/Public/customtemplate.html");
            string newLine = Environment.NewLine;
            rtbEditor.AppendText(newLine + CustomTEMP);
            
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            string newLine = Environment.NewLine;
            rtbEditor.AppendText(newLine + "<p><u>This is underlined text</u></p>");
        }

        private void btnHeadingI_Click(object sender, EventArgs e)
        {
            string nlHeadings = Environment.NewLine;
            rtbEditor.AppendText(nlHeadings + "<h1>Heading I</h1>");
        }

        private void btnHeadingII_Click(object sender, EventArgs e)
        {
            string nlHeadings = Environment.NewLine;
            rtbEditor.AppendText(nlHeadings + "<h2>Heading II</h2>");
        }

        private void btnHeadingIII_Click(object sender, EventArgs e)
        {
            string nlHeadings = Environment.NewLine;
            rtbEditor.AppendText(nlHeadings + "<h3>Heading III</h3>");
        }

        private void btnHeadingIV_Click(object sender, EventArgs e)
        {
            string nlHeadings = Environment.NewLine;
            rtbEditor.AppendText(nlHeadings + "<h4>Heading IV</h4>");
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            string nlTags = Environment.NewLine;
            rtbEditor.AppendText(nlTags + " <i>This is italic text</i> ");
        }

        private void btnUcheck_Click(object sender, EventArgs e)
        {
            UpdateChecker checker = new UpdateChecker();
            checker.ShowDialog();
        }

        private void btnPrevedge_Click(object sender, EventArgs e)
        {
            PreviewLoad();
            PreviewEdge prev = new PreviewEdge();
            prev.ShowDialog();
        }
    }
}
