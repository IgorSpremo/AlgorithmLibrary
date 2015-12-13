using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLibrary.Graph
{
    public class AdjacencyGraphWithParallelEdges : AdjacencyMatrixGraph
    {
        
        /// <summary>
        /// The matrix of type ulong that represents the graph elements (Nodes) and the Edges between them.
        /// The matrix is of size N x N, where is N the number of Nodes.
        /// Each number in matrix represents the number of Edges between two Nodes.
        /// Example: For given graph G, if G[i, j] = 3, that means that there are 3 Edges connecting Nodes that are on 'i' and 'j' positions.
        /// </summary>
        public ulong[,] GraphMatrix { get; set; }


        public AdjacencyGraphWithParallelEdges(int numberOfNodes) : base(numberOfNodes)
        {
            GraphMatrix = new ulong[n, n];
        }

    }
}
