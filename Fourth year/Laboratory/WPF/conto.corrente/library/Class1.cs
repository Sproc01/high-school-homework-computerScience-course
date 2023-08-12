using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public enum Tipo {versamento, prelievo}//enumeratore tipo movimento
    public class Banca
    {
        List<Conti> conti=new List<Conti>();
        List<Persona> clienti=new List<Persona>();
        public static int nconto = 000;//membro statico
        public void Addcliente(Persona p)
        {  clienti.Add(p);}
        public void Addconto(Conti c)
        { conti.Add(c); }
        public int ricerca(string n)
        {//ricerca tramite delegato
           return clienti.FindIndex(x  => x.Nome==n);//operatore di lambda
        }
        public Persona GetPersona(int pos)
        { return clienti[pos]; }
        public List<Persona> listclienti
        { get{ return clienti; } }
        public List<Conti> listconti
        { get { return conti; } }
        public Conti Getconto(int pos)
        { return conti[pos]; }
        public static string getnconto()//numero conto generato dalla banca
        {
            nconto++;
            return nconto.ToString("000");
        }
    }
    public class Persona
    {
        string nome;
        string telefono;
        public Persona(string n, string t)//costruttore
        {
            nome = n;
            telefono = t;
        }
        public string Nome
        { get { return nome; } }
        public override string ToString()//override per visualizzazione
        {
            return ($"Nome: {nome}, n° telefono: {telefono}");
        }
    }
    public class Movimento
    {
        DateTime data;
        double importo;
        Tipo t;
        public Movimento(DateTime d, double i, string tipo)//costruttore
        {
            data = d;
            importo = i;
            switch (tipo)
            {
                case "Versamento":
                    t = Tipo.versamento;
                    break;
                case "Prelievo":
                    t = Tipo.prelievo;
                    break;
            }
        }
        public double Importo
        { get { return importo; } }
        public Tipo Tipo
        {  get { return t; } }
        public override string ToString()//override per visualizzazione
        {
            string tipo="";
            switch (t)
            {
                case Tipo.versamento:
                    tipo = "versamento";
                    break;
                case Tipo.prelievo:
                    tipo = "Prelievo";
                    break;
            }
            return ($"Data:{data.ToShortDateString()}, importo:{importo} €, tipo: {tipo}");
        }
    }
    public class Conti
    {
        string nconto;
        Persona correntista;
        double saldo;
        List<Movimento> operazioni;
        public Conti(Persona p)//costruttore
        {
            operazioni = new List<Movimento>();
            saldo = 0;
            nconto = "ABC123" + Banca.getnconto();
            correntista = p;
        }
        public string Nconto
        { get { return nconto; }}
        public void addmovimento(Movimento m)
        {
            operazioni.Add(m);
            switch (m.Tipo)
            {
                case Tipo.versamento:
                    saldo += m.Importo;
                    break;
                case Tipo.prelievo:
                    saldo -= m.Importo;
                    break;
            }
        }
        public double Saldo
        { get { return saldo; } }
        public List<Movimento> Listmov
        { get { return operazioni; } }
    }
}
