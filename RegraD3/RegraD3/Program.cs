using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XpandoLibrary;

namespace RegraD3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool novamente = true;
            Pipelines ExecPipeline = new Pipelines();
            while (novamente)
            {
                dynamic x = ExecPipeline["CalculoRegraD3"].RunDetailed(new { }.ToExpando());
                Console.WriteLine(x.Output.resultado);

                Console.WriteLine("Novamente? 0 => Não || 1 => Sim");
                if (Console.ReadLine() == "0")
                {
                    novamente = false;
                }
            }
        }

        static void calcula()
        {
        }
    }
}
