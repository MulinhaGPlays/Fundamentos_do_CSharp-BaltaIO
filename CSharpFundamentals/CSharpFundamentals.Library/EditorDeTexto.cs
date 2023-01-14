namespace CSharpFundamentals.Library
{
    public class EditorDeTexto
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?" +
                "\n 0 - Sair" +
                "\n 1 - Criar arquivo" +
                "\n 2 - Abrir arquivo" +
                "\n 3 - Editar arquivo" +
                "\n 4 - Deletar arquivo");

            short option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 0: Environment.Exit(0); break;
                case 1: Criar(); break;
                case 2: Abrir(); break;
                case 3: Editar(); break;
                case 4: Deletar(); break;
                default: Menu(); break;
            }
        }

        public static void Criar()
        {
            
        }
        public static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?" +
                "\n------------------------");
            var path = Console.ReadLine();
            using var file = new StreamReader(path!);
            string text = file.ReadToEnd();
            Console.Write($"\n{text}");

            Console.WriteLine("\nPressione qualquer botão para voltar...");
            Console.ReadKey();
            Menu();
        }
        public static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto (ESC para sair)" +
                "\n------------------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);
        }
        public static void Deletar()
        {

        }
        public static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using var file = new StreamWriter(path!);
            file.Write(text);

            Console.WriteLine($"Arquivo salvo em {path} com sucesso!");
            Console.ReadKey();
            Menu();
        }
    }
}
