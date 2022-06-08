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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnJavaTemplate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnComment = new System.Windows.Forms.Button();
            this.btnAddbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnTemplate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.optionsPanel.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnJavaTemplate);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.optionsPanel);
            this.panel1.Controls.Add(this.btnPreview);
            this.panel1.Controls.Add(this.btnTemplate);
            this.panel1.Location = new System.Drawing.Point(489, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 565);
            this.panel1.TabIndex = 1;
            // 
            // btnJavaTemplate
            // 
            this.btnJavaTemplate.AutoSize = true;
            this.btnJavaTemplate.Location = new System.Drawing.Point(10, 63);
            this.btnJavaTemplate.Name = "btnJavaTemplate";
            this.btnJavaTemplate.Size = new System.Drawing.Size(116, 62);
            this.btnJavaTemplate.TabIndex = 6;
            this.btnJavaTemplate.Text = "Add JS Template";
            this.btnJavaTemplate.UseVisualStyleBackColor = true;
            this.btnJavaTemplate.Click += new System.EventHandler(this.btnJavaTemplate_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.btnComment);
            this.panel2.Controls.Add(this.btnAddbtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(10, 393);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 144);
            this.panel2.TabIndex = 5;
            // 
            // btnComment
            // 
            this.btnComment.Location = new System.Drawing.Point(7, 51);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(109, 23);
            this.btnComment.TabIndex = 2;
            this.btnComment.Text = "Comment";
            this.btnComment.UseVisualStyleBackColor = true;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // btnAddbtn
            // 
            this.btnAddbtn.Location = new System.Drawing.Point(7, 21);
            this.btnAddbtn.Name = "btnAddbtn";
            this.btnAddbtn.Size = new System.Drawing.Size(109, 23);
            this.btnAddbtn.TabIndex = 1;
            this.btnAddbtn.Text = "Clickable button";
            this.btnAddbtn.UseVisualStyleBackColor = true;
            this.btnAddbtn.Click += new System.EventHandler(this.btnAddbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Insert";
            // 
            // optionsPanel
            // 
            this.optionsPanel.BackColor = System.Drawing.Color.Gray;
            this.optionsPanel.Controls.Add(this.btnFont);
            this.optionsPanel.Controls.Add(this.btnOpen);
            this.optionsPanel.Controls.Add(this.label1);
            this.optionsPanel.Controls.Add(this.btnSave);
            this.optionsPanel.Location = new System.Drawing.Point(199, 4);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(152, 144);
            this.optionsPanel.TabIndex = 4;
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(4, 21);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(75, 23);
            this.btnFont.TabIndex = 1;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(3, 79);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Options";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(3, 50);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(10, 125);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 1;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnTemplate
            // 
            this.btnTemplate.AutoSize = true;
            this.btnTemplate.Location = new System.Drawing.Point(10, 4);
            this.btnTemplate.Name = "btnTemplate";
            this.btnTemplate.Size = new System.Drawing.Size(116, 62);
            this.btnTemplate.TabIndex = 0;
            this.btnTemplate.Text = "Add HTML Template";
            this.btnTemplate.UseVisualStyleBackColor = true;
            this.btnTemplate.Click += new System.EventHandler(this.btnTemplate_Click_1);
            // 
            // MainEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtbEditor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainEditor";
            this.Text = "HTMLEditX";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTemplate;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        public System.Windows.Forms.RichTextBox rtbEditor;
        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnJavaTemplate;
        private System.Windows.Forms.Button btnComment;
    }
}

