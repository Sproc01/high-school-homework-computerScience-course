using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace esVerifica
{
    class Program
    {
        struct Calciatore
        {
            public string nome;
            public int goal;
            public string squadra;
        }
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("f1.txt");
            Calciatore calciatore = new Calciatore();
            calciatore.nome = "Michele";
            calciatore.goal = 0;
            calciatore.squadra = "fc";
            sw.WriteLine("{0,-20}|{1,-2}|{2,-20}|", calciatore.nome, calciatore.goal, calciatore.squadra);
            calciatore.nome = "Mattia";
            calciatore.goal = 4;
            calciatore.squadra = "cf";
            sw.WriteLine("{0,-20}|{1,-2}|{2,-20}|", calciatore.nome, calciatore.goal, calciatore.squadra);
            sw.Close();
            StreamReader sr = new StreamReader("f1.txt");
            string s = sr.ReadLine();
            calciatore.nome = s.Substring(0, 20);
            calciatore.squadra = s.Substring(24,20);
            calciatore.goal = Convert.ToInt32(s.Substring(21, 2));
            Console.WriteLine($"{calciatore.nome}|{calciatore.goal}|{calciatore.squadra}");
            string[] c = sr.ReadLine().Split('|');
            calciatore.nome = c[0];
            calciatore.squadra = c[2];
            calciatore.goal = Convert.ToInt32(c[1]);
            Console.WriteLine($"{calciatore.nome}|{calciatore.goal}|{calciatore.squadra}");
            Console.ReadLine();

            FileStream fs = new FileStream("f2.txt", FileMode.OpenOrCreate);
            BinaryWriter bw = new BinaryWriter(fs,Encoding.ASCII,true);
            calciatore.nome = "Michele";
            calciatore.goal = 0;
            calciatore.squadra = "fc";
            bw.Write(calciatore.nome);
            bw.Write(calciatore.goal);
            bw.Write(calciatore.squadra);
            calciatore.nome = "Mattia";
            calciatore.goal = 4;
            calciatore.squadra = "cf";
            bw.Write(calciatore.nome);
            bw.Write(calciatore.goal);
            bw.Write(calciatore.squadra);
            bw.Close();
            fs.Seek(0, SeekOrigin.Begin);
            BinaryReader br = new BinaryReader(fs);
            Console.Write(br.ReadString() + "|");
            Console.Write(br.ReadInt32()+"|");
            Console.WriteLine(br.ReadString());
            Console.Write(br.ReadString() + "|");
            Console.Write(br.ReadInt32() + "|");
            Console.WriteLine(br.ReadString());
            Console.ReadLine();
        }
    }
}
