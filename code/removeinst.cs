using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GDDownloader
{
    internal class REMOVEINST
    {
        public void REMOVEINSTi(string name, string version)
        {
            // Define the file path and the line to remove
            string pathe = "imp\\instanices.txt";
            string fid = $"new {name} {version}";

            // Read all lines from the file
            string[] lines = File.ReadAllLines(pathe);

            // Create a list to hold the lines to keep
            List<string> updatedLines = new List<string>();

            // Iterate through each line and add to updatedLines if it does not match fid
            foreach (string line in lines)
            {
                // Check if the line is not exactly equal to fid
                if (!line.Trim().Equals(fid, StringComparison.OrdinalIgnoreCase))
                {
                    updatedLines.Add(line);
                }
            }

            // Write the updated lines back to the file
            File.WriteAllLines(pathe, updatedLines);
        }
    }
}
