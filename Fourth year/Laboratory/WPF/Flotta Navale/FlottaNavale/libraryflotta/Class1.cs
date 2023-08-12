using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace libraryflotta
{
    
    #region "Enumeratori"
    public enum statonav { cantiere, varata, demolita}//enumeratori stato nave
    public enum statocap { servizio, pensione, licenziato}//enumeratori stato comandante
    #endregion
    public class SerializzatoreBINARY
    {
        string nomeFile;
        object tipoDato;

        public SerializzatoreBINARY(string nome, object tDato)
        {
            nomeFile = nome;
            tipoDato = tDato;
        }
        public void Serializza()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(nomeFile, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, tipoDato);
            stream.Close();
        }

        public object DeSerializza()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(nomeFile, FileMode.Open, FileAccess.Read, FileShare.Read);
            tipoDato = formatter.Deserialize(stream);
            stream.Close();
            return tipoDato;
        }
    }

    [Serializable()]
    public class Posizione
    {
        public double longitudine { get; private set; }
        public double latitudine { get; private set; }
        public Posizione(double lon, double lat)
        {
            longitudine = lon;
            latitudine = lat;
        }

    }

    [Serializable()]
    public class Incarico
    {
        DateTime inizio;
        DateTime fine;
        Comandante comandante;
        Nave nave;
        List<Posizione> rotta;
        public Incarico(DateTime i, Nave n, Comandante c,List<Posizione> l)
        {
            inizio = i;
            fine = default(DateTime);
            nave = n;
            comandante = c;
            rotta = l;
        }
        public override string ToString()
        {
            string s = "in corso";
            if (fine != default(DateTime))
                s = fine.ToShortDateString();
            return "Inizio:" + inizio.ToShortDateString() + " // Fine:" + s + " // Nave:" + nave.Nome + " // Comandante:" + comandante.Nome;
        }
        //proprietà
        public Comandante Com
        { get { return comandante; } }
        public Nave Nav
        { get { return nave; } }
        public DateTime DataFine
        { get { return fine; } set { fine = value; }/*set per modifica incarico quando termina l'incarico*/ }
        public DateTime DataInizio
        { get { return inizio; } }
    }

    [Serializable()]
    public class Comandante
    {
        string nome;
        statocap stato;
        DateTime datanascita;
        string telefono;
        public Comandante(string n, string t, DateTime d, statocap cap)
        {
            nome = n;
            stato = cap;
            telefono = t;
            datanascita = d;
        }
        public override string ToString()
        {
            string s = "";
            return "Nome:" + nome + " // Numero di telefono:" + telefono + " // Data di nascita:" + datanascita.ToShortDateString() + " // Stato Capitano:" + stato + s;
        }
        //proprietà
        public string Nome
        {  get { return nome; }}
        public string Telefono
        { get { return telefono; } }
        public DateTime Datanascita
        { get { return datanascita; } }
        public statocap Stato
        { get { return stato; } }
    }

    [Serializable()]
    public class Nave
    {
        string nome;
        double stazza;
        double velocità;
        statonav stato;
        public Nave(string n, double s, double v, statonav nav)
        {
            nome = n;
            stato = nav;
            stazza = s;
            velocità = v;
        }
        public override string ToString()
        {
            string s = "";
            return "Nome:" + nome + " // Stazza:" + stazza + " // Velocità:" + velocità + " // Stato Nave:" + stato + s;
        }
        //proprietà
        public string Nome
        { get { return nome; }}
        public double Stazza
        { get { return stazza; } }
        public double Velocità
        { get { return velocità; } }
        public statonav Stato
        { get { return stato; } }
    }

    [Serializable()]
    public class Flotta:ISerializable
    {
        string nome;
        List<Comandante> comandanti;
        List<Nave> navi;
        List<Incarico> incarichi;
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Nome", nome, typeof(string));
            info.AddValue("Com", comandanti, typeof(List<Comandante>));
            info.AddValue("Nav", navi, typeof(List<Nave>));
            info.AddValue("Inc", incarichi, typeof(List<Incarico>));
        }
        public Flotta(SerializationInfo info, StreamingContext context)
        {
            nome = (string)info.GetValue("Nome", typeof(string));
            comandanti = (List<Comandante>)info.GetValue("Com", typeof(List<Comandante>));
            navi = (List<Nave>)info.GetValue("Nav", typeof(List<Nave>));
            incarichi= (List<Incarico>)info.GetValue("Inc", typeof(List<Incarico>));
        }
        public Flotta()
        {//inizializzazzione liste
            navi = new List<Nave>();
            comandanti = new List<Comandante>();
            incarichi = new List<Incarico>();
        }
        //metodi
        public int Ricercanav(string n)//ricerca nave per nome
        {
            return navi.FindIndex(x => x.Nome == n);
        }
        public int Ricercacom(string n)//ricerca comandante per nome
        {
            return comandanti.FindIndex(x => x.Nome == n);
        }
        public void removenav(Nave n)//rimozione nave
        {
            int i = Ricercanav(n.Nome);
            if (i != -1)
                navi.RemoveAt(i);
        }
        public void removecom(Comandante c)//rimozione comandante
        {
            int i = Ricercacom(c.Nome);
            if (i != -1)
                comandanti.RemoveAt(i);
        }
        public Comandante GetComandante(int i)//metodo per accedere ad un determinato comandante
        { return comandanti[i]; }
        public Nave GetNave(int i)//metodo per accedere ad un determinata nave
        { return navi[i];}
        public void Addnave(Nave n)//aggiunta nave
        { navi.Add(n);}
        public void Addcomandante(Comandante c)//aggiunta comandante
        { comandanti.Add(c); }
        public void Addincarico(Incarico i)//aggiunta incarico
        { incarichi.Add(i); }
        
        public bool controllonave(Nave n)//ritorna true se la nave non ha un incarico
        {
            bool ris;
            List<Incarico> list = incarichi.FindAll(x => x.DataFine == default(DateTime));
            int i = list.FindIndex(x => x.Nav.Nome == n.Nome);//ricerca se nave ha un incarico
            if (i != -1)
                ris = false;
            else
                ris = true;
            return ris;
        }
        public bool controllocom(Comandante n)//ritorna true se il comandante non ha un incarico
        {
            bool ris;
            List<Incarico> list = incarichi.FindAll(x => x.DataFine == default(DateTime));
            int i = list.FindIndex(x => x.Com.Nome == n.Nome);//ricerca se comandante ha un incarico
            if (i != -1)
                ris = false;
            else
                ris = true;
            return ris;
        }
        //proprietà
        public List<Nave> listnavi//proprietà per ritornare la lista delle navi
        { get { return navi; } }
        public List<Comandante> listcomandanti//proprietà per ritornare la lista di comandanti
        { get { return comandanti; } }
        public List<Incarico> listincarichi//proprietà per ritornare la lista di incarichi
        { get { return incarichi; } }
        public List<Nave> NaviLibere//proprietà per ritornare la lista delle navi libere a cui assegnare un incarico
        {
            get
            {
                int j;
                List<Nave> list = navi.FindAll(x => x.Stato == statonav.varata);//lista navi varate
                if (list.Count != 0)
                    for (int i = 0; i < incarichi.Count; i++)
                    {
                        if (incarichi[i].DataFine == default(DateTime))
                        {
                            j = list.FindIndex(x => x.Nome == incarichi[i].Nav.Nome);
                            if (j != -1)
                                list.RemoveAt(j);//rimozione navi che hanno incarico
                        }
                    }
                return list;
            }
        }
        public List<Comandante> ComandantiLiberi//proprietà per ritornare la lista di comandanti liberi a cui assegnare un incarico
        {
            get
            {
                int j;
                List<Comandante> list = comandanti.FindAll(x => x.Stato == statocap.servizio);//lista comandanti in servizio
                if (list.Count != 0)
                    for (int i = 0; i < incarichi.Count; i++)
                    {
                        if (incarichi[i].DataFine == default(DateTime))
                        {
                            j = list.FindIndex(x => x.Nome == incarichi[i].Com.Nome);
                            if (j != -1)
                                list.RemoveAt(j);//rimozione comandanti che hanno incarico
                        }
                    }
                return list;
            }
        }
        public string Nomeflotta//proprietà per nome flotta 
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}
