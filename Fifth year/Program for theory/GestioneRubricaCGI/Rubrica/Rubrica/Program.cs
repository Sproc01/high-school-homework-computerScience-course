using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Rubrica
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.SetData("APP_CONFIG_FILE", @"C:\inetpub\wwwroot\web.config");
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Environment.CurrentDirectory+"\\Rubrica.accdb");
            con.Open();
            Console.WriteLine("HTTP/1.1 200 OK");

            Console.WriteLine("Content-type: text/html");
            Console.WriteLine();
            //Pagina di ritorno
            Console.WriteLine("<html>");
            Console.WriteLine("<head> <title> Rubrica </title> </head>");
            Console.WriteLine("<body>");
            Console.WriteLine("<form method = \"GET\" action = \"Rubrica.exe\">");
            Console.WriteLine(" Nome: <input type = \"text\" name = \"Nome\"/> ");
            Console.WriteLine("<br>");
            Console.WriteLine("<input type = \"submit\" value = \"Cerca\"/> </form>");
            Console.WriteLine("<br>");
            string s = Environment.GetEnvironmentVariable("QUERY_STRING");
            string nome = s.Split('=')[1];
            OleDbCommand cmd = new OleDbCommand($"SELECT * FROM PERSONA WHERE NOME='{nome}'", con);
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable da = new DataTable();
            da.Load(dr);
            if (da.Rows.Count == 1)
            {
                string telefono = da.Rows[0][1].ToString();
                string img = da.Rows[0][2].ToString();
                Console.WriteLine("Numero di telefono: " + telefono+ "<br>");
                Console.WriteLine("<br>");
                Console.WriteLine($"<img src=\"img//{img}\"");
            }
            else
                Console.WriteLine("Elemento non presente <br>");
            con.Close();
            Console.WriteLine("</body > </html> ");
            Console.ReadLine();
        }
    }
}
