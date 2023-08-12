using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangolo
{
    public enum TipoTriangolo { equilatero,isoscele,scaleno};
    public class Triangolo1
    {
        double Lato1;
        double Lato2;
        double Lato3;

        //double perimetro;
        //double area;
        TipoTriangolo tipoT;//per capire di che tipo è il triangolo
        public Triangolo1(double L1)
        {
            Lato1 = Lato2 = Lato3 = L1;
            tipoT = TipoTriangolo.equilatero;
        }
        public Triangolo1(double L1, double L2) : this(L1)
        {
            /*if (ControllaLati(L1, L2, L1))
            {
                Lato1 = Lato3 = L1;
                Lato2 = L2;
                tipoT = TipoTriangolo.isoscele;
            }
            else throw new Exception("Lati errati");*/
            if (ControllaLati(L1, L2, L1))
            {
                //Lato1 = Lato3 = L1;
                Lato2 = L2;
                tipoT = TipoTriangolo.isoscele;
            }
            else throw new Exception("Lati errati");
            //tipoT = TipoTriangolo.isoscele;
        }
        public Triangolo1(double L1, double L2, double L3)
        {
            if (ControllaLati(L1, L2, L3))
            {
                Lato1 = L1;
                Lato2 = L2;
                Lato3 = L3;
                tipoT = TipoTriangolo.scaleno;
            }
            else throw new Exception("Lati errati");
        }
        public double GetLato1()
        { return Lato1; }
        public double GetLato2()
        { return Lato2; }
        public double GetLato3()
        { return Lato3; }
        public void SetLato1(double l1)
        {
            if (ControllaLati(l1, Lato2, Lato3))
            {
                Lato1 = l1;
                RicalcolaTipo();//perchè devo guardare se la modifica del lato mi ha cambiato tipo di triangolo e ricaclolo area e perimetro
            }
            else throw new Exception("Lati errati");
        }
        public void SetLato2(double l2)
        {
            if (ControllaLati(Lato1, l2, Lato3))
            {
                Lato2 = l2;
                RicalcolaTipo();
            }
            else throw new Exception("Lati errati");
        }
        public void SetLato3(double l3)
        {
            if (ControllaLati(Lato1, Lato2, l3))
            {
                Lato3 = l3;
                RicalcolaTipo();
            }
            else throw new Exception("Lati errati");
        }
        public TipoTriangolo GetTipoTriangolo()
        {
            return tipoT;            
        }
        public double GetArea()
        {           
            return Math.Sqrt((GetPerimetro() / 2) * ((GetPerimetro() / 2) - Lato1) * ((GetPerimetro()) / 2 - Lato2) * ((GetPerimetro() / 2) - Lato3));
        }
        public double GetPerimetro()
        {
            return Lato1 + Lato2 + Lato3;
        }      
        public bool ControllaLati(double L1, double L2, double L3)
        {
            return (L1 < (L2 + L3) && L2 < (L3 + L1) && L3 < (L1 + L2));               
        }
        public void RicalcolaTipo()
        {
            if (Lato1 == Lato2 && Lato3 == Lato1)
                tipoT = TipoTriangolo.equilatero;
            else if (Lato1 == Lato2 || Lato1 == Lato3 || Lato2 == Lato3)
                tipoT = TipoTriangolo.isoscele;
            else tipoT = TipoTriangolo.scaleno;            
        }
    }
}
