using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC2
{
    class View
    {
        Model modello;
        Controller controllore;

        static void Main(string[] args)
        {
            View pgm = new View();
        }

        View()
        {
            modello = new Model();
            controllore = new Controller(modello, this);

            modello.updated += new Model.updatedHandler(aggiorna);

            bool continua = true;
            double add1;
            double add2;
            string scelta;
            do
            {
                Console.Write("Inserire il primo addendo: ");
                add1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Inserire il secondo addendo: ");
                add2 = Convert.ToDouble(Console.ReadLine());
                controllore.uguale_Click(add1, add2);
                Console.Write("Vuoi ripetere? (s/n) ");
                scelta = Console.ReadLine();
                if (scelta == "n" || scelta == "N")
                    continua = false;
            } while (continua);

        }

        void aggiorna()
        {
            Console.WriteLine("La somma è: {0}", modello.Somma.ToString());
        }

    }
}
