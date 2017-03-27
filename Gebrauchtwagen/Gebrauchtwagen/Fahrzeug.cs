using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gebrauchtwagen
{
    class Fahrzeug
    {
        public string fid { get; set; }
        public string marke { get; set; }
        public string model { get; set; }
        public string preis { get; set; }
        public string kilometerstand { get; set; }
        public string baujahr { get; set; }
        public string treibstoff { get; set; }
        public string getriebeart { get; set; }
        public string leistung { get; set; }
        public string beschreibung { get; set; }


        public override string ToString()
        {
            return $"Fahrzeug: {fid} {marke} {model} {preis} {kilometerstand} {baujahr} {treibstoff} {getriebeart} {leistung} {beschreibung}";
        }
    }
}
