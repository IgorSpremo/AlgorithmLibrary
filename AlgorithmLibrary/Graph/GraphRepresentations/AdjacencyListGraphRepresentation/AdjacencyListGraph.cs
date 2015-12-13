using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLibrary.Graph.GraphRepresentations.AdjacencyListGraphRepresentation
{
    public class AdjacencyListGraph : ICloneable
    {

        #region Properties

        public HashSet<Node> Nodes { get; set; }

        public HashSet<Edge> Edges { get; set; }

        #endregion

        #region Constructors

        public AdjacencyListGraph()
        {
            Nodes = new HashSet<Node>();
            Edges = new HashSet<Edge>();
        }

        #endregion

        #region Methods

        #region Nodes methods

        /// <summary>
        /// Adds the 'node' to the end of Nodes list if it is not NULL or already in the list.
        /// </summary>
        /// <param name="node">The Node to add to the list.</param>
        /// <returns>TRUE if the Node is added to the list; FALSE otherwise.</returns>
        public bool AddNode(Node node)
        {
            if (node == null || Nodes.Contains(node))
            {
                return false;
            }
            else
            {
                Nodes.Add(node);
                return true;
            }
        }

        /// <summary>
        /// Removes the given Node if it is in the list and returns true. Otherwise returns false.
        /// </summary>
        /// <param name="nodeToRemove">The exact Node object to remove.</param>
        /// <returns>TRUE if given Node is in the list and is removed.
        ///          FALSE if given node is not in the list.</returns>
        public bool RemoveNode(Node nodeToRemove)
        {
            return Nodes.Remove(nodeToRemove);
        }

        /// <summary>
        /// Determines whether an element is in the Nodes list.
        /// </summary>
        /// <param name="node">
        ///     The Node to locate in the Nodes list.
        /// </param>
        /// <returns>TRUE if item is found in the Nodes list; otherwise, FALSE.</returns>
        public bool ContainsNode(Node node)
        {
            return Nodes.Contains(node);
        }

        #endregion

        #region Edges methods

        /// <summary>
        /// Adds the 'edge' to the end of Edges list if it is not NULL or already in the list.
        /// </summary>
        /// <param name="edge">The Edge to add to the list.</param>
        /// <returns>TRUE if the Edge is added to the list; FALSE otherwise.</returns>
        public bool AddEdge(Edge edge)
        {
            if (edge == null || Edges.Contains(edge))
            {
                return false;
            }
            else
            {
                Edges.Add(edge);
                return true;
            }
        }

        /// <summary>
        /// Removes the given Edge if it is in the list and returns true. Otherwise returns false.
        /// </summary>
        /// <param name="edgeToRemove">The exact Node object to remove.</param>
        /// <returns>TRUE if given Edge is in the list and is removed.
        ///          FALSE if given node is not in the list.</returns>
        public bool RemoveEdge(Edge edgeToRemove)
        {
            return Edges.Remove(edgeToRemove);
        }

        /// <summary>
        /// Determines whether an element is in the Edge list.
        /// </summary>
        /// <param name="edge">
        ///     The Edge to locate in the Edges list.
        /// </param>
        /// <returns>TRUE if item is found in the Nodes list; otherwise, FALSE.</returns>
        public bool ContainsEdge(Edge edge)
        {
            return Edges.Contains(edge);
        }

        #endregion

        public object Clone()
        {
            AdjacencyListGraph clonedGraph = new AdjacencyListGraph();

            HashSet<Node> clonedNodes = new HashSet<Node>();
            foreach (Node n in Nodes)
            {
                clonedNodes.Add(n.Clone() as Node);
            }

            HashSet<Edge> clonedEdges = new HashSet<Edge>();
            foreach (Edge e in Edges)
            {
                clonedEdges.Add(e.Clone() as Edge);
            }

            clonedGraph.Nodes = clonedNodes;
            clonedGraph.Edges = clonedEdges;

            return clonedGraph;
        }

        /// <summary>
        /// If in the graph is a Node with the given ID, puts that Node in the out parameter 'nodeToBeFound' and returns TRUE.
        /// If there is no such Node in the graph, puts null in the 'nodeToBeFound' and returns FALSE.
        /// </summary>
        /// <param name="nodeId">An ID of the Node to be found in the graph.</param>
        /// <returns>The TRUE if the Node with the given ID if it exists in the graph; FALSE otherwise.</returns>
        public bool TryFindNodeById(string nodeId, out Node nodeToFind)
        {
            nodeToFind = null;
            foreach (Node node in Nodes)
            {
                if (node.Id.Equals(nodeId))
                {
                    nodeToFind = node;
                    return true;
                }
            }

            return false;
        }

        #endregion

    }
}
