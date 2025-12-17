using System;

class Program
{
    class Pessoa
    {
        public string nome1;
        public float peso1;
        public float altura1;
        public Pessoa(string nome, float peso, float altura)
        {
            nome1 = nome;
            peso1 = peso;
            altura1 = altura;
        }

        public float calculoIMC()
        {
            return (altura1 * altura1) / peso1;
        }
        public string categoriaIMC()
        {
            double imc = calculoIMC();

            if (imc < 20)
            {
                return "Abaixo do peso";
            }
            else if (imc > 20 && imc <= 25)
            {
                return "Peso normal";
            }
            else if (imc > 25 && imc <= 30)
            {
                return "Sobrepeso";
            }
            else if (imc > 30 && imc <= 35)
            {
                return "Obesidade grau 1";
            }
            else if (imc > 35 && imc <= 40)
            {
                return "Obesidade grau 2";
            }
            else
            {
                return "Obesidade grau 3";
            }
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o seu nome :");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite o seu peso :");
        float peso = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite a sua altura :");
        float altura = float.Parse(Console.ReadLine());

        Pessoa c = new Pessoa(nome, peso, altura);

        Console.WriteLine($"O calculo do seu IMC e : {c.categoriaIMC()}");

        Console.ReadKey();
    }
}