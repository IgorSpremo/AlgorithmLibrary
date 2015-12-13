using AlgorithmLibrary.Graph;
using AlgorithmLibrary.Graph.GraphRepresentations.AdjacencyListGraphRepresentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLibrary.MinimumCut
{
    /// <summary>
    /// Class used for computing the minimum cut of the given graph.
    /// </summary>
    public class RadndomContractionAlgorithm
    {

        //public AdjacencyListGraph[] ComputeMinimumCut(AdjacencyListGraph graph)
        //{
        //    AdjacencyListGraph clonedGraph = graph.Clone() as AdjacencyListGraph;
        //    AdjacencyListGraph[] retVal = new AdjacencyListGraph[2];

        //    int numberOfIterations = (int) Math.Pow(clonedGraph.Nodes.Count, 2);

        //    // TODO: Implement the method
        //    throw new NotImplementedException();
        //    //return retVal;
        //}

        //protected AdjacencyListGraph[] ExractGraphPartitions(AdjacencyListGraph graph)
        //{
        //    AdjacencyListGraph clonedGraph = graph.Clone() as AdjacencyListGraph;
        //    AdjacencyListGraph[] retVal = new AdjacencyListGraph[2];
            
        //    var edgeEnumerator = clonedGraph.Edges.GetEnumerator();
        //    var nodeEnumerator = clonedGraph.Nodes.GetEnumerator();

        //    int numberOfEdges = clonedGraph.Edges.Count;

        //    LinkedList<Node> firstFusedNodes = new LinkedList<Node>();
        //    LinkedList<Node> secondFusedNodes = new LinkedList<Node>();

        //    foreach (Node n in clonedGraph.Nodes)
        //    {
        //        secondFusedNodes.AddLast(n.Clone() as Node);
        //    }

        //    while (true)
        //    {
        //        if (--numberOfEdges <= 2)
        //            break;

        //        Edge currentEdge = edgeEnumerator.Current;

        //        Node currentNode1;
        //        Node currentNode2;

        //        if (clonedGraph.TryFindNodeById(currentEdge.FirstNodeId, out currentNode1))
        //        {
        //            firstFusedNodes.AddLast(currentNode1);
        //        }

        //        if (clonedGraph.TryFindNodeById(currentEdge.SecondNodeId, out currentNode2))
        //        {
        //            firstFusedNodes.AddLast(currentNode2);
        //        }

        //        secondFusedNodes.Remove(currentNode1);
        //        secondFusedNodes.Remove(currentNode2);
        //    }

        //    return retVal;
        //}

    }
}
