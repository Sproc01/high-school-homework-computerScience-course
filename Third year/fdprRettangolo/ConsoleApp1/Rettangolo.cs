using System;
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
            double area,perimetro;
            altezza=5.2;
            baseRettangolo =5 ;
            //calcolo dell'area
            area = altezza * baseRettangolo;//operatori aritmetici *;/;+;-;%
            //calcolo perimetro
            perimetro = (altezza + baseRettangolo) * 2;
            //visualizzazione risultati
            Console.Write("l'area è ");
            Console.WriteLine(area);
            Console.Write("Il perimetro è ");
            Console.WriteLine(perimetro);
            Console.ReadLine();
        }
    }
}
