using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeLista_Organizada.BibliotecaLista
{
    class Lista
    {
        string[] lista;
        /// <summary>
        /// Nosso contrutor assina nossa lista com valores definidos
        /// </summary>
        public Lista()
        {
            lista = new string[10];

            CarregaLista();
        }
        /// <summary>
        /// Aqui preenchemos a lista e depois mostramos em tela
        /// </summary>
        public void CarregaLista()
        {
            Console.WriteLine("Valores:");

            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
            }

            foreach (var item in lista)
                Console.WriteLine(item);
        }
        /// <summary>
        /// Aqui apagmos todo os valores ereotnamos em branco
        /// </summary>
        public void ApagaLista()
        {
            Console.WriteLine("\r\nPara apagar os valores precione qualquer tecla:");
            Console.ReadKey();
            Console.WriteLine("\r\nValores Apagados:");

            for (int i = 0; i < lista.Length; i++)
                lista[i] = string.Empty;

            foreach (var item in lista)
            Console.WriteLine(item);
            Console.ReadKey();
        }
    }

}
