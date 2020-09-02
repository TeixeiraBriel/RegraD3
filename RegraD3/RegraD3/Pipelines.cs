using PipeliningLibrary;
using RegraD3.Pipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraD3
{
    public class Pipelines : PipelineGroup
    {
        public Pipelines()
        {
            Pipeline("CalculoRegraD3")
                .Pipe<CalculoRegraD3>();
        }
    }
}

