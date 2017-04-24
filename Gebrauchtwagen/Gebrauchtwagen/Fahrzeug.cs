using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gebrauchtwagen
{
    class Fahrzeug
    {
        public int fid { get; set; }
        public string marke { get; set; }
        public string model { get; set; }
        public int preis { get; set; }
        public int kilometerstand { get; set; }
        public int baujahr { get; set; }
        public string treibstoff { get; set; }
        public string getriebeart { get; set; }
        public int leistung { get; set; }
        public string beschreibung { get; set; }


        public override string ToString()
        {
            return $"Fahrzeug: {fid} {marke} {model} {preis} {kilometerstand} {baujahr} {treibstoff} {getriebeart} {leistung} {beschreibung}";
        }
    }
}
