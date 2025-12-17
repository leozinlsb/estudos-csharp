namespace BancoApp
{
    public class Conta
    {
        protected double saldo;

        public double Saldo
        {
            get { return saldo; }
        }

        public Conta()
        {
            this.saldo = 0;
        }

        public virtual void LancarCredito(double valor)
        {
            if (valor > 0)
            {
                this.saldo += valor;
                Console.WriteLine($"Crédito de {valor:C} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Valor inválido. O crédito deve ser positivo.");
            }
        }

        public virtual void LancarDebito(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor inválido. O débito deve ser positivo.");
                return;
            }
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
                Console.WriteLine($"Débito de {valor:C} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o débito.");
            }
        }

        public virtual void LancarTransferencia(Conta contaDestino,double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor inválido. A transferência deve ser positiva.");
                return;
            }

            if (this.saldo >= valor)
            {
                this.saldo -= valor;
                contaDestino.saldo += valor;
                Console.WriteLine($"Transferência de {valor:C} realizada com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar a transferência.");
            }
        }

        public double CalcularSaldo()
        {
            return this.Saldo;
        }
    }

    public class ContaCorrente : Conta
    {
    }

    public class ContaInvestimento : Conta
    {
    }

    public class Program
    {
        private static ContaCorrente minhaCC = new ContaCorrente();
        private static ContaInvestimento minhaCI = new ContaInvestimento();

        public static void Main(string[] args)
        {
            bool executando = true;
            while (executando)
            {Console.WriteLine("1. Lançar Crédito (Conta Corrente)");
                Console.WriteLine("2. Lançar Débito (Conta Corrente)");
                Console.WriteLine("3. Lançar Crédito (Conta Investimento)");
                Console.WriteLine("4. Lançar Débito (Conta Investimento)");
                Console.WriteLine("5. Transferir (CC -> CI)");
                Console.WriteLine("6. Transferir (CI -> CC)");
                Console.WriteLine("7. Ver Saldos");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        LancarCredito(minhaCC);
                        break;
                    case "2":
                        LancarDebito(minhaCC);
                        break;
                    case "3":
                        LancarCredito(minhaCI);
                        break;
                    case "4":
                        LancarDebito(minhaCI);
                        break;
                    case "5":
                        LancarTransferencia(minhaCC, minhaCI);
                        break;
                    case "6":
                        LancarTransferencia(minhaCI, minhaCC);
                        break;
                    case "7":
                        VerSaldos();
                        break;
                    case "0":
                        executando = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        private static double LerValor()
        {
            double valor;
            Console.Write("Digite o valor: ");
            while (!double.TryParse(Console.ReadLine(), out valor))
            {
                Console.WriteLine("Entrada inválida. Digite um número (ex: 50,25): ");
            }
            return valor;
        }

        private static void LancarCredito(Conta conta)
        {
            double valor = LerValor();
            conta.LancarCredito(valor);
            VerSaldos();
        }

        private static void LancarDebito(Conta conta)
        {
            double valor = LerValor();
            conta.LancarDebito(valor);
            VerSaldos();
        }

        private static void LancarTransferencia(Conta origem, Conta destino)
        {
            double valor = LerValor();
            origem.LancarTransferencia(destino, valor);
            VerSaldos();
        }

        private static void VerSaldos()
        {
            Console.WriteLine($"Saldo Conta Corrente: {minhaCC.CalcularSaldo():C}");
            Console.WriteLine($"Saldo Conta Investimento: {minhaCI.CalcularSaldo():C}");
        }
    }
}