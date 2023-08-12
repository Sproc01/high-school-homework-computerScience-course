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
        static void Cancella(Persona[] agenda, string risposta,int posizione)
        {
            do
            {
                Console.WriteLine("Vuoi cancellarla?S/N");
                risposta = Console.ReadLine().ToUpper();
            } while (risposta != "S" & risposta != "N");
            if (risposta == "S")
            {
                agenda[posizione].Nome = "";
                agenda[posizione].Cognome = "";
                agenda[posizione].NumTelefono = "";
            }
        }
        static void Modifica (Persona [] agenda, string risposta, int posizione)
        {
            do
            {
                Console.WriteLine("Vuoi cambiare il numero?S/N");
                risposta = Console.ReadLine().ToUpper();
            } while (risposta != "S" & risposta != "N");
            if (risposta == "S")
            {
                Console.WriteLine("Inserisci nuovo numero di telefono");
                agenda[posizione].NumTelefono = Console.ReadLine();
            }
        } 
        static int RicercaPosizione(Persona[] agenda, int count, Persona contatto)
        {
            int posizione=-1;
            bool trovato = false;
            int i;
            for (i = 0; i < count & !trovato; i++)
            {
                trovato = (contatto.Nome == agenda[i].Nome & contatto.Cognome == agenda[i].Cognome);
            }
            if (trovato)
                posizione=i-1;
            return posizione;

        }
        static bool Ricerca(Persona [] agenda,int count, Persona contatto)
        {
            bool trovato = false;
            for (int i = 0; i < count& !trovato; i++)
            {
                trovato =(contatto.Nome == agenda[i].Nome & contatto.Cognome == agenda[i].Cognome);
            }
            return trovato;
        }
        static int Menu(string[] opzioni)
        {
            int Risposta = 1;

            do
            {
                Console.WriteLine("=Menù=");
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
                    Risposta = opzioni.Length+1;
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
        static void Visualizza(Persona []agenda,int numpersone)
        {
            for (int i = 0; i < numpersone; i++)
            {
                if(agenda[i].Cognome!=""&agenda[i].Nome!=""&agenda[i].NumTelefono!="")
                Console.WriteLine($"Cognome: {agenda[i].Cognome} Nome: {agenda[i].Nome} numero: {agenda[i].NumTelefono}");
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            int opzione;
            Persona temporanea;
            const int dim = 3;
            bool fine = true;
            int count=0;
            int posizione;
            string risposta="";
            bool agendapiena;
            string[] opzioni = { "Inserimento: ", "Visualizzazione","Ricerca","Modifica","Elimina", "Fine"};
            Persona[] agenda = new Persona[dim];
            do
            {
                agendapiena = true;
                Console.Clear();
                opzione= Menu(opzioni);
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
                            for (int i = 0; i < agenda.Length; i++)
                            {
                                if (agenda[i].Cognome == "" & agenda[i].Nome == "" & agenda[i].NumTelefono == "")
                                {
                                    do
                                    {
                                        Console.WriteLine("Inserire una nuova persona a posto di quella eliminata?S/N");
                                        risposta = Console.ReadLine().ToUpper();
                                        if (risposta == "S")
                                        {
                                            agenda[i] = LeggiPersona(true);
                                            agendapiena = false;
                                        }
                                    } while (risposta != "S" & risposta != "N");
                                }
                            }
                            if(agendapiena)
                            Console.WriteLine("Agenda piena");
                        }
                        if (agendapiena)
                            Console.ReadLine();
                        break;
                    case 2:
                        Visualizza(agenda, count);
                        break;
                    case 3:
                        Console.WriteLine("Inserisci contatto di cui cercare il numero di telefono");
                        temporanea = LeggiPersona(false);
                        posizione = RicercaPosizione(agenda, count, temporanea);
                        if (posizione != -1)
                        {
                            Console.WriteLine("L'indice è:" + (posizione + 1));
                            Console.WriteLine("Il numero di telefono è:" + agenda[posizione].NumTelefono);
                        }
                        else
                            Console.WriteLine("Elemento non presente");
                        Console.ReadLine();
                        break;
                    case 4:
                        temporanea = LeggiPersona(false);
                        if (Ricerca(agenda, count, temporanea))
                        {
                            posizione = RicercaPosizione(agenda, count, temporanea);
                            Console.WriteLine("Il contatto è: nome:" + agenda[posizione].Nome+" cognome:"+agenda[posizione].Cognome+" numero di telefono:"+agenda[posizione].NumTelefono);
                            Modifica(agenda, risposta, posizione);
                        }
                        else
                        {
                            Console.WriteLine("elemento non presente");
                            Console.ReadLine();
                        }
                        break;
                    case 5:
                            temporanea= LeggiPersona(false);
                        if (Ricerca(agenda, count, temporanea))
                        {
                            posizione = RicercaPosizione(agenda, count, temporanea);
                            Console.WriteLine("Il contatto è: nome:" + agenda[posizione].Nome + " cognome:" + agenda[posizione].Cognome + " numero di telefono:" + agenda[posizione].NumTelefono);
                            Cancella(agenda, risposta, posizione);
                        }
                        else
                        {
                            Console.WriteLine("elemento non presente");
                            Console.ReadLine();
                        }
                        break;
                    case 6: fine = false; break;
                }
            } while (fine);
        }
    }
}
