using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            Console.Write("Enter your name: ");
            str = Console.ReadLine();
            Console.WriteLine("Welcome, {0}",str);

            int n = new Int32();
            int n2 = new Int32();
            Console.Write("Enter two numbers: ");
            n = Int32.Parse(Console.ReadLine());
            n2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {3}", n, n2, n + n2);

        }
    }
}
