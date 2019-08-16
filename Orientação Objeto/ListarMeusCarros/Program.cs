using ListarMeusCarros.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListarMeusCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carro> carroAdicionar = new List<Carro>();

            var opcaoMenu = MenuInicial();

            while (opcaoMenu !=3)
            {
                if (opcaoMenu == 1)
                {
                    Console.Clear();
                    carroAdicionar.Add(new Carro()
                    {
                        Nome = RetornaOpcao("Nome:"),
                        Ano = int.Parse(RetornaOpcao("Ano:")),
                        Placa = RetornaOpcao("Placa:"),
                        Cavalos = int.Parse(RetornaOpcao("Cavalos:"))
                    }); ;
                }

                if (opcaoMenu == 2)
                {
                    Console.Clear();
                    foreach (Carro item in carroAdicionar)
                        Console.WriteLine($"Nome:{item.Nome} - " +
                            $"Ano:{item.Ano} - " +
                            $"Placa:{item.Placa} - " +
                            $"Cavalos:{item.Cavalos}");
                }

                opcaoMenu = MenuInicial();
            }

             Console.ReadKey();
        }
        public static string RetornaOpcao(string opcao)
        {
            Console.WriteLine($"Informe o campo {opcao}");
            return Console.ReadLine();
        }

        public static int MenuInicial()
        {
            Console.Clear();
            Console.WriteLine("----------Bem vindo a garagem do Joca----------");
            Console.WriteLine("\r\nO que deseja fazer?");
            Console.WriteLine("1 - Cadastrar carro:");
            Console.WriteLine("2 - Ver carros cadastrados:");
            Console.WriteLine("3 - Sair do sistema:");
            Console.WriteLine("\r\n--------------Digite a opção desejada--------------");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
    }
}
