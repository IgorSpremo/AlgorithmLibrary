using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmLibrary.Graph.GraphRepresentations.AdjacencyListGraphRepresentation;

namespace AlgorithmLibrary.Graph
{
    public class Node : ICloneable
    {
        #region Fields

        protected HashSet<Node> adjacentNodes = new HashSet<Node>();

        #endregion

        #region Properties
        
        public string Id { get; set; }

        public bool Explored { get; set; }

        public List<Edge> Edges { get; set; }

        public HashSet<Node> AdjacentNodes
        {
            get
            {
                return adjacentNodes;
            }
        }

        #endregion

        #region Contructors

        public Node()
        {
            Edges = new List<Edge>();
            Explored = false;
        }

        public Node(int numberOfEdges)
        {
            Edges = new List<Edge>(numberOfEdges);
            Explored = false;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds new adjacent Node to this Node by extracting it from the Edge.
        /// </summary>
        /// <param name="graph">A graph in which the Nodes are in.</param>
        /// <param name="edge">An edge containing this Node and the adjacent Node.</param>
        protected void AddNewAdjacentNode(AdjacencyListGraph graph, Edge edge)
        {
            if (adjacentNodes == null)
            {
                adjacentNodes = new HashSet<Node>();
            }

            Node node1;
            Node node2;

            if (graph.TryFindNodeById(edge.FirstNodeId, out node1) &&
                !edge.IsDirected && 
                !adjacentNodes.Contains(node1) && 
                this != node1)
            {
                adjacentNodes.Add(node1);
            }

            if (graph.TryFindNodeById(edge.SecondNodeId, out node2) && 
                !adjacentNodes.Contains(node2) && 
                this != node2)
            {
                adjacentNodes.Add(node2);
            }
        }

        /// <summary>
        /// Adds the newEdge to the list of edges if there isn't
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="newEdge"></param>
        /// <returns></returns>
        public bool AddEdge(AdjacencyListGraph graph, Edge newEdge)
        {
            if (Edges == null)
            {
                Edges = new List<Edge>();
            }

            if (Edges.Contains(newEdge))
                return false;

            Edges.Add(newEdge);
            AddNewAdjacentNode(graph, newEdge);
            
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            bool retVal = Id.Equals((obj as Node).Id);

            return retVal;
        }

        public object Clone()
        {
            Node clonedNode = new Node();

            clonedNode.Id = Id;
            clonedNode.Explored = Explored;

            clonedNode.adjacentNodes = new HashSet<Node>();
            foreach (Node n in adjacentNodes)
            {
                clonedNode.adjacentNodes.Add(n.Clone() as Node);
            }

            clonedNode.Edges = new List<Edge>(Edges.Count);

            foreach (Edge edge in Edges)
            {
                clonedNode.Edges.Add(edge.Clone() as Edge);
            }

            return clonedNode;
        }

        #endregion

    }
}
