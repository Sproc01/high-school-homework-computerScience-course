using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Esempio di uso delle interfacce IComparable e IComparable<T>
 * combinata con la classe Vettore
 * oppure con la classe Vettore<T>
 * che rende il tutto molto più generale
 */

namespace Interfaccia01
{
    class Program
    {
        static void Main(string[] args)
        {
            Vettore<Persona> v = new Vettore<Persona>(10);
            v[0] = new Persona("mario", 10, "ottimo");
            v[1] = new Persona("pippo", 10, "ottimo");
            v[5] = new Persona("zorro", 10, "ottimo");
            v[7] = new Persona("aldo", 10, "ottimo");

            for (int i=0 ; i < v.Length; i++)
                if(v[i] != null)
                    Console.WriteLine(v[i].ToString());

            Console.WriteLine();

            v.Sort();
            for (int i = 0; i < v.Length; i++)
                if (v[i] != null)
                    Console.WriteLine(v[i].ToString());


            Vettore<int> vi = new Vettore<int>(10);
            vi[0] = 20;
            vi[1] = 2;

            vi.Sort();
            for (int i = 0; i < vi.Length; i++)
                    Console.WriteLine(vi[i].ToString());
        

            Console.WriteLine();
            Vettore<string> vs = new Vettore<string>(10);
            vs[0] = "scuola";
            vs[1] = "zampa";
            vs[7] = "casa";

            for (int i = 0; i < vi.Length; i++)
                if (vs[i] != null)
                    Console.WriteLine(vs[i].ToString());

            Console.WriteLine();
            vi.Sort();
            for (int i = 0; i < v.Length; i++)
                if (vs[i] != null)
                    Console.WriteLine(vs[i].ToString());

            Console.ReadLine();
        }
    }
}
