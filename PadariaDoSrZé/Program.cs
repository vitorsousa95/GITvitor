using PadariaDoSrZé.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadariaDoSrZé
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MinhaPadaria> minhaPadaria = new List<MinhaPadaria>();

                for (int i = 0; i < 5; i++)
                {
                minhaPadaria.Add(new MinhaPadaria()
                {
                    Nome = RetornaValores("Nome:"),
                    Quantidade = int.Parse(RetornaValores("Quantidade:")),
                    Valor = double.Parse(RetornaValores("Valor:"))
                });

                }
            
              Console.WriteLine("Lista de produtos, quantidades e preços");

            foreach (MinhaPadaria item in minhaPadaria )
                Console.WriteLine($"\nNome do produto:{item.Nome} - " +
                    $"Quantidade:{item.Quantidade} - " +
                    $"Valor:{item.Valor}");

            Console.ReadKey();
        }
        public static string RetornaValores(string nome)
        {
            Console.WriteLine($"Informe o valor para o campo:{nome}");
            return Console.ReadLine();
        }
    }
}
