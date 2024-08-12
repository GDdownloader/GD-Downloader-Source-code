using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace GDDownloader
{
    public partial class play : Form
    {
        public static int counter = 0;
        private List<(string name, string version)> dataList = new List<(string, string)>();
        private int currentIndex = 0;

        public play()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Back to previous form
            counter = 0;
            Form1 form1 = new Form1();
            form1.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FIND fIND = new FIND();
            fIND.findi(1, out string rest);
            string version = label3.Text;
            if (rest == "temp")
            {
                rest =Path.GetTempPath();
            }
            string file = $"{rest}GD{version}";
            string commanf;

            commanf = file;

            Process process = new Process();
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"/c {file}";
            process.Start();
        }

        private void play_Load(object sender, EventArgs e)
        {
            // Load data from file
            string filePath = "imp\\instanices.txt";

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line = reader.ReadLine();
                    if (line != null)
                    {
                        // Process the first line
                        string[] parts = line.Trim().Split(' ');
                        if (parts.Length == 3 && parts[0] == "new")
                        {
                            string name = parts[1];
                            string version = parts[2];

                            // Update labels
                            label2.Text = name;
                            label3.Text = version;
                        }
                    }
                }

                // Load all lines into dataList for navigation
                foreach (var line in File.ReadLines(filePath))
                {
                    string[] parts = line.Trim().Split(' ');
                    if (parts.Length == 3 && parts[0] == "new")
                    {
                        string name = parts[1];
                        string version = parts[2];
                        dataList.Add((name, version));
                    }
                }
            }
            else
            {
                MessageBox.Show("File not found!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Previous button functionality
            if (dataList.Count > 0)
            {
                currentIndex = (currentIndex - 1 + dataList.Count) % dataList.Count;
                label2.Text = dataList[currentIndex].name;
                label3.Text = dataList[currentIndex].version;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Next button functionality
            if (dataList.Count > 0)
            {
                currentIndex = (currentIndex + 1) % dataList.Count;
                label2.Text = dataList[currentIndex].name;
                label3.Text = dataList[currentIndex].version;
            }
        }
    }
}
