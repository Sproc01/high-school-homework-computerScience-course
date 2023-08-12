using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria1;

namespace progetto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("progetto 2");
            Libreria1.Calcolatrice dato=new Libreria1.Calcolatrice();
            dato.op1 = 3;
            dato.op2 = 10;
            dato.Somma();
            Console.WriteLine(dato.risultato);
            Console.ReadLine();
        }
    }
}
namespace Libreria1
{
    public class calcolatrice
    {
        public int op1;
        public int op2;
        public int risultato;
        public void Somma()
        {
            risultato = op1 + op2;
        }
    }
}
