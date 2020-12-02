using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 55;
            Console.WriteLine("Привет, МИР! {0}", x);
            var s = Console.ReadLine();
            Console.WriteLine(s);
            int a;
            int.TryParse(s, out a);

            var b = a * 3;
            Console.WriteLine("{0}*3={1}", a, b);
            Console.ReadKey();
        }
        
    }
}
