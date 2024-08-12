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
    public partial class op : Form
    {
        public op()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valueset;
            valueset = textBox1.Text;

            if (Directory.Exists(valueset))
            {
                SETINSTFILEINST sETINSTFILEINST = new SETINSTFILEINST();
                sETINSTFILEINST.SETINSRDILEI(valueset);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setting setting = new setting();
            setting.Show();
            this.Visible = false;
        }
    }
}
