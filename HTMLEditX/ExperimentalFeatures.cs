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
            FileMan fm = new FileMan();
            fm.ShowDialog();
        }
    }
}
