using System;
using System.Globalization;


namespace moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10234.25m;

            Console.WriteLine(valor.ToString("G", CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(valor.ToString("E04", CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(valor.ToString("F", CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(valor.ToString("P", CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(valor.ToString("N", CultureInfo.CreateSpecificCulture("pt-BR")));


            // decimal converterValor = 10234.25m;



            Console.WriteLine(Math.Floor(valor));
            Console.WriteLine(Math.Round(valor));
            Console.WriteLine(Math.Ceiling(valor));



        }
    }
}