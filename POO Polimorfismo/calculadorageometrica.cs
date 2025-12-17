class CalculadoraDeArea
{
    public double CalculoArea(double raio)
    {
        return Math.PI * Math.Pow(raio, 2);
    }
    public double CalculoArea(double a, double h)
    {
        return a * h;
    }
    public double CalculoArea(double a, double b, double c)
    {
        double s = (a + b + c) / 2.0;
        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        return area;
    }
    public int CalculoArea(int lado)
    {
        return lado * lado;
    }
}
class program
{
    static void Main()
    {
        CalculadoraDeArea calc = new CalculadoraDeArea();
        double calculocirculo = calc.CalculoArea(30.0);
        double calculoret = calc.CalculoArea(10, 5);
        double calculotri = calc.CalculoArea(10, 5, 15);
        double calculoquad = calc.CalculoArea(10);
        Console.WriteLine($"Círculo : {calculocirculo}; Retângulo : {calculoret}; Triângulo: {calculotri}; Quadrado:{calculoquad}");
    }
}