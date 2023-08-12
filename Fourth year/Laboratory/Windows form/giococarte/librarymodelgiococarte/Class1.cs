using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymodelgiococarte
{
    public class Gioco
    {
        public enum tipocarta { cuori, quadri, fiori, picche }
        public enum stato { Vingiocatore, Vincomputer, parità }
        Carta carta1;
        Carta carta2;
        stato s;
        public void Comincia()
        {
            Random r = new Random();
            int i = r.Next(1, 5);
            int n = r.Next(1, 14);
            tipocarta t = tipocarta.picche;
            switch (i)
            {
                case 1:
                    t = tipocarta.cuori;
                    break;
                case 2:
                    t = tipocarta.quadri;
                    break;
                case 3:
                    t = tipocarta.fiori;
                    break;
                case 4:
                    t = tipocarta.picche;
                    break;
            }
            carta1 = new Carta(n, t);
            int t2 = r.Next(1, 5);
            int n2 = r.Next(1, 14);
            t = tipocarta.picche;
            switch (t2)
            {
                case 1:
                    t = tipocarta.cuori;
                    break;
                case 2:
                    t = tipocarta.quadri;
                    break;
                case 3:
                    t = tipocarta.fiori;
                    break;
                case 4:
                    t = tipocarta.picche;
                    break;
            }
            carta2 = new Carta(n2, t);
        }
        public void confronto()
        {
            if (carta1 > carta2)
                s = stato.Vingiocatore;
            else
                if (carta1 != carta2)
                s = stato.Vincomputer;
            else
                s = stato.parità;
        }
        public Carta CartaGiocatore
        {
            get { return carta1; }
        }
        public Carta CartaComputer
        {
            get { return carta2; }
        }
        public string Risultato
        {
            get
            {
                string ris = "";
                switch (s)
                {
                    case stato.Vingiocatore:
                        ris = "Ha vinto il giocatore";
                        break;
                    case stato.Vincomputer:
                        ris = "Ha vinto il Computer";
                        break;
                    case stato.parità:
                        ris = "Stato di parità";
                        break;
                }
                return ris;
            }
        }
        public class Carta
        {
            tipocarta seme;
            int numero;
            string img;
            public Carta(int n, tipocarta t)
            {
                numero = n;
                seme = t;
                img = Environment.CurrentDirectory + "\\img\\" + this.ToString()+".png";
            }
            public string Percorsoimg
            {
                get { return img; }
            }
            public static bool operator >(Carta c1, Carta c2)
            {
                bool ris = false;
                if (c1.seme != c2.seme)
                {
                    switch (c1.seme)
                    {
                        case tipocarta.cuori:
                            ris = true;
                            break;
                        case tipocarta.quadri:
                            switch (c2.seme)
                            {
                                case tipocarta.cuori:
                                    ris = false;
                                    break;
                                case tipocarta.fiori:
                                    ris = true;
                                    break;
                                case tipocarta.picche:
                                    ris = true;
                                    break;
                            }
                            break;
                        case tipocarta.fiori:
                            switch (c2.seme)
                            {
                                case tipocarta.cuori:
                                    ris = false;
                                    break;
                                case tipocarta.quadri:
                                    ris = false;
                                    break;
                                case tipocarta.picche:
                                    ris = true;
                                    break;
                            }
                            break;
                        case tipocarta.picche:
                            ris = false;
                            break;
                    }
                }
                else
                    ris = c1.numero > c2.numero;
                return ris;
            }
            public static bool operator <(Carta c1, Carta c2)
            {
                return !(c1 > c2);
            }
            public static bool operator ==(Carta c1, Carta c2)
            {
                bool r = true;
                if (ReferenceEquals(c1, null))
                    r = false;
                else
                    if (ReferenceEquals(c2, null))
                    r = false;
                else
                    r = c1.numero == c2.numero && c1.seme == c2.seme;
                return r;
            }
            public static bool operator !=(Carta c1, Carta c2)
            {
                return !(c1 == c2);
            }
            public override string ToString()
            {
                string s = "";
                switch (seme)
                {
                    case tipocarta.cuori:
                        s = "Cuori";
                        break;
                    case tipocarta.quadri:
                        s = "Quadri";
                        break;
                    case tipocarta.fiori:
                        s = "Fiori";
                        break;
                    case tipocarta.picche:
                        s = "Picche";
                        break;
                }
                return numero + "^%" + s;
            }
            public override int GetHashCode()
            {
                return numero.GetHashCode() ^ seme.GetHashCode();
            }
            public override bool Equals(object obj)
            {
                return this == (Carta)obj;
            }
        }
    }
}
