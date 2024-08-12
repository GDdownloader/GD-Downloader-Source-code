using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GDDownloader
{
    internal class SETINSTFILEINST
    {
        public void SETINSRDILEI(string path)
        {
            string pathe = "imp\\set.txt";
            string Readtext = File.ReadAllText(pathe);
            string[] lines = Readtext.Split(new[] { '\r', '\n' }, StringSplitOptions.None);

            for (int i = 0; i < lines.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(lines[i]))
                {
                    string test = lines[i];
                    List<string> list = test.Split(' ').ToList();

                    for (int j = 0; j < list.Count; j++)
                    {
                        if (list[j] == "install" && j + 1 < list.Count)
                        {
                            list[j + 1] = path; // Change the word after "install" to the path variable
                            lines[i] = string.Join(" ", list); // Reconstruct the line
                            break; // Exit the loop after the replacement
                        }
                    }
                }
            }

            // Write the modified lines back to the file
            File.WriteAllLines(pathe, lines);
        }

    }
}
