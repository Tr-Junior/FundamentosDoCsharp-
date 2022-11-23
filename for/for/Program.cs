using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 500; i++)
            {
                int exp = (i * 1) + (i * 10);
                Console.WriteLine($"  - Level: {i}");
                Console.WriteLine($"    Exp: {exp}");

            }

        }
    }
}