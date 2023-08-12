using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RubricaModale
{
    public struct Persona
    {
        public string nome;
        public string cognome;
        public Statocivile stato;
        public Sesso Sesso;
        public PictureBox img;
    }
    public enum Sesso
    {
        Maschio,
        Femmina,      
    }
    public enum Statocivile
    {
        Celibe,
        Nubile,
        Coniugato,
        Coniugata,
        Divorziata,
        Divorziato,
    }
}
