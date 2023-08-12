using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryAlloggioVilla
{
    public abstract class Edificio
    {
        int codice;
        double metriQuad;
        public Edificio(int codiceed, double metri)
        {
            codice = codiceed;
            metriQuad = metri;
        }
        //proprietà per accesso ai campi dalle derivate
        protected int Codice
        {
            get { return codice; }
        }
        protected double MetriQuadri
        {
            get { return metriQuad; }
        }
        //metodi virtuali, ogni classe derivata avrà l'override
        public virtual double CalcoloCostoAcqua()
        { return 0; }
        public virtual double Densità()
        { return 0; }
        public virtual double CalcoloCostoAlloggio()
        { return 0; }
        public override string ToString()
        {
            return "Codice:" + Codice+ ", Metri quadri:"+metriQuad;
        }
    }
    public class Magazzino:Edificio
    {
        static double costoMetriquad=1500;
        public Magazzino(int codice, double grandezza):base(codice,grandezza)
        { }
        public double Costomagazzino()//calcolo costo magazzino
        {
            return costoMetriquad * MetriQuadri;
        }
        public override string ToString()
        {
            return base.ToString()+ ", Costo Magazzino:"+Costomagazzino();//richiamo il to string della classe da cui deriva e aggiungo altre informazioni
        }
    }
    public class Alloggio:Edificio
    {
        int numPersone;
        static double Costoacqua = 15.5;//costante costo pro capite di acqua
        static double CostoMetroQuadro = 2000;//costante costo al metro quadro di casa
        public Alloggio(int codiceall, double metri, int persone) : base(codiceall, metri)
        {
            numPersone = persone;
        }
        //proprietà per accedere dalle derivate all?attributo
        protected int NumeroPersone
        {
            get { return numPersone; }
        }
        public override double Densità()
        {
            return MetriQuadri / numPersone;
        }
        public override double CalcoloCostoAcqua()
        {
            return Costoacqua * numPersone;
        }
        public override double CalcoloCostoAlloggio()
        {
            return CostoMetroQuadro * MetriQuadri;
        }
        public override string ToString()
        {
            //richiamo il to string della classe da cui deriva e aggiungo altre informazioni
            return base.ToString() + ", Costo Acqua:" + CalcoloCostoAcqua() + ", Densità:" + Densità()+ "Costo Alloggio:" + CalcoloCostoAlloggio() ;
        }
    }
    public class Villa : Alloggio
    {
        double metriQuadriGiardino;
        static double costoMetroGiardino = 700;//costante costo al metro quadro del giardino
        public Villa(int numeropersone, double metri, int codice, double GrandeGiardino) : base(codice, metri,numeropersone)
        { metriQuadriGiardino = GrandeGiardino; }
        public override double CalcoloCostoAlloggio()
        {
            return base.CalcoloCostoAlloggio() + CostoGiardino();
        }
        private double CostoGiardino()
        {
            return metriQuadriGiardino * costoMetroGiardino;
        }
        public override double Densità()
        {
            return base.Densità() + (metriQuadriGiardino / NumeroPersone);
        }
        public override string ToString()
        {
            //richiamo il to string della classe da cui deriva e aggiungo altre informazioni
            return base.ToString() + ", Costo Giardino:" + CostoGiardino()+ ", Costo totale alloggio:"+CalcoloCostoAlloggio();
        }
    }
}
