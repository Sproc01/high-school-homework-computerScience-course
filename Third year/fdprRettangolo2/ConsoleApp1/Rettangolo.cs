﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprRettangolo
{
    class Rettangolo
    {
        static void Main(string[] args)//variabili di 2 tipi, variabili valore e variabili riferimento, 
                                       //variabili all'interno del metodo si dicono locali al metodo; al di fuori si chiamano globali
        {// double occupa 8 byte; in virgola mobile
            double altezza;//contiene l'altezza del rettangolo
            double baseRettangolo;
            double area, perimetro;
            string risposta="S";
            bool rispostaTrue=true;//valore booleano 1,0
            //while (risposta != "S")// operatori relazionali: == (equivalenza); !=(diverso);<;>;<=;>=
            while(rispostaTrue)
            {
                Console.WriteLine("Inserire l'altezza");//inserire costante stringa
                altezza = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Inserire la base");
                baseRettangolo = Convert.ToDouble(Console.ReadLine());
                //calcolo dell'area
                area = altezza * baseRettangolo;//operatori aritmetici *;/;+;-;%
                //calcolo perimetro
                perimetro = (altezza + baseRettangolo) * 2;
                //visualizzazione risultati
                /*Console.Write("l'area:{0} perimetro:{1} area+perimetro:{2}", area, perimetro,area+perimetro);+ è operatore di concatenazione in questo caso,
                funziona solo perchè da una parte c'è una stringa, se ci fossero entrambe variabili farebbe la somma, {} segnaposto per scrivere le variabili,
                gli errori sono eccezioni, si posssono gestire*/
                Console.WriteLine($"l'area:{area} perimetro:{perimetro} area+perimetro:{area + perimetro}");//il simbolo del $ permette di inserire la variabile al posto del segnaposto
                Console.Write("Ripetere il programma S/N?");
                risposta =Console.ReadLine().ToUpper();
                rispostaTrue = (risposta == "S");
            }
        }
    }
}
