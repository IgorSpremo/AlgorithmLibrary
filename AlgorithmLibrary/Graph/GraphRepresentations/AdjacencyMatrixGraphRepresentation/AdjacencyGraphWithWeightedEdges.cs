using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLibrary.Graph
{
    public class AdjacencyGraphWithWeightedEdges : AdjacencyMatrixGraph
    {
        
        /// <summary>
        /// The matrix of type double that represents the graph elements (Nodes) and the Edges between them.
        /// The matrix is of size N x N, where is N the number of Nodes.
        /// Each number in matrix represents the weight of Edge between two Nodes.
        /// Example: For given graph G, if G[i, j] = 2.3, that means that there is an Edge of weight 2.3 connecting Nodes that are on 'i' and 'j' positions.
        /// </summary>
        public double[,] GraphMatrix { get; set; }


        public AdjacencyGraphWithWeightedEdges(int numberOfNodes) : base(numberOfNodes)
        {
            GraphMatrix = new double[n, n];
        }

    }
}
