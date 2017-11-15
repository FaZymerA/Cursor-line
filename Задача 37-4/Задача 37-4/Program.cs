using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_37_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool s = true;
            bool t = false;
            Console.WriteLine(!(s && t) && s || !t);
           
            
        }
    }
}
