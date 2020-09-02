using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraD3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool novamente = true;
            while (novamente)
            {
                calcula();
                Console.WriteLine("Novamente? 0 => Não || 1 => Sim");
                if (Console.ReadLine() == "0")
                {
                    novamente = false;
                }
            }
        }

        static void calcula()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int x = (c * b) / a;
            Console.WriteLine(x);
        }
    }
}
