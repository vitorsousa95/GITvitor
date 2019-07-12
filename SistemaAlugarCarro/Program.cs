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
           
            var opcaomenu = MenuPrincipal();

            while (opcaomenu != 3)
            {
                if (opcaomenu == 1)
                    MenuAlugarCarro();

                if (opcaomenu == 2)
                    MenuDevolverCarro();

                opcaomenu = MenuPrincipal();
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
            Console.WriteLine("\r\n3 - Sair do sistema");
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
        public static bool? PesquisaCarroParaAlugar(string nomeCarro)
        {
            for (int i = 0; i < baseDeCarros.GetLength(0); i++)
            {
                if (CompararNomes(nomeCarro, baseDeCarros[i, 0]))
                {
                    Console.WriteLine($"O Carro: {nomeCarro}" +
                          $" pode ser alugado?: {baseDeCarros[i, 2]}");

                    return baseDeCarros[i, 2] == "sim";
                }
            }

            Console.WriteLine("Nenhum carro encontrado. Deseja realizar a busca novamente ?");
            Console.WriteLine("Digite o número da opção desejada: Sim - 1     Não - 2");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            if (opcao == 1)
            {
                Console.WriteLine("Digite o nome do carro a ser pesquisado:");
                nomeCarro = Console.ReadLine();

                return PesquisaCarroParaAlugar(nomeCarro);
            }

            return null;
        }
        /// <summary>
        /// Metodo para alterar a informação de alugar um carro.
        /// </summary>
        /// <param name="nomeDeCarro">Nome do carro.</param>
        /// <param name="alugar">Parametro que diz se o carro pode ou não ser alugado.</param>
        public static void AtualizarCarro(string nomeCarro, bool alugar)
        {
            for (int i = 0; i < baseDeCarros.GetLength(0); i++)
            {
                if (CompararNomes(nomeCarro, baseDeCarros[i, 0]))
                {
                    baseDeCarros[i, 2] = alugar? "não" : "sim";
                }
            }

        }
        /// <summary>
        /// Metodo que mostra o menu de alugar carro.
        /// </summary>
        public static void MenuAlugarCarro()
        {
            MostrarMenuInicialCarros("MenuAlugarCarro um carro");

            var nomedoCarro = Console.ReadLine();
            var resultadoPesquisa = PesquisaCarroParaAlugar(nomedoCarro);

            if (resultadoPesquisa != null && resultadoPesquisa == true)
            {
                Console.Clear();
                BemVindo();
                Console.WriteLine("\n\nVocê deseja alugar esse carro? para sim - 1  para não - 2");

                AtualizarCarro(nomedoCarro, Console.ReadKey().KeyChar.ToString() == "1");

                MostarListaDeCarros();

                Console.ReadKey();
            }

            if (resultadoPesquisa == null)
            {
                Console.WriteLine("Nenhum livro encontrado em nossa base de dados do sistema.");

            }
        }
        /// <summary>
        /// mostra o menu de devolver o carro.
        /// </summary>
        public static void MenuDevolverCarro()
        {
            MostrarMenuInicialCarros("Devolver um carro");

            MostarListaDeCarros();

            var nomeCarro = Console.ReadLine();
            var resultadoPesquisa = PesquisaCarroParaAlugar(nomeCarro);

            if (resultadoPesquisa != null && resultadoPesquisa == false)
            {
                Console.Clear();
                BemVindo();
                Console.WriteLine("\n\nVocê deseja devolver esse carro? para sim - 1  para não - 2");

                AtualizarCarro(nomeCarro, Console.ReadKey().KeyChar.ToString() == "0");

                MostarListaDeCarros();

                Console.ReadKey();
            }

            if (resultadoPesquisa == null)
            {
                Console.WriteLine("Nenhum livro encontrado em nossa base de dados do sistema.");
            }


        }
        /// <summary>
        /// Mostra a lista de carros disponiveis ou não.
        /// </summary>
        public static void MostarListaDeCarros()
        {
            Console.WriteLine("Carros ainda disponiveis:");

            for (int i = 0; i < baseDeCarros.GetLength(0); i++)
            {
                Console.WriteLine($"\nNome: {baseDeCarros[i, 0]} Ano: {baseDeCarros[i, 1]} Disponivel: {baseDeCarros[i, 2]}");
            }

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
        /// <summary>
        /// Metodo que compara duas string deixando em caixa alta e removendo espaços vazios dentro da mesma.
        /// </summary>
        /// <param name="primeiro">Primeira string.</param>
        /// <param name="segundo">Segunda string.</param>
        /// <returns></returns>
        public static bool CompararNomes(string primeiro, string segundo)
        {
            if (primeiro.ToUpper().Replace(" ","") == segundo.ToUpper().Replace(" ",""))
                return true;

            return false;
        }

        
    }
}
