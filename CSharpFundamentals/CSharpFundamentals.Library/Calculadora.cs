using CSharpFundamentals.Library.Enums;

namespace CSharpFundamentals.Library;

public class Calculadora
{
    public static void Menu()
    {
        float n1, n2, resultado;
        Console.Clear();

        try
        {
            Console.WriteLine("Selecione uma opção: " +
                "\n 1 - Soma " +
                "\n 2 - Divisão " +
                "\n 3 - Subtração " +
                "\n 4 - Multiplicação");

            var operador = short.Parse(Console.ReadLine()!) switch
            {
                1 => ECalculadora.SOMA,
                2 => ECalculadora.DIVISAO,
                3 => ECalculadora.SUBTRACAO,
                4 => ECalculadora.MULTIPLICACAO,
                _ => ECalculadora.SOMA,
            };

            Console.WriteLine("Digite o primeiro valor:");
            n1 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("Digite o segundo valor:");
            n2 = float.Parse(Console.ReadLine()!);

            resultado = Calcular(n1, n2, operador);

            Console.WriteLine($"Resultado: {resultado}");
            Console.WriteLine("\n Deseja encerrar?\n Digite S/N");

            if (Console.ReadLine()!.ToUpper() == "S") Environment.Exit(0);
        }
        catch (FormatException)
        {
            Console.WriteLine("Você não digitou um número, tente novamente");
            Console.WriteLine("Pressione qualquer tecla para fechar...");
            Console.ReadKey();
            Menu();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Foi encontrado o seguinte erro: {ex}");
            Console.WriteLine("Pressione qualquer tecla para fechar...");
            Console.ReadKey();
            Menu();
        }
    }

    public static float Calcular(float n1, float n2, ECalculadora operador)
        => operador switch
        {
            ECalculadora.SOMA => Soma(n1,n2),
            ECalculadora.DIVISAO => Divisao(n1, n2),
            ECalculadora.SUBTRACAO => Subtracao(n1, n2),
            ECalculadora.MULTIPLICACAO => Multiplicacao(n1, n2),
            _ => throw new NotImplementedException("Este elemento não foi implementado"),
        };

    public static float Soma(float n1, float n2) => n1 + n2;
    public static float Divisao(float n1, float n2) => n1 / n2;
    public static float Subtracao(float n1, float n2) => n1 - n2;
    public static float Multiplicacao(float n1, float n2) => n1 * n2;
}