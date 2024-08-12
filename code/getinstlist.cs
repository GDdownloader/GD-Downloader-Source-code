using System;
using System.Collections.Generic;
using System.IO;

namespace GDDownloader
{
    internal class GETINSTLIST
    {
        // Method to process the file and populate the provided list
        public void ProcessFile(string filePath, out List<string> extractedData)
        {
            extractedData = new List<string>();

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

                    // Add the last element (version) to the extractedData list (if it exists)
                    if (lineList.Count > 1)
                    {
                        extractedData.Add(lineList[^1]); // Extract the last item (version)
                    }
                }
            }
        }
    }
}