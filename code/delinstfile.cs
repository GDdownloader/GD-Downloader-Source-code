using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;
using System.Diagnostics;
namespace GDDownloader
{
    internal class DELINSTFILE
    {
        public void delinstfilei(string verision)
        {
            string pateh;
            string dele;
            string fi;
            FIND fIND = new FIND();
            fIND.findi(1, out string res);

            if (string.IsNullOrEmpty(res))
            {
                Console.WriteLine("Path cannot be null or empty.");
                return;
            }

            if (res == "temp")
            {
                pateh = Path.GetTempPath();
            }
            else
            {
                pateh = res;
            }

            dele = $"GD{verision}";

            if (pateh.EndsWith("\\") || pateh.EndsWith("/"))
            {
                fi = pateh + dele;
            }
            else
            {
                fi = pateh + "\\" + dele;
            }

            if (Directory.Exists(fi))
            {
                Directory.Delete(fi, true); // Use 'true' to delete recursively
                Console.WriteLine($"Directory {fi} has been deleted.");
            }
            else
            {
                Console.WriteLine($"Directory {fi} does not exist.");
            }
        }
    }
}

