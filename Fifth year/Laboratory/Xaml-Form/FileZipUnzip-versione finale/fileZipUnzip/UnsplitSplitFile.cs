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
        string[] percorsi;
        public string[] Percorsi
        {
            get { return percorsi; }
        }
        //due costruttori: uno per quando si seleziona il file da dividere, l'altro per quando si selezionano più file da compattare
        public UnsplitSplitFile(string[] p)
        {
            percorsi = p;
        }
        public UnsplitSplitFile(string p)
        {
            //inizializzo il vettore solo con il primo elemento perchè il file è da dividere
            percorsi = new string[1];
            Percorsi[0] = p;
        }

        public void SplitFile(int numparti)//divide il file
        {
            //inizializzo i due campi altrimenti provoca errore al di fuori del for
            FileStream file = null;
            string nomeParte = "";
            string nomefile = percorsi[0];
            percorsi = new string[numparti];
            FileStream fileInput = new FileStream(nomefile, FileMode.Open, FileAccess.Read);
            int dimParte = (int)(fileInput.Length / numparti);
            byte[] buffer = new byte[dimParte];
            int i;
            for (i = 0; i < numparti; i++)
            {
                nomeParte = string.Format("{0}{1:000}{2}", nomefile.Replace(Path.GetExtension(nomefile), ""), i, Path.GetExtension(nomefile));
                //string format per nome del file con 000, 001, 002 ecc.. prima dell'estensione
                file = new FileStream(nomeParte, FileMode.Create, FileAccess.Write);
                fileInput.Read(buffer, 0, dimParte);
                file.Write(buffer, 0, dimParte);
                file.Close();
                percorsi[i] = file.Name;
            }
            int byteResidui = (int)(fileInput.Length - fileInput.Position);
            if (byteResidui > 0)
            {
                buffer = new byte[byteResidui];//inizializzo nuovamente il vettore perchè in alcuni casi capita che byteresidui è maggiore di dimparte+1
                file = new FileStream(nomeParte, FileMode.Append);//posiziono puntatore alla fine dell'ultima parte
                fileInput.Read(buffer, 0, byteResidui);
                file.Write(buffer, 0, byteResidui);
            }
            fileInput.Close();
            file.Close();
        }
        public void UnSplitFile(string p)//riunisce il file diviso
        {
            FileStream fileInput;
            byte[] buffer;
            FileStream filenuovo = new FileStream(p, FileMode.Create, FileAccess.Write);
            for (int i = 0; i < percorsi.Length; i++)
            {
                //leggo uno per uno tutto i file divisi, poi unoper uno li scrivo sul file nuovo 
                fileInput = new FileStream(percorsi[i], FileMode.Open, FileAccess.Read);
                buffer = new byte[(int)fileInput.Length];
                fileInput.Read(buffer, 0, (int)fileInput.Length);
                filenuovo.Write(buffer, 0, (int)fileInput.Length);
                fileInput.Close();
            }
            filenuovo.Close();
        }
    }
}
