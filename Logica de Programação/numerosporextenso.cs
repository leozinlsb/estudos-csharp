class Program
{
    static void Main(string[] args)
    {
        int num;

        do
        {
            Console.WriteLine("Digite um número inteiro de 1 a 10 :");
            num = int.Parse(Console.ReadLine());
        } while (num < 1 || num > 10);

        string resultado = Extenso(num);

        Console.WriteLine(resultado);
    }

    static string Extenso(int num)
    {
        string[] extenso = { "Um", "Dois", "Três", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove", "Dez" };

        return (extenso[num - 1]);

    }
}