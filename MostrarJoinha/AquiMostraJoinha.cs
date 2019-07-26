using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarJoinha
{
    public class AquiMostraJoinha
    {
        /// <summary>
        /// Sera que é sexta hoje?
        /// </summary>
        public void MetodoInicialDoJoinha()
        {
            Console.WriteLine("Aqui iniciamos o nosso joinha XD");
            Console.ReadKey();
        }
        /// <summary>
        /// Aqui ainda não bebe mais que eu!!!!!
        /// </summary>
        /// <param name="eQuinta">2.0 ainda faz 3 por 1</param>
        public void MetodoDoisPontoZero(bool eQuinta)
        {
            if(eQuinta)
                Console.WriteLine("Cariai mermâo!!!");
            else
                Console.WriteLine("AIaiaiaiai!!!");

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que vamos identificar o tipo
        /// </summary>
        /// <returns>retorna algo?</returns>
        public string[] TesteUmOperadorLegal()
        {
            return new string[2] { "Teste 1", "Teste 2" };
        }
    }
}
