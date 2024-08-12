using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GDDownloader
{
    public partial class saved : Form
    {
        
        public saved()
        {
            InitializeComponent();
        }

        private void saved_Load(object sender, EventArgs e)
        {
            IDictionary<string, string> dataw = new Dictionary<string, string>();
            string key = null;
            string filePath = "imp\\instanices.txt";
            List<List<string>> extractedData = new List<List<string>>();

            // Open the file using StreamReader
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                // Iterate through each line in the file
                while ((line = reader.ReadLine()) != null)
                {
                    // Split the line into a list of strings by spaces
                    List<string> lineList = new List<string>(line.Split(' '));
                    // Add the list to the extractedData collection
                    extractedData.Add(lineList);
                }
            }

            // Now extractedData contains all lines from the file as lists of strings
            // You can process the extractedData as needed
            foreach (List<string> lineList in extractedData)
            {
                foreach (string item in lineList)
                {
                    Console.Write(item + " ");
                    if (item == "new")
                    {
                        key = null; // Reset key on encountering "new"
                        continue;
                    }

                    // If the item is a number, treat it as a value
                    if (double.TryParse(item, out double number))
                    {
                        if (key != null)
                        {
                            dataw[key] = item;  // Assign the number to the last key
                        }
                    }
                    else
                    {
                        // Treat the item as a key
                        key = item;
                        if (!dataw.ContainsKey(key))
                        {
                            dataw.Add(key, null);
                        }
                    }
                }
            }

            int versionfic = 102;
            int namefic = 517;
            int samecycle = 15;

            foreach (var entry in dataw)
            {
                samecycle += 85;

                // Create label for name
                Label nameLabel = new Label();
                nameLabel.BackColor = Color.White;
                nameLabel.Text = entry.Key;
                nameLabel.Location = new Point(namefic, samecycle);
                this.Controls.Add(nameLabel);

                // Create label for version
                Label versionLabel = new Label();
                versionLabel.BackColor = Color.White;
                versionLabel.Text = entry.Value;
                versionLabel.Location = new Point(versionfic, samecycle);
                this.Controls.Add(versionLabel);
            }
        }


    }
}


