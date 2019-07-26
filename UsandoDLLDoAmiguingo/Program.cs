using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoCalculadoraParaOAmiguinho;

namespace UsandoDLLDoAmiguingo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora cl = new Calculadora();
            var MI = MenuInicial();


            while (true)
            {
                switch (MI)
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("----------Operação de Adição----------");
                            Console.WriteLine("\r\nDigite um numero:");
                            int.TryParse(Console.ReadLine(), out int n1);
                            Console.WriteLine("\r\nDigite um numero:");
                            int.TryParse(Console.ReadLine(), out int n2);
                            Console.WriteLine($"\r\nResultado:{ cl.Adicao(n1, n2)}");
                            Console.ReadKey();
                            
                        } break;
                    case "2":
                        {
                            Console.Clear();
                            Console.WriteLine("----------Operação de Subtração----------");
                            Console.WriteLine("\r\nDigite um numero:");
                            int.TryParse(Console.ReadLine(), out int n3);
                            Console.WriteLine("\r\nDigite um numero:");
                            int.TryParse(Console.ReadLine(), out int n4);
                            Console.WriteLine($"\r\nResultado:{ cl.Subtracao(n3, n4)}");
                            Console.ReadKey();
                            
                        } break;
                    case "3":
                        {
                            Console.Clear();
                            Console.WriteLine("----------Operação de Divisão----------");
                            Console.WriteLine("\r\nDigite um numero:");
                            int.TryParse(Console.ReadLine(), out int n5);
                            Console.WriteLine("\r\nDigite um numero:");
                            int.TryParse(Console.ReadLine(), out int n6);
                            Console.WriteLine($"\r\nResultado:{ cl.Divisao(n5, n6)}");
                            Console.ReadKey();
                            
                        } break;
                    case "4":
                        {
                            Console.Clear();
                            Console.WriteLine("----------Operação de Multiplicação----------");
                            Console.WriteLine("\r\nDigite um numero:");
                            int.TryParse(Console.ReadLine(), out int n7);
                            Console.WriteLine("\r\nDigite um numero:");
                            int.TryParse(Console.ReadLine(), out int n8);
                            Console.WriteLine($"\r\nResultado:{ cl.multipicacao(n7, n8)}");
                            Console.ReadKey();
                            
                        } break;
                    case "5":
                        {
                            Console.Clear();
                            Console.WriteLine("----------Operação de calcular area do Retangulo----------");
                            Console.WriteLine("\r\nDigite a base(cm):");
                            int.TryParse(Console.ReadLine(), out int n9);
                            Console.WriteLine("\r\nDigite a altura(cm):");
                            int.TryParse(Console.ReadLine(), out int n10);
                            Console.WriteLine($"\r\nResultado(cm):{ cl.CalcularRetangulo(n9, n10)}");
                            Console.ReadKey();
                            
                        } break;
                    case "6":
                        {
                            Console.Clear();
                            Console.WriteLine("----------Operação de calcular area do Triangulo----------");
                            Console.WriteLine("\r\nDigite a base(cm):");
                            int.TryParse(Console.ReadLine(), out int n11);
                            Console.WriteLine("\r\nDigite a altura(cm):");
                            int.TryParse(Console.ReadLine(), out int n12);
                            Console.WriteLine($"\r\nResultado(cm):{ cl.CalcularTriangulo(n11, n12)}");
                            Console.ReadKey();

                        } break;
                    case "7":
                        {
                            Console.Clear();
                            Console.WriteLine("----------Operação de calcular raio da circuferencia----------");
                            Console.WriteLine("\r\nDigite a circuferencia(cm):");
                            int.TryParse(Console.ReadLine(), out int n13);
                            Console.WriteLine($"\r\nResultado(cm):{ cl.CalcularRaioDeUmCirculo(n13)}");
                            Console.ReadKey();
                            
                        } break;

                    case "8": { return; }

                }

                MI = MenuInicial();
            }
        }
        public static string MenuInicial()
        {
            Console.Clear();
            Console.WriteLine("Menu Inicial.");
            Console.WriteLine("1 - Adição:");
            Console.WriteLine("2 - Subtração:");
            Console.WriteLine("3 - Divisão:");
            Console.WriteLine("4 - Multiplicação:");
            Console.WriteLine("5 - Calcular area do Retangulo:");
            Console.WriteLine("6 - Calcular area do Triangulo:");
            Console.WriteLine("7 - Calcular raio da circuferencia:");
            Console.WriteLine("8 - Sair:");
            return Console.ReadLine();
        }
    }
}
