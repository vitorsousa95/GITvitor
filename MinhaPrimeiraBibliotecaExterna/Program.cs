using BibliotecaDeArquivosDoWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraBibliotecaExterna
{
    class Program
    {
        static void Main(string[] args)
        {
            var arquivos = new GetFiles();

            Console.WriteLine("\r\nArquivos documentos");
            foreach (var retorno in arquivos.RetornaArquivosDoMeuDocumentos())
            { 
                Console.WriteLine(retorno);
            }

            Console.ReadKey();

            Console.WriteLine("\r\nArquivos imagens");
            foreach (var retorno in arquivos.RetornaArquivosImagesFiles())
            {
                Console.WriteLine(retorno);
            }

            Console.ReadKey();

            Console.WriteLine("\r\nArquivos Git");
            foreach (var retorno in arquivos.RetornaArquivosGit())
            {
                Console.WriteLine(retorno);

                if (retorno == null)
                {
                    Console.WriteLine("Nenhum arquivo encontrado");
                }
            }

            Console.ReadKey();
        }
    }
}14248242
