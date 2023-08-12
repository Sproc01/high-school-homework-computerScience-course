using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprVinaio
{
    class Program
    {
        static void Main(string[] args)
        {
            double litri = 0;
            string rispostatrans;
            const double sconto = 0.1;
            int prezzolitro;
            const double nlitri = 1;
            double prezzo=0;
            double ScontoApplicato = 0;
            int speseTrasporto = 0;
            double totaleIncasso = 0;
            double totaleSconto = 0;
            int nScontrini = 0;
            int nBotttiglioni=0;
            int BottiglioniTotali = 0;
            double LitriTotali = 0;
            string risposta;
            int speseTraspTotali = 0;
            string tipovino;
            string r1;
            double prezzo1Tipologia=0;
            double litriMerlot=0;
            double litriLugana=0;
            double litriRecioto=0;
            int bottiglioni1Vino = 0;
            int spesetrasporto1 = 0;
            double litri1 = 0;
            do
            {
                Console.Clear();
                ScontoApplicato = 0;
                speseTrasporto = 0;
                Console.WriteLine("Buongiorno cliente,");
                do
                {
                    //controllo errori tipologia vino;
                    do
                    {
                        Console.WriteLine("Abbiamo a dispozione tre tipologie di vino: Merlot(2$ a litro), lugana(6$ a litro), recioto(10$ a litro); prego inserire quale si vuole acquistare:");
                        tipovino = Console.ReadLine();
                    } while (tipovino != "merlot" & tipovino != "lugana" & tipovino != "recioto");
                    //controllo errori numero bottiglioni
                    do
                    {
                        Console.WriteLine("Inserire quanti bottiglioni(1 contiene un litro) si vuole acquistare?");
                        bottiglioni1Vino = Convert.ToInt32(Console.ReadLine());//input numero bottiglioni
                    } while (bottiglioni1Vino == 0);
                    litri1 = nlitri * bottiglioni1Vino;
                    //conrollo tipologia vino inserita
                    switch (tipovino)
                    {
                        case "merlot":
                            prezzolitro = 2;
                            litriMerlot += litri1;
                            prezzo1Tipologia = bottiglioni1Vino * prezzolitro;
                            break;
                        case "lugana":
                            prezzolitro = 6;
                            litriLugana += litri1;
                            prezzo1Tipologia = bottiglioni1Vino * prezzolitro;
                            break;
                        case "recioto":
                            prezzolitro = 10;
                            litriRecioto += litri1;
                            prezzo1Tipologia = bottiglioni1Vino * prezzolitro;
                            break;
                    }
                    //somma valori tipologia 1 vino
                    nBotttiglioni += bottiglioni1Vino;
                    BottiglioniTotali += bottiglioni1Vino;
                    litri += litri1;
                    LitriTotali += litri1;
                    prezzo += prezzo1Tipologia;
                    Console.WriteLine("si desidera acquistare altri tipi di vini?S/N");
                    r1 = Console.ReadLine().ToUpper();
                } while (r1 == "S");
                //controllo errori risposta trasporto
                do
                {
                    Console.WriteLine("Vuole la consegna a domicilio?S/N");
                    rispostatrans = Console.ReadLine().ToUpper();
                } while (rispostatrans != "S" & rispostatrans != "N");
                if (rispostatrans == "S")
                    spesetrasporto1 = 3;
                else
                    spesetrasporto1 = 0;
                speseTrasporto += spesetrasporto1;
                //controllo sconto
                if (nBotttiglioni > 5)
                    ScontoApplicato = prezzo * sconto;
                //output scontrino personale
                Console.WriteLine("========== Tana dei Goti ============");
                Console.WriteLine($"Barbera:{nBotttiglioni} bottiglioni({litri} L) importo:{prezzo}$");
                Console.WriteLine($"Sconto 10%                         {ScontoApplicato}$");
                prezzo -= ScontoApplicato;
                Console.WriteLine($"Totale parziale                    {prezzo}$");
                Console.WriteLine($"Spese di trasporto                 {speseTrasporto}$");
                prezzo += speseTrasporto;
                Console.WriteLine("=====================================");
                Console.WriteLine($"Importo Totale                     {prezzo}$ ");
                //incremento numero scontrini
                nScontrini++;
                Console.WriteLine($"                                    {nScontrini}");
                Console.WriteLine("============ Arrivederci ============");
                //incremento conteggi totali
                totaleIncasso += prezzo;
                totaleSconto += ScontoApplicato;
                speseTraspTotali += speseTrasporto;
                Console.ReadLine();
                Console.Clear();
                //controllo errori risposta prossimo cliente
                do
                {
                    Console.WriteLine("Prossimo cliente?S/N");
                    risposta = Console.ReadLine().ToUpper();
                } while (risposta != "S" & risposta != "N");

            } while (risposta == "S");
            //scontrino fine giornata
            Console.WriteLine("========== Tana dei Goti ============");
            Console.WriteLine("========= Chiusura Cassa ============");
            Console.WriteLine($"Barbera Totale:  {BottiglioniTotali} bottiglioni,   {LitriTotali} L");
            Console.WriteLine($"Litri Merlot Venduti               {litriMerlot}L");
            Console.WriteLine($"Litri Lugana Venduti               {litriLugana}L");
            Console.WriteLine($"Litri Recioto Venduti              {litriRecioto}L");
            Console.WriteLine("=====================================");
            Console.WriteLine("=====================================");
            Console.WriteLine($"Totale sconto                      {totaleSconto}$");
            Console.WriteLine($"Totale Incasso                     {totaleIncasso}$");
            Console.WriteLine($"Totale Spese di trasporto          {speseTraspTotali}$");
            Console.WriteLine($"n° scontrini emessi                 {nScontrini}");
            Console.WriteLine("============ Arrivederci ============");
            Console.ReadLine();
        }
    }
}
