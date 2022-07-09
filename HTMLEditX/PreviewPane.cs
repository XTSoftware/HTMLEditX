/* Copyright (c) 2022 XT Software

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions: */
using System;
using System.Windows.Forms;

namespace HTMLEditX
{
    public partial class PreviewPane : Form
    {
        public PreviewPane()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void PreviewPane_Load(object sender, EventArgs e)
        {
            webBrowser1.AllowWebBrowserDrop = false;
            webBrowser1.Navigate(new System.Uri(@"C:/Users/Public/preview.html"));
            
        }
    }
}
