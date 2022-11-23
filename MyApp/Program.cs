using System;
using System.Text;

namespace Stopwatch
{
    class Program
    {
        static void Main(String[] args)
        {
            var id = Guid.NewGuid();

            Console.WriteLine(id);

            var price = 10.2;
            Console.WriteLine("________________________________________________");

            // var text = $@"o Preço é 
            // \n {price}";
            var text = "o Preço é " + price + " na promoção";
            var texto = string.Format("O preço do produto é {0} apenas na promoção", price);

            Console.WriteLine(texto);
            Console.WriteLine("________________________________________________");

            var texto3 = "Testando";
            var texto2 = "Este texto é um teste";

            Console.WriteLine(texto3.CompareTo("Testando"));
            Console.WriteLine(texto3.CompareTo("testando"));

            Console.WriteLine(texto2.Contains("teste"));
            Console.WriteLine(texto2.Contains("Teste"));
            Console.WriteLine(texto2.Contains("Teste", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto2.Contains("null")); // se passar um valor nulo dará erro
            Console.WriteLine("________________________________________________");
            var texto4 = "Este texto é um teste";
            Console.WriteLine(texto4.StartsWith("Este"));
            Console.WriteLine(texto4.StartsWith("texto"));
            Console.WriteLine(texto4.StartsWith("este"));

            Console.WriteLine(texto4.EndsWith("teste"));
            Console.WriteLine(texto4.EndsWith("Teste", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto4.EndsWith("asd"));

            Console.WriteLine("________________________________________________");

            var texto5 = "Este texto é um teste";
            Console.WriteLine(texto5.Equals("Este texto é um teste"));
            Console.WriteLine(texto5.Equals("Este exto é um Teste"));
            Console.WriteLine(texto5.Equals("Este Texto é um teste", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("________________________________________________");
            var texto6 = "Este texto é para teste";

            Console.WriteLine(texto6.IndexOf("é"));
            Console.WriteLine(texto6.LastIndexOf("te"));

            Console.WriteLine("________________________________________________");
            var texto7 = "Este texto é para teste";

            Console.WriteLine(texto7.ToLower());
            Console.WriteLine(texto7.ToUpper());
            Console.WriteLine(texto7.Insert(5, "AQUI"));
            Console.WriteLine(texto7.Remove(5, 5));
            Console.WriteLine(texto7.Length);

            Console.WriteLine("________________________________________________");
            var texto8 = "Este texto é para teste   ";
            Console.WriteLine(texto8.Replace("Este", "esse"));
            Console.WriteLine(texto8.Replace("e", "p"));

            var divisao = texto8.Split(" ");

            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);

            var resultado = texto8.Substring(5, texto8.LastIndexOf("o"));
            var resultado2 = texto8.Substring(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(resultado2);
            Console.WriteLine(texto8.Trim());

            Console.WriteLine("________________________________________________");
            var texto9 = new StringBuilder();
            texto9.Append("Este texto é para teste ");
            texto9.Append("Este texto é para teste");

            Console.WriteLine(texto9);
        }
    }
}