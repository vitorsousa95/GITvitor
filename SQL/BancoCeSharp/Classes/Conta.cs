using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCeSharp.Classes
{
    public class Conta
    {
        double saldo = 0;
        /// <summary>
        /// propriedade que contem o valor do saldo
        /// </summary>
        public double Saldo { get { return saldo; } }

        public Conta()
        {
            //Bonus de mil reais para iniciar operar daytrade
            saldo = 1000;
        }

        /// <summary>
        /// Metodo para sacar de acordo com saldo disponivel
        /// </summary>
        /// <param name="valor">Valor a ser sacado</param>
        /// <returns>retorna se o saque foi feito ou não</returns>
        public bool Sacar(double valor)
        {
            if(valor <= saldo)
            {//desconta do valor em saldo na conta
                saldo -= valor;
                return true;
            }

            return false;
        }
        /// <summary>
        /// Metodo para mostrar saldo em conta que está disponivel
        /// </summary>
        public double MostrarSaldo()
        {
            return saldo;
        }
    }
}
