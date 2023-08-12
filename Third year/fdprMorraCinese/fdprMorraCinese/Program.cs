using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprMorraCinese
{
    class Program
    {
        static void Main(string[] args)
        {
            string giocatore1, giocatore2;
            int pg1 = 0, pg2 = 0;//corrispondono ai punteggi dei due giocatori
            bool errinput1,errinput2;//controllo errori input dei giocatori
            Console.WriteLine("Regole Gioco:");
            Console.WriteLine("Due giocatori con queste possibilità di input");
            Console.WriteLine("--Giocatore 1:");
            Console.WriteLine("-s=sasso");
            Console.WriteLine("-a=carta");
            Console.WriteLine("-d=forbici");
            Console.WriteLine("--Giocatore 2:");
            Console.WriteLine("-K=sasso");
            Console.WriteLine("-j=carta");
            Console.WriteLine("-l=forbici");
            Console.WriteLine("-x per entrambi i giocatori termina il gioco");
            Console.WriteLine("-sasso batte forbice, forbice batte carta, carta batte sasso");
            Console.WriteLine("Premi invio per continuare");
            Console.ReadLine();
            Console.Clear();
            do
            {
                do
                {
                    Console.WriteLine("Turno giocatore uno");
                    Console.ForegroundColor = ConsoleColor.Black;
                    giocatore1 = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    errinput1 = giocatore1 != "x" & giocatore1 != "a" & giocatore1 != "s" & giocatore1 != "d";
                    if (errinput1)
                    {
                        Console.WriteLine("Errore input");
                        Console.Clear();
                    }
                } while (errinput1);//gestione errore input giocatore 1
                do
                {
                    Console.WriteLine("Turno giocatore due");
                    Console.ForegroundColor = ConsoleColor.Black;
                    giocatore2 = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    errinput2 = giocatore2 != "x" & giocatore2 != "k" & giocatore2 != "j" & giocatore2 != "l";
                    if (errinput2)
                    {
                        Console.WriteLine("Errore input");
                        Console.Clear();
                    }
                } while (errinput2);//gestione errore input giocatore 2
                Console.Clear();
                //controllo possibili risultati gioco
                if ((giocatore1 == "a" & giocatore2 == "j") | (giocatore1 == "s" & giocatore2 == "k") | (giocatore1 == "d" & giocatore2 == "l"))
                Console.WriteLine("Risultato: Parità");
                else
                {
                    if ((giocatore1 == "a" & giocatore2 == "k") | (giocatore1 == "s" & giocatore2 == "l") | (giocatore1 == "d" & giocatore2 == "j"))
                    {
                    Console.WriteLine("Risultato: Vittoria giocatore 1");
                    pg1++;
                    }
                        else
                        {
                            if ((giocatore1 == "a" & giocatore2 == "l") | (giocatore1 == "s" & giocatore2 == "j") | (giocatore1 == "d" & giocatore2 == "k"))
                            {
                                Console.WriteLine("Risultato: Vittoria giocatore 2");
                                pg2++;
                            }
                        }
                }
            } while (giocatore1 != "x" & giocatore2 != "x");
            Console.WriteLine("Hai terminato il gioco, risultato:");
            Console.WriteLine($"Vittorie giocatore 1={pg1}");
            Console.WriteLine($"Vittorie giocatore 2={pg2}");
            Console.ReadLine();
        }
    }
}
