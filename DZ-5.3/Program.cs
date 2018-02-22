using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Четные или нечетные между данными");
            Console.WriteLine();
            int a = int.Parse(Console.ReadLine());
           
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for(int x = 0; a < b; a++)
            {
                if (a % 2 == 0)
                {
                    Console.Write($"{a}  четные между числа  {a} и {b}         ");
                }
                else if (a % 2 != 0)
                {
                    Console.WriteLine($"       {a}  нечетные между числами  {a} и {b}");
                }
            
            }
            Console.ReadKey();
            
        }
    }
}
