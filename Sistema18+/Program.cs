using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema18_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");

            var nomePessoa = Console.ReadLine();

            Console.WriteLine("Digite sua idade");

            int.TryParse(Console.ReadLine().ToString(), out int opcao);

            if (opcao < 18)
            {
                Console.WriteLine("Você não pode consumir bebidas alcoólicas");
            }

            if (opcao >18)
            {
                Console.WriteLine("Você pode consumir bebidas alcoólicas");
            }


            Console.ReadKey();

            
        }

    }
}
