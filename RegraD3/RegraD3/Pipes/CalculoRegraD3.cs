using PipeliningLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraD3.Pipes
{
    public class CalculoRegraD3 : IPipe
    {
        public object Run(dynamic input)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int x = (c * b) / a;
            input.resultado = x;

            return input;
        }
    }
}
