class Empresa
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }

    public virtual void ImprimirDados()
    {
        Console.WriteLine($"Nome : {Nome}");
        Console.WriteLine($"Local : {Endereco}, {Cidade}-{Estado}");
    }
}

class Restaurante : Empresa
{
    public string TipoComida { get; set; }
    public double PrecoMedio { get; set; }

    public override void ImprimirDados()
    {
        base.ImprimirDados();
        Console.WriteLine($"Tipo de Comida : {TipoComida}");
        Console.WriteLine($"Preço Médio : {PrecoMedio}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o Nome da Empresa :");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite o Endereço da Empresa :");
        string endereco = Console.ReadLine();

        Console.WriteLine("Digite a Cidade da Empresa :");
        string cidade = Console.ReadLine();

        Console.WriteLine("Digite o Estado da Empresa :");
        string estado = Console.ReadLine();

        Console.WriteLine("Digite o tipo de comida :");
        string tipo = Console.ReadLine();

        Console.WriteLine("Digite o preço médio :");
        double precomedio = double.Parse(Console.ReadLine());

        Console.Clear();

        Restaurante restaurante = new Restaurante
        {
            Nome = nome,
            Endereco = endereco,
            Cidade = cidade,
            Estado = estado,
            TipoComida = tipo,
            PrecoMedio = precomedio
        };

        restaurante.ImprimirDados();

        Console.ReadKey();

    }
}

class program
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de itens que o cliente vai pedir :");
        int qtd = int.Parse(Console.ReadLine());

        float total = 0;

        for (int i = 1; i <= qtd; i++)
        {
            Console.WriteLine($"Digite o nome do {i}º item :");
            string nome = Console.ReadLine();
            Console.WriteLine($"Digite o valor do {i}º item :");
            float valor = float.Parse(Console.ReadLine());

            total += valor;
        }

        Console.WriteLine("O cliente possui cupom de desconto? (s/n) :");
        string resposta = Console.ReadLine().ToUpper();

        bool cadastrado = (resposta == "S");

        if (cadastrado)
        {
            double valorFinal = total - (total * 0.10);

            Console.WriteLine($"Valor a pagar: {valorFinal:C}");
        }
        else
        {
            Console.WriteLine($"Valor a pagar: {total:C}");
        }
    }
}
