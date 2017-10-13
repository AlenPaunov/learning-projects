using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    public class NumbersOperator
    {
        public static string FindPiToNthDigit(int digits)
        {
            digits++;

            uint[] x = new uint[digits * 10 / 3 + 2];
            uint[] r = new uint[digits * 10 / 3 + 2];

            uint[] pi = new uint[digits];

            for (int j = 0; j < x.Length; j++)
                x[j] = 20;

            for (int i = 0; i < digits; i++)
            {
                uint carry = 0;
                for (int j = 0; j < x.Length; j++)
                {
                    uint num = (uint)(x.Length - j - 1);
                    uint dem = num * 2 + 1;

                    x[j] += carry;

                    uint q = x[j] / dem;
                    r[j] = x[j] % dem;

                    carry = q * num;
                }


                pi[i] = (x[x.Length - 1] / 10);


                r[x.Length - 1] = x[x.Length - 1] % 10; ;

                for (int j = 0; j < x.Length; j++)
                    x[j] = r[j] * 10;
            }

            string result = "";

            uint c = 0;

            for (int i = pi.Length - 1; i >= 0; i--)
            {
                pi[i] += c;
                c = pi[i] / 10;

                result = (pi[i] % 10).ToString() + result;
            }

            return result.Insert(1, ".");
        }

        public static int FibonacciNumber(int number)
        {
            int a = 0;
            int b = 1;
            // In inputed steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < number; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        public static int[] FibonacciSequence(int range)
        {
            int[] sequence = new int[1];
            Array.Resize(ref sequence, range);

            sequence[0] = 0;
            sequence[1] = 1;

            for (int i = 2; i < range; i++)
                sequence[i] = sequence[i - 1] + sequence[i - 2];

            return sequence;
        }

        public static List<int> GeneratePrimes(int count)
        {
            List<int> primes = new List<int>
            {
                2
            };
            int nextPrime = 3;
            while (primes.Count < count)
            {
                int sqrt = (int)Math.Sqrt(nextPrime);
                bool isPrime = true;
                for (int i = 0; (int)primes[i] <= sqrt; i++)
                {
                    if (nextPrime % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(nextPrime);
                }
                nextPrime += 2;
            }
            return primes;
        }
    }
}
