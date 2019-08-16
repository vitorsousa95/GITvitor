using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeAlunos
{
    class Program
    {
        static string[,] baseDados;
        static void Main(string[] args)
        {
            CarregaBancoDeDados();

            MostaDados();

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que carrega o banco de dados.
        /// </summary>
        public static void CarregaBancoDeDados()
        {
            baseDados = new string[20, 3]
            {
                {"Alice Fonseca","20 anos","Mulher"},
                {"Américo Valverde","42 anos","Homem"},
                {"Anna Lage","62 anos","Mulher"},
                {"Carminda Pêssego","58 anos","Mulher"},
                {"Constantino Velásquez","12 anos","Homem"},
                {"Délio Maciel","42 anos","Homem"},
                {"Galindo Cortez","52 anos","Homem"},
                {"Guido Vaz","18 anos","Homem"},
                {"Ifigénia Uchoa","2 anos","Mulher"},
                {"Isabel Gusmão","45anos","Mulher"},
                {"Liliana Amarante","25 anos","Mulher"},
                {"Marilda Balsemão","26 anos","Mulher"},
                {"Marlene Morgado","47 anos","Mulher"},
                {"Reginaldo Hernández","32 anos","Homem"},
                {"Roberto Estrela","37 anos","Homem"},
                {"Rudi Tabajara","56 anos","Mulher"},
                {"Solange López","78 anos","Mulher"},
                {"Teresa Carrillo","22 anos","Mulher"},
                {"Valéria Damasceno","63 anos","Mulher"},
                {"Vicente Collaço","21 anos","Homem"},

            };
        }
        /// <summary>
        /// Metodo que mostra nome, idade e sexo das pessoas que estão cadastrados no banco de dados.
        /// </summary>
        public static void MostaDados()
        {
            for (int i = 0; i < baseDados.GetLength(0); i++)
            {
                var NomePessoa = baseDados[i, 0];
                var idadePessoa = baseDados[i, 1];
                var sexoPessoa = baseDados[i, 2];

                Console.WriteLine($"\n\nNome da Pessoa: {NomePessoa} " +
                    $"\r\nIdade da Pesoa: {idadePessoa}" +
                    $"\r\nSexo da Pessoa: {sexoPessoa}");
            }
        }
    }
}
