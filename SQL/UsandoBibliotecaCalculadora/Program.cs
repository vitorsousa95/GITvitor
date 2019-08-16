using BibliotecaCalculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoBibliotecaCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            var calcular = new Calculadora();
            Console.WriteLine("Soma");
            Console.WriteLine(calcular.Soma(10, 10));
            Console.WriteLine("Subtrai");
            Console.WriteLine(calcular.Subtrai(10, 10));
            Console.WriteLine("Divide");
            Console.WriteLine(calcular.Divide(10, 10));
            Console.WriteLine("Multiplica");
            Console.WriteLine(calcular.Multiplica(10, 10));
            Console.ReadKey();
        }
    }
}
