using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace цилиндър
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Въведи радиус: ");
            double r = double.Parse(Console.ReadLine());
            Console.Write("Въведи височина: ");
            double h = double.Parse(Console.ReadLine());
            double s = 2 * Math.PI * r * h;
            double S = 2 * Math.PI * r * h+2*Math.PI*Math.Pow(r,2);
            Console.WriteLine("Околната повърхнина е {0} и пълната повърхнина е {1}",s,S);


        }
    }
}
