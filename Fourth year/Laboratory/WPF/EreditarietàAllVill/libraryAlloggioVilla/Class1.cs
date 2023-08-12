using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryAlloggioVilla
{
    public class Alloggio
    {
        int numPersone;
        int codice;
        double metriQuad;
        static double CostoAcqua=15.5;
        static double CostoMetroQuadro = 2000;
        public Alloggio(int codiceall, double metri, int persone)
        {
            codice = codiceall;
            metriQuad = metri;
            numPersone = persone;
        }
        //public int Codice
        //{
        //    get { return codice; }
        //}
        public int NumeroPersone
        {
            get { return numPersone; }
        }
        public double MetriQuadri
        {
            get { return metriQuad; }
        }
        public double Densità()
        {
            return metriQuad / numPersone;
        }
        public double CalcoloCostoAcqua()
        {
            return CostoAcqua * numPersone;
        }
        public double CalcoloCostoAlloggio()
        {
            return CostoMetroQuadro * metriQuad;
        }
    }
    public class Villa : Alloggio
    {
        double metriQuadriGiardino;
        const double costoMetroGiardino = 700;
        public Villa(int numeropersone, double metri, int codice, double GrandeGiardino) : base(codice, metri,numeropersone)
        { metriQuadriGiardino = GrandeGiardino; }
        new public double CalcoloCostoAlloggio()
        {
            return base.CalcoloCostoAlloggio() + (metriQuadriGiardino * costoMetroGiardino);
        }
        new public double Densità()
        {
            return (MetriQuadri + metriQuadriGiardino) / NumeroPersone;
        }
    }
}
