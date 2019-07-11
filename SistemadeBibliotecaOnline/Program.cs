﻿using System;
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

            MostrarSejaBemVindo();

            if (MenuInicial() == 1)
                MostrarMenuAlocacao();

            Console.ReadKey();

        }
        /// <summary>
        /// Cabeçario do sistema onde da as boas vindas ao usuario
        /// </summary>
        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine(" ,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,");
            Console.WriteLine("|               Seja bem vindo a Biblioteca Online                   |");
            Console.WriteLine("                                                                      ");
            Console.WriteLine("|       A melhor biblioteca para usuarios de console RAIZ            |");
            Console.WriteLine("                                                                      ");
            Console.WriteLine("|       BIRLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL !!!      |");
            Console.WriteLine(" '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''");

        }
        /// <summary>
        /// Metodo que mostra o conteudo do menu e as opções de escolha.
        /// </summary>
        /// <returns>Retorna o valor do menu escolhido em um tipo inteiro.</returns>
        public static int MenuInicial()
        {
            Console.WriteLine("O que você dejesa fazer?");
            Console.WriteLine("1 - Alocar um livro.");
            Console.WriteLine("2 - Sair do sistema.");
            Console.WriteLine("Digite o número desejado:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opção);

            return opção;
        }
        /// <summary>
        /// Metodo que carrega a base de daodos dentro do sistema.
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            baseDeLivros = new string[2, 2]
            {
                {"O pequeno","sim"},
                { "O grande","não"}
            };
        }
        /// <summary>
        /// Metodo que retorno se um livro pode ser alocado.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser pesquisado.</param>
        /// <returns>Retorna verdadeiro caso o livro estiver disponivel para alocação.</returns>
        public static bool PesquisaLivroParaAlocação(string nomeLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomeLivro == baseDeLivros[i, 0])
                {
                    Console.WriteLine($"O livro: {nomeLivro}" +
                          $" pode ser alocado?: {baseDeLivros[i, 1]}");

                    return baseDeLivros[i, 1] == "sim";
                }
            }
            return false;
        }
        /// <summary>
        /// Metodo que aloca o livre de acordo com o parametro passado.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser alocado.</param>
        public static void AlocarLivro(string nomeLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomeLivro == baseDeLivros[i, 0])
                    baseDeLivros[i, 1] = "não";
            }
        }
        /// <summary>
        /// Metodo que carrega o menu incial 1.
        /// </summary>
        public static void MostrarMenuAlocacao()
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine("Menu - Alocação de livro:");
            Console.WriteLine("Digite o nome do livro a ser alocado:");

            var nomedolivro = Console.ReadLine();
            if (PesquisaLivroParaAlocação(nomedolivro))
            {
                Console.WriteLine("Você deseja alocar o livro? para sim (1)  para não(2)");
                if (Console.ReadKey().KeyChar.ToString() == "1")
                {
                    AlocarLivro(nomedolivro);
                    Console.WriteLine("\n\nLivro alocado!");
                }
                else
                    Console.Clear();

                Console.WriteLine("Listagem de livros:");

                for (int i = 0; i < baseDeLivros.GetLength(0); i++)
                {
                    Console.WriteLine($"Nome: {baseDeLivros[i, 0]}  Disponivel: {baseDeLivros[i, 1]}");
                }
            }
        }
    }
}
    
