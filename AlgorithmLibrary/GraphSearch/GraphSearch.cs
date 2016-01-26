using AlgorithmLibrary.Graph;
using AlgorithmLibrary.Graph.GraphRepresentations.AdjacencyListGraphRepresentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLibrary.GraphSearch
{
    public class GraphSearch
    {


        public static List<Node> BFS(AdjacencyListGraph graph, string startingNodeId)
        {
            Node startingNode;

            if (graph.Nodes.TryGetValue(startingNodeId, out startingNode))
            {
                List<Node> retVal = new List<Node>();
                Queue<Node> queue = new Queue<Node>();

                startingNode.Explored = true;
                queue.Enqueue(startingNode);

                while (queue.Any<Node>())
                {
                    Node currentNode = queue.Dequeue();
                    retVal.Add(currentNode);

                    HashSet<string> adjacentNodesOfCurrentNode = currentNode.AdjacentNodes;
                    Node adjacentNode = null;

                    foreach (string adjacentNodeId in adjacentNodesOfCurrentNode)
                    {
                        if (graph.TryFindNodeById(adjacentNodeId, out adjacentNode))
                        {
                            if (!adjacentNode.Explored)
                            {
                                adjacentNode.Explored = true;
                                queue.Enqueue(adjacentNode);
                            }
                        }
                    }
                }

                return retVal;
            }
            else
            {
                return null;
            }
        }

        public static List<Node> NonRecursiveDFS(AdjacencyListGraph graph, string startingNodeId)
        {
            Node startingNode;
            if (graph.Nodes.TryGetValue(startingNodeId, out startingNode))
            { 
                List<Node> retVal = new List<Node>();
                Stack<Node> stack = new Stack<Node>();


                startingNode.Explored = true;
                stack.Push(startingNode);

                while (stack.Any<Node>())
                {
                    Node currentNode = stack.Pop();
                    retVal.Add(currentNode);

                    HashSet<string> adjacentNodesOfCurrentNode = currentNode.AdjacentNodes;
                    Node adjacentNode = null;

                    foreach (string adjacentNodeId in adjacentNodesOfCurrentNode)
                    {
                        if (graph.TryFindNodeById(adjacentNodeId, out adjacentNode))
                        {
                            if (!adjacentNode.Explored)
                            {
                                adjacentNode.Explored = true;
                                stack.Push(adjacentNode);
                            }
                        }
                    }
                }

                return retVal;
            }
            else
            {
                return null;
            }
        }

        public static List<Node> RecursiveDFS(AdjacencyListGraph graph, string startingNodeId)
        {
            Node startingNode;

            if (graph.Nodes.TryGetValue(startingNodeId, out startingNode))
            {
                List<Node> retVal = new List<Node>();

                startingNode.Explored = true;
                retVal.Add(startingNode);

                HashSet<string> adjacentNodesOfCurrentNode = startingNode.AdjacentNodes;

                foreach (string adjacentNodeId in adjacentNodesOfCurrentNode)
                {
                    Node adjacentNode;
                    if (graph.TryFindNodeById(adjacentNodeId, out adjacentNode))
                    {
                        if (!adjacentNode.Explored)
                        {
                            retVal.AddRange(RecursiveDFS(graph, adjacentNode.Id));
                        }
                    }
                }

                return retVal;
            }

            return null;
        }

        /// <summary>
        /// A method used for finding separate connected components (graphs) in a List of AdjacencyListGraphs.
        /// </summary>
        /// <param name="graphs">A List of AdjacencyListGraphs that is to be explored for connected graphs.</param>
        /// <returns>A List of Lists of Nodes that belong to the separated graphs.</returns>
        public static List<List<Node>> FindConnectedComponentsInUnirectedGraph(List<AdjacencyListGraph> graphs)
        {
            List<AdjacencyListGraph> clonedGraphs = new List<AdjacencyListGraph>(graphs.Count);
            foreach (AdjacencyListGraph graph in graphs)
            {
                clonedGraphs.Add(graph.Clone() as AdjacencyListGraph);
            }

            List<List<Node>> retVal = new List<List<Node>>();

            foreach (AdjacencyListGraph graph in clonedGraphs)
            {
                foreach(Node node in graph.Nodes.Values)
                {
                    if (!node.Explored)
                    {
                        retVal.Add(BFS(graph, node.Id));
                    }
                }
            }

            return retVal;
        }

        // TODO: Implement this algorithm.
        public List<Node> DijkstraSearch(AdjacencyListGraph graph)
        {
            throw new NotImplementedException();
        }

    }
}
