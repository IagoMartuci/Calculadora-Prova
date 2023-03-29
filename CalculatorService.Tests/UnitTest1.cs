namespace CalculatorService.Tests;

public class DivisaoTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void DividirDoisNumerosPositivos()
    {
        double a = 10;
        double b = 3;

        double resultado = calc.Divisao(a, b);

        Assert.Equal(3.3333333333333335, resultado);
    }

    [Fact]
    public void DividirNumeroPositivoComNumeroNegativo()
    {
        double a = 10;
        double b = -3;

        double resultado = calc.Divisao(a, b);

        Assert.Equal(-3.3333333333333335, resultado);
    }

    [Fact]
    public void DividirDoisNumerosNegativos()
    {
        double a = -10;
        double b = -4;

        double resultado = calc.Divisao(a, b);

        Assert.Equal(2.5, resultado);
    }

    [Fact]
    public void DividirPorZero()
    {
        double a = 10;
        double b = 0;

        double resultado = calc.Divisao(a, b);

        Assert.Equal((double.PositiveInfinity), resultado);
    }

    [Fact]
    public void DividirNegativoPorZero()
    {
        double a = -10;
        double b = 0;

        double resultado = calc.Divisao(a, b);

        Assert.Equal((double.NegativeInfinity), resultado);
    }

    [Fact] // Não deveria dar falha, já que não tem como dividir número com letra?
    public void TestarDivisaoComNaN()
    {
        // Arrange
        double a = 2.0;
        double b = double.NaN;

        // Act
        double resultado = calc.Divisao(a, b);

        // Assert
        Assert.True(double.IsNaN(resultado));
    }
}

public class SomaTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void SomarDoisNumerosPositivos()
    {
        int a = 10;
        int b = 5;

        int resultado = calc.Soma(a, b);

        Assert.Equal(15, resultado);
    }

    [Fact]
    public void SomarNumeroPositivoComNumeroNegativo()
    {
        int a = 5;
        int b = -10;

        int resultado = calc.Soma(a, b);

        Assert.Equal(-5, resultado);
    }

    [Fact]
    public void SomarDoisNumerosNegativos()
    {
        int a = -5;
        int b = -10;

        int resultado = calc.Soma(a, b);

        Assert.Equal(-15, resultado);
    }

    /*[Fact] // Não tem como aplicar o NaN em int
    public void TestarSomaComNaN()
    {
        int a = 10;
        int b = int.NaN;

        int resultado = calc.Soma(a, b);

        Assert.True(int.IsNaN(resultado));
    }*/

    [Fact] // Pq esse teste passa? Não deveria dar falha já que excedeu o tamanho que a variável comporta?
    public void TestarSomaComMaiorNumero()
    {
        int a = int.MaxValue;
        int b = 1;

        Assert.Throws<OverflowException>(() => calc.Soma(a, b));
    }
}

public class SubtracaoTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void SubtrairNumerosPositivos()
    {
        int a = 10;
        int b = 5;

        int resultado = calc.Subtracao(a, b);

        Assert.Equal(5, resultado);
    }

    [Fact]
    public void SubtrairNumeroPositivoComNumeroNegativo()
    {
        int a = 5;
        int b = -10;

        int resultado = calc.Subtracao(a, b);

        Assert.Equal(15, resultado);
    }

    [Fact]
    public void SubtrairDoisNumerosNegativos()
    {
        int a = -5;
        int b = -10;

        int resultado = calc.Subtracao(a, b);

        Assert.Equal(5, resultado);
    }

    /*[Fact] // Não tem como aplicar o NaN em int
    public void TestarSubtracaoComNaN()
    {
        int a = 10;
        int b = int.NaN;

        int resultado = calc.Subtracao(a, b);

        Assert.True(int.IsNaN(resultado));
    }*/

    [Fact] // Pq esse teste passa? Não deveria dar falha já que excedeu o tamanho que a variável comporta?
    public void TestarSubtracaoComMenorNumero()
    {
        int a = int.MinValue;
        int b = 1;

        Assert.Throws<OverflowException>(() => calc.Subtracao(a, b));
    }
}

public class MultiplicacaoTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void MultiplicarNumerosPositivos()
    {
        int a = 10;
        int b = 5;

        int resultado = calc.Multiplicacao(a, b);

        Assert.Equal(50, resultado);
    }

    [Fact]
    public void MultiplicarNumeroPositivoComNumeroNegativo()
    {
        int a = 5;
        int b = -10;

        int resultado = calc.Multiplicacao(a, b);

        Assert.Equal(-50, resultado);
    }

    [Fact]
    public void MultiplicarDoisNumerosNegativos()
    {
        int a = -5;
        int b = -10;

        int resultado = calc.Multiplicacao(a, b);

        Assert.Equal(50, resultado);
    }

    /*[Fact] // Não tem como aplicar o NaN em int
    public void TestarMultiplicacaoComNaN()
    {
        int a = 10;
        int b = int.NaN;

        int resultado = calc.Multiplicacao(a, b);

        Assert.True(int.IsNaN(resultado));
    }*/

    [Fact] // Pq esse teste passa? Não deveria dar falha já que excedeu o tamanho que a variável comporta?
    public void TestarMultiplicacaoComMaiorNumero()
    {
        int a = int.MaxValue;
        int b = 2;

        Assert.Throws<OverflowException>(() => calc.Multiplicacao(a, b));
    }
}

public class MediaTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void CalcularMediaNumerosPositivos()
    {
        double[] m = { 6, 8 };
       
        double resultado = calc.Media(m);

        Assert.Equal(7, resultado);
    }

    [Fact]
    public void CalcularMediaNumeroPositicoComNumeroNegativo()
    {
        double[] m = { 6, -8 };

        double resultado = calc.Media(m);

        Assert.Equal(-1, resultado);
    }

    [Fact]
    public void CalcularMediaDeTresNumerosReais()
    {
        double[] m = { 7.5, 5.75, 3.25 };

        double resultado = calc.Media(m);

        Assert.Equal(5.5, resultado);
    }

    [Fact]
    public void CalcularMediaSemArgumento()
    {
        double[] m = { };

        double resultado = calc.Media(m);

        Assert.Equal(double.NaN, resultado);
    }
}

public class MedianaTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void CalcularMedianaImpar()
    {
        double[] m = { 7, 3, 10 };

        double resultado = calc.Mediana(m);

        Assert.Equal(7, resultado);
    }

    [Fact]
    public void CalcularMedianaPar()
    {
        double[] m = {7, 3, 10, 5 };

        double resultado = calc.Mediana(m);

        Assert.Equal(6, resultado);
    }

    [Fact]
    public void CalcularMedianaConjuntoVazio()
    {
        double[] m = { };

        Assert.Throws<IndexOutOfRangeException>(() => calc.Mediana(m));
    }
}
