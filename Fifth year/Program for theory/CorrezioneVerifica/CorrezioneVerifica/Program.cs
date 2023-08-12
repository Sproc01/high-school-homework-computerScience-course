using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CorrezioneVerifica
{
    class Program
    {
        const int posCognome = 21;
        const int posVotoMate = 42;
        const int posVotoInf = 50;
        const string nomefile = "studenti.bin";
        struct Studente
        {
            public string Nome;
            public string Cognome;
            public double VotoMate;
            public double VotoInf;
        }
        static void Inserimento(Studente s)
        {
            FileStream f1 = new FileStream(nomefile, FileMode.OpenOrCreate);
            BinaryWriter bw = new BinaryWriter(f1);
            bw.Seek(0, SeekOrigin.End);
            //bw.Write($"{s.Nome,-20}");
            //bw.Write($"{s.Cognome,-20}");
            //bw.Write(s.VotoMate);
            //bw.Write(s.VotoInf);
            //bw.Close();
            long iniziorec = f1.Position;
            bw.Write(s.Nome);
            f1.Seek(iniziorec + posCognome, SeekOrigin.Begin);
            bw.Write(s.Nome);
            f1.Seek(iniziorec + posVotoMate, SeekOrigin.Begin);
            bw.Write(s.VotoMate);
            bw.Write(s.VotoInf);
            bw.Close();
        }
        static void Modifica()
        {
            int pos;
            Studente s1 = new Studente();
            Console.Write("Nome:");
            s1.Nome = Console.ReadLine();
            Console.Write("Cognome:");
            s1.Cognome = Console.ReadLine();
            if (Ricerca(ref s1, out pos))
            {
                Console.WriteLine("Voto Matematica:"+s1.VotoMate);
                Console.WriteLine("Voto informatica:" + s1.VotoInf);
                Console.WriteLine("Quale voto modificare");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Inserisci nuovo voto");
                        double.TryParse(Console.ReadLine(), out s1.VotoMate);
                        ModificaVoto(pos,posVotoMate,s1.VotoMate);
                        break;
                    case "2":
                        Console.WriteLine("Inserisci nuovo voto");
                        double.TryParse(Console.ReadLine(), out s1.VotoInf);
                        ModificaVoto(pos, posVotoInf,s1.VotoInf);
                        break;
                }
            }
            else
                Console.WriteLine("Studente non trovato");
            Console.ReadLine();
        }
        static void ModificaVoto(int pos,int offset, double voto)
        {
            FileStream f1 = new FileStream(nomefile, FileMode.OpenOrCreate);
            BinaryWriter bw = new BinaryWriter(f1);
            f1.Seek(pos * 58 + offset, SeekOrigin.Begin);
            bw.Write(voto);
        }
        static bool Ricerca(ref Studente s, out int pos)
        {
            bool trovato = false;
            FileStream f1 = new FileStream(nomefile, FileMode.OpenOrCreate);
            BinaryReader br = new BinaryReader(f1);
            pos = 0;
            while (br.PeekChar()!=-1 && !trovato)
            {
                long Iniziorec = f1.Position;
                string nome = br.ReadString();
                f1.Seek(Iniziorec + posCognome, SeekOrigin.Begin);
                string cognome = br.ReadString();
                if (s.Nome == nome && s.Cognome == cognome)
                {
                    trovato = true;
                    br.BaseStream.Seek(Iniziorec + posVotoMate, SeekOrigin.Begin);
                    s.VotoMate = br.ReadDouble();
                    s.VotoInf = br.ReadDouble();
                }
                else
                {
                    f1.Seek(Iniziorec + 58, SeekOrigin.Begin);
                    pos++;
                }
            }
            br.Close();
            return trovato;
        }
        static void Main(string[] args)
        {
            int risposta=0;
            Studente s1 = new Studente();
            do
            {
                Console.Clear();
                Console.WriteLine("1) Inserire nuovo studente");
                Console.WriteLine("2) Cancella studente");
                Console.WriteLine("3) Modifica voto studente");
                Console.WriteLine("4) Visualizza lista studenti");
                Console.WriteLine("5) Copia su file di testo");
                Console.WriteLine("6) Esci");
                int.TryParse(Console.ReadLine(), out risposta);
                switch (risposta)
                {
                    case 1:
                        Console.Write("Nome:");
                        s1.Nome = Console.ReadLine();
                        Console.Write("Cognome:");
                        s1.Cognome = Console.ReadLine();
                        Console.Write("Voto matematica:");
                        double.TryParse(Console.ReadLine(), out s1.VotoMate);
                        Console.Write("Voto informatica:");
                        double.TryParse(Console.ReadLine(), out s1.VotoInf);
                        Inserimento(s1);
                        break;
                    case 2:
                        break;
                    case 3:
                        Modifica();
                        break;
                   case 4:
                        break;
                    case 5:
                        break;
                }
            } while (risposta>0 && risposta<6);
        }
    }
}
