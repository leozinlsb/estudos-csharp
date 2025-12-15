class Produto
{
    public int Codigo;
    public string Nome;

    private float _preco;
    private int _estoque;

    public float Preco
    {
        get { return _preco; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Valor negativo, não válido!");
            }
            else
            {
                _preco = value; 
            }
        }
    }

    public int Estoque
    {
        get { return _estoque; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Estoque negativo, não válido!");
            }
            else
            {
                _estoque = value;
            }
        }
    }
    public void ExibirDados()
    {
        Console.WriteLine($"Código do produto : {Codigo}");
        Console.WriteLine($"Nome do produto : {Nome}");
        Console.WriteLine($"Preço do produto : {Preco}");
        Console.WriteLine($"Estoque do produto : {Estoque}");
        Console.WriteLine("----------------------------------");
    }
}

class program
{
       static void Main()
    {
        Produto produto = new Produto();

        produto.Codigo = 01;

        produto.Nome = "Teclado Mecanico";

        produto.Preco = 150.64f;

        produto.Estoque = 15;

        produto.ExibirDados();

        Produto produto1 = new Produto();

        produto1.Codigo = 02;

        produto1.Nome = "Mouse Gamer";

        produto1.Preco = -80.99f;

        produto1.Estoque = -10;

        produto1.ExibirDados();
    }

}