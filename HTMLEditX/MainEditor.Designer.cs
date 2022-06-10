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
            this.btnFont = new DarkUI.Controls.DarkButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.btnOpen = new DarkUI.Controls.DarkButton();
            this.btnExperimental = new DarkUI.Controls.DarkButton();
            this.darkSectionPanel2 = new DarkUI.Controls.DarkSectionPanel();
            this.darkSectionPanel1.SuspendLayout();
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
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(5, 29);
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
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(398, 28);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(398, 65);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Padding = new System.Windows.Forms.Padding(5);
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnExperimental
            // 
            this.btnExperimental.Location = new System.Drawing.Point(7, 65);
            this.btnExperimental.Name = "btnExperimental";
            this.btnExperimental.Padding = new System.Windows.Forms.Padding(5);
            this.btnExperimental.Size = new System.Drawing.Size(140, 23);
            this.btnExperimental.TabIndex = 4;
            this.btnExperimental.Text = "Experimental settings";
            this.btnExperimental.Click += new System.EventHandler(this.btnExperimental_Click);
            // 
            // darkSectionPanel2
            // 
            this.darkSectionPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.darkSectionPanel2.Location = new System.Drawing.Point(640, 12);
            this.darkSectionPanel2.Name = "darkSectionPanel2";
            this.darkSectionPanel2.SectionHeader = null;
            this.darkSectionPanel2.Size = new System.Drawing.Size(200, 100);
            this.darkSectionPanel2.TabIndex = 3;
            // 
            // MainEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 570);
            this.Controls.Add(this.darkSectionPanel2);
            this.Controls.Add(this.darkSectionPanel1);
            this.Controls.Add(this.darkDockPanel1);
            this.Controls.Add(this.rtbEditor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainEditor";
            this.Text = "HTMLEditX Editor";
            this.darkSectionPanel1.ResumeLayout(false);
            this.darkSectionPanel1.PerformLayout();
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
    }
}

