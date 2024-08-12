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
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setting setting = new setting();
            setting.Show();
            this.Visible = false;
        }
    }
}
