using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodBad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imgGood.Visible = true;
            imgBad.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            imgGood.Visible = false;
            imgBad.Visible = true;
        }

        private void imgBad_Click(object sender, EventArgs e)
        {

        }

        private void imgGood_Click(object sender, EventArgs e)
        {

        }
    }
}
