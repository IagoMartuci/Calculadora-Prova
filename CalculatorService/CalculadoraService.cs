namespace CalculatorService;
public class CalculadoraService
{
    public int Soma(int a, int b)
    {
        return a + b;
    }

    public int Subtracao(int a, int b)
    {
        return a - b;
    }

    public int Multiplicacao(int a, int b)
    {
        return a * b;
    }

    public double Divisao(double a, double b)
    {
        return a / b;
    }
    public double Media(params double[] valores)
    {
        double soma = 0;
        foreach (double valor in valores) // Percorre o Array valores até o fim e atribui o "valor" do índice ref. a cada volta na variável valor
        {
            soma += valor; // soma = soma + valor
        }
        return soma / valores.Length; // Quando o foreach termina de percorrer Array, ele retorna a soma de todos os valores dividido pelo "tamanho" do array de valores
    }

    public double Mediana(params double[] valores)
    {
        Array.Sort(valores); // Ordena o Array em ordem crescente (Reverse para decrescente)
        int tamanho = valores.Length;
        if (tamanho % 2 == 0) // Par
        {
            // Se for par pega os 2 itens do meio e faz a média
            return (valores[tamanho / 2 - 1] + valores[tamanho / 2]) / 2;
        }
        else // Impar
        {
            // Se for impar paga apenas o item do meio e não faz média
            return valores[tamanho / 2];
        }
    }

    public double Derivada(Func<double, double> funcao, double x, double dx = 1e-6)
    {
        double f1 = funcao(x);
        double f2 = funcao(x + dx);
        return (f2 - f1) / dx;
    }

    public double Integral(Func<double, double> funcao, double a, double b, int n = 1000)
    {
        double h = (b - a) / n;
        double soma = 0;
        for (int i = 0; i < n; i++)
        {
            double x = a + i * h;
            soma += funcao(x);
        }
        return soma * h;
    }
}
