using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
namespace EreditarietàAlloggio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Edificio> edifici = new List<Edificio>();
            bool quit = true;

            do
            {
                Console.Clear();
                Console.WriteLine("-----Menù-----");
                Console.WriteLine("1-Aggiungi Alloggio\n2-Aggiungi Capannone\n3-Aggiungi Villa\n4-Aggiungi Farmacia\n5-Visualizza Edifici\n6-Fine");
                int scelta = Convert.ToInt32(Console.ReadLine());
                switch (scelta)
                {
                    case 1: edifici.Add(CreaAlloggio());break;
                    case 2: edifici.Add(CreaCapannone()); break;
                    case 3: edifici.Add(CreaVilla()); break;
                    case 4: edifici.Add(CreaFarmacia()); break;
                    case 5: VisualizzaEdifici(edifici); break;
                    case 6: quit = false;break;
                    default:
                        break;
                }                
            } while (quit);
        }
        static void CreaEdificio(out int codice, out double mq)
        {
            Console.Clear();
            Console.WriteLine("Inserire il codice dell'edificio:");
            codice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserire la dimensione dell'edificio (mq):");
            mq = Convert.ToDouble(Console.ReadLine());
        }
        static Alloggio CreaAlloggio()
        {
            CreaEdificio(out int codice, out double mq);
            Console.WriteLine("\nInserire il numero di persone dell'alloggio:");
            int numPers = Convert.ToInt32(Console.ReadLine());
            return new Alloggio(codice, numPers, mq);
        }
        static Capannone CreaCapannone()
        {
            CreaEdificio(out int codice, out double mq);
            Console.WriteLine("\nInserire il numero di macchinari del capannone:");
            int numMacchine = Convert.ToInt32(Console.ReadLine());
            return new Capannone(codice, mq, numMacchine);
        }
       
        static Villa CreaVilla()
        {
            CreaEdificio(out int codice, out double mq);
            Console.WriteLine("\nInserire il numero di persone della villa:");
            int numPers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserire la dimensione del giardino della villa (mq):");
            double mqGiardino = Convert.ToDouble(Console.ReadLine());
            return new Villa(codice, numPers, mq, mqGiardino);
        }
        static Farmacia CreaFarmacia()
        {
            CreaEdificio(out int codice, out double mq);
            Console.WriteLine("\nInserire il numero di farmacisti della farmacia:");
            int numFarm = Convert.ToInt32(Console.ReadLine());
            return new Farmacia(codice, mq, numFarm);
        }
        static void VisualizzaEdifici(List<Edificio> edifici)
        {
            if (edifici.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("Lista Edifici:");
                for (int i = 0; i < edifici.Count; i++)                
                    Console.WriteLine((i + 1) + ": {0}", edifici[i].ToString());                
            }
            else
                Console.WriteLine("Non sono presenti edifici nella lista");
            Console.ReadLine();
        }
    }
}
