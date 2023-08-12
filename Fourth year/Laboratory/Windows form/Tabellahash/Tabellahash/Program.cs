using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabellahash
{
    class Program
    {
        struct studente
        {
            public string codice;
            public string nomecognome;
            public string classe;
            public char stato;
        }
        struct tabella
        {
            public int dimprimaria;
            public int dimoverflow;
            public int nelementioverflow;
            public studente[] studenti;
        }
        enum messaggio
        {
            inserito, trovato, noninserito, nontrovato,riorganizzato,nonriorganizzato,cancellato, giàpresente
        }
        static void provainput(tabella tab)
        {
            studente tmp;
            int pos;
            tmp.codice = "abc";
            tmp.nomecognome = "Primo primo";
            tmp.classe = "1";
            tmp.stato = 'O';
            pos = poskey(tmp.codice, 10);
            tab.studenti[pos] = tmp;
            tmp.codice = "sss";
            tmp.nomecognome = "Secondo secondo";
            tmp.classe = "2";
            tmp.stato = 'O';
            pos = poskey(tmp.codice, 10);
            tab.studenti[pos] = tmp;
            tmp.codice = "zzz";
            tmp.nomecognome ="Terzo terzo";
            tmp.classe = "3";
            tmp.stato = 'O';
            pos = poskey(tmp.codice, 10);
            tab.studenti[pos] = tmp;
        }
        static void creazione(out tabella tab, int dimprimaria, int dimoverflow)//creazione tabella
        {
            int nelementioverflow = 0;
            tab.studenti = new studente[dimprimaria + dimoverflow];
            tab.dimoverflow = dimoverflow;
            tab.dimprimaria = dimprimaria;
            tab.nelementioverflow = nelementioverflow;
            for (int i = 0; i < tab.studenti.Length; i++)
                tab.studenti[i].stato = 'L';

        }
        static int poskey(string codice, int elementivalidi)//calcolo posizione vettore dalla chiave
        {
            int indicehash;
            indicehash=codice.GetHashCode();
            return Math.Abs(indicehash % elementivalidi);
        }
        static messaggio inserimento(ref tabella tab, studente tmp)//inesrimento elementi in tabella hash
        {
            messaggio mess;
            int pos;
            int postrovato;
            pos = poskey(tmp.codice, tab.dimprimaria);
            mess = ricerca(tmp.codice, tab, out postrovato);
            if (mess == messaggio.trovato)
                mess = messaggio.giàpresente;
            else
            if (tab.studenti[pos].stato == 'L')
            {
                tab.studenti[pos] = tmp;
                mess = messaggio.inserito;
            }
            else
            {
                if (tab.nelementioverflow + tab.dimprimaria < tab.dimprimaria + tab.dimoverflow)
                {
                    tab.studenti[tab.dimprimaria + tab.nelementioverflow] = tmp;
                    tab.nelementioverflow++;
                    mess = messaggio.inserito;
                }
                else
                    mess = messaggio.noninserito;
            }
            return mess; 
        }
        static void riorganizza(ref tabella tab)//riorganizzazione
        {      
            tabella tabnuova;
            tabnuova.dimoverflow = 10;
            tabnuova.dimprimaria = 20;
            creazione(out tabnuova, tabnuova.dimprimaria, tabnuova.dimoverflow);
            for (int i = 0; i < tab.dimprimaria+tab.nelementioverflow; i++)
            {
                if(tab.studenti[i].stato!='L')
                    inserimento(ref tabnuova, tab.studenti[i]);
            }
            tab = tabnuova;
        }
        static void Mesaggi(messaggio mess)
        {
            switch (mess)
            {
                case messaggio.inserito:
                    Console.WriteLine("Inserito con successo");
                    break;
                case messaggio.trovato:
                    Console.WriteLine("Elemento trovato");
                    break;
                case messaggio.cancellato:
                    Console.WriteLine("Elemento eliminato");
                    break;
                case messaggio.nontrovato:
                    Console.WriteLine("Elemento non trovato");
                    break;
                case messaggio.noninserito:
                    Console.WriteLine("Elemento non inserito");
                    break;
                case messaggio.riorganizzato:
                    Console.WriteLine("Collezione riorganizzata");
                    break;
                case messaggio.nonriorganizzato:
                    Console.WriteLine("Collezione non riorganizzata, perchè è già stata riorganizzata una volta");
                    break;
                case messaggio.giàpresente:
                    Console.WriteLine("Elemento già presente");
                    break;
            }
        }
        static void visualizza(studente tmp,int pos)
        {
                Console.WriteLine(pos+")Codice:"+tmp.codice+", Nome e cognome:" + tmp.nomecognome+", classe:"+tmp.classe);
        }
        static messaggio ricerca(string codice, tabella tab, out int pos)//ricerca elemento
        {
            bool trovatoover=false;
            pos=poskey(codice, tab.dimprimaria);
            messaggio mess;
            if (tab.studenti[pos].codice == codice)
                mess = messaggio.trovato;
            else
            {
                mess = messaggio.nontrovato;
                pos = -1;
                for (int i = tab.dimprimaria; i < tab.nelementioverflow&&!trovatoover; i++)
                {
                    if (codice == tab.studenti[i].codice)
                    {
                        pos = i;
                        mess = messaggio.trovato;
                        trovatoover = true;
                    }
                }
            }
            return mess;
        }
        static messaggio cancella(tabella tab, string codice)//metodo cancella
        {
            int pos;
            messaggio mess;
            bool cancellato = false;
            mess=ricerca(codice, tab, out pos);
            if(mess==messaggio.trovato)
            {
                if (tab.studenti[pos].codice == codice)//cancella nella dimprimaria
                {
                    tab.studenti[pos].stato = 'L';
                    for (int i = tab.dimprimaria; i < tab.nelementioverflow+tab.dimprimaria&&!cancellato; i++)
                    {
                        if (codice.GetHashCode() == tab.studenti[i].codice.GetHashCode())
                        {
                            tab.studenti[pos] = tab.studenti[i];
                            tab.studenti[i].stato = 'L';
                            cancellato = true;
                        }
                    }
                    mess = messaggio.cancellato;
                }
                else//cancella nell'overflow
                {
                    for (int i = tab.dimprimaria; i < tab.nelementioverflow+tab.dimprimaria&&!cancellato; i++)
                    {
                        if (codice == tab.studenti[i].codice)
                        {
                            for (int j=i; i < tab.nelementioverflow; j=i++)
                            {
                                tab.studenti[i] = tab.studenti[i + 1];
                            }
                            tab.nelementioverflow--;
                            cancellato = true;
                            mess = messaggio.cancellato;      
                        }
                    }
                }
            }
            return mess;
        }
        static void Main(string[] args)
        {
            int dimprima = 10;
            int dimover = 5;
            tabella tabhash;
            string risposta;
            string codice;
            int pos;
            messaggio mess;
            studente tmp;
            bool riorganizzata = false;
            creazione(out tabhash, dimprima, dimover);
            provainput(tabhash);
            do
            {
                //menu
                Console.Clear();
                Console.WriteLine("Digitare numero corrispondente all'operazione da effettuare:");
                Console.WriteLine("1-Inserimento");
                Console.WriteLine("2-Visualizza");
                Console.WriteLine("3-Ricerca");
                Console.WriteLine("4-Riorganizza");
                Console.WriteLine("5-Cancella");
                Console.WriteLine("6-Chiusura programma");
                risposta = Console.ReadLine();
                switch (risposta)
                {//distinzione operazione da eseguire
                    case "1"://inserimento
                        do
                        {
                            Console.WriteLine("Inserire codice studente:(max 3 caratteri)");
                            tmp.codice = Console.ReadLine();
                        } while (tmp.codice.Length > 3);
                        do
                        {
                            Console.WriteLine("Inserire nome e cognome studente:");
                            tmp.nomecognome = Console.ReadLine();
                        } while (tmp.nomecognome == "");
                        do
                        {
                            Console.WriteLine("Inserire classe dello studente:");
                            tmp.classe = Console.ReadLine();
                        } while (tmp.classe == "");
                        tmp.stato = 'O';
                        mess=inserimento(ref tabhash,tmp);
                        Mesaggi(mess);
                        break;
                    case "2"://visualizza
                        for (int i=0;i<tabhash.studenti.Length;i++ )
                            if(tabhash.studenti[i].stato!='L')
                            visualizza(tabhash.studenti[i],i);
                        break;
                    case "3"://ricerca
                        do
                        {
                            Console.WriteLine("Inserisci il codice dell'elemento da cercare:");
                            codice = Console.ReadLine();
                        } while (codice.Length!=3);                       
                        ricerca(codice,tabhash,out pos);
                        if (pos != -1)
                        {
                            Mesaggi(messaggio.trovato);
                            visualizza(tabhash.studenti[pos],pos);
                        }
                        else
                            Mesaggi(messaggio.nontrovato);
                        break;
                    case "4"://riorganizza
                        if (!riorganizzata)
                        {
                            mess = messaggio.riorganizzato;
                            riorganizzata = true;
                            riorganizza(ref tabhash);
                        }
                        else
                            mess = messaggio.nonriorganizzato;
                        Mesaggi(mess);
                        break;
                    case "5"://ricerca
                        do
                        {
                            Console.WriteLine("Inserisci il codice dell'elemento da cancellare:");
                            codice = Console.ReadLine();
                        } while (codice.Length != 3);
                        mess=cancella(tabhash, codice);
                        Mesaggi(mess);
                        break;
                    default://controllo risposta errata
                        if (risposta != "6")
                            Console.WriteLine("Input valore errato");
                        break;
                }
                if(risposta!="6")
                Console.ReadLine();
            } while (risposta!="6");//5 è la chiusura del programma
        }
    }
}
