using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraParaOAmiguinho
{
    public class Calculadora
    { 
        /// <summary>
        /// Metodo que realiza a operação de soma
        /// </summary>
        /// <param name="x">primeiro numero</param>
        /// <param name="y">segundo numero</param>
        /// <returns></returns>
        public decimal Soma(decimal x, decimal y)
        {
            return x + y;
        }
        /// <summary>
        /// Metodo que realiza operação de subtração
        /// </summary>
        /// <param name="x">primeiro numero</param>
        /// <param name="y">segundo numero</param>
        /// <returns></returns>
        public decimal Subtracao(decimal x, decimal y)
        {
            return x - y;
        }
        /// <summary>
        /// Metodo que realiza a operacao de divisão
        /// </summary>
        /// <param name="x">primeiro numero</param>
        /// <param name="y">segundo numero</param>
        /// <returns></returns>
        public decimal Divisao(decimal x, decimal y)
        {
            return x / y;
        }
        /// <summary>
        /// Metodo que realiza a operacao de multiplicação
        /// </summary>
        /// <param name="x">primeiro numero</param>
        /// <param name="y">segundo numero</param>
        /// <returns></returns>
        public decimal Multiplicacao(decimal x, decimal y)
        {
            return x * y;
        }
        /// <summary>
        /// Metodo que calcula a area de um retangulo
        /// </summary>
        /// <param name="x">medida da base</param>
        /// <param name="y">medida da altura</param>
        /// <returns></returns>
        public decimal AreaDoRetangulo(decimal x, decimal y)
        {
            var area = x * y;

            return area;
        }
        /// <summary>
        /// Metodo que calcula a area do tringulo equilatero
        /// </summary>
        /// <param name="x">medida da base</param>
        /// <param name="y">medida da altura</param>
        /// <returns></returns>
        public decimal AreaDoTriaguloEquilatero(decimal x, decimal y)
        {
            var area = (x * y) / 2;

            return area;
        }
        /// <summary>
        /// Metodo que calcula o raio da circunferência
        /// </summary>
        /// <param name="x">medida da circuferencia</param>
        /// <returns></returns>
        public decimal RaioDeUmCirculo(decimal x)
        {
            decimal pi = 3.14m;
            decimal raio = x / (2 * pi);

            return raio;
        }
    }
}
