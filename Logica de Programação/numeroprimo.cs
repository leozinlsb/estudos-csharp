class Program
{
    static void Main(string[] args)
    {
        int c = 0;
        int num = 2;
        while (c < 20)
        {
            bool primo = true;
            int divisor = 2;
            while (divisor <= Math.Sqrt(num) && primo)
            {
                if (num % divisor == 0)
                {
                    primo = false;
                }

            divisor++;
            }

             if (primo)
            {
                Console.WriteLine(num);
                c++;
            }
         num++;
        }
        Console.ReadKey();
    }
}