class program
{
    class Investimento
    {
        private double capital;
        private double taxaMensal;
        public Investimento(double capitalInicial, double taxaPercentual)
        {
            capital = capitalInicial;
            taxaMensal = taxaPercentual / 100.0;
        }
        public double CalcularMontante(int meses)
        {
            return capital * Math.Pow(1 + taxaMensal, meses);
        }
        public void MostrarEvolucao(int meses)
        {
            Console.WriteLine("Evolução do Investimento");
            for (int mes = 1; mes <= meses; mes++)
            {
                double montante = CalcularMontante(mes);
                Console.WriteLine($"Mês {mes}: R$ {montante:F2}");
            }
        }
    }
    static void Main()
    {
        Console.Write("Digite o valor do capital investido: ");
        double capital = double.Parse(Console.ReadLine());
        Console.Write("Digite a taxa de juros mensais (em %): ");
        double taxa = double.Parse(Console.ReadLine());
        Investimento inv = new Investimento(capital, taxa);
        inv.MostrarEvolucao(12);
    }
}