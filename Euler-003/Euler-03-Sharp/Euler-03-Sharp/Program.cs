using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_03_Sharp
{
    class Program
    {
        /// <summary>
        /// Check number is a prime or not
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static bool is_prime(int number)
        {
            if (number == 2)
                return true;

            if (number > 2)
            {
                if (number % 2 == 0)
                    return false;

                int mid = (int)Math.Sqrt(number);
                int j = (mid % 2 == 1) ? mid : (mid + 1);

                for (; j > 1; j -= 2)
                {
                    if (number % j == 0)
                        break;
                }

                if (j == 1)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Using recursion to identify the largest prime factor
        /// </summary>
        /// <param name="n"></param>
        /// <param name="fn"></param>
        static void max_factor(int n, ref int fn)
        {
            if (n == 1)
                return;

            int j = fn + 1;
            for (; j <= n; j++)
                if (n % j == 0)
                    break;
            
            while (n % j == 0)
                n /= j;
            
            fn = j;
            max_factor(n, ref fn);
        }

        static void Main(string[] args)
        {
            Console.Write("Input number N: ");
            int n = Int32.Parse(Console.ReadLine());

            int fn = 1;
            max_factor(n, ref fn);
            
            Console.Write("The largest prime factor is {0}", fn);
            Console.ReadLine();
        }
    }
}
