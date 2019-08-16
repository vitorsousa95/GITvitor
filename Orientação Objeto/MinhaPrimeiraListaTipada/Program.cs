using MinhaPrimeiraListaTipada.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraListaTipada
{
    class Program
    {
        static void Main(string[] args)
        {
            //O indicador <T> o tipo da minha lista com isso temos uma lista de lanches
            List<Lanche> minhaLista = new List<Lanche>();
            //Adiciona na minha lista pastel de carne
            minhaLista.Add(new Lanche() { 
                Nome = "Pastel de carne",
                Quantidade = 10,
                Valor = 2.50
            });
            //Adiciono na minha lista coxinha de catupiry
            minhaLista.Add(new Lanche()
            {
                Nome = "Coxinha com catupiry",
                Quantidade = 5,
                Valor = 2.50
            });
            //Adiciono na minha lista doguinho
            minhaLista.Add(new Lanche()
            {
                Nome = "Doguinho",
                Quantidade = 7,
                Valor = 1.70
            });
            //Adiciono na minha lista X-Salada
            minhaLista.Add(new Lanche()
            {
                Nome = "Coxinha com catupiry",
                Quantidade = 15,
                Valor = 6.00
            });
            //Adiciono na minha lista coxinha de catupiry
            minhaLista.Add(new Lanche()
            {
                Nome = "X-Salada",
                Quantidade = 5,
                Valor = 2.50
            });
            //Adiciono na minha lista Pizza de filé com chedder
            minhaLista.Add(new Lanche()
            {
                Nome = "Pizza de filé com chedder",
                Quantidade = 3,
                Valor = 18.00
            });
            //Adiciono na minha lista Rosca de calabresa
            minhaLista.Add(new Lanche()
            {
                Nome = "Rosca de calabresa",
                Quantidade = 9,
                Valor = 5.50
            });
            //Adiciono na minha lista Pão com bolinho, ovo, queijo 
            minhaLista.Add(new Lanche()
            {
                Nome = "Pão com bolinho, ovo e queijo",
                Quantidade = 25,
                Valor = 12.00
            });
            //Adiciono na minha lista Pastel de "flango"
            minhaLista.Add(new Lanche()
            {
                Nome = "Pastel de flango",
                Quantidade = 150,
                Valor = 1.00
            });
            //Adiciono na minha lista massinha de chocolate
            minhaLista.Add(new Lanche()
            {
                Nome = "massinha de chocolate",
                Quantidade = 100,
                Valor = 0.50
            });

            //Aqui ando pela minha lista para poder apresentar em tela os valores
            //item in significa que ele já é um indice da minha lista bonitinho
            foreach (Lanche item in minhaLista)
                Console.WriteLine($"Lanches disponiveis:{item.Nome} - Quantidade:{item.Quantidade}");

            Console.WriteLine("Removendo item");
            //Aqui removo nosso item da lista de acordo com sua quantidade
            minhaLista.Remove(minhaLista.FirstOrDefault(x => x.Quantidade == 5));

            var meuIten = (from item in minhaLista
                           where item.Quantidade == 3
                           select item).ToList<Lanche>();

            foreach (Lanche item in minhaLista)
                Console.WriteLine($"Lanches disponiveis:{item.Nome} - Quantidade:{item.Quantidade}");

            Console.ReadKey();
        }
    }
}
