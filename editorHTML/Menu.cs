namespace editorHTML
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            DrawScreen();
            Options();

            var option = short.Parse(Console.ReadLine());

            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            int coluns = 30,
              lines = 10;

            string upBar = "=",
              upBarLR = "+",
              lrBar = "|";

            Colun(coluns, upBarLR, upBar);

            Lines(lines, coluns, lrBar);

            Colun(coluns, upBarLR, upBar);

        }
        public static void Colun(int coluns, string upBarLR, string upBar)
        {
            Console.Write(upBarLR);
            for (int i = 0; i <= coluns; i++)
            {
                Console.Write(upBar);
            }
            Console.Write(upBarLR);
            Console.Write("\n");


        }

        public static void Lines(int lines, int coluns, string lrBar)
        {
            for (int i = 0; i <= lines; i++)
            {
                Console.Write(lrBar);
                for (int j = 0; j <= coluns; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(lrBar);
                Console.Write("\n");
            }
        }
        public static void Options()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("=====================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }
        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }

    }


}