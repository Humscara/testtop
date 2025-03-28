public class Calculator
{
    public int Add(int a, int b) => a + b;

    public int Subtract(int a, int b) => a - b;

    // Реализация умножения
    public int Multiply(int a, int b) => a * b;

    // Реализация деления
    public double Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Нельзя на ноль делить");
        }
        return (double)a / b;
    }

    // Реализация возведения в степень
    public double Power(double a, double b) => Math.Pow(a, b);
}
