using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace provaBinarioTesto
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f1 = new FileStream("f1.txt", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(f1, Encoding.UTF8, true);
            bw.Write(77);
            bw.Write(8.19);
            bw.Write("ciao");
            bw.Close();
            BinaryReader br = new BinaryReader(f1);
            f1.Seek(0, SeekOrigin.Begin);
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());
            Console.WriteLine(br.ReadString());
            Console.ReadLine();

            StreamWriter sw = new StreamWriter("f2.txt");
            sw.Write(876);
            sw.WriteLine("ciao");
            sw.NewLine = "fff";
            sw.WriteLine("s");
            sw.Close();
            StreamReader sr = new StreamReader("f2.txt");
            Console.WriteLine(sr.ReadToEnd());
            Console.ReadLine();
            FileStream f = new FileStream("f3.txt",FileMode.Create);
            BinaryWriter bw1 = new BinaryWriter(f,Encoding.UTF8,true);
            bw1.Write("d");
            bw.Close();
        }
    }
}
