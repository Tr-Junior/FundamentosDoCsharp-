using System;
using System.Globalization;


namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            var meuArray = new int[5] { 1, 2, 3, 4, 5 };
            var meuArray2 = new int[5] { 1, 2, 3, 4, 5 };

            meuArray[0] = 12;
            meuArray[3] = 11;




            Console.WriteLine($"{meuArray[0]}, {meuArray2[0]}");
            Console.WriteLine($"{meuArray[1]}, {meuArray2[1]}");
            Console.WriteLine($"{meuArray[2]}, {meuArray2[2]}");
            Console.WriteLine($"{meuArray[3]}, {meuArray2[3]}");
            Console.WriteLine($"{meuArray[4]}, {meuArray2[4]}");

            var meuArray3 = new Teste[5];
            meuArray3[0] = new Teste();


            Console.WriteLine(meuArray3[0].Id);
            Console.WriteLine(meuArray3[1]);
            Console.WriteLine(meuArray3[2]);
            Console.WriteLine(meuArray3[3]);
            Console.WriteLine(meuArray3[4]);


            var meuArray4 = new int[5] { 1, 2, 3, 4, 5 };
            meuArray4[2] = 12;

            for (var item = 0; item < meuArray4.Length; item++)
            {
                Console.WriteLine(meuArray4[item]);
            }

            foreach (var index in meuArray4)
            {
                Console.WriteLine(index);

            }

            var funcionarios = new Funcionario[5];

            funcionarios[0] = new Funcionario() { Id = 2579, Nome = "Junior" };


            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id);
                Console.WriteLine(funcionario.Nome);

            }

            var primeiro = new int[4];

            var segundo = new int[4];

            segundo[0] = primeiro[0];
            primeiro.CopyTo(segundo, 0);

            primeiro[0] = 23;

            Console.WriteLine(segundo[0]);
        }

        struct Teste
        {
            public int Id { get; set; }
        }

        struct Funcionario
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
    }
}