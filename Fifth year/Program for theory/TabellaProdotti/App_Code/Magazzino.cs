using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

public struct Prodotto
{
    private string nome;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    private string descrizione;

    public string Descrizione
    {
        get { return descrizione; }
        set { descrizione = value; }
    }
    private double prezzo;

    public double Prezzo
    {
        get { return prezzo; }
        set { prezzo = value; }
    }
}

public struct Ordinato
{
    private string codice;

    public string Codice
    {
        get { return codice; }
        set { codice = value; }
    }
    private int qta;

    public int Quantià
    {
        get { return qta; }
        set { qta = value; }
    }
}
public class Magazzino : IEnumerable
{
    public List<Prodotto> mag;
	public Magazzino()
	{
        mag = new List<Prodotto>(){
            new Prodotto(){Nome="sedia", Descrizione="sedia in pelle",Prezzo=50.0},
            new Prodotto(){Nome="tavolo", Descrizione="tavolo per sei",Prezzo=150.0},
            new Prodotto(){Nome="poltrona", Descrizione="poltrona in pelle",Prezzo=500.0},
        };
	}

    public IEnumerator GetEnumerator()
    {
        foreach (Prodotto p in mag)
            yield return p;
    }

    public void Cancella(string nome)
    {
        for (int i = 0; i < mag.Count; i++)
            if (mag[i].Nome == nome)
            {
                mag.RemoveAt(i);
                break;
            }
    }

    public void Add(string nome, string descrizione, string prezzo)
    {
        mag.Add(new Prodotto() { Nome = nome, Descrizione = descrizione, Prezzo = Convert.ToDouble(prezzo) });
    }

    public void Modifica(string nome, string descrizione, string prezzo)
    {
        for (int i = 0; i < mag.Count; i++)
            if (mag[i].Nome == nome)
            {
                Prodotto prod = new Prodotto() { Nome = nome, Descrizione = descrizione, Prezzo = Convert.ToDouble(prezzo) };
                mag[i] = prod;
                //Prodotto prod = mag[i];
                //prod.Descrizione = descrizione;
                //prod.Prezzo = Convert.ToDouble(prezzo);
                break;
            }
    }
}