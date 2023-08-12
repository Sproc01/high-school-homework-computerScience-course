using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UnsplitSplitFileclass
{
    class UnsplitSplitFile
    {
        string percorso;
        List<byte> bytefile;//vettore di appoggio
        string extension;
        public UnsplitSplitFile(string p)//costruttore
        {
            percorso = p;
            extension = Path.GetExtension(p);
            bytefile = new List<byte>();
        }
        private void savebuffer(int dimParte, byte[] buffer)
        {
            //copio i byte su vettore di appoggio
            for (int y = 0; y < dimParte; y++)
            {
                bytefile.Add(buffer[y]);
            }
        }
        public FileStream[] SplitFile(int numparti)//divide il file
        {
            FileStream[] file = new FileStream[numparti];
            FileStream fileLetto = new FileStream(percorso, FileMode.Open, FileAccess.Read);
            int dimParte = (int)(fileLetto.Length / numparti);
            byte[] buffer = new byte[dimParte + 1];
            string nomeParte="";
            int i;
            for (i = 0; i < numparti; i++)
            {
                nomeParte = string.Format("{0}{1:000}{2}",percorso.Replace(Path.GetExtension(percorso),""), i,extension);
                file[i]=new FileStream(nomeParte, FileMode.Create, FileAccess.Write);
                fileLetto.Read(buffer, 0, dimParte);
                savebuffer(dimParte, buffer);
                file[i].Write(buffer, 0, dimParte);
                file[i].Close();
            }
            int byteResidui = (int)(fileLetto.Length - fileLetto.Position);
            if (byteResidui > 0)
            {
                buffer = new byte[byteResidui];
                fileLetto.Read(buffer, 0, byteResidui);
                file[i - 1] = new FileStream(nomeParte, FileMode.Append);
                savebuffer(byteResidui, buffer);
                file[i - 1].Write(buffer, 0, byteResidui);
                file[i - 1].Close();      
            }
            fileLetto.Close();
            return file;
        }
        public void UnSplitFile(string p)//riunisce il file diviso
        {
            FileStream fs = new FileStream(p, FileMode.Create, FileAccess.Write);
            fs.Write(bytefile.ToArray(), 0, bytefile.Count);
            fs.Close();
        }
        public string Percorso
        {
            get { return percorso; }
        }
        public string Extension
        {
            get { return extension; }
        }
    }
}
