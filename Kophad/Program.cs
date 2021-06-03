using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kophad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kophadni kirting: Misol: 2 * x ^ 3 + 2 * x ^ 1 + 4 * x ^ 0", "4 * x ^ 3 + 4 * x ^ 1 + 2 * x ^ 0");
            Console.WriteLine("P(x):");
            string p = Console.ReadLine();
            Console.WriteLine("Q(x):");
            string q = Console.ReadLine();
            Console.WriteLine("Qanday nuqtadagi qiymat hisoblansin");
            int value = int.Parse(Console.ReadLine());
            Kophad re = new Kophad(p,q,value);

            Console.ReadKey();

        }
    }
}
