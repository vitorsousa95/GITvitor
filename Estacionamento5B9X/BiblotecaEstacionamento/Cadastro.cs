using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento5B9X.BiblotecaEstacionamento
{
    public class Cadastro
    {
        string[,] bancoDeDados = new string[10, 5];
        int iD = 0;

        public void InserirCadastro()
        {
            Console.WriteLine("----------------------Inserir cadastro do carro----------------------");
            Console.WriteLine("Informe o modelo do carro");
            var carro = Console.ReadLine();
            Console.WriteLine("Informe a placa do carro");
            var placa = Console.ReadLine();

            for (int i = 0; i < bancoDeDados.GetLength(0); i++)
            {
                if (bancoDeDados[i, 0] != null)
                    continue;

                bancoDeDados[i, 0] = iD++.ToString();
                bancoDeDados[i, 1] = carro;
                bancoDeDados[i, 2] = placa;
                bancoDeDados[i, 3] = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
                bancoDeDados[i, 4] = null;
            }
            Console.WriteLine("Cadastro realizado com sucesso");
            Console.WriteLine("Para retornar ao menu incial precione qualquer tecla");
            Console.ReadKey();
        }

    }
}
