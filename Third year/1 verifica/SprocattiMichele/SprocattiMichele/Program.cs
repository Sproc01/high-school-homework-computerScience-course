using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprocattiMichele
{
    class Program
    {
        static void Main(string[] args)
        {
            double litri = 0;
            string rispostatrans;
            const double sconto = 0.1;
            const int prezzolitro = 2;
            const double nlitri = 1.5;
            const double prezzoBottiglia=prezzolitro*1.5;
            double prezzo;
            double ScontoApplicato=0;
            int speseTrasposrto=0;
            double totaleIncasso=0;
            double totaleSconto=0;
            int nScontrini=0;
            int nBotttiglioni;
            int BottiglioniTotali=0;
            double LitriTotali = 0;
            string risposta;
            int speseTraspTotali=0;
            do
            {
                Console.Clear();
                litri = 0;
                ScontoApplicato = 0;
                speseTrasposrto = 0;
                //controllo errori numero bottiglioni
                do
                {
                    Console.WriteLine("Buongiorno cliente,");
                    Console.WriteLine("Inserire quanti bottiglioni si vuole acquistare?");
                    nBotttiglioni = Convert.ToInt32(Console.ReadLine());//input numero bottiglioni
                } while (nBotttiglioni == 0);
                //controllo errori risposta trasporto
                do
                {
                    Console.WriteLine("Vuole la consegna a domicilio?S/N");
                    rispostatrans = Console.ReadLine().ToUpper();
                } while (rispostatrans != "S" & rispostatrans != "N");
                if (rispostatrans == "S")
                    speseTrasposrto = 3;
                BottiglioniTotali += nBotttiglioni;
                prezzo = prezzoBottiglia * nBotttiglioni;
                litri=nlitri * nBotttiglioni;
                LitriTotali += litri;
                if (litri > 45)
                    ScontoApplicato=prezzo*sconto;
                //output scontrino personale
                Console.WriteLine("========== Tana dei Goti ============");
                Console.WriteLine($"Barbera:{nBotttiglioni} bottiglioni({litri} L) importo:{prezzo}$");
                Console.WriteLine($"Sconto 10%                         {ScontoApplicato}$");
                prezzo -= ScontoApplicato;
                Console.WriteLine($"Totale parziale                    {prezzo}$");
                Console.WriteLine($"Spese di trasporto                 {speseTrasposrto}$");
                prezzo += speseTrasposrto;
                Console.WriteLine("=====================================");
                Console.WriteLine($"Importo Totale                     {prezzo}$ ");
                //incremento numero scontrini
                nScontrini++;
                Console.WriteLine($"                                    {nScontrini}");
                Console.WriteLine("============ Arrivederci ============");
                //incremento conteggi totali
                totaleIncasso += prezzo;
                totaleSconto += ScontoApplicato;
                speseTraspTotali += speseTrasposrto;
                Console.ReadLine();
                Console.Clear();
                //controllo errori risposta prossimo cliente
                do
                {
                    Console.WriteLine("Prossimo cliente?S/N");
                    risposta = Console.ReadLine().ToUpper();
                } while (risposta != "S" & risposta != "N");

            } while (risposta=="S");
            //scontrino fine giornata
            Console.WriteLine("========== Tana dei Goti ============");
            Console.WriteLine("========= Chiusura Cassa ============");
            Console.WriteLine($"Barbera Totale:  {BottiglioniTotali} bottiglioni,   {LitriTotali} L");
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
