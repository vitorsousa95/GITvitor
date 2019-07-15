﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiDeManeiraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando nossa lista com mais de uma dimensão
            string[,] listaDeNome = new string[5, 2];

            //Aqui como estamos apenas uma referencia da nossa lista colocamos o "ref" ao passar ela no metodo
            carregaInformaçõesEListaElasEmTela(ref listaDeNome);
            
            //após carregar as informações e mostrar em tela ele espera um comando
            Console.ReadKey();

            //Indicamos que o usuario precisa informar um número de identificação para pesquisar um registro.
            Console.WriteLine("Informe um ID do registro a ser pesquisado.");

            //Aqui como realizamos a pesquisa somente na chamada
            //passamos a nossa lista normalmente pois não iremos alterar e apenas pesquisar a informação
            //Após a virgula temos o "Console.ReadLine()" que esperanosso identificador unico
            pesquisandoInformaçõesNaNossaLista(listaDeNome, Console.ReadLine());

            Console.ReadKey();

        }
        /// <summary>
        /// Metodo que carrega as informações dentro da nossa lista criada no metodo "MAIN"
        /// e mostra as informações logo em seguida
        /// </summary>
        /// <param name="arrayBi">Nossa lista a ser carregada.</param>
        public static void carregaInformaçõesEListaElasEmTela(ref string[,] arrayBi)
        {
            //Usando um laço simples para colocar valores mas no memso agora utilizando o
            //GetLength com o parametro "0" para indicar que queremos o tamanho da primeira coluna
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Carregando o que podemos chamar de ID, identificador do nosso registro unico
                arrayBi[i, 0] = i.ToString();
                //Aqui apenas indicamos uma informação extra para encorpar mais o contexto
                arrayBi[i, 1] = $"Vitor_{i}";
            }

            //Lembrando que GetLength é um metodo e usamos "(parametro)" com parametro ou as vezes sem para realizar a chamada do mesmo
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Formatamos uma string de maneira que os dados sejam apresentados
                Console.WriteLine($"ID:{arrayBi[i, 0]} - Nome:{arrayBi[i, 1]}");
            }

        }

        public static void pesquisandoInformaçõesNaNossaLista(string[,] arrayBi, string pId)
        {
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Realizamos nossa comparação dos mesmos tipos
                if (arrayBi[i, 0] == pId)
                {
                    //Mostramos as informações formatadas da nossa pesquisa
                    Console.WriteLine($"Informação escolhida: ID:{arrayBi[i, 0]} - Nome:{arrayBi[i, 1]}");

                    //Aqui saimos da nossa lista mas retornamos vazio "return;" pois estamos em um metodo
                    //vazio "void" que não espera retornar algo
                    return;
                }

                //Caso ele passe por esta linha identificamos que ele nao encontrou resultados compativeis.
                Console.WriteLine("Infelismente a busca pelo id não resultou em nenhuma informação.");
            }
        }
    }
}
