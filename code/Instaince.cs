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
    public partial class Insit : Form
    {
        public Insit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crefrom crefrom = new crefrom();
            crefrom.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saved saved = new saved();
            saved.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //delete installision
            deletef deletef = new deletef();
            deletef.Show();
            this.Visible =false;
        }
    }
}
