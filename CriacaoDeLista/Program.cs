using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeLista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iniciando uma lista com array linear
            string[] lista = new string[10];//Definindo as posições da lista iniciando ela com 10 
            //espaços na memoria para alocar informações de texto

            // laço que usamos geralmente para andar sobre as posições da nossa lista
            for (int i = 0; i < lista.Length; i++)
            {
                //carregando os valores da nossa lista aqui
                //onde "i" representa cada espaço que temos disponivel
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy  hh:mm:ss.fff");
                //DateTime é um tipo do .NET C# que disponibiliza funções relacionadas a datas
                //e horas, ou seja, se precisar trabalhar com essas informações é possivel usar esse cara.
            }

                //Laços de repetição que usamos para varrer nossa lista de maneira mais simples
            foreach (var item in lista)//"var item" indica uma unidade da nossa lista "in lista"
                //indica a lista que desejamos varrer

                Console.WriteLine(item);//aqui representamos a informação na tela

            Console.ReadKey();//usamos o ReadKey para pausar a aplicação até que o usuario aperte qualquer tecla.
        }
    }
}
