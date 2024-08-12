using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace GDDownloader
{
    internal class  NUMBERINST
    {
        public void NUMBERINSTi(int need,out int tita) 
        {
            string pathe;
            string noute;
            
            tita = 0;
            pathe = "imp\\set.txt";

            List<List<string>> strings = new List<List<string>>();

            using (StreamReader reader = new StreamReader(pathe))
            {
                string line;
                // Iterate through each line in the file
                while ((line = reader.ReadLine()) != null)
                {
                    // Split the line into a list of strings by spaces
                    List<string> lineList = new List<string>(line.Split(' '));
                    // Add the list to the extractedData collection
                    strings.Add(lineList);
                }
            }

            foreach (List<string> list in strings)
            {
                foreach (string str in list)
                {
                    if (str == "item")
                    {
                        tita =tita + 1;
                    }
                }
            }

            
        }
    }
}
