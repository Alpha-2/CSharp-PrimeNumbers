using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PrimeNumbers
{
    class Program
    {
        static bool IsPrimeNumber(int number)
        {
            if (number <= 1)
                return false;

            if (number <= 3)
                return true;

            if (number % 2 == 0 || number % 3 == 0)
                return false;

            for (int i = 5; i * i <= number; i += 6)
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;

            return true;
        }

        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                    if (IsPrimeNumber(i))
                        Console.Write(i + " ");
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
