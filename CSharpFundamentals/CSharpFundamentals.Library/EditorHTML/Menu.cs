namespace CSharpFundamentals.Library.EditorHTML;

public class Menu
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;

        DrawScreen();
    }

    private static void DrawScreen()
    {
        int qtdLines = 30;

        Line(qtdLines);
        Console.Write("\n");
        Column(12, 30);
        Line(qtdLines);
        WriteOptions();

        var option = short.Parse(Console.ReadLine()!);
        HandleMenuOption(option);
    }

    private static void Column(int qtdHeight, int qtdWidth)
    {
        for (int lines = 0; lines < qtdHeight; lines++)
        {
            Console.Write("|");
            for (int i = 0; i < qtdWidth; i++)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            Console.Write("\n");
        }
    }

    private static void Line(int qtd)
    {
        Console.Write("+");
        for (int i = 0; i < qtd; i++)
        {
            Console.Write("-");
        }
        Console.Write("+");
    }

    private static void WriteOptions()
    {
        Console.SetCursorPosition(3,2);
        Console.WriteLine("Editor HTML");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("===========");
        Console.SetCursorPosition(3, 4);
        Console.WriteLine("Selecione uma opção abaixo");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("1 - Novo arquivo");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("2 - Abrir");
        Console.SetCursorPosition(3, 9);
        Console.WriteLine("0 - Sair");
        Console.SetCursorPosition(3, 10);
        Console.WriteLine("Opção: ");
    }

    private static void HandleMenuOption(short option)
    {
        switch (option)
        {
            case 1: Editor.Show(); break;
            case 2: Viewer.Show(""); break;
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
