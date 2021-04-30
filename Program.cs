using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_e_encapsulamento_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Figura> listFig = new List<Figura>();

            Retangulo ret1 = new Retangulo(2.0, 7.0);
            listFig.Add(ret1);

            Retangulo ret2 = new Retangulo(50.6, 918.7);
            listFig.Add(ret2);

            Circulo circ1 = new Circulo(91.0);
            listFig.Add(circ1);

            Circulo circ2 = new Circulo(245);
            listFig.Add(circ2);

            foreach (var fig in listFig)
            {
                Console.WriteLine();
                Console.WriteLine("Área:\t\t{0}", fig.Area);
                Console.WriteLine("Perímetro:\t{0}", fig.Perimetro);
            }

            Console.ReadKey();
        }

    }
}
