using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SistemaAlugarCarro
{
    class Program
    {
        static string[,] baseDeCarros;
        static void Main(string[] args)
        {
            CarregaBancoDeDados();

            BemVindo();

            var opcaomenu = MenuInicial();

            if (opcaomenu == 1)
            {
                MostrarMenuAlugarCarro();
            }

            if (opcaomenu == 3)
            {
                MostrarMenuSeguro();
            }
            Console.ReadKey();

        }
        /// <summary>
        /// Metodo que mostra o bem vindo ao sistema.
        /// </summary>
        public static void BemVindo()
        {
            Console.WriteLine("            ,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,");
            Console.WriteLine("            |               Bem vindo a GearCar                 |");
            Console.WriteLine("            *****************************************************");
        }
        /// <summary>
        /// Metodo que mostra as opções do menu inicial.
        /// </summary>
        /// <returns>Retorna a opção desejada do cliente.</returns>
        public static int MenuInicial()
        {
            Console.WriteLine("Como podemos ajuda-lo?");
            Console.WriteLine("\r\n1 - Alugar carro");
            Console.WriteLine("\r\n2 - Devolver carro");
            Console.WriteLine("\r\n3 - Seguro");
            Console.WriteLine("\r\nDigite a opção desejada:");
            Console.WriteLine("\r\n");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
        /// <summary>
        /// Metodo que carrega o banco de dados.
        /// </summary>
        public static void CarregaBancoDeDados()
        {
            baseDeCarros = new string[5, 3]
            {
                {"Ferrari","2011","sim",},
                {"Lamborguine", "2015", "sim"},
                {"Porsche", "2018", "nâo"},
                {"Golf", "2010","não"},
                {"Fiat147","1980","sim"},
            };
        }
        /// <summary>
        /// Metodo que retorna se o carro pode ser alugado.
        /// </summary>
        /// <param name="nomeCarro">Nome do carro a ser alugado.</param>
        /// <returns>Retorna verdadeiro caso o carro esteja disponivel para alugar.</returns>
        public static bool PesquisaCarroParaAlugar(string nomeCarro)
        {
            for (int i = 0; i < baseDeCarros.GetLength(0); i++)
            {
                if (nomeCarro == baseDeCarros[i, 0])
                {
                    Console.WriteLine($"O Carro: {nomeCarro}" +
                          $" pode ser alocado?: {baseDeCarros[i, 2]}");

                    return baseDeCarros[i, 2] == "sim";
                }
            }
            return false;
        }
        /// <summary>
        /// Metodo que aluga o carro de acordo com o parametro passado.
        /// </summary>
        /// <param name="nomeCarro">Nome do carro a ser alugado.</param>
        public static void AlocarCarro(string nomeCarro)
        {
            for (int i = 0; i < baseDeCarros.GetLength(0); i++)
            {
                if (nomeCarro == baseDeCarros[i, 0])
                    baseDeCarros[i, 2] = "não";
            }
        }
        /// <summary>
        /// Metodo que mostra o menu de alugar carro.
        /// </summary>
        public static void MostrarMenuAlugarCarro()
        {
            Console.Clear();

            BemVindo();

            Console.WriteLine("Menu - Alugar carro:");
            Console.WriteLine("Digite o nome do carro que dejesa alugar:");

            var nomeCarro = Console.ReadLine();
            if (PesquisaCarroParaAlugar(nomeCarro))
            {
                Console.WriteLine("\n\nVocê deseja alocar o esse carro? para sim - 1  para não - 2");
                if (Console.ReadKey().KeyChar.ToString() == "1")
                {
                    AlocarCarro(nomeCarro);
                    Console.WriteLine("\n\nCarro alugado com sucesso!");
                    Thread.Sleep(2000);
                }


                Console.Clear();

                BemVindo();

                Console.WriteLine("Carros ainda disponiveis:");

                for (int i = 0; i < baseDeCarros.GetLength(0); i++)
                {
                    Console.WriteLine($"\n Nome: {baseDeCarros[i, 0]} Ano: {baseDeCarros[i, 1]} Disponivel: {baseDeCarros[i, 2]}");
                }
            }
        }

        public static int MostrarMenuSeguro()
        {
            Console.Clear();

            BemVindo();

            Console.WriteLine("Menu - Seguro:");
            Console.WriteLine("Deseja adiquirir qual seguro?");
            Console.WriteLine("1 - Seguro completo");
            Console.WriteLine("2 - Seguro parcial");
            Console.WriteLine("\r\nDigite uma das opções:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;

        }
        
    }
}
