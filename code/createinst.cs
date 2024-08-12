using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace createinst
{
    internal class Createinst
    {
        public void Writeinstaincefile(string verision, string name)
        {
            StreamWriter writerc = null;
            writerc = new StreamWriter("imp/instanices.txt",true);
            string writet;
            string verisiont;
            verisiont = verision;
            writet = $"new {name} {verisiont}" ;
            writerc.WriteLine(writet);
            writerc.Close();
        }
    }

}