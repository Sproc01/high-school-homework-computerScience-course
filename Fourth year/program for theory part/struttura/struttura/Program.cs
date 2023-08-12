using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struttura
{
    struct Persona
    {
        public int voto;
        public string nome;
        public static int numero=2;
        public Persona(string n, int v=0)
        {
            nome = n;
            voto = v;
        }
    }
    struct Persona1
    {
        int voto;
        string nome;
        public Persona1(string n, int v = 0)
        {
            nome = n;
            voto = v;
        }
        public string Nome
        {
            get { return nome; }
            private set { nome = value; }//value ha il valore che assegno alla proprietà
        }

        public int Voto
        {
            get => voto;
            set => voto = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Pippo", 10);
            Console.WriteLine($"{p.nome}:{p.voto}");
            Persona p1=new Persona();
            p1.nome = "Pluto";
            Console.WriteLine($"{p1.nome}:{p1.voto}");
            Console.WriteLine(Persona.numero);
            Persona1 p2 = new Persona1("Pippo2", 9);
            Console.Write(p2.Nome);
            p2.Voto = 4;
            Console.Write(":" + p2.Voto);
            Console.ReadLine();
        }
    }
}
