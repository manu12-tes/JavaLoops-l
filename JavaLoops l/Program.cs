using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaLoops_l
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dame un numero ");
            int var = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(var + "*" + i + ":" + (var * i));
            }
        }
    }
}
