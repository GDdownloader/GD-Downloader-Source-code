using System;
using System.Collections.Generic;
using System.IO;
//name
namespace GDDownloader
{
    internal class GETVERSIONSLIST
    {
        // Method to process the file and populate the provided list
        public void ProcessFile(string filePath, out List<List<string>> extractedData)
        {
            extractedData = new List<List<string>>();

            // Open the file using StreamReader
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                // Iterate through each line in the file
                while ((line = reader.ReadLine()) != null)
                {
                    // Remove the word "new" if it is present
                    if (line.Contains("new"))
                    {
                        line = line.Replace("new", "").Trim();
                    }

                    // Split the remaining line by spaces into a list of strings
                    List<string> lineList = new List<string>(line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

                    // Add the list to the extractedData collection
                    extractedData.Add(lineList);
                }
            }
        }
    }
}
