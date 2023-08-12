using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RedirectionOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato;
            Process mioProcesso;
            Console.WriteLine("Questo programma lancia un altro programma");
            Console.Write("Inserire dato:");
            dato = Console.ReadLine();
            mioProcesso = new Process();
            mioProcesso.StartInfo.UseShellExecute = false;
            mioProcesso.StartInfo.FileName = "lanciato.exe";
            mioProcesso.StartInfo.CreateNoWindow = true;
            mioProcesso.StartInfo.RedirectStandardOutput = true;
            mioProcesso.StartInfo.EnvironmentVariables.Add("nome", dato);
            mioProcesso.Start();
            mioProcesso.WaitForExit();
            string output = mioProcesso.StandardOutput.ReadToEnd();
            Console.Write(output);
            Console.ReadLine();
        }
    }
}
