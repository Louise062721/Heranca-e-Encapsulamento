using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_e_encapsulamento_1
{
    public class Figura
    {
        protected double _area; 
        protected double _perimetro; 

        public double Area 
        {
            get { return this._area; }
        }

        public double Perimetro 
        {
            get { return this._perimetro; }
        }
    }
}
