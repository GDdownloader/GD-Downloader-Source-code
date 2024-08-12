namespace GDDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            play play = new play();
            play.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Insit insit = new Insit();
            insit.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setting setting = new setting();
            setting.Show();
            this.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
