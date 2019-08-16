using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MostrarJoinha;

namespace UsandoBibliotecaJoinha
{
    class Program
    {
        static void Main(string[] args)
        {
            new AquiMostraJoinha().MetodoInicialDoJoinha();

            new AquiMostraJoinha().MetodoDoisPontoZero(true);

            new AquiMostraJoinha().MetodoDoisPontoZero(false);

            //operação pesada com leitura e gravação a memoria
            var outroCaraParaRealizarOTeste = new AquiMostraJoinha().TesteUmOperadorLegal();
            //Contagem de todos os registros da nossa lista
            var tamanhoDaLista = outroCaraParaRealizarOTeste.Length;
            //Nosso for agr esta mais rapido
            for (int i = 0; i < tamanhoDaLista; i++)
            {
                Console.WriteLine(outroCaraParaRealizarOTeste[i]);
            }

            Console.ReadKey();
        }
    }
}
