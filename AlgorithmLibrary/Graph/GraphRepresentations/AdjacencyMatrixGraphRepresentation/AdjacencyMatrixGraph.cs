using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLibrary.Graph
{
    public abstract class AdjacencyMatrixGraph
    {

        protected int n;

        public AdjacencyMatrixGraph(int numberOfNodes)
        {
            n = numberOfNodes;
        }

    }
}
