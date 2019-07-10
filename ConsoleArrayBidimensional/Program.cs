using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArrayBidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] ListaDeLivros = new string[2, 2]
                {{"O pequeno","sim" },{"O grande","não"} };

            for (int i = 0; i < ListaDeLivros.GetLength(0); i++)
            {
                var Nomelivro = ListaDeLivros[i,0];
                var disponivel = ListaDeLivros[i,1];

                Console.WriteLine($"Nome do livro: {Nomelivro}  Disponivel:{disponivel}.");
            }

            Console.ReadKey();

        }
    }
}
