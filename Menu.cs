using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);

        }

        public static void DrawScreen()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");
            Console.Write("+");
            Console.Write("\n");

            for (int lines = 0; lines <= 12; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");
            Console.Write("+");
            Console.Write("\n\n\n");
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(10, 2);  //Função para ser possivel escrever dentro do "DrawScreen" (Coluna3, Linha2)
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(6, 4);
            Console.WriteLine("====================");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("Selecione uma opção abaixo :");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 11);
            Console.Write("Opção : ");
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
