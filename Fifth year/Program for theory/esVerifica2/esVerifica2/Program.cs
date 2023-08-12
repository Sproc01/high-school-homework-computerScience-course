using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace esVerifica2
{
    struct persona
    {
        public string cognome;
        public string nome;
    }
    class File
    {
        StreamReader sr;
        StreamWriter sw;
        public File(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Truncate, FileAccess.ReadWrite, FileShare.ReadWrite);
            sr = new StreamReader(fs);
            sw = new StreamWriter(fs);
            sw.AutoFlush = true;
        }
        public void Write(persona p)
        {
            sw.WriteLine($"{p.nome}|{p.cognome}|");
        }
        public string ReadFile()
        {
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            return sr.ReadToEnd();
        }
        public persona ReadPersona(int i)
        {
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string[] r= ReadFile().Split('|');
            int posin = 2 * (i - 1);
            return new persona() { nome = r[posin], cognome = r[posin + 1] };
        }
    }
    class FileBin
    {
        BinaryReader sr;
        BinaryWriter sw;
        public FileBin(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Truncate, FileAccess.ReadWrite, FileShare.ReadWrite);
            sr = new BinaryReader(fs);
            sw = new BinaryWriter(fs);
        }
        public void Write(persona p)
        {
            sw.Write($"{p.nome}|{p.cognome}|"+8+"|\n");
            sw.Flush();
        }
        public string ReadFile()
        {
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string s="";
            do
            {
                s += sr.ReadString();
            } while (sr.PeekChar()!=-1);
            return s;
        }
        public persona ReadPersona(int i)
        {
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string[] r = ReadFile().Split('|');
            int posin = 3 * (i - 1);
            return new persona() { nome = r[posin], cognome = r[posin + 1],};
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            File f = new File("f1.txt");
            persona p = new persona() { nome = "a", cognome = "a" };
            f.Write(p);
            p = new persona() { nome = "b", cognome = "b" };
            f.Write(p);
            p = new persona() { nome = "c", cognome = "c" };
            f.Write(p);
            Console.WriteLine(f.ReadFile());
            Console.Write("inserisci numero record da leggere:");
            p = f.ReadPersona(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(p.nome + "|" + p.cognome);
            Console.ReadLine();

            FileBin f1 = new FileBin("f1.txt");
            persona p1 = new persona() { nome = "a", cognome = "a" };
            f1.Write(p1);
            p1 = new persona() { nome = "b", cognome = "b" };
            f1.Write(p1);
            p1 = new persona() { nome = "c", cognome = "c" };
            f1.Write(p1);
            Console.WriteLine(f1.ReadFile());
            Console.Write("inserisci numero record da leggere:");
            p1=f1.ReadPersona(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(p1.nome+"|"+ p1.cognome);
            Console.ReadLine();
        }
    }
}
