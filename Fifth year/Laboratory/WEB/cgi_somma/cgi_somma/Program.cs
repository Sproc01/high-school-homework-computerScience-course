using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cgi_somma
{
    class Program
    {
        static void Main(string[] args)
        {
            // inviamo al server l'intestazione HTTP da inviare al browser
            Console.WriteLine("HTTP/1.1 200 OK");
            Console.WriteLine("Content-type: text/html");
            Console.WriteLine();

            // inviamo al server la pagina HTML
            Console.WriteLine("<HTML>");
            Console.WriteLine("<HEAD>");
            Console.WriteLine("<TITLE>Prova CGI</TITLE>");
            Console.WriteLine("</HEAD>");
            Console.WriteLine("<BODY bgcolor=\"#FFFBDB\">");
            Console.WriteLine("<FORM NAME=\"dati\" METHOD=\"GET\" ACTION=\"cgi_somma.exe\" >");
            Console.WriteLine("Dato1 &nbsp;&nbsp;<INPUT TYPE=\"TEXT\" NAME=\"Dato1\" VALUE = \"0\" ></BR></BR>");
            Console.WriteLine("Dato2 &nbsp;&nbsp;<INPUT TYPE=\"TEXT\" NAME=\"Dato2\" VALUE=\"0\"></BR></BR></BR>");
            Console.WriteLine("<INPUT TYPE=\"SUBMIT\" VALUE=\"Somma\">");
            Console.WriteLine("</FORM>");

            Console.WriteLine("<H2>Prova di esecuzione di un CGI sviluppato in C#");
            Console.WriteLine("</H2>");
            Console.WriteLine("<H2>somma");
            // leggiamo la variabile di ambiente che contiene la querystring
            string qs = Environment.GetEnvironmentVariable("QUERY_STRING");
            //string qs="dato1=10&dato2=3";
            // separiamo e visualizziamo i due valori trasmessi
            string[] valore = qs.Split('&');
            string[] adddendo = valore[0].Split('=');
            int dato1 = Convert.ToInt32(adddendo[1]);
            adddendo = valore[1].Split('=');
            int dato2 = Convert.ToInt32(adddendo[1]);

            // chiusura della pagina HTML
            Console.WriteLine(dato1 + "</BR>" + dato2 + "</BR>");

            Console.WriteLine(dato1 + dato2);

            Console.WriteLine("</H2>");

            Console.WriteLine("</BODY>");
            Console.WriteLine("</HTML>");
            Console.WriteLine();
            // Console.ReadLine();
        }
    }
}
