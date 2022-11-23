using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();

        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("       Menu");
            Console.WriteLine("--------------------");
            Console.WriteLine("| 1 - Soma         |");
            Console.WriteLine("| 2 - Subtração    |");
            Console.WriteLine("| 3 - Divisão      |");
            Console.WriteLine("| 4 - Multiplicação|");
            Console.WriteLine("| 5 - Sair         |");
            Console.WriteLine("--------------------");

            Console.Write("Opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;

                case 2: Subtracao(); break;

                case 3: Divisao(); break;

                case 4: Multiplicacao(); break;

                case 5: System.Environment.Exit(0); break;

                default: Menu(); break;
            }

        }
        static void Soma()
        {

            Console.Clear();
            Console.WriteLine("Opção de Soma");
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            // Console.WriteLine("O resultado é " + resultado);
            Console.WriteLine($"O resultado é {resultado}");
            // Console.WriteLine($"O resultado é {v1 + v2}");
            // Console.WriteLine("O resultado é " + (v1 + v2));
            Console.Write("Pressione qualquer tecla para voltar ao menu anterior......");

            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Opção de Subtração");
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;
            // Console.WriteLine("O resultado é " + resultado);
            Console.WriteLine($"O resultado é {resultado}");

            Console.Write("Pressione qualquer tecla para voltar ao menu anterior......");

            Console.ReadKey();
            Menu();

        }

        static void Divisao()
        {

            Console.Clear();
            Console.WriteLine("Opção de Divisão");
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;

            Console.WriteLine($"O resultado é {resultado}");

            Console.Write("Pressione qualquer tecla para voltar ao menu anterior......");

            Console.ReadKey();
            Menu();

        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Opção de Multiplicação");
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado é {resultado}");

            Console.Write("Pressione qualquer tecla para voltar ao menu anterior......");

            Console.ReadKey();
            Menu();

        }
    }
}