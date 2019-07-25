using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExecicioNotasEFrequencias.NotasEFrequencias;

namespace ExecicioNotasEFrequencias.Cadastro
{
    public class Cadastro
    {
        public string[,] bancoDeDados = new string[5, 6];
        int inicioBancoDeDados = 0;
        NotaEFrequencia nf = new NotaEFrequencia();

        /// <summary>
        /// Metodo que inserir os registro do boletim do aluno no banco de dados
        /// </summary>
        /// <param name="bancoDeDados">nosso banco de dados referenciado para alterar para todos</param>
        /// <param name="inicioBancoDeDados">Parametro como ref para criar um identificar unico para cada dado inserido no sistema</param>
        public void InserirBoletim()
        {
            Console.WriteLine("----------------Inserir boletim do aluno----------------");
            Console.WriteLine("\r\nInforme o nome do Aluno:");
            var aluno = Console.ReadLine();
            Console.WriteLine("\r\nInforme a primeira nota do aluno:");
            int.TryParse(Console.ReadLine(), out int nota1);
            Console.WriteLine("\r\nInforme a segunda nota do aluno:");
            int.TryParse(Console.ReadLine(), out int nota2);
            Console.WriteLine("\r\nInforme a terceira nota do aluno:");
            int.TryParse(Console.ReadLine(), out int nota3);
            Console.WriteLine("\r\nInforme o total de aulas:");
            int.TryParse(Console.ReadLine(), out int totalAulas);
            Console.WriteLine("\r\nInforme o total de faltas:");
            int.TryParse(Console.ReadLine(), out int numeroFaltas);


            var media = (nota1 + nota2 + nota3) / 3;
            var frequencia = (totalAulas - numeroFaltas) * 100 / totalAulas;

            for (int i = 0; i < bancoDeDados.GetLength(0); i++)
            {
                if (bancoDeDados[i, 0] != null)
                    continue;

                bancoDeDados[i, 0] = (inicioBancoDeDados++).ToString();
                bancoDeDados[i, 1] = aluno;
                bancoDeDados[i, 2] = media.ToString();
                bancoDeDados[i, 3] = frequencia.ToString();
                bancoDeDados[i, 4] = nf.RetornaStatus(media, frequencia);
                bancoDeDados[i, 5] = "true";
                break;
            }
            Console.WriteLine("\r\nRegistro realizado com sucesso!");
            Console.WriteLine("\r\nPara voltar ao menu inicial precione qualquer tecla");
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo que remove um registro de boletim do aluno no sistema
        /// </summary>
        /// <param name="bancoDeDados">nosso banco de dados referenciado para alterar para todos</param>
        public void RemoverBoletim()
        {
            Console.WriteLine("----------------Remover boletim do aluno----------------");
            for (int i = 0; i < bancoDeDados.GetLength(0); i++)
            {
                if (bancoDeDados[i, 5] != "false")
                    Console.WriteLine($"\r\nID:{bancoDeDados[i, 0]}" +
                        $" || Nome do Aluno:{bancoDeDados[i, 1]}" +
                        $" || Media:{bancoDeDados[i, 2]}" +
                        $" || Fequencia:{bancoDeDados[i, 3]}%" +
                        $" || Status:{bancoDeDados[i, 4]}");
            }
            Console.WriteLine("\r\nDigite o id do registro a ser removido:");
            var id = Console.ReadLine();

            for (int i = 0; i < bancoDeDados.GetLength(0); i++)
            {
                if (bancoDeDados[i, 0] != null && bancoDeDados[i, 0] == id)
                    bancoDeDados[i, 5] = "false";
            }
            Console.WriteLine("\r\nRemoção realizado com sucesso!");
            Console.WriteLine("\r\nPara voltar ao menu inicial precione qualquer tecla");
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que mostra os registros dos boletim de aluno ativos ou removidos
        /// </summary>
        /// <param name="bancoDeDados">Base de dados do sistema para servir de leitura e mostrar a lista de livros ao usuario</param>
        /// <param name="listarBoletimNAtivos">Parametro que define e mostra se o livro foi removido</param>
        public void ListarRegistro(string listarBoletimNAtivos = "false")
        {
            Console.WriteLine("----------------Lista de boletim do aluno----------------");

            if (listarBoletimNAtivos == "true")
                Console.WriteLine("------------ Lista de livros removidos ------------");


            for (int i = 0; i < bancoDeDados.GetLength(0); i++)
            {
                if (bancoDeDados[i, 5] != listarBoletimNAtivos)
                    Console.WriteLine($"\r\nID:{bancoDeDados[i, 0]}" +
                        $" || Nome do Aluno:{bancoDeDados[i, 1]}" +
                        $" || Media:{bancoDeDados[i, 2]}" +
                        $" || Frequencia:{bancoDeDados[i, 3]}%" +
                        $" || Status:{bancoDeDados[i, 4]}");
            }
            Console.WriteLine("\r\nListagem realizado com sucesso!");
            Console.WriteLine("\r\nPara voltar ao menu inicial precione qualquer tecla");
            Console.ReadKey();
        }

        public void AlterarNota()
        {
            Console.WriteLine("----------------Alterar boletim do aluno----------------");
            for (int i = 0; i < bancoDeDados.GetLength(0); i++)
            {
                if (bancoDeDados[i, 5] != "false")
                    Console.WriteLine($"\r\nID:{bancoDeDados[i, 0]}" +
                        $" || Nome do Aluno:{bancoDeDados[i, 1]}" +
                        $" || Media:{bancoDeDados[i, 2]}" +
                        $" || Fequencia:{bancoDeDados[i, 3]}%" +
                        $" || Status:{bancoDeDados[i, 4]}");
            }
            Console.WriteLine("\r\nDigite o id do registro a ser removido:");
            var id = Console.ReadLine();
            Console.WriteLine("\r\nInforme a primeira nota do aluno:");
            int.TryParse(Console.ReadLine(), out int nota1);
            Console.WriteLine("\r\nInforme a segunda nota do aluno:");
            int.TryParse(Console.ReadLine(), out int nota2);
            Console.WriteLine("\r\nInforme a terceira nota do aluno:");
            int.TryParse(Console.ReadLine(), out int nota3);
            Console.WriteLine("\r\nInforme o total de aulas:");

            var media = (nota1 + nota2 + nota3) / 3;

            for (int i = 0; i < bancoDeDados.GetLength(0); i++)
            {
                if (bancoDeDados[i, 0] != null && bancoDeDados[i, 0] == id)
                    bancoDeDados[i, 2] = media.ToString();
            }
            Console.WriteLine("\r\nRegistro atualizado com sucesso!");
            Console.WriteLine("\r\nPara voltar ao menu inicial precione qualquer tecla");
            Console.ReadKey();

        }

        public void AlterarFrequencia()
        {
            Console.WriteLine("----------------Alterar boletim do aluno----------------");
            for (int i = 0; i < bancoDeDados.GetLength(0); i++)
            {
                if (bancoDeDados[i, 5] != "false")
                    Console.WriteLine($"\r\nID:{bancoDeDados[i, 0]}" +
                        $" || Nome do Aluno:{bancoDeDados[i, 1]}" +
                        $" || Media:{bancoDeDados[i, 2]}" +
                        $" || Fequencia:{bancoDeDados[i, 3]}%" +
                        $" || Status:{bancoDeDados[i, 4]}");
            }
            Console.WriteLine("\r\nDigite o id do registro a ser removido:");
            var id = Console.ReadLine();
            Console.WriteLine("\r\nInforme o total de aulas:");
            int.TryParse(Console.ReadLine(), out int totalAulas);
            Console.WriteLine("\r\nInforme o total de faltas:");
            int.TryParse(Console.ReadLine(), out int numeroFaltas);

            var frequencia = (totalAulas - numeroFaltas) * 100 / totalAulas;

            for (int i = 0; i < bancoDeDados.GetLength(0); i++)
            {
                if (bancoDeDados[i, 0] != null && bancoDeDados[i, 0] == id)
                    bancoDeDados[i, 3] = frequencia.ToString();
            }
            Console.WriteLine("\r\nRegistro atualizado com sucesso!");
            Console.WriteLine("\r\nPara voltar ao menu inicial precione qualquer tecla");
            Console.ReadKey();


        }
    }
}
