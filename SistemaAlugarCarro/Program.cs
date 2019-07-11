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
        static string[,] baseDeSeguros;
        static string[,] baseDeCarros;
        static void Main(string[] args)
        {
            CarregaBancoDeDados();
            CarregaDadosSeguros();

            var opcaomenu = MenuPrincipal();

            while (opcaomenu != 5)
            {
                if (opcaomenu == 1)
                    MenuAlugarCarro();

                if (opcaomenu == 2)
                    MenuDevolverCarro();

                if (opcaomenu == 3)
                    MenuSeguros();

                MenuPrincipal();
            }


        }
        /// <summary>
        /// Metodo que mostra o bem vindo ao sistema.
        /// </summary>
        public static void BemVindo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("            ,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,");
            Console.WriteLine("            |               Bem vindo a DiCars™                 |");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("            *****************************************************");
            Console.WriteLine("            |                Carros importados                  |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("            |                   Nacionais                       |");
            Console.WriteLine("            *****************************************************");
            Console.ForegroundColor = ConsoleColor.White;
        }
        /// <summary>
        /// Metodo que mostra as opções do menu inicial.
        /// </summary>
        /// <returns>Retorna a opção desejada do cliente.</returns>
        public static int MenuPrincipal()
        {
            Console.Clear();
            BemVindo();
            Console.WriteLine("Como podemos ajuda-lo?");
            Console.WriteLine("\r\n1 - Alugar carro");
            Console.WriteLine("\r\n2 - Devolver carro");
            Console.WriteLine("\r\n3 - Contratar seguro");
            Console.WriteLine("\r\n4 - Cancelar seguro");
            Console.WriteLine("\r\n5 - Sair do sistema");
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
        /// Metodo para alterar a informação de alugar um carro.
        /// </summary>
        /// <param name="nomeCarro">Nome do carro.</param>
        /// <param name="alugar">Parametro que diz se o carro pode ou não ser alugado.</param>
        public static void AtualizarCarro(string nomeCarro, bool alugar)
        {
            for (int i = 0; i < baseDeCarros.GetLength(0); i++)
            {
                if (nomeCarro == baseDeCarros[i, 0])
                {
                    baseDeCarros[i, 2] = alugar ? "não" : "sim";
                }
            }

        }
        /// <summary>
        /// Metodo que mostra o menu de alugar carro.
        /// </summary>
        public static void MenuAlugarCarro()
        {
            MostrarMenuInicialCarros("MenuAlugarCarro um carro");

            var nomeCarro = Console.ReadLine();
            if (PesquisaCarroParaAlugar(nomeCarro))
            {
                Console.Clear();
                BemVindo();
                Console.WriteLine("\n\nVocê deseja alugar esse carro? para sim - 1  para não - 2");

                AtualizarCarro(nomeCarro, Console.ReadKey().KeyChar.ToString() == "1");

                MostarListaDeCarros();

                Console.ReadKey();
            }
        }
        /// <summary>
        /// mostra o menu de devolver o carro.
        /// </summary>
        public static void MenuDevolverCarro()
        {
            MostrarMenuInicialCarros("Devolver um carro");
            var nomeCarro = Console.ReadLine();
            if (PesquisaCarroParaAlugar(nomeCarro))
            {
                Console.Clear();
                BemVindo();
                Console.WriteLine("\n\nVocê deseja alugar esse carro? para sim - 1  para não - 2");

                AtualizarCarro(nomeCarro, Console.ReadKey().KeyChar.ToString() == "0");

                MostarListaDeCarros();

                Console.ReadKey();
            }


        }
        /// <summary>
        /// Mostra a lista de carros disponiveis ou não.
        /// </summary>
        public static void MostarListaDeCarros()
        {
            Console.Clear();
            BemVindo();

            Console.WriteLine("Carros ainda disponiveis:");

            for (int i = 0; i < baseDeCarros.GetLength(0); i++)
            {
                Console.WriteLine($"\nNome: {baseDeCarros[i, 0]} Ano: {baseDeCarros[i, 1]} Disponivel: {baseDeCarros[i, 2]}");
            }
            Console.ReadKey();



        }
        /// <summary>
        /// metodo usado para mostrar o menu inicial para alugar ou devolver carros.
        /// </summary>
        /// <param name="operacao">Nome do menu a ser exibido.</param>
        public static void MostrarMenuInicialCarros(string operacao)
        {
            Console.Clear();

            BemVindo();

            Console.WriteLine($"Menu - {operacao}");
            Console.WriteLine("Digite o nome do carro para realizar a operação:");
        }

        public static void MenuSeguros()
        {
            MostrarMenuInicialCarros("Contratar Seguros");

            ListaDeSeguros();

            var nomeSeguro = Console.ReadLine();
            if (PesquisaCarroParaSeguro(nomeSeguro))
            {
                Console.Clear();
                BemVindo();
                Console.WriteLine("\n\nVocê deseja contratar esse seguro? para sim - 1  para não - 2");

                AtualizarSeguro(nomeSeguro, Console.ReadKey().KeyChar.ToString() == "1");

                Console.WriteLine("Seguro cadastrado com sucesso");

                Console.ReadKey();
            }

        }

        public static bool PesquisaCarroParaSeguro(string nomeSeguro)
        {
            for (int i = 0; i < baseDeSeguros.GetLength(0); i++)
            {
                if (nomeSeguro == baseDeSeguros[i, 0])
                {
                    Console.WriteLine($"O Seguro: {nomeSeguro}" +
                          $" pode ser contratado?: {baseDeSeguros[i, 1]}");

                    return baseDeSeguros[i, 1] == "sim";
                }
            }
            return false;
        }

        public static void CarregaDadosSeguros()
        {
            baseDeSeguros = new string[2, 2]
            {
                { "Seguro completo", "sim" },
                { "Seguro parcial", "sim" },

            };
        }

        public static void AtualizarSeguro(string nomeSeguro, bool alugar)
        {
            for (int i = 0; i < baseDeSeguros.GetLength(0); i++)
            {
                if (nomeSeguro == baseDeSeguros[i, 0])
                {
                    baseDeSeguros[i, 1] = alugar ? "não" : "sim";
                }
            }

        }

        public static void ListaDeSeguros()
        {

            Console.WriteLine("Seguro completo");
            Console.WriteLine("Seguro parcial");
            Console.WriteLine("Escreva a opção desejada:");

        }
    }
}
