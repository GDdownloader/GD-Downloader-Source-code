using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GDDownloader
{
    public partial class deletef : Form
    {
        private Label selectedLabel = null;
        private Label selectedPartnerLabel = null;
        private Dictionary<Label, Label> labelPairs = new Dictionary<Label, Label>();

        public deletef()
        {
            InitializeComponent();
        }

        private void deletef_Load(object sender, EventArgs e)
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

            int versionfic = 1049;
            int namefic = 112;
            int samecycle = 15;

            foreach (var entry in dataw)
            {
                samecycle += 85;

                // Create label for name
                Label nameLabel = new Label();
                nameLabel.BackColor = Color.White;
                nameLabel.Text = entry.Key;
                nameLabel.Location = new Point(namefic, samecycle);
                nameLabel.Click += new EventHandler(Label_Click);
                this.Controls.Add(nameLabel);

                // Create label for version
                Label versionLabel = new Label();
                versionLabel.BackColor = Color.White;
                versionLabel.Text = entry.Value;
                versionLabel.Location = new Point(versionfic, samecycle);
                versionLabel.Click += new EventHandler(Label_Click);
                this.Controls.Add(versionLabel);

                // Store the label pair in the dictionary
                labelPairs[nameLabel] = versionLabel;
                labelPairs[versionLabel] = nameLabel;
            }
        }

        // Event handler for label click
        private void Label_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                // Deselect the previously selected labels
                if (selectedLabel != null)
                {
                    selectedLabel.BackColor = Color.White;
                }
                if (selectedPartnerLabel != null)
                {
                    selectedPartnerLabel.BackColor = Color.White;
                }

                // Select the clicked label and its partner label
                selectedLabel = clickedLabel;
                selectedPartnerLabel = labelPairs[clickedLabel];
                selectedLabel.BackColor = Color.LightBlue;
                selectedPartnerLabel.BackColor = Color.LightBlue;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedLabel != null && selectedPartnerLabel != null)
            {
                // Remove both the selected label and its partner label
                this.Controls.Remove(selectedLabel);
                this.Controls.Remove(selectedPartnerLabel);
                string nameText = selectedLabel.Text;
                string versionText = selectedPartnerLabel.Text;
                // Clear the selection
                selectedLabel = null;
                selectedPartnerLabel = null;
                REMOVEINST REMOVEINSTf = new REMOVEINST();
                REMOVEINSTf.REMOVEINSTi(nameText ,versionText);
                DELINSTFILE dELINSTFILE = new DELINSTFILE();
                dELINSTFILE.delinstfilei(versionText);
                // Insert code to run when the labels are removed here
                MessageBox.Show("Installition Removed  successfully.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Insit insit = new Insit();
            insit.Show();
            this.Visible = false;
        }
    }
}
