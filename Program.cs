using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            double Celsius;
            double Fahrenheit = 32;

            Console.ForegroundColor = ConsoleColor.DarkRed;
        
    
            Console.Write("Digite seu valor em Celsius: ");
            Celsius = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkYellow;
          
          
            Fahrenheit = Celsius * 1.8 + 32;
            Console.WriteLine("Celsius para Fahrenheit = {0}", Fahrenheit);
            Console.Write("\n");

            Console.WriteLine("Pressione ENTER para Sair!");
            Console.ReadKey();
        }
    }
}
