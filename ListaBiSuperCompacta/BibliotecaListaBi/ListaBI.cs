using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiSuperCompacta.BibliotecaListaBi
{
    class ListaBI
    {
        string[,] listaBi;

        /// <summary>
        /// Iniciamos nossa lista bi, agora quando iniciamos uma instanca dela ela ja vem com a lista carregada
        /// </summary>
        public ListaBI()
        {
            listaBi = new string[999, 2];
            //Ao chamar este metodo no contrutor nossa lista ja vai estar carregada ao iniciar a instancia "jogar para memoria"
            CarregaListaBi();
        }

        /// <summary>
        /// Aqui carregamos a lista quando chamado este metodo
        /// </summary>
        public void CarregaListaBi()
        {
            for (int i = 0; i < listaBi.GetLength(0); i++)
            {
                listaBi[i, 0] = i.ToString();
                listaBi[i, 1] = $"Vitor_{i}";
                //Ao adicionar o resgistro na lista ja mostramos na tela
                Console.WriteLine($"ID:{i} ||Nome:Vitor_{i}");
            }
        }
        /// <summary>
        /// Aqui temos o metodo que realiza a pesquisa das informações em nossa lista
        /// </summary>
        /// <param name="idPesquisa">Aqui vai o id da nossa informação</param>
        public void PesquisaLista(string idPesquisa)
        {
            for (int i = 0; i < listaBi.GetLength(0); i++)
            {
                if (listaBi[i, 0] == idPesquisa)
                {
                    Console.WriteLine("Resultado encontrado com sucesso!");
                    Console.WriteLine($"Você pesquisou pelo registro:{listaBi[i, 1]}");
                    //Saio do metodo porque não preciso mais dele sem passar
                    return;
                }
            }

            Console.WriteLine("Nenhum registro encontrado com esse ID");
        }
    }
}
