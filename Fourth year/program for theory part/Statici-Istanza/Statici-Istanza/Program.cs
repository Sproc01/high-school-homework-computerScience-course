using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statici_Istanza
{
    class Persona
    {
        /*public*/ static int NumeroIstanze;//membri statici sono inizializzati quando si fa new persona
       /*public*/ string Nome;
        Persona compagno;
        public Persona(string n, string cn)//costruttore d'istanza
        {
            Nome =n;
            NumeroIstanze++;
            if(cn!=null)
                compagno = new Persona(cn,null);
        }
        static Persona()//costruttore statico, chiamato solo la prima volta
        {
            NumeroIstanze = 0;
        }
        public static void incrementainstanze()
        {
            NumeroIstanze++;
        }
        public static int getinstanze()
        {
            return NumeroIstanze;
        }
        public string getnome()
        {
            return Nome;
        }
        public void dispose()
        {
            NumeroIstanze -= 2;
        }
    }
    class Program
    {
        static void elimina(Persona p)
        {
            p.dispose();
            p = null;
        }
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Pippo","Mario");//parte il costruttore statico e d'istanza
            //prima costruttore statico poi d'istanza
            //Persona.NumeroIstanze++;//se non c'è la new parte comunque il costruttore statico
            //Persona.incrementainstanze();
            Persona p2 = new Persona("Gigi","Pluto");
            elimina(p2);
            //Persona.NumeroIstanze++;
            //Persona.incrementainstanze();
            Console.WriteLine(Persona.getinstanze());
            Console.WriteLine(p1.getnome());
            Console.ReadLine();
        }
    }
}
