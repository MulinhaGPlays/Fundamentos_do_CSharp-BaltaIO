using CSharpFundamentals.Library;
using CSharpFundamentals.Library.Enums;

namespace CSharpFundamentals.Tests;

[TestClass]
public class CalculadoraTest
{
    [TestMethod]
    public void MetodoCalcular()
    {
        float resultado = Calculadora.Calcular(1, 1, ECalculadora.SOMA);
        float esperado = 2;
        Assert.AreEqual(esperado, resultado);
    }
    [TestMethod]
    public void MetodoSoma()
    {
        float resultado = Calculadora.Soma(1, 1);
        float esperado = 2;
        Assert.AreEqual(esperado, resultado);
    }
    [TestMethod]
    public void MetodoDivisao()
    {
        float resultado = Calculadora.Divisao(4,2);
        float esperado = 2;
        Assert.AreEqual(esperado, resultado);
    }
    [TestMethod]
    public void MetodoSubtracao()
    {
        float resultado = Calculadora.Subtracao(4,2);
        float esperado = 2;
        Assert.AreEqual(esperado, resultado);
    }
    [TestMethod]
    public void MetodoMultiplicacao()
    {
        float resultado = Calculadora.Multiplicacao(2,5);
        float esperado = 10;
        Assert.AreEqual(esperado, resultado);
    }

}