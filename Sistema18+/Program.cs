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
            Console.WriteLine("Digite uma opção:");
            Console.WriteLine("(1) para menor de 18 \n(2) para maior de 18");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            if (opcao == 1)
            {
                Console.WriteLine("\n\nVocê não pode entrar,nem beber! Volte para sua casa.");
            }

            if (opcao == 2)
                {
                    Console.WriteLine("\n\nVocê pode entrar, chapar e ficar doidão (*_*)");
                }


            Console.ReadKey();
        }
    }
}
