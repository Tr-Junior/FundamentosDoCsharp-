using System;
using System.Text;
namespace editorHTML
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Modo Editor");
            Console.WriteLine("_______________________");
            Start();


        }
        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine(" Deseja Salvar o arquivo?");

        }

    }
}