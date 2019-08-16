using ExecicioNotasEFrequencias.Cadastro;
using ExecicioNotasEFrequencias.NotasEFrequencias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoNotasEFrequencias
{
    
    class Program
    {
       
        static void Main(string[] args)
        {
            #region Notas e Frequencia
            /*var diplomaAluno = new NotaEFrequencia();

            Console.WriteLine("Digite o nome do aluno:");
            Console.ReadLine();
            Console.WriteLine("Digite as notas do aluno:");
            var nota1 = int.Parse(Console.ReadLine());
            var nota2 = int.Parse(Console.ReadLine()); ;
            var nota3 = int.Parse(Console.ReadLine());

            var media = diplomaAluno.Nota(nota1, nota2, nota3);

            var frequencia = diplomaAluno.Frequencia(10, 10);

            diplomaAluno.Status(media, frequencia);         

            Console.ReadKey();*/
            #endregion
            var opcao = new Cadastro();

            while (true)
            {
                switch(MenuInicial())
                {
                    case "1": { opcao.InserirBoletim(); } break;
                    case "2": { opcao.RemoverBoletim(); } break;
                    case "3": { opcao.AlterarNota(); } break;
                    case "4": { opcao.AlterarFrequencia(); } break;
                    case "5": { opcao.ListarRegistro(); } break;
                    case "6": { opcao.ListarRegistro("true"); } break;
                    case "7": { return; }
                }
            }

        }
        /// <summary>
        /// Metodo que carrega as opções do menu inicial
        /// </summary>
        /// <returns>Retorna a opção escolida</returns>
        public static string MenuInicial()
        {
            Console.Clear();
            Console.WriteLine("----------------BEM VINDO AO SISTEMA DA ESCOLA C#----------------");
            Console.WriteLine(" ");
            Console.WriteLine("Menu Inicial.");
            Console.WriteLine("1 - Inserir dados do Boletim:");
            Console.WriteLine("2 - Remover dados do Boletim:");
            Console.WriteLine("3 - Alterar nota do Boletim:");
            Console.WriteLine("4 - Alterar frequencia Boletim:");
            Console.WriteLine("5 - Listar Boletim:");
            Console.WriteLine("6 - Listar boletim removido:");
            Console.WriteLine("7 - Sair:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\r\n        Digite o número da opção desejada e tecle ENTER:");
            Console.ForegroundColor = ConsoleColor.White;
            return Console.ReadLine();
        }


    }
}
