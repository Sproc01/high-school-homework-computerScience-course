using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdpragenda
{
    public struct Persona
    {
        public string Cognome;
        public string Nome;
        public string NumTelefono;
    }
    class Program
    {
        static void Ricerca(Persona [] persona)
        {
            int risposta;
            string ricerca;
            do
            {
                Console.WriteLine("Tramite che elemento effetuare la ricerca:");
                Console.WriteLine("1) Cognome");
                Console.WriteLine("2) Nome");
                Console.WriteLine("3)  Numero");
                risposta = Convert.ToInt32(Console.ReadLine());
            } while (risposta < 1 | risposta > 3);
            Console.WriteLine("inserire la stringa da ricercare");
            ricerca = Console.ReadLine();
            switch (risposta)
            {
                case 1:
                    for (int i = 0; i < persona.Length; i++)
                    {
                        if (ricerca == persona[i].Cognome)
                        { Console.WriteLine("IL nome è:" + persona[i].Nome);
                            Console.WriteLine("Il numero è:" + persona[i].NumTelefono);
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < persona.Length; i++)
                    {
                        if (ricerca == persona[i].Nome)
                        {
                            Console.WriteLine("IL cognome è:" + persona[i].Cognome);
                            Console.WriteLine("Il numero è:" + persona[i].NumTelefono);
                        }
                    }
                    break;
                case 3:
                    for (int i = 0; i < persona.Length; i++)
                    {
                        if (ricerca == persona[i].NumTelefono)
                        {
                            Console.WriteLine("IL nome è:" + persona[i].Nome);
                            Console.WriteLine("Il cognome è:" + persona[i].Cognome);
                        }
                    }
                    break;
            }
        }
        static void Visualizzazione(Persona []persona)
        {
            for (int i = 0; i < persona.Length; i++)
            {
                Console.WriteLine(i + ")" + persona[i].Cognome+" "+persona[i].Nome+" "+persona[i].NumTelefono);
            }
        }
        static Persona LeggiPersona()
        {
            Persona contatto;
            Console.WriteLine("Inserisci il cognome");
            contatto.Cognome = Console.ReadLine();
            Console.WriteLine("inserisci il nome");
            contatto.Nome = Console.ReadLine();
            Console.WriteLine("Inserisci il numero di telefono");
            contatto.NumTelefono = Console.ReadLine();
            return contatto;
        }
        static int Menu(string[] opzioni)
        {
            int Risposta = 1;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu:");
                for (int i = 0; i < opzioni.Length; i++)
                {
                    Console.WriteLine(i + 1 + ": " + opzioni[i]);
                }
                try
                {
                    Risposta = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "\n Premere invio per continuare il programma");
                    Console.ReadLine();
                    Risposta =opzioni.Length+1;
                }
            } while (Risposta > opzioni.Length | Risposta < 1);

            return Risposta;
        }
        static void Main(string[] args)
        {
            const int dim=3;
            bool fine = true;
            string[] opzioni = { "Inserimento", "Visualizza","Rierca", "Fine" };
            Persona[] persona = new Persona[dim];
            int risposta;
            string visualizza="";
            Console.Clear();
            do
            {
                risposta=Menu(opzioni);
                do
                {
                    switch (risposta)
                    {
                        case 1:
                            for (int i = 0; i < persona.Length; i++)
                            {
                                persona[i] = LeggiPersona();
                            }
                            break;
                        case 2:
                            Visualizzazione(persona);
                            break;
                        case 3:
                            Ricerca(persona);
                            break;
                        case 4:
                            fine = false;
                            break;
                    }
                    if (risposta<4)
                    Console.ReadLine();
                } while (visualizza=="S");  
            } while (fine);
        }
    }
}
