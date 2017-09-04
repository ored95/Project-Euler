using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_02_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number N: ");
            int n = Int32.Parse(Console.ReadLine());

            int A0 = 1, A1 = 1, sum = 0;
            while (A1 < n)
            {
                A1 = A1 + A0;
                A0 = A1 - A0;

                if (A0 % 2 == 0)
                    sum += A0;
            }

            Console.Write("Total sum is {0}", sum);
            Console.ReadLine();
        }
    }
}
