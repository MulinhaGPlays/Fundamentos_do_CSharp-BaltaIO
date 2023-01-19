namespace CSharpFundamentals.Library;

public class Cronometro
{
    public static void Menu()
    {
        Console.Clear();
        Console.WriteLine(@"Cronômetro" +
            "\n S = Segundos => 10s = 10 segundos" +
            "\n M = Minutos => 1m = 1 minuto" +
            "\n H = Horas => 1h = 1 hora" +
            "\n Quanto tempo deseja contar?");

        string data = Console.ReadLine()!.ToUpper();

        char type = data.Last(); // ou char.Parse(data.Substring(data.Length - 1, 1));
        var time = long.Parse(data[..^1]);
        int multiplicador = type switch
        {
            'S' => 1,
            'M' => 60,
            'H' => 60 * 60,
            _ => throw new NotImplementedException("Não implementado")
        };

        Console.WriteLine("Deseja utilizar contagem regressiva?");
        Console.WriteLine("S/N");

        string contagemRegressiva = Console.ReadLine()!.ToUpper();

        long tempo = time * multiplicador;
        bool contReg = contagemRegressiva == "S";

        PreIniciar(tempo, contReg);
    }

    public static void PreIniciar(long time, bool contRegressiva = false)
    {
        Console.Clear();
        Console.WriteLine("Preparando...");
        Thread.Sleep(1000);
        Console.WriteLine("Calculando...");
        Thread.Sleep(1000);
        Console.WriteLine("Iniciando...");
        Thread.Sleep(2500);

        Iniciar(time, contRegressiva);
    }

    public static void Iniciar(long time, bool contRegressiva = false)
    {
        Contador(time, contRegressiva);

        Console.Clear();
        Console.WriteLine("Cronômetro finalizado");
        Thread.Sleep(2500);
    }

    public static void Contador(long time, bool contRegressiva = false)
    {
        long currentTime = 0;
        if (contRegressiva)
        {
            currentTime = time;
            time = 0;
        }

        while (time != currentTime)
        {
            if (contRegressiva)
                currentTime--;
            else
                currentTime++;

            Console.Clear();
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }
    }
}

