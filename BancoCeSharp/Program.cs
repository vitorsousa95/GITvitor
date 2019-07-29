using BancoCeSharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCeSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta acconuntUser = new Conta();

            Console.WriteLine("Informe o valor a ser sacado:");
            //Aqui usamos a conversão do valor informado
            double.TryParse(Console.ReadLine(), out double valorSacar);
            //Verficamos se o valor é maior que 0 e se realizou o saque
            if(valorSacar > 0 && acconuntUser.Sacar(valorSacar))
                Console.WriteLine("Saque realizado com sucesso");
            else
                Console.WriteLine("Operação não realizada");
            //Mostra o saldo disponivel
            Console.WriteLine($"Saldo atual disponivel:{acconuntUser.Saldo.ToString("N2")}");

            Console.ReadKey();
        }
    }
}
