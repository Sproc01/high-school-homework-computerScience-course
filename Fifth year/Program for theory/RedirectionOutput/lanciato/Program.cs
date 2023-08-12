using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lanciato
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato = Environment.GetEnvironmentVariable("nome");
            Console.WriteLine("Io sono " + dato);
        }
    }
}
