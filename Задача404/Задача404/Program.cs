using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача404
{
    class Program
    {
        public static void Sum()
        {
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("........ \nShow all arrays with three-digit number");
            int sum = 0;
            int count = 0;
            int[] array = new int[51];
            if (k < array.Length)
            {
                for (int i = k; i < array.Length; ++i)
                {
                    array[i] = i + 1;
                    sum = array.Sum();
                    if (sum.ToString().Length == 3)
                    {
                        if (sum % 2 == 0)
                        {
                            Console.WriteLine(sum);
                            count++;
                        }

                    }
                }
                Console.WriteLine("The amount in the array is {0}", sum);
                Console.WriteLine("The count is: {0}", count);

            }
            else
            {
                Console.WriteLine("Parameter k is greater than 50");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for K parameter: ");
            Sum();

            Console.WriteLine("....................");

            Console.ReadKey(true);
        }
    }
}
