using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisorUntilInputToOne
{
    class Program
    {
        static long GCD(long num1, int num2)
        {
            long gcd = 1;

            for (int j = 2; num1 >= j && num2 >= j; j++)
            {
                if (num1 % j == 0 && num2 % j == 0)
                {
                    num1 /= j;
                    num2 /= j;
                    gcd *= j;
                    j = 1;
                }
            }
            return gcd;
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter your number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            long result = 1;
            long gcd = 1;

            if (num == 0)
                result = 0;
            else
            {
                for (int i = 2; i <= num; i++)
                {
                    gcd = GCD(result, i);
                    if (gcd == 1)
                    {
                        result *= i;
                    }
                    else
                    {
                        result *= (i / gcd);
                    }
                }
            }

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
