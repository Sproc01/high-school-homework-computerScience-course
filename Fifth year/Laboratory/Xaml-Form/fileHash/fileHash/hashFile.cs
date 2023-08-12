using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileHash
{
    /// <summary>
    /// struttura persona
    /// </summary>
    struct Persona
    {
        public string nome; //dim:20+1
        public string cognome; //dim:20+1
        public string nTelefono; //dim:10+1
        public double credito; //dim:8 byte
        public override string ToString()
        {
            return string.Format("{0,-20}|{1,-20}|{2,-10}|" + credito,nome, cognome,nTelefono);
        }
    }
    /// <summary>
    /// Classe che gestisce un file hash di persone
    /// </summary>
    class HashFile
    {
        int dimPrimaria;
        int dimOverflow;
        const int dimTestata = 8;
        const int dimRecord = 62;//61(dati)+1 flag controllo
        const int posNome = 0;
        const int posCognome = 21;
        const int posTelefono = 42;
        const int posCredito = 53;
        const int posFlag = 61;
        FileStream fs;
        string fileName;
        /// <summary>
        /// dimensione completa file, somma dimensione primaria e quella dell'overflow
        /// </summary>
        public int Dimfile
        {
            get { return (dimPrimaria + dimOverflow); }
        }
        /// <summary>
        /// Dimensione overflow file
        /// </summary>
        public int DimensioneOverflow
        {
            get { return dimOverflow; }
        }
        /// <summary>
        /// Calcola funzione hash di una persona
        /// </summary>
        /// <param name="p1">persona di cui calcolare l'hash</param>
        /// <returns>Ritorna posizione nel file della persona</returns>
        int FunzioneHash(Persona p1)//calcolo posizione tramite hash
        {
            int hashnome = Math.Abs(p1.nome.GetHashCode());
            int hashcognome = Math.Abs(p1.cognome.GetHashCode());
            int pos = (hashnome ^ hashcognome) % dimPrimaria;
            return pos;
        }
        /// <summary>
        /// Inizializza file hash oppure assegna i valori di classe in base al file selezionato
        /// </summary>
        /// <param name="nomefile">Percirso del file hash</param>
        /// <param name="dimP">Dimensione primaria</param>
        /// <param name="percOv">Percentuale dimensione overflow rispetto primaria</param>
        /// <param name="fm">FileMode per aprire il file</param>
        /// <param name="fa">FileAccess per aprire file</param>
        public HashFile(string nomefile, int dimP, double percOv, FileMode fm=FileMode.OpenOrCreate, FileAccess fa= FileAccess.ReadWrite)
        {
            fileName = nomefile;
            fs = new FileStream(fileName, fm, fa);
            BinaryReader br = new BinaryReader(fs, Encoding.UTF8,true);
            if(br.PeekChar()==-1)//file vuoto: inizializzo tutti i record a vuoto
            {
                dimPrimaria = dimP;
                dimOverflow = (int)(percOv * dimPrimaria);
                br.Close();
                BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8, true);
                bw.Write(dimPrimaria);
                bw.Write(dimOverflow);
                int posCorrente = dimTestata;
                for (int i = 0; i < dimPrimaria + dimOverflow; i++)
                {
                    posCorrente += dimRecord - 1;
                    bw.BaseStream.Seek(posCorrente, SeekOrigin.Begin);
                    bw.Write('L');
                    posCorrente++;
                }
                bw.Close();
            }
            else//file esistente: si leggono le dimensioni scritte su file
            {
                dimPrimaria = br.ReadInt32();
                dimOverflow = br.ReadInt32();
            }
            br.Close();
        }
        /// <summary>
        /// Inizializza nuovo file, eliminando il precedente
        /// </summary>
        public void Pulisci()
        {
            HashFile file2 = new HashFile("f2.hash", 10, 0.20);
            Close();
            file2.Close();
            File.Delete(fileName);
            File.Move("f2.hash", fileName);
            dimPrimaria = 10;
            dimOverflow = (int)(0.2 * 10);
            fs = new FileStream(fileName, FileMode.Open);                 
        }
        /// <summary>
        /// Legge persona data posizione
        /// </summary>
        /// <param name="pos">Posizione in cui leggere</param>
        /// <param name="p">Persona letta</param>
        /// <returns>Booleano se record è occupata o no</returns>
        public bool ReadPersona(int pos,out Persona p)
        {
            BinaryReader br = new BinaryReader(fs,Encoding.UTF8, true);
            p = new Persona();
            bool occupato;
            br.BaseStream.Seek(pos * dimRecord + dimTestata, SeekOrigin.Begin);
            p.nome = br.ReadString();
            br.BaseStream.Seek(dimTestata+21 + (dimRecord*pos), SeekOrigin.Begin);
            p.cognome = br.ReadString();
            br.BaseStream.Seek(dimTestata+42 + (dimRecord * pos), SeekOrigin.Begin);
            p.nTelefono = br.ReadString();
            br.BaseStream.Seek(dimTestata+53 + (dimRecord * pos), SeekOrigin.Begin);
            p.credito = br.ReadDouble();
            if (br.ReadChar() == 'O')
                occupato= true;
            else
                occupato= false;
            br.Close();
            return occupato;
        }
        /// <summary>
        /// Scrive la persona nella posizione
        /// </summary>
        /// <param name="p">Persona da scrivere</param>
        /// <param name="pos">Posizione in cui scrivere</param>
        private void WritePersona(Persona p,int pos)
        {
            BinaryWriter bw = new BinaryWriter(fs,Encoding.UTF8, true);
            bw.BaseStream.Seek(dimTestata+(dimRecord*(pos)), SeekOrigin.Begin);
            bw.Write(p.nome);
            bw.BaseStream.Seek(20-p.nome.Length, SeekOrigin.Current);
            bw.Write(p.cognome);
            bw.BaseStream.Seek(20- p.cognome.Length, SeekOrigin.Current);
            bw.Write(p.nTelefono);
            bw.BaseStream.Seek(10-p.nTelefono.Length, SeekOrigin.Current);
            bw.Write(p.credito);
            bw.Write('O');
            bw.Close();
        }
        /// <summary>
        /// Ricerca persona
        /// </summary>
        /// <param name="p">persona da cercare</param>
        /// <returns>ritorna posizione se persona presente oppure -1</returns>
        public int Ricerca(Persona p)
        {
            int posizione=-1;
            int pos = FunzioneHash(p);//se è nella parte primaria, la sua posizione è quella calcolata con l'hash
            BinaryReader br = new BinaryReader(fs,Encoding.UTF8, true);
            br.BaseStream.Seek(dimTestata + pos * dimRecord+dimRecord-1, SeekOrigin.Begin);
            if (br.ReadChar() == 'O')
            {
                br.BaseStream.Seek(dimTestata + pos * dimRecord, SeekOrigin.Begin);
                string n = br.ReadString();
                br.BaseStream.Seek(20 - p.nome.Length, SeekOrigin.Current);
                string c = br.ReadString();
                if (p.nome ==n && p.cognome==c)//confronto nome e cognome
                    posizione=pos;
                else//se non sono uguali, c'era stata collisione, controllo in zona overflow
                {                   
                    for (int i = 0; i < dimOverflow; i++)//lettura sequenziale
                    {
                        br.BaseStream.Seek(((dimPrimaria+i) * dimRecord) + dimTestata+dimRecord-1, SeekOrigin.Begin);
                        if (br.ReadChar() == 'O')
                        {
                            br.BaseStream.Seek(((dimPrimaria+i)*dimRecord)+dimTestata, SeekOrigin.Begin);
                            n = br.ReadString();
                            br.BaseStream.Seek(20 - p.nome.Length, SeekOrigin.Current);
                            c = br.ReadString();
                            if (p.nome == n && p.cognome == c)//confronto nome e cognome
                            {
                                posizione = i + dimPrimaria;
                                break;
                            }

                        }

                    }
                }
            }
            br.Close();
            return posizione;
        }
        /// <summary>
        /// aggiungi persona
        /// </summary>
        /// <param name="p"> 
        /// Persona da aggiungere
        /// </param>
        public void Aggiungi(Persona p)//inserimento di una persona
        {
            BinaryReader br = new BinaryReader(fs,Encoding.UTF8,true);
            int pos = Ricerca(p);
            if (pos == -1)
            {
                pos = FunzioneHash(p);
                int posizione = 8 + (pos * dimRecord) + dimRecord - 1;
                br.BaseStream.Seek(posizione, SeekOrigin.Begin);
                char c = (char)br.Read();
                if (c == 'L')//se posizione libera inserisco lì
                    WritePersona(p, pos);
                else
                {//inserisco nella prima posizione marcata ad 'L' nell'overflow
                    posizione = 8 + (dimPrimaria * dimRecord);
                    br.BaseStream.Seek(posizione, SeekOrigin.Begin);
                    for (int i = 0; i < dimOverflow; i++)
                    {
                        br.BaseStream.Seek(dimRecord - 1, SeekOrigin.Current);
                        if ((char)br.Read() == 'L')
                        {
                            WritePersona(p, dimPrimaria + i);
                            break;
                        }
                        if(i==dimOverflow-1)
                        {
                            Riorganizza();//se overflow pieno, riorganizzo file
                            Aggiungi(p);
                            break;
                        }
                        posizione++;
                    }
                }
            }
            else
                throw new Exception("Elemento già presente");
            br.Close();
        }
        /// <summary>
        /// riorganizzazione file
        /// </summary>
        private void Riorganizza()
        {
            //inizializzo nuova istanza classe
            HashFile file2 = new HashFile("f2.hash", dimPrimaria * 2, 0.20);
            Persona p;
            for (int i = 0; i < Dimfile; i++)
            {
                if(ReadPersona(i, out p))
                    file2.Aggiungi(p);//aggiungo tutte le persone presenti sul nuovo file
            }
            fs.Close();
            File.Delete(fileName);//cancello vecchio file
            file2.Close();//chiudo nuovo
            File.Move("f2.hash", fileName);//rinomino file nuovo
            //riassegno i valori della classe
            fs = new FileStream(fileName, FileMode.Open);
            dimPrimaria = dimPrimaria * 2;
            dimOverflow = (int)(0.20 * dimPrimaria);
        }
        private void Close()
        {
            fs.Close();
        }
        public void Cancella(string n, string c)
        {
            //cancellazione   
            Persona p;
            p.nome = n;
            p.cognome = c;
            p.credito = 0;
            p.nTelefono = "";
            int pos = Ricerca(p);
            if (pos != -1)
            {
                if(pos<dimPrimaria)
                {//se si cancella in area primaria bisogna controllare se ci siano elementi che avevano colliso con l'elemento cancellato
                    Persona p1;
                    for (int i = 0; i < dimOverflow; i++)
                    {
                        bool occupato=ReadPersona(i + dimPrimaria, out p1);//leggo record nell'overflow
                        BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8, true);
                        int pos1 = FunzioneHash(p1);//calcolo posizione che avrebbero avuto in primaria
                        if (pos1 == pos && occupato)//confronto posizione cnacellata con posizione del record in overflow
                        {//se sono uguali, e se il record è marcato come occupato allora scrivo elemento dell'overflow nella zona primaria
                            WritePersona(p1, pos1);
                            bw.BaseStream.Seek((i+dimPrimaria) * dimRecord + dimTestata + dimRecord - 1, SeekOrigin.Begin);
                            bw.Write('L');//marco a libero il record nell'overflow
                            bw.Close();
                            break;
                        }
                        else
                        {//marco a libero il record in zona primaria
                            bw.BaseStream.Seek(pos * dimRecord + dimTestata + dimRecord - 1, SeekOrigin.Begin);
                            bw.Write('L');
                            bw.Close();
                        }

                    }                   
                }
                else
                {//se non è primaria effettuo la cancellazione logica nell'overflow
                    BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8, true);
                    bw.BaseStream.Seek(pos * dimRecord + dimTestata+dimRecord-1, SeekOrigin.Begin);
                    bw.Write('L');
                    bw.Close();
                }
            }
            else
                throw new Exception("Elemento non presente");
        }
        public void Modifica(Persona p)
        {
            //si modifica solo credito
            int pos = Ricerca(p);
            if (pos != -1)
            {
                BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8, true);
                bw.BaseStream.Seek(pos * dimRecord + dimTestata + dimRecord - 9, SeekOrigin.Begin);
                bw.Write(p.credito);
                bw.Close();
            }
            else
                throw new Exception("Elemento non presente");
        }
    }
}
