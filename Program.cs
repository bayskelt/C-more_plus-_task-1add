using System;

namespace C__more_plus__task_1add
{
    internal class Program
    {
        static int SieveEratosthen(int n)
        {
            bool[] primes = new bool[n + 1];
            Array.Fill(primes, true);
            primes[0] = false;
            primes[1] = false;
            for (int i = 2; i * i <= n; i++)
            {
                if (primes[i])
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }

            int closestPrime = n;
            while (!primes[closestPrime])
            {
                closestPrime--;
            }

            int nextClosestPrime = n;
            while (nextClosestPrime < primes.Length && !primes[nextClosestPrime])
            {
                nextClosestPrime++;
            }

            if (nextClosestPrime - n == n - closestPrime)
            {
                return nextClosestPrime;
            }
            else
            {
                return closestPrime;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введiть будь-яке цiле число, що бiльше 1: ");
            int n = int.Parse(Console.ReadLine());
            int closestNumber = SieveEratosthen(n);
            Console.Write($"Найближче просте число до {n}: {closestNumber}");
        }
    }
}
