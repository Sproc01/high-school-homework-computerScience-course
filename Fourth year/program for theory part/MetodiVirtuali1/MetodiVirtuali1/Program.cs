using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodiVirtuali1
{
    class C1
    {
        int[] v = new int[3];
        ConsoleColor color = ConsoleColor.Black;
        public int this[int i]//indicizzatore
        {
            get { return v[i]; }
            set => v[i] = value;
        }
        public ConsoleColor this[bool f]//indicizzatore
        {
            get { return color; }
            set
            {
                color = value;
                if (f)
                    Console.ForegroundColor = value;
                else
                    Console.BackgroundColor = value;
            }
        }
        public int this[string s]//indicizzatore
        {
            get
            {
                int i = 0;
                switch (s)
                {
                    case "primo":
                        i = 0;
                        break;
                    case "secondo":
                        i = 1;
                        break;
                    case "terzo":
                        i = 2;
                        break;
                }
                return v[i];
            }
        }

        public virtual void M1()
        {
            Console.WriteLine("Metodo classe C1");
        }
    }
    class C2:C1
    {
        public int x;
        public void M1()
        {
            Console.WriteLine("Metodo classe C2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C2 a = new C2();
            a.M1();//chiama il metodo della classe c2 perchè nasconde l'altro
            Console.ReadLine();
            C1 b = new C2();
            b.M1();//la classe c2 ha la tabella virtuale uguale alla classe c1
            Console.ReadLine();
            C1 c = a;
            //c.x non lo vede, vede solo la parte della classe base
            a = (C2)c;
            C1 f = new C1();
            f[1] = 40;
            int x = f[1];//accesso tramite primo indicizzatore
            int y = f["secondo"];//accesso tramite secondo indicizzatore
            f[false]=ConsoleColor.Green;
        }
    }
}
