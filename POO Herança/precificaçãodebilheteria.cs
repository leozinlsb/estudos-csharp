public class Ingresso
{
    public decimal Valor { get; set; }
    public Ingresso(decimal valor)
    {
        this.Valor = valor;
    }
    public void ImprimeValor()
    {
        Console.WriteLine($"Valor do Ingresso: {this.Valor:C}");
    }
}
public class VIP : Ingresso
{
    public decimal ValorAdicional { get; set; }
    public VIP(decimal valor, decimal valorAdicional) : base(valor)
    {
        this.ValorAdicional = valorAdicional;
    }
    public decimal RetornaValorVIP()
    {
        return this.Valor + this.ValorAdicional;
    }
}
public class Normal : Ingresso
{
    public Normal(decimal valor) : base(valor)
    {
    }
    public void ImprimeTipo()
    {
        Console.WriteLine("Ingresso Normal");
    }
}
public class CamaroteInferior : VIP
{
    public string Localizacao { get; set; }
    public CamaroteInferior(decimal valor, decimal valorAdicional,
   string localizacao)
        : base(valor, valorAdicional)
    {
        this.Localizacao = localizacao;
    }
    public void ImprimeLocalizacao()
    {
        Console.WriteLine($"Localização: {this.Localizacao}");
    }
}
public class CamaroteSuperior : VIP
{
    public decimal AdicionalSuperior { get; set; }
    public CamaroteSuperior(decimal valor, decimal valorAdicional,
   decimal adicionalSuperior)
    : base(valor, valorAdicional)
    {
        this.AdicionalSuperior = adicionalSuperior;
    }
    public decimal RetornaValorTotal()
    {
        return RetornaValorVIP() + this.AdicionalSuperior;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Normal ingressoNormal = new Normal(50.00m);

        ingressoNormal.ImprimeTipo();
        ingressoNormal.ImprimeValor();

        VIP ingressoVIP = new VIP(50.00m, 30.00m);

        Console.WriteLine($"Valor total VIP:{ingressoVIP.RetornaValorVIP()}");

        CamaroteInferior camInf = new CamaroteInferior(50.00m, 30.00m, "Setor A, Fila 5");

        camInf.ImprimeLocalizacao();

        Console.WriteLine($"Valor total Cam. Inferior: {camInf.RetornaValorVIP()}");

        CamaroteSuperior camSup = new CamaroteSuperior(50.00m, 30.00m, 40.00m);

        Console.WriteLine($"Valor total Cam. Superior:{camSup.RetornaValorTotal()}");
    }
}