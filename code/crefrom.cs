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
    public partial class crefrom : Form
    {
        public crefrom()
        {
            InitializeComponent();
        }

        private void crefrom_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            createinst.Createinst createinst = new createinst.Createinst();
            string Version;
            string Name;
            Version = textBox2.Text;
            Name = textBox1.Text;
            GDDownloaderConsole gDDownloaderConsole = new GDDownloaderConsole();
            
            FIND fIND = new FIND();
            fIND.findi(1, out string pathe);
            if (pathe == "temp")
            {
                pathe = Path.GetTempPath();
            }
            else { }
            gDDownloaderConsole.SearchAndDownloadVersionAsync(Version, pathe);
            createinst.Writeinstaincefile(Version, Name);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
