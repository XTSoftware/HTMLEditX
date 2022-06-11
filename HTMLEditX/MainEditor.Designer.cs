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

namespace HTMLEditX
{
    partial class MainEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainEditor));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.rtbEditor = new System.Windows.Forms.RichTextBox();
            this.darkDockPanel1 = new DarkUI.Docking.DarkDockPanel();
            this.darkSectionPanel1 = new DarkUI.Controls.DarkSectionPanel();
            this.btnExperimental = new DarkUI.Controls.DarkButton();
            this.btnOpen = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.btnFont = new DarkUI.Controls.DarkButton();
            this.label1 = new System.Windows.Forms.Label();
            this.darkSectionPanel2 = new DarkUI.Controls.DarkSectionPanel();
            this.btnBold = new DarkUI.Controls.DarkButton();
            this.btnJScomment = new DarkUI.Controls.DarkButton();
            this.btnAddHtmlComment = new DarkUI.Controls.DarkButton();
            this.btnAddbtn = new DarkUI.Controls.DarkButton();
            this.btnJSTemp = new DarkUI.Controls.DarkButton();
            this.btnHTMLTempl = new DarkUI.Controls.DarkButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPreview = new DarkUI.Controls.DarkButton();
            this.btnCustomTemp = new DarkUI.Controls.DarkButton();
            this.btnUnderline = new DarkUI.Controls.DarkButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHeadingI = new DarkUI.Controls.DarkButton();
            this.btnHeadingII = new DarkUI.Controls.DarkButton();
            this.btnHeadingIII = new DarkUI.Controls.DarkButton();
            this.btnHeadingIV = new DarkUI.Controls.DarkButton();
            this.darkSectionPanel1.SuspendLayout();
            this.darkSectionPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbEditor
            // 
            this.rtbEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbEditor.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbEditor.Location = new System.Drawing.Point(-1, 1);
            this.rtbEditor.Name = "rtbEditor";
            this.rtbEditor.Size = new System.Drawing.Size(494, 567);
            this.rtbEditor.TabIndex = 0;
            this.rtbEditor.Text = "";
            // 
            // darkDockPanel1
            // 
            this.darkDockPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkDockPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.darkDockPanel1.Location = new System.Drawing.Point(491, 0);
            this.darkDockPanel1.Name = "darkDockPanel1";
            this.darkDockPanel1.Size = new System.Drawing.Size(361, 570);
            this.darkDockPanel1.TabIndex = 1;
            // 
            // darkSectionPanel1
            // 
            this.darkSectionPanel1.Controls.Add(this.btnExperimental);
            this.darkSectionPanel1.Controls.Add(this.btnOpen);
            this.darkSectionPanel1.Controls.Add(this.btnSave);
            this.darkSectionPanel1.Controls.Add(this.btnFont);
            this.darkSectionPanel1.Controls.Add(this.label1);
            this.darkSectionPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.darkSectionPanel1.Location = new System.Drawing.Point(0, 470);
            this.darkSectionPanel1.Name = "darkSectionPanel1";
            this.darkSectionPanel1.SectionHeader = null;
            this.darkSectionPanel1.Size = new System.Drawing.Size(491, 100);
            this.darkSectionPanel1.TabIndex = 2;
            this.darkSectionPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.darkSectionPanel1_Paint);
            // 
            // btnExperimental
            // 
            this.btnExperimental.Location = new System.Drawing.Point(7, 28);
            this.btnExperimental.Name = "btnExperimental";
            this.btnExperimental.Padding = new System.Windows.Forms.Padding(5);
            this.btnExperimental.Size = new System.Drawing.Size(84, 39);
            this.btnExperimental.TabIndex = 4;
            this.btnExperimental.Text = "Experimental settings";
            this.btnExperimental.Click += new System.EventHandler(this.btnExperimental_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(398, 58);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Padding = new System.Windows.Forms.Padding(5);
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(398, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(317, 29);
            this.btnFont.Name = "btnFont";
            this.btnFont.Padding = new System.Windows.Forms.Padding(5);
            this.btnFont.Size = new System.Drawing.Size(75, 23);
            this.btnFont.TabIndex = 1;
            this.btnFont.Text = "Font";
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Options";
            // 
            // darkSectionPanel2
            // 
            this.darkSectionPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.darkSectionPanel2.Controls.Add(this.btnHeadingIV);
            this.darkSectionPanel2.Controls.Add(this.btnHeadingIII);
            this.darkSectionPanel2.Controls.Add(this.btnHeadingII);
            this.darkSectionPanel2.Controls.Add(this.btnHeadingI);
            this.darkSectionPanel2.Controls.Add(this.label3);
            this.darkSectionPanel2.Controls.Add(this.btnUnderline);
            this.darkSectionPanel2.Controls.Add(this.btnCustomTemp);
            this.darkSectionPanel2.Controls.Add(this.btnBold);
            this.darkSectionPanel2.Controls.Add(this.btnJScomment);
            this.darkSectionPanel2.Controls.Add(this.btnAddHtmlComment);
            this.darkSectionPanel2.Controls.Add(this.btnAddbtn);
            this.darkSectionPanel2.Controls.Add(this.btnJSTemp);
            this.darkSectionPanel2.Controls.Add(this.btnHTMLTempl);
            this.darkSectionPanel2.Controls.Add(this.label2);
            this.darkSectionPanel2.Location = new System.Drawing.Point(640, 12);
            this.darkSectionPanel2.Name = "darkSectionPanel2";
            this.darkSectionPanel2.SectionHeader = null;
            this.darkSectionPanel2.Size = new System.Drawing.Size(212, 510);
            this.darkSectionPanel2.TabIndex = 3;
            // 
            // btnBold
            // 
            this.btnBold.Location = new System.Drawing.Point(101, 115);
            this.btnBold.Name = "btnBold";
            this.btnBold.Padding = new System.Windows.Forms.Padding(5);
            this.btnBold.Size = new System.Drawing.Size(107, 23);
            this.btnBold.TabIndex = 6;
            this.btnBold.Text = "Bold text";
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnJScomment
            // 
            this.btnJScomment.Location = new System.Drawing.Point(101, 86);
            this.btnJScomment.Name = "btnJScomment";
            this.btnJScomment.Padding = new System.Windows.Forms.Padding(5);
            this.btnJScomment.Size = new System.Drawing.Size(107, 23);
            this.btnJScomment.TabIndex = 5;
            this.btnJScomment.Text = "JS Comment";
            this.btnJScomment.Click += new System.EventHandler(this.btnJScomment_Click);
            // 
            // btnAddHtmlComment
            // 
            this.btnAddHtmlComment.Location = new System.Drawing.Point(101, 57);
            this.btnAddHtmlComment.Name = "btnAddHtmlComment";
            this.btnAddHtmlComment.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddHtmlComment.Size = new System.Drawing.Size(107, 23);
            this.btnAddHtmlComment.TabIndex = 4;
            this.btnAddHtmlComment.Text = "HTML comment";
            this.btnAddHtmlComment.Click += new System.EventHandler(this.btnAddHtmlComment_Click);
            // 
            // btnAddbtn
            // 
            this.btnAddbtn.Location = new System.Drawing.Point(101, 28);
            this.btnAddbtn.Name = "btnAddbtn";
            this.btnAddbtn.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddbtn.Size = new System.Drawing.Size(107, 23);
            this.btnAddbtn.TabIndex = 3;
            this.btnAddbtn.Text = "Clickable button";
            this.btnAddbtn.Click += new System.EventHandler(this.btnAddbtn_Click);
            // 
            // btnJSTemp
            // 
            this.btnJSTemp.Location = new System.Drawing.Point(7, 86);
            this.btnJSTemp.Name = "btnJSTemp";
            this.btnJSTemp.Padding = new System.Windows.Forms.Padding(5);
            this.btnJSTemp.Size = new System.Drawing.Size(84, 52);
            this.btnJSTemp.TabIndex = 2;
            this.btnJSTemp.Text = "Add JS Template";
            this.btnJSTemp.Click += new System.EventHandler(this.btnJSTemp_Click);
            // 
            // btnHTMLTempl
            // 
            this.btnHTMLTempl.Location = new System.Drawing.Point(7, 28);
            this.btnHTMLTempl.Name = "btnHTMLTempl";
            this.btnHTMLTempl.Padding = new System.Windows.Forms.Padding(5);
            this.btnHTMLTempl.Size = new System.Drawing.Size(84, 52);
            this.btnHTMLTempl.TabIndex = 1;
            this.btnHTMLTempl.Text = "Add HTML Template";
            this.btnHTMLTempl.Click += new System.EventHandler(this.btnHTMLTempl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Insert";
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreview.Location = new System.Drawing.Point(500, 17);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Padding = new System.Windows.Forms.Padding(5);
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnCustomTemp
            // 
            this.btnCustomTemp.Location = new System.Drawing.Point(4, 144);
            this.btnCustomTemp.Name = "btnCustomTemp";
            this.btnCustomTemp.Padding = new System.Windows.Forms.Padding(5);
            this.btnCustomTemp.Size = new System.Drawing.Size(87, 61);
            this.btnCustomTemp.TabIndex = 7;
            this.btnCustomTemp.Text = "Add Experimental Custom Template";
            this.btnCustomTemp.Click += new System.EventHandler(this.btnCustomTemp_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.Location = new System.Drawing.Point(101, 144);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Padding = new System.Windows.Forms.Padding(5);
            this.btnUnderline.Size = new System.Drawing.Size(107, 23);
            this.btnUnderline.TabIndex = 8;
            this.btnUnderline.Text = "Underlined text";
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Add Headings";
            // 
            // btnHeadingI
            // 
            this.btnHeadingI.Location = new System.Drawing.Point(4, 420);
            this.btnHeadingI.Name = "btnHeadingI";
            this.btnHeadingI.Padding = new System.Windows.Forms.Padding(5);
            this.btnHeadingI.Size = new System.Drawing.Size(75, 23);
            this.btnHeadingI.TabIndex = 10;
            this.btnHeadingI.Text = "Heading 1";
            this.btnHeadingI.Click += new System.EventHandler(this.btnHeadingI_Click);
            // 
            // btnHeadingII
            // 
            this.btnHeadingII.Location = new System.Drawing.Point(85, 420);
            this.btnHeadingII.Name = "btnHeadingII";
            this.btnHeadingII.Padding = new System.Windows.Forms.Padding(5);
            this.btnHeadingII.Size = new System.Drawing.Size(75, 23);
            this.btnHeadingII.TabIndex = 11;
            this.btnHeadingII.Text = "Heading 2";
            this.btnHeadingII.Click += new System.EventHandler(this.btnHeadingII_Click);
            // 
            // btnHeadingIII
            // 
            this.btnHeadingIII.Location = new System.Drawing.Point(3, 449);
            this.btnHeadingIII.Name = "btnHeadingIII";
            this.btnHeadingIII.Padding = new System.Windows.Forms.Padding(5);
            this.btnHeadingIII.Size = new System.Drawing.Size(75, 23);
            this.btnHeadingIII.TabIndex = 12;
            this.btnHeadingIII.Text = "Heading 3";
            this.btnHeadingIII.Click += new System.EventHandler(this.btnHeadingIII_Click);
            // 
            // btnHeadingIV
            // 
            this.btnHeadingIV.Location = new System.Drawing.Point(85, 449);
            this.btnHeadingIV.Name = "btnHeadingIV";
            this.btnHeadingIV.Padding = new System.Windows.Forms.Padding(5);
            this.btnHeadingIV.Size = new System.Drawing.Size(75, 23);
            this.btnHeadingIV.TabIndex = 13;
            this.btnHeadingIV.Text = "Heading 4";
            this.btnHeadingIV.Click += new System.EventHandler(this.btnHeadingIV_Click);
            // 
            // MainEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 570);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.darkSectionPanel2);
            this.Controls.Add(this.darkSectionPanel1);
            this.Controls.Add(this.darkDockPanel1);
            this.Controls.Add(this.rtbEditor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainEditor";
            this.Text = "HTMLEditX Editor";
            this.darkSectionPanel1.ResumeLayout(false);
            this.darkSectionPanel1.PerformLayout();
            this.darkSectionPanel2.ResumeLayout(false);
            this.darkSectionPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        public System.Windows.Forms.RichTextBox rtbEditor;
        private DarkUI.Docking.DarkDockPanel darkDockPanel1;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel1;
        private System.Windows.Forms.Label label1;
        private DarkUI.Controls.DarkButton btnFont;
        private DarkUI.Controls.DarkButton btnSave;
        private DarkUI.Controls.DarkButton btnOpen;
        private DarkUI.Controls.DarkButton btnExperimental;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel2;
        private DarkUI.Controls.DarkButton btnHTMLTempl;
        private System.Windows.Forms.Label label2;
        private DarkUI.Controls.DarkButton btnJSTemp;
        private DarkUI.Controls.DarkButton btnPreview;
        private DarkUI.Controls.DarkButton btnAddbtn;
        private DarkUI.Controls.DarkButton btnAddHtmlComment;
        private DarkUI.Controls.DarkButton btnJScomment;
        private DarkUI.Controls.DarkButton btnBold;
        private DarkUI.Controls.DarkButton btnCustomTemp;
        private DarkUI.Controls.DarkButton btnUnderline;
        private DarkUI.Controls.DarkButton btnHeadingIV;
        private DarkUI.Controls.DarkButton btnHeadingIII;
        private DarkUI.Controls.DarkButton btnHeadingII;
        private DarkUI.Controls.DarkButton btnHeadingI;
        private System.Windows.Forms.Label label3;
    }
}

