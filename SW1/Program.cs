using System;
using System.Collections.Generic;   
using System.Linq;                  
using System.Text;                  
using System.Threading.Tasks;      

namespace SW1
{
    class Program
    {
        static bool IsPrime(int num)
        {
            if (num <= 1) return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        static (double Peso, double Yen) ConvertCurrency(double dollar)
        {
            double peso = dollar * 57.17;
            double yen = dollar * 146.67;
            return (peso, yen);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine() ?? "";
            string[] numbers = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                int num = int.Parse(numbers[i]);
                bool prime = IsPrime(num);
                Console.WriteLine($"{i + 1}. {num}  {(prime ? "Prime" : "Composite")}");
            }

            Console.Write("\nEnter currency in ($): ");
            string curInput = Console.ReadLine() ?? "";
            string[] dollars = curInput.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("\nDollar($)\tPhil Peso(P)\tJpn Yen (Y)");
            foreach (string d in dollars)
            {
                double dollar = double.Parse(d);

                var result = ConvertCurrency(dollar);

                Console.WriteLine(dollar);
            }

            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
