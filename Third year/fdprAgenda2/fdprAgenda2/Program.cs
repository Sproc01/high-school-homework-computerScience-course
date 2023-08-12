using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fpdrAgenda
{
    public struct Persona
    {
        public string Cognome;
        public string Nome;
        public string NumTelefono;

    }
    class Program
    {
        static int RicercaPosizione(Persona[] agenda, int count, Persona contatto)
        {
            int posizione = -1;
            bool trovato = false;
            int i;
            for (i = 0; i < count & !trovato; i++)
            {
                trovato = (contatto.Nome == agenda[i].Nome & contatto.Cognome == agenda[i].Cognome);
            }
            if (trovato)
                posizione = i;
            return posizione;

        }
        static bool Ricerca(Persona[] agenda, int count, Persona contatto)
        {
            bool trovato = false;
            for (int i = 0; i < count & !trovato; i++)
            {
                trovato = (contatto.Nome == agenda[i].Nome & contatto.Cognome == agenda[i].Cognome);
            }
            return trovato;
        }
        static int Menu(string[] opzioni)
        {
            int Risposta = 1;

            do
            {
                Console.WriteLine("=Men˘=");
                for (int i = 0; i < opzioni.Length; i++)
                {
                    Console.WriteLine("{0}] - {1}", i + 1, opzioni[i]);
                }

                try
                {
                    Risposta = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Risposta = opzioni.Length + 1;
                }
            } while (Risposta < 1 | Risposta > opzioni.Length);

            return Risposta;
        }

        static Persona LeggiPersona(bool telefono)
        {
            Persona contatto;
            Console.WriteLine("Inserisci il cognome");
            contatto.Cognome = Console.ReadLine();
            Console.WriteLine("Inserisci il nome");
            contatto.Nome = Console.ReadLine();

            if (telefono)
            {
                Console.WriteLine("Inserisci il numero di telefono");
                contatto.NumTelefono = Console.ReadLine();
            }
            else
                contatto.NumTelefono = "";

            return contatto;
        }
        static void Visualizza(Persona[] agenda, int numpersone)
        {
            for (int i = 0; i < numpersone; i++)
            {
                Console.WriteLine($"Cognome: {agenda[i].Cognome} Nome: {agenda[i].Nome} numero: {agenda[i].NumTelefono}");
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Persona temporanea;
            int opzione;
            const int dim = 3;
            bool fine = true;
            int count = 0;

            string[] opzioni = { "Inserimento: ", "Visualizzazione", "Ricerca", "Fine" };
            Persona[] agenda = new Persona[dim];


            do
            {
                Console.Clear();
                opzione = Menu(opzioni);

                switch (opzione)
                {
                    case 1:
                        if (count == 0)
                        {
                            agenda[count] = LeggiPersona(true);
                            Console.WriteLine("elemento inserito");
                            count++;
                        }
                        else
                        if (count < dim)
                        {
                            temporanea = LeggiPersona(true);
                            if (Ricerca(agenda, count, temporanea))  
                                Console.WriteLine("Elemento già presente");
                            else
                            {
                                agenda[count] = temporanea;
                                Console.WriteLine("elemento inserito");
                                count++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Agenda piena");
                        }
                        Console.ReadLine();
                        break;
                    case 2:
                        Visualizza(agenda, count);
                        break;
                    case 3:
                        Console.WriteLine("Inserisci contatto da cercare");
                        temporanea = LeggiPersona(false);
                        if (Ricerca(agenda, count, temporanea))
                        {
                            Console.WriteLine("Presente in agenda");
                            Console.WriteLine("L'indice è:" + RicercaPosizione(agenda, count, temporanea));
                        }
                        else
                            Console.WriteLine("Elemento non presente");
                        Console.ReadLine();
                        break;
                    case 4: fine = false; break;
                }
            } while (fine);
        }
    }
}

