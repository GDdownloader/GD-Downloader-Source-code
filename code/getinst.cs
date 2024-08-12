using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDDownloader
{
    internal class GETINST
    {

        public void getinsti(int need ,out IDictionary<string ,string> set)
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

            set = dataw;
        }
    }
}
