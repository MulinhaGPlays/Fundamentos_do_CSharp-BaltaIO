namespace CSharpFundamentals.Library;

public class Cronometro
{
    public static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Cronômetro" +
            "\n S = Segundos => 10s = 10 segundos" +
            "\n M = Minutos => 1m = 1 minuto" +
            "\n H = Horas => 1h = 1 hora" +
            "\n 0 = Sair" +
            "\n Quanto tempo deseja contar?");

        string data = Console.ReadLine()!.ToUpper();
        if (data == "0") Environment.Exit(0);
        char type = data.Last(); // ou char.Parse(data.Substring(data.Length - 1, 1));
        var time = long.Parse(data[..^1]);
        int multiplicador = type switch
        {
            'S' => 1,
            'M' => 60,
            'H' => 60 * 60,
            _ => 1
        };

        PreIniciar(time * multiplicador);
    }

    public static void PreIniciar(long time)
    {
        Console.Clear();
        Console.WriteLine("Preparando...");
        Thread.Sleep(1000);
        Console.WriteLine("Calculando...");
        Thread.Sleep(1000);
        Console.WriteLine("Iniciando...");
        Thread.Sleep(2500);

        Iniciar(time);
    }

    public static void Iniciar(long time)
    {
        int currentTime = 0;

        while (time != currentTime)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("Cronômetro finalizado");
        Thread.Sleep(2500);
    }
}

