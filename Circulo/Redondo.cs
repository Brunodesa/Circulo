using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulo
{
    class Redondo
    {
        private double _r;
        public string Raio { set => _r = Convert.ToDouble(value); }
        public string Area => (Math.PI *(_r * _r)).ToString();
        public string Perimetro => ((2 * Math.PI) * _r).ToString();
        public string Diametro => (_r * 2).ToString();
    }
}
