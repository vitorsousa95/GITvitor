using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdicionandoValoresEmUmaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação da nossa lista o.0.
            string[,] listaDeNome = new string[2, 2];
            //Aqui vamos criar forma externa de identificar nossos registros
            int IdParaLista = 0;
            //Chamada do nosso
            InserirRegistro(ref listaDeNome, ref IdParaLista);
            
            Console.ReadKey();
            
            //Aqui continuamos inserindo os regiistros
            InserirRegistro(ref listaDeNome, ref IdParaLista);

            Console.ReadKey();
        }
        /// <summary>
        /// metodo que inseri novo registro dentro da nossa lista
        /// </summary>
        /// <param name="listaDeNome">Nossa lista de nome vazia ou não</param>
        /// <param name="IdParaLista">Nossa referencia externa de ID1
        /// 11</param>
        public static void InserirRegistro( ref string[,] listaDeNome, ref int IdParaLista)
        {
            //Aqui estaremos em um laço para informar o registro
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                //Aqui definimos que o mesmo deve continuar para o próximo registro
                //pois esse registro já está ocupado
                if (listaDeNome[i, 0] != null)
                    continue;
                //Indicamos que ele deve apenas informar o nome do nosso registro
                Console.WriteLine("\r\nInforme um nome para adicionar um registro:");
                var nome = Console.ReadLine();
                //Criamos o nosso identificador unico com um objeto externo que
                //mesmo após sairmos do nosso laço ainda podera ser 
                listaDeNome[i, 0] = (IdParaLista++).ToString();
                //Aqui colocamos nosso nome na lista
                listaDeNome[i, 1] = nome;
                //Identificamos se o usuario ainda deseja inserir registros dentro da nossa lista
                Console.WriteLine("\nDeseja inserir um novo registro? Sim - 1     Não - 0");
                //O "Console.ReadKey()" só espera uma unica tecla e nos retorna a tecla que foi acionada e não o valor dela
                //Por isso usamos o "KeyChar" para pegar esse valor e converter ele em um string para comparação
                var continuar = Console.ReadKey().KeyChar.ToString();
                //Aqui validamos a condição se o mesmo deve ou não continuar a adicionar registro até que a nossa
                //lista esteja completa de informações

                if (continuar == "0")
                    break;//break é uma palavra reservada do c# que para, por isso break, todo laço de repetição ou sequenciador lógico o.0.

                //metodo que aumenta o tamanho da lista de acordo com a quantidade de registros
                AumentaTamanhoLista(ref listaDeNome);
            }

            Console.WriteLine("\nRegistro adicionado com sucesso, segue lista de informações adicionadas:");

            //Mas agora a coisa muda,
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
                //Utilizamos o string format, basicamente ele faz da mesma forma que o sifrão
                //a diferença entre eles é que este é um cara em grande quantidade aca sendo mais rápido
                Console.WriteLine(string.Format("\nResgistro ID {0} - Nome: {1}", listaDeNome[i, 0], listaDeNome[i, 1]));
        }

        public static void AumentaTamanhoLista(ref string[,] ListaDeNome)
        {
            //Verifica se precisa criar uma lista maior
            var limiteDeLista = true;
            //Laço que verifica se existe registro disponivel
            for (int i = 0; i < ListaDeNome.GetLength(0); i++)
            {
                //Caso ainda existir registro disponivel
                if (ListaDeNome[i, 0] == null)
                    limiteDeLista = false;
            }
            //Caso não tenha mais registro nossa variavel ficou como true então indica que precisamos aumentar nossa lista
            if (limiteDeLista)
            {
                //criamos uma cópia da nossa lista para não perder os valores
                var listaCopia = ListaDeNome;
                //Aqui limpamos nossa lista antiga e assinamos novamente com uma lista com mais espaços
                ListaDeNome = new string[ListaDeNome.GetLength(0) + 5, 2];
                //Agora copiamos os registros da nossa lista antiga e passamos para a nossa nova lista
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    //copiamos a informação do nosso identificador unico
                    ListaDeNome[i, 0] = listaCopia[i, 0];
                    //Copiamos a informação do nosso nome
                    ListaDeNome[i, 1] = listaCopia[i, 1];
                }
                //Indicamos que neste ponto que o tamanho da lista foi aumentado
                Console.WriteLine("O tamanho da lista foi atualizado");
            }
        }
    }
}
