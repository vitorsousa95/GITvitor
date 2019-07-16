using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] baseDeDados = new string[2, 5];
            int IBD = 0;
            var MI = PMenuInicial();

            while (true)
            {
                switch (MI)
                {
                    case "1": { PInserirDados(ref baseDeDados, ref IBD); } break;
                    case "2": { PRemoverLivro(ref baseDeDados); } break;
                    case "3": { PListarLivros(baseDeDados); } break;
                    case "4": { PListarLivros(baseDeDados, "true"); } break;
                    case "5": { return; }

                }

                MI = PMenuInicial();
            }

        }
        /// <summary>
        /// Metodo que carrega o menu inicial.
        /// </summary>
        /// <returns>Retorna a opção do menu que foi escolhida.</returns>
        public static string PMenuInicial()
        {
            Console.Clear();
            Console.WriteLine("Menu Inicial.");
            Console.WriteLine("1 - Inserir dados do livro:");
            Console.WriteLine("2 - Remover dados do livro:");
            Console.WriteLine("3 - Listar livros:");
            Console.WriteLine("4 - Listar livros removidos:");
            Console.WriteLine("5 - Sair:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\r\n        Digite o número da opção desejada e tecle ENTER:");
            Console.ForegroundColor = ConsoleColor.White;
            return Console.ReadLine();
        }
        /// <summary>
        /// Metodo que faz a inserção de registro no nosso banco de dados.
        /// </summary>
        /// <param name="baseDeDados">Nossa base de dados do sistema como ref para alterar para todos.</param>
        /// <param name="IB">Parametro como ref para criar um identificar unico para cada dado inserido no sistema.</param>
        public static void PInserirDados(ref string[,] baseDeDados, ref int IB)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------- Inserindo livro nos registros ------------");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\r\nInforme o nome do livro:");
            var livro = Console.ReadLine();
            Console.WriteLine("\r\nInforme o nome do autor(a):");
            var autor = Console.ReadLine();
            PAumentarTamanhoLista(ref baseDeDados);

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null)
                    continue;

                baseDeDados[i, 0] = (IB++).ToString();
                baseDeDados[i, 1] = livro;
                baseDeDados[i, 2] = autor;
                baseDeDados[i, 3] = "true";
                baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss");
                break;
            }
            Console.WriteLine("\r\nRegistro realizado com sucesso!");
            Console.WriteLine("\r\nPara voltar ao menu inicial precione qualquer tecla");
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que inseri mais capos na nossa base de dados para registro de livros.
        /// </summary>
        /// <param name="baseDeDados">Paramentro que retorna nossa base de dados.</param>
        public static void PAumentarTamanhoLista(ref string[,] baseDeDados)
        {
            var limiteDeLivros = true;

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] == null)
                    limiteDeLivros = false;
            }

            if (limiteDeLivros)
            {
                var copia = baseDeDados;

                baseDeDados = new string[baseDeDados.GetLength(0) + 5, 5]; 

                for (int i = 0; i < copia.GetLength(0); i++)
                {
                    baseDeDados[i, 0] = copia [i, 0];
                    baseDeDados[i, 1] = copia [i, 1];
                    baseDeDados[i, 2] = copia [i, 2];
                    baseDeDados[i, 3] = copia [i, 3];
                    baseDeDados[i, 4] = copia [i, 4];
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\r\nForam inserido mais campos para registros!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        /// <summary>
        /// Metodo que faz a remoção de registros no nosso banco de dados.
        /// </summary>
        /// <param name="baseDeDados">Usamos nossa base de dados como ref para alterar os dados ja existentes.</param>
        public static void PRemoverLivro(ref string[,] baseDeDados)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------- Removendo livro nos registros ------------");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if(baseDeDados[i,3] != "false")
                    Console.WriteLine($"\r\nID:{baseDeDados[i, 0]}" +
                        $" || Nome do livro{baseDeDados[i, 1]}" +
                        $" || Nome do autor:{baseDeDados[i, 2]}" +
                        $" || Data de alteração{baseDeDados[i, 4]}");
            }
            Console.WriteLine("\r\nDigite o id do registro a ser removido:");
            var id = Console.ReadLine();

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null && baseDeDados[i, 0] == id)
                    baseDeDados[i, 3] = "false";
                baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss");
            }
            Console.WriteLine("\r\nRemoção realizado com sucesso!");
            Console.WriteLine("\r\nPara voltar ao menu inicial precione qualquer tecla");
            Console.ReadKey();

        }
        /// <summary>
        /// Metodo que mostra a lista de livros cadastrados ou removidos
        /// </summary>
        /// <param name="baseDeDados">Base de dados do sistema para servir de leitura e mostrar a lista de livros ao usuario</param>
        /// <param name="listarRegistosNAtivos">Parametro que define e mostra se o livro foi removido</param>
        public static void PListarLivros(string[,] baseDeDados, string listarRegistosNAtivos = "false")
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------------ Lista de livros ------------");
            

            if (listarRegistosNAtivos == "true")
            Console.WriteLine("------------ Lista de livros removidos ------------");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 3] != listarRegistosNAtivos)
                    Console.WriteLine($"\r\nID: {baseDeDados[i, 0]}" +
                        $" || Nome do livro: {baseDeDados[i, 1]}" +
                        $" || Nome do autor: {baseDeDados[i, 2]}" +
                        $" || Data de alteração: {baseDeDados[i, 4]}");
            }
            Console.WriteLine("\r\nListagem realizado com sucesso!");
            Console.WriteLine("\r\nPara voltar ao menu inicial precione qualquer tecla");
            Console.ReadKey();           
        }

    }
}
