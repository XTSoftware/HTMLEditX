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
    public partial class ExperimentalFeatures : Form
    {
        public ExperimentalFeatures()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PreviewEdge edge = new PreviewEdge();
            edge.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Templates templates = new Templates();
            templates.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateChecker uchecker = new UpdateChecker();
            uchecker.ShowDialog();
        }

        private void ExperimentalFeatures_Load(object sender, EventArgs e)
        {

        }
    }
}
