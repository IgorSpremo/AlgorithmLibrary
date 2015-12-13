using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLibrary.Graph
{
    public class AdjacencyGraphWithDirectedEdges : AdjacencyMatrixGraph
    {

        /// <summary>
        /// The matrix of type double that represents the graph elements (Nodes) and the number of Edges between them.
        /// The matrix is of size N x N, where is N the number of Nodes.
        /// Each number in matrix represents the number and the direction of the Edges between two Nodes. 
        /// Negative values represent revers direction, and positive values represent normal direction.
        /// Example: For given graph G, if G[i, j] = -2, that means that there are 2 Edges directed from the Node on position 'j' to the position 'i'.
        /// </summary>
        public long[,] GraphMatrix { get; set; }


        public AdjacencyGraphWithDirectedEdges(int numberOfNodes) : base(numberOfNodes)
        {
            GraphMatrix = new long[n, n];
        }

    }
}
