using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_e_encapsulamento_1
{
    public class Circulo : Figura
    {
        private double _raio; 
        public double Raio 
        {
            get
            {
                return this._raio;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Raio inválido");
                }
                else
                {
                    this._raio = value;
                    this.AtualizarArea();
                    this.AtualizarPerimetro();
                }
            }
        }

        public Circulo(double raio)
        {
            this.Raio = raio;
        }

        private void AtualizarArea()
        {
            this._area = Math.PI * this._raio * this._raio;
        }

        private void AtualizarPerimetro()
        {
            this._perimetro = 2 * Math.PI * this._raio;
        }

        public String Imprimir()
        {
            String s = String.Format("Raio:\t\t{0}\n", this.Raio);
            s += String.Format("Área:\t\t{0}\n", this.Area);
            s += String.Format("Perímetro\t{0}\n", this.Perimetro);

            return s;
        }
        
    }
}
