using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeBibliotecaOnline
{
    class Program
    {
        static string[,] baseDeLivros;

        static void Main(string[] args)
        {
            CarregaBaseDeDados();

            var opcaoMenu = MenuPrincipal();
            
            while (opcaoMenu != 3)
            {
                if (opcaoMenu == 1)
                    AlocarUmLivro();

                if (opcaoMenu == 2)
                    DesalocarUmLivro();

                opcaoMenu = MenuPrincipal();
            }

        }
        /// <summary>
        /// Cabeçario do sistema onde da as boas vindas ao usuario
        /// </summary>
        public static void MostrarSejaBemVindo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,");
            Console.WriteLine("|               Seja bem vindo a Biblioteca Online                   |");
            Console.WriteLine("                                                                      ");
            Console.WriteLine("|       A melhor biblioteca para usuarios de console RAIZ            |");
            Console.WriteLine("                                                                      ");
            Console.WriteLine("|       BIRLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL !!!      |");
            Console.WriteLine(" '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.ForegroundColor = ConsoleColor.White;

        }
        /// <summary>
        /// Metodo que mostra o menu inicial com as opções para escolha.
        /// </summary>
        /// <returns>Retorna o número do menu escolhido.</returns>
        public static int MenuPrincipal()
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine("Menu - Inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Alocar um livro.");
            Console.WriteLine("2 - Devolver um livro.");
            Console.WriteLine("3 - Sair do sistema.");
            Console.WriteLine("Digite o número desejado:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
        /// <summary>
        /// Metodo que carrega a base de dados dentro do sistema.
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            baseDeLivros = new string[2, 2]
            {
                {"O pequeno","sim"},
                {"O grande","não"}
            };
        }
        /// <summary>
        /// Metodo que retorna se um livro pode ser alocado.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser pesquisado</param>
        /// <returns>Retorna verdadeiro em caso o livro estiver livre para alocação.</returns>
        public static bool? PesquisaLivroParaAlocacao(string nomeLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (CompararNomes(nomeLivro, baseDeLivros[i, 1]))
                {
                    Console.WriteLine($"O livro:{nomeLivro}" +
                          $" pode ser alocado?:{baseDeLivros[i, 1]}");

                    return baseDeLivros[i, 1] == "sim";
                }
            }

            Console.WriteLine("Nenhum livro encontrado, deseja realizar uma nova busca?");
            Console.WriteLine("Digite o numero da opção desejada: Sim - 1    Não - 2  ");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            if (opcao == 1)
            {
                Console.WriteLine("Digite o nome do livro a ser pesquisado:");
                nomeLivro = Console.ReadLine();

                return PesquisaLivroParaAlocacao(nomeLivro);
            }


            return null;
        }
        /// <summary> 
        /// Metodo para alterar a informação de alocação do livro.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro</param>
        /// <param name="alocar">Valor booleano que define se o livro esta ou não disponivel.</param>
        public static void AlocarLivro(string nomeLivro, bool alocar)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (CompararNomes(nomeLivro, baseDeLivros[i, 0]))
                {
                    baseDeLivros[i, 1] = alocar ? "não" : "sim";
                }
            }

            Console.Clear();
            MostrarSejaBemVindo();
            Console.WriteLine("Livro atualizado com sucesso!");
        }
        /// <summary>
        /// Metodo que carrega o conteudo inicial da aplicação do menu 1
        /// </summary>
        public static void AlocarUmLivro()
        {
            MostrarMenuInicialLivros("Alocar um livro:");

            var nomedolivro = Console.ReadLine();
            var resultadoPesquisa = PesquisaLivroParaAlocacao(nomedolivro);

            if (resultadoPesquisa != null && resultadoPesquisa == true)
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja alocar o livro? para sim(1) para não(0)");

                AlocarLivro(nomedolivro, Console.ReadKey().KeyChar.ToString() == "1");

                MostrarListaDeLivros();

                Console.ReadKey();
            }
        }
        /// <summary>
        /// Metodo que mostra a lista de livros atualizado
        /// </summary>
        public static void MostrarListaDeLivros()
        {
            Console.WriteLine("Listagem de livros:");

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {baseDeLivros[i, 0]} Disponivel:{baseDeLivros[i, 1]}");
            }
        }
        /// <summary>
        /// Metodo para desalocar um livro.
        /// </summary>
        public static void DesalocarUmLivro()
        {
            MostrarMenuInicialLivros("Desalocar um livro:");

            MostrarListaDeLivros();

            var nomedolivro = Console.ReadLine();
            var resultadoDePesquisa = PesquisaLivroParaAlocacao(nomedolivro);

            if (resultadoDePesquisa != null && resultadoDePesquisa == false)
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja desalocar o livro? para sim(1) para não(0)");

                AlocarLivro(nomedolivro, Console.ReadKey().KeyChar.ToString() == "0");

                MostrarListaDeLivros();

                Console.ReadKey();
            }

            if (resultadoDePesquisa == null)
            {
                Console.WriteLine("Nenhum livro encontrado em nossa base de dados do sistema.");
            }
        }
        /// <summary>
        /// Metodo que mostra onome do menu de acordo com a operação.
        /// </summary>
        /// <param name="operacao">Nome do menu a ser acessado.</param>
        public static void MostrarMenuInicialLivros(string operacao)
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine($"Menu - {operacao}");
            Console.WriteLine("Digite o nome do livro para realizar a operação:");
        }
        /// <summary>
        /// Metodo que compara duas string deixando em caixa baixa e removendo espaços vazios dentro da mesma.
        /// </summary>
        /// <param name="primeiro">Primeira string a ser comparada.</param>
        /// <param name="segundo">Segunda string a ser comparada.</param>
        /// <returns></returns>
        public static bool CompararNomes(string primeiro, string segundo)
        {
            if (primeiro.ToLower().Replace(" ", "")
                == segundo.ToLower().Replace(" ", ""))
                return true;

                return false;
        }

    }
}
    
