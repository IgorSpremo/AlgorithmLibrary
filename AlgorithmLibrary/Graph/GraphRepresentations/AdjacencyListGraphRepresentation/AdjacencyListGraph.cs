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

        public Dictionary<string, Node> Nodes { get; set; }

        public HashSet<Edge> Edges { get; set; }

        public bool IsDirected
        {
            get
            {
                if (Edges != null)
                {
                    if (Edges.Count > 0)
                    {
                        return Edges.First().IsDirected;
                    }

                    throw new ArgumentException("There are no edges in this graph!");
                }

                throw new ArgumentNullException("Edges collection is null!");
            }
        }

        #endregion

        #region Constructors

        public AdjacencyListGraph()
        {
            Nodes = new Dictionary<string, Node>();
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
            if (node == null || Nodes.ContainsKey(node.Id))
            {
                return false;
            }
            else
            {
                Nodes.Add(node.Id, node);
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
            return Nodes.Remove(nodeToRemove.Id);
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
            return Nodes.ContainsKey(node.Id);
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

            Dictionary<string, Node> clonedNodes = new Dictionary<string, Node>();
            foreach (Node n in Nodes.Values)
            {
                clonedNodes.Add(n.Id.Clone() as string, n.Clone() as Node);
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

            if (Nodes.ContainsKey(nodeId))
            {
                nodeToFind = Nodes[nodeId];
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("AdjacencyListGraph:");
            strBuilder.Append(Environment.NewLine);
            strBuilder.Append(Environment.NewLine);

            strBuilder.Append("Nodes:");
            strBuilder.Append(Environment.NewLine);

            foreach (Node n in Nodes.Values)
            {
                strBuilder.Append(n.Id);
                strBuilder.Append(" ");
            }

            strBuilder.Append(Environment.NewLine);
            strBuilder.Append(Environment.NewLine);

            strBuilder.Append("Edges:");
            strBuilder.Append(Environment.NewLine);

            foreach (Edge e in Edges)
            {
                strBuilder.Append(e.Id);
                strBuilder.Append(" ");
            }

            strBuilder.Append(Environment.NewLine);
            strBuilder.Append(Environment.NewLine);

            return strBuilder.ToString();
        }

        #endregion

    }
}
