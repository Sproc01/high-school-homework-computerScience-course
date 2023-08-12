using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libraryAlloggioVilla;

namespace AbstractClass
{
    static class View//insieme di metodi utilizzati per input e output
    {
        internal static int Input()//metodo input iniziale
        {
            int ris;
            do
            {
                Console.WriteLine("Scegli un'opzione:");
                Console.WriteLine("1) Creare Magazzino;");
                Console.WriteLine("2) Creare Villa;");
                Console.WriteLine("3) Creare Alloggio;");
                Console.WriteLine("4) Visualizza;");
                Console.WriteLine("5) Elimina tutto;");
                Console.WriteLine("6)Chiudi");
            } while (!int.TryParse(Console.ReadLine(),out ris) && ris>=7 && ris<=0);//controllo dati
            return ris;
        }
        internal static Villa InputVilla()//metodo input per la villa
        {
            int codice;
            double metri;
            int numpers;
            double metrigiard;
            do
            {
                Console.Write("Inserire codice:");
            } while (!int.TryParse(Console.ReadLine(), out codice));//controllo dati
            do
            {
                Console.Write("Inserire metri quadrati:");
            } while (!double.TryParse(Console.ReadLine(), out metri));//controllo dati
            do
            {
                Console.Write("Inserire numero persone:");
            } while (!int.TryParse(Console.ReadLine(), out numpers));//controllo dati
            do
            {
                Console.Write("Inserire metri quadrati giardino:");
            } while (!double.TryParse(Console.ReadLine(), out metrigiard));//controllo dati
            Villa villa = new Villa(numpers, metri, codice, metrigiard);//creazione villa
            return villa;
        }
        internal static Magazzino InputMagazzino()//metodo input magazzino
        {
            int codice;
            double metri;
            do
            {
                Console.Write("Inserire codice:");
            } while (!int.TryParse(Console.ReadLine(), out codice));//controllo dati
            do
            {
                Console.Write("Inserire metri quadrati:");
            } while (!double.TryParse(Console.ReadLine(), out metri));//controllo dati
            Magazzino magazzino = new Magazzino(codice, metri);//creazione magazzino
            return magazzino;
        }
        internal static Alloggio InputAlloggio()//metodo input alloggio
        {
            int codice;
            double metri;
            int numpers;
            do
            {
                Console.Write("Inserire codice:");
            } while (!int.TryParse(Console.ReadLine(), out codice));//controllo dati
            do
            {
                Console.Write("Inserire metri quadrati:");
            } while (!double.TryParse(Console.ReadLine(), out metri));//controllo dati
            do
            {
                Console.Write("Inserire numero persone:");
            } while (!int.TryParse(Console.ReadLine(), out numpers));//controllo dati
            Alloggio all = new Alloggio(codice, metri, numpers);//creazione alloggio
            return all;
        }
        internal static void Output(List<Edificio> lista)
        {
            foreach (Edificio item in lista)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
    class Program
    {       
        static void Main(string[] args)
        {
            List<Edificio> lista = new List<Edificio>();
            bool ripeti = true;
            do
            {
                Console.Clear();
                int ris = View.Input();
                switch (ris)//switch per gestire l'operazione richiesta
                {
                    case 1:
                        lista.Add(View.InputMagazzino());//aggiunta alla collezione dell'elemento
                        break;
                    case 2:
                        lista.Add(View.InputVilla());//aggiunta alla collezione dell'elemento
                        break;
                    case 3:
                        lista.Add(View.InputAlloggio());//aggiunta alla collezione dell'elemento
                        break;
                    case 4:
                        View.Output(lista);//ouput
                        break;
                    case 5:
                        lista.Clear();//eliminazione tutti elementi
                        break;
                    case 6:
                        ripeti = false;//chiusura programma
                        break;
                }
            } while (ripeti);
        }
    }
}
