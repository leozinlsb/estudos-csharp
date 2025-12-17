class Program
{
    static void Main(string[] args)
    {
        int valor, unidade, dinheiro;
        float troco, faltam;

        do
        {
            Console.WriteLine("Digite o valor unitário do produto :");
            valor = int.Parse(Console.ReadLine());
        } while (valor <= 0);

        do
        {
            Console.WriteLine("Digite a quantidade comprada do produto :");
            unidade = int.Parse(Console.ReadLine());
        } while (unidade <= 0);

        valor = valor * unidade;

        do
        {
            Console.WriteLine("Digite o dinheiro recebido :");
            dinheiro = int.Parse(Console.ReadLine());

            if (dinheiro < valor)
            {
                faltam = valor - dinheiro;

                Console.WriteLine($"Faltam {faltam} para completar");
            }
            else if (dinheiro >= valor)
            {
                troco = dinheiro - valor;

                Console.WriteLine($"Troco a ser devolvido : {troco}");
            }
        } while (dinheiro <= 0);
    }
}