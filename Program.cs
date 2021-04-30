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
            Retangulo ret1 = new Retangulo(2.0, 7.8);

            Console.WriteLine();
            Console.WriteLine(ret1.Imprimir());
           

            Console.WriteLine();
            ret1.Altura = 27.9;
            ret1.Largura = 2.4;

            Console.WriteLine();
            Console.WriteLine(ret1.Imprimir());

            Console.WriteLine();
            ret1.Altura = -87.8;
            ret1.Largura = 29.4;

            Console.WriteLine();
            Console.WriteLine(ret1.Imprimir());

            Console.WriteLine();
            ret1.Altura = 2.6;
            ret1.Largura = -22.5;

            Console.WriteLine();
            Console.WriteLine(ret1.Imprimir());

            Console.WriteLine();
            ret1.Altura = 12.3;
            ret1.Largura = 31.2;

            Console.WriteLine();
            Console.WriteLine(ret1.Imprimir());

            Console.WriteLine();
            ret1.Altura = 12.3;
            ret1.Largura = 31.2;

            Console.WriteLine();
            Console.WriteLine(ret1.Imprimir());

            Console.ReadKey();
        }
    }
}
