using System.Text.RegularExpressions;

namespace CSharpFundamentals.Library.EditorHTML;

public partial class Viewer
{
    public static void Show(string text)
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("MODO VISUALIZAÇÃO");
        Console.WriteLine("----------------------------------------");
        Replace(text);
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Menu.Show();
    }

    public static void Replace(string text)
    {
        var strong = StrongRegex();
        var words = text.Split(' ');
        for (var i = 0; i < words.Length; i++)
        {
            if (strong.IsMatch(words[i]))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(
                    words[i].Substring(
                        words[i].IndexOf('>') + 1,
                        words[i].LastIndexOf('<') - 1 - words[i].IndexOf('>')
                    )
                );
                Console.Write(" ");
            }
            else
            {
                Console.Write(words[i]);
                Console.Write(" ");
            }
        }
    }

    [GeneratedRegex("<\\s*strong[^>]*>(.*?)<\\s*/\\s*strong>")]
    private static partial Regex StrongRegex();
}
