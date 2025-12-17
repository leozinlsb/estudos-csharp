class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro valor");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o terceiro valor");
        int c = int.Parse(Console.ReadLine());

        float Maiorvalor = a;
        
        if (b > Maiorvalor)
        {
            Maiorvalor = b;
        }
        else if (c > Maiorvalor)
        {
            Maiorvalor = c;
        }

        float Menorvalor = a;

        if (b < Menorvalor)
        {
            Menorvalor = b;
        }
        else if (c < Menorvalor)
        {
            Menorvalor = c;
        }
        
        Console.WriteLine("O Maior valor é : {0}", Maiorvalor);
        Console.WriteLine("O Menor valor é : {0}", Menorvalor);
    }
}