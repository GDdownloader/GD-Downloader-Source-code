using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GDDownloader
{
    internal class FIND
    {
        public void findi(int need, out string result)
        {
            result = null; // Initialize the out parameter
            string filep = "imp\\set.txt";
            string readText = File.ReadAllText(filep, Encoding.UTF8);
            string[] lines = readText.Split(new[] { '\r', '\n' }, StringSplitOptions.None);
            bool key = false;
            string goal = string.Empty; // Initialize the variable

            for (int i = 0; i < lines.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(lines[i]))
                {
                    Console.WriteLine(lines[i]);

                    if (need == 1)
                    {
                        string test = lines[i];
                        List<string> list = test.Split(' ').ToList();

                        foreach (var t in list)
                        {
                            if (t == "install")
                            {
                                key = true;
                            }

                            if (!key)
                            {
                                goal = t;
                            }
                        }
                    }
                }
            }
        }
    }
}





