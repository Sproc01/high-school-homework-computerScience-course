using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw1 = new StreamWriter("f1.txt", false, Encoding.ASCII);
            sw1.Write("File ASCII");
            sw1.Close();

            StreamWriter sw2 = new StreamWriter("f2.txt", false, Encoding.Unicode);
            sw2.Write("File Unicode");
            sw2.Close();

        }
    }
}
