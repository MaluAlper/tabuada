using System;

namespace tabuada
{

    
        
// Using System;

namespace Number
{
	class Program
	{

		public static void Main(string[] args)
		{
            string numero1;
            int numero;
            Console.Write ("Digite um numero: " );
			numero1=Console.ReadLine();
            numero=int.Parse(numero1);
			//Console.ReadKey(true);
	
		
		//public static void tabuada(int numero)
		
			for (int x = 1; x <= 10; x++)
			{
				Console.WriteLine(numero1 + " * " + x + " = " + numero*x);
            }
        }
    }
}
}
			
		
	
