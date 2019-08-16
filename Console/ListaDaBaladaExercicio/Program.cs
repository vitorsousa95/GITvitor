using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDaBaladaExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Cabeçario();

            string[,] nomeDaGalera = new string[10, 3];

            int IDporPessoa = 0;

            InserirRegistro(ref nomeDaGalera, ref IDporPessoa);
            Console.ReadKey();

            InserirRegistro(ref nomeDaGalera, ref IDporPessoa);
            Console.ReadKey();

        }
        /// <summary>
        /// Metodo que mostra a data, atração e preços
        /// </summary>
        public static void Cabeçario()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                   SÓ NESSE FINAL DE SEMANA 20/07 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                        HUNGRIA HIP HOP           ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n                         PISTA R$20,00          ");
            Console.WriteLine("                       CAMAROTE R$35,00           ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        /// <summary>
        /// Metodo que coleta o nome e a opção desejada do usuario
        /// </summary>
        /// <param name="nomeDaGalera">Nome da pessoa</param>
        /// <param name="IDporPessoa">Id da essoa no sistema</param>
        public static void InserirRegistro(ref string[,] nomeDaGalera, ref int IDporPessoa)
        {

            for (int i = 0; i < nomeDaGalera.GetLength(0); i++)
            {
                if (nomeDaGalera[i, 0] != null)
                    continue;

                Console.WriteLine("\r\nInforme seu nome para adicionar a lista de presença:");
                var nome = Console.ReadLine();
                Console.WriteLine("\r\nDigite o número de uma das opções: 1-pista ou 2-camarote");
                var opcao = Console.ReadKey().KeyChar.ToString();

                if (opcao == "1")
                    Console.WriteLine(" - Pista");

                if (opcao == "2")
                    Console.WriteLine(" - Camarote");

                nomeDaGalera[i, 0] = (IDporPessoa++).ToString();

                nomeDaGalera[i, 1] = nome;

                nomeDaGalera[i, 2] = opcao;

                Console.WriteLine("\r\nDeseja inserir uma noca confirmação? Sim - 1     Não - 0");

                var continuar = Console.ReadKey().KeyChar.ToString();


                if (continuar == "0")
                    break;

                ListaPlus(ref nomeDaGalera);
            }

            Console.WriteLine("\n\nRegistro adicionado com sucesso, segue lista de informações adicionadas:");


            for (int i = 0; i < nomeDaGalera.GetLength(0); i++)
                Console.WriteLine(string.Format("\r\nResgistro ID {0} || Nome: {1} || Opção:{2}", nomeDaGalera[i, 0], nomeDaGalera[i, 1], nomeDaGalera[i, 2]));
        }
        /// <summary>
        /// Metodo que aumenta a quantidade de nomes na lista de reserva
        /// </summary>
        /// <param name="NomeDaGaleta">Nova lista a ser criada juntado a lista ja existente</param>
        public static void ListaPlus(ref string[,] NomeDaGaleta)
        {

            var limiteDeLista = true;

            for (int i = 0; i < NomeDaGaleta.GetLength(0); i++)
            {

                if (NomeDaGaleta[i, 0] == null)
                    limiteDeLista = false;
            }

            if (limiteDeLista)
            {

                var listaCopia = NomeDaGaleta;

                NomeDaGaleta = new string[NomeDaGaleta.GetLength(0) + 2, 3];

                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {

                    NomeDaGaleta[i, 0] = listaCopia[i, 0];

                    NomeDaGaleta[i, 1] = listaCopia[i, 1];

                    NomeDaGaleta[i, 2] = listaCopia[i, 2];
                }

                Console.WriteLine("\r\nAdicionar mais nomes na reserva!");
            }
        }
    }
}
