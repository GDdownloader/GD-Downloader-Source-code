using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDDownloader
{
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            op op = new op();
            op.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            help help =new help();
            help.Show();
            this.Visible = false;
        }
    }
}
