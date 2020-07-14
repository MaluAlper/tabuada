using System;

namespace tabuada
{
    class Program
    {
        public static void Main(string[] args)
        {
            string numero1;
            int numero;
            Console.Write("Digite um numero: ");
            numero1 = Console.ReadLine();
            numero = int.Parse(numero1);
            if (numero < 1)
            {
                Console.WriteLine("Informar números inteiros > 0");
                Environment.Exit(-1);
            }

            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine(numero1 + " * " + x + " = " + numero * x);
            }
        }
    }
}
