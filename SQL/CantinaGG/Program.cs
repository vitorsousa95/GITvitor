using CantinaGG.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaGG
{
    class Program
    {
        static void Main(string[] args)
        {
            Compra sourico = new Compra();
            

            Console.WriteLine("Qual lanche deseja comprar hoje Zezinho?");
            Console.WriteLine("1 - Doguinho");
            Console.WriteLine("2 - X-Salada");
            Console.WriteLine("Digite o numero do lanche que ");
            int.TryParse(Console.ReadLine(), out int opcao);

            if (opcao == 1)
            {
                Console.WriteLine("Compra realizada com sucesso!");
                sourico.CompraLanche(double.Parse(sourico.listaLanches[0, 1].ToString()));
                Console.WriteLine($"Seu novo saldo é:R${sourico.Saldo.ToString("N2")}");
            }
            if (opcao == 2)
            {
                Console.WriteLine("Compra realizada com sucesso!");
                sourico.CompraLanche(double.Parse(sourico.listaLanches[1, 1].ToString()));
                Console.WriteLine($"Seu novo saldo é:R${sourico.Saldo.ToString("N2")}");
            }
            if (opcao != 1 && opcao != 2)
            {
                Console.WriteLine("Infelismente você escolheu a opção errada!");
            }

            Console.ReadKey();
            
        }
        
    }
}
