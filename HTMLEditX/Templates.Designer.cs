/* Copyright (c) 2022 XT Software

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE. */
namespace HTMLEditX
{
    partial class Templates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Templates));
            this.darkTextBox1 = new DarkUI.Controls.DarkTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveAsTemp = new DarkUI.Controls.DarkButton();
            this.SuspendLayout();
            // 
            // darkTextBox1
            // 
            this.darkTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox1.Location = new System.Drawing.Point(13, 13);
            this.darkTextBox1.Multiline = true;
            this.darkTextBox1.Name = "darkTextBox1";
            this.darkTextBox1.Size = new System.Drawing.Size(234, 229);
            this.darkTextBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 154);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type the text you want as your\r\ntemplate in the box to the left then \r\nclick \"Sav" +
    "e as template\"\r\n\r\nWhen you get into the editor then\r\nclick \"Add Experimental Cus" +
    "tom\r\nTemplate\"\r\n";
            // 
            // btnSaveAsTemp
            // 
            this.btnSaveAsTemp.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAsTemp.Location = new System.Drawing.Point(253, 206);
            this.btnSaveAsTemp.Name = "btnSaveAsTemp";
            this.btnSaveAsTemp.Padding = new System.Windows.Forms.Padding(5);
            this.btnSaveAsTemp.Size = new System.Drawing.Size(110, 23);
            this.btnSaveAsTemp.TabIndex = 2;
            this.btnSaveAsTemp.Text = "Save as Template";
            this.btnSaveAsTemp.Click += new System.EventHandler(this.btnSaveAsTemp_Click);
            // 
            // Templates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 274);
            this.Controls.Add(this.btnSaveAsTemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.darkTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Templates";
            this.Text = "Templates";
            this.Load += new System.EventHandler(this.Templates_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkTextBox darkTextBox1;
        private System.Windows.Forms.Label label1;
        private DarkUI.Controls.DarkButton btnSaveAsTemp;
    }
}