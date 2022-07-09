/* Copyright (c) 2022 XT Software

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions: */
using System;
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
