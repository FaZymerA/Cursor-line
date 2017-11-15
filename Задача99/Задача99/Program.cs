using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача99
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 0;
            decimal positiveLeftToRight = 0;
            decimal negativeLeftToRight = 0;

            for (int i = 1; i <= 100000; i++)
            {
                if (i % 2 == 0)
                {
                    sum -= (decimal)1 / i;
                    negativeLeftToRight -= (decimal)1 / i;
                }
                else
                {
                    sum += (decimal)1 / i;
                    positiveLeftToRight += (decimal)1 / i;
                }
            }
            decimal sum2 = 0;
            decimal positiveRightToLeft = 0;
            decimal negativeRightToLeft = 0;

            for (int i = 100000; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    sum2 -= (decimal)1 / i;
                    negativeRightToLeft -= (decimal)1 / i;
                }
                else
                {
                    sum2 += (decimal)1 / i;
                    positiveRightToLeft += (decimal)1 / i;
                }
            }
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Sum2: " + sum2);
            Console.WriteLine();
            Console.WriteLine("positivLeftToRight: " + positiveLeftToRight);
            Console.WriteLine("negativeLeftToRight: " + negativeLeftToRight);
            Console.WriteLine();
            Console.WriteLine("positivRightToLeft: " + positiveRightToLeft);
            Console.WriteLine("negativeRightToLeft: " + negativeRightToLeft);
            Console.WriteLine();
        }
    }
}
