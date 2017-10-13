using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Numbers;

namespace Testing
{
    class Testing
    {
        static void Main(string[] args)
        {
            //test pi digits
            Console.WriteLine(NumbersOperator.FindPiToNthDigit(10));
            
            //test fibonacci on position
            Console.WriteLine(NumbersOperator.FibonacciNumber(3));
            
            //test fibonacci sequence
            int[] fibonacci = NumbersOperator.FibonacciSequence(20);
            foreach (int num in fibonacci)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            //test PrimeList
            List<int> primes = NumbersOperator.GeneratePrimes(20);
            foreach (int num in primes)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
