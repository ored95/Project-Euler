using System;
using System.Text;

namespace Euler_01_Sharp
{
    class Program
    {
        static bool check_number(int number)
        {
            return (number % 3 == 0) || (number % 5 == 0);
        }

        static void Main(string[] args)
        {
            Console.Write("Input number N: ");
            int n = Int32.Parse(Console.ReadLine());

            int sum = 0;
            for (int j = 3; j < n; j++)
            {
                if (check_number(j))
                    sum += j;
            }

            Console.Write("Total sum is {0}", sum);
            Console.ReadLine();
        }
    }
}
