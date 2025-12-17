class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o valor da compra :");
        float valorCompra = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantia dada pelo comprador");
        float dinheiro = float.Parse(Console.ReadLine());
        float troco = dinheiro - valorCompra;
        int i;
        float moeda = 0;
        float qtdMoedas = 0;

        for (i = 1; i <= 6; i++)
        {
            qtdMoedas = 0;
            if (i == 1) moeda = 1.00f;
            if (i == 2) moeda = 0.50f;
            if (i == 3) moeda = 0.25f;
            if (i == 4) moeda = 0.10f;
            if (i == 5) moeda = 0.05f;
            if (i == 6) moeda = 0.01f;
            if (troco >= moeda)
            {
                qtdMoedas = (int) (troco/ moeda);
                troco = troco - (qtdMoedas * moeda);
                troco = MathF.Round(troco, 2);
            }

            if (qtdMoedas > 0)
            {
                Console.WriteLine("Serão dadas {0} moedas de {1:C}", qtdMoedas, moeda);
            }
        }
    }
}
