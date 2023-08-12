using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Edificio
    {
        protected double MqEdificio { get; private set; }
        protected int CodiceEdificio { get; private set; }

        public Edificio(int codice, double mqEdificio)
        {
            CodiceEdificio = codice;
            MqEdificio = mqEdificio;
        }
        /*public virtual string Valore(double costoMq)
        {
            return (costoMq * MqEdificio).ToString();
        }*/
        public abstract string Valore(double mq);
        new public virtual string ToString()
        {
            return $"Tipo: {GetType().Name}\tCodice: {CodiceEdificio.ToString()}\tMq Edificio: {MqEdificio.ToString()}";            
        }
    }
    public class Capannone : Edificio
    {
        protected int NumMacchinari { get; private set; }
        static double valoreLuce = 22.5;

        public Capannone(int codice, double mqCapannone, int numMacchinari) : base(codice, mqCapannone)
        {
            NumMacchinari = numMacchinari;
        }

        public string CostoLuce()
        {
            return (valoreLuce * NumMacchinari).ToString();
        }
        public override string Valore(double costoMq)
        {
            return (costoMq * MqEdificio).ToString();
        }
        public override string ToString()
        {
            return base.ToString() + Valore(2000) + CostoLuce();
        }
    }
    public class Alloggio : Edificio
    {
        protected int NumPersone { get; private set; }
        static double valoreAcqua = 15.5;
        public Alloggio(int codice, int numPersone, double mqAlloggio) : base(codice, mqAlloggio)
        {
            NumPersone = numPersone;
        }
        public double CostoAcqua()
        {
            return valoreAcqua * NumPersone;
        }
        public override string Valore(double costomQuadro)
        {
            return (costomQuadro * MqEdificio).ToString();
        }
        public virtual double Densità()
        {
            return MqEdificio / NumPersone;
        }
        public override string ToString()
        {
            return base.ToString() + Valore(2000) + CostoAcqua();
        }
    }
    public class Villa : Alloggio
    {
        public double MqGiardino { get; private set; }

        public Villa(int codice, int numPersone, double mqAlloggio, double mqGiardino) : base(codice, numPersone, mqAlloggio)
        {
            MqGiardino = mqGiardino;
        }

        public string ValoreVilla(double costomQuadroGiardino, double costomQuadroAlloggio)
        {
            return Valore(costomQuadroGiardino) + Valore(costomQuadroAlloggio);
        }
        public override string Valore(double costomQuadroAlloggio)
        {
            return (MqGiardino * costomQuadroAlloggio).ToString();
        }
        public double DensitàAlloggio()
        {
            return base.Densità();
        }
        public override double Densità()
        {
            return (MqEdificio + MqGiardino) / NumPersone;
        }
        public override string ToString()
        {
            return base.ToString() +ValoreVilla(2000,150) +  CostoAcqua()  ;
        }
    }
    public class Farmacia : Edificio
    {
        public int NumFarmacisti { get; private set; }
        public Farmacia(int codice, double mq, int numFarmacisti) : base (codice, mq)
        {
            NumFarmacisti = numFarmacisti;
        }
        public override string Valore(double costomQuadro)
        {
            return (costomQuadro * MqEdificio).ToString();
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }//Fine classe Farmacia
}
