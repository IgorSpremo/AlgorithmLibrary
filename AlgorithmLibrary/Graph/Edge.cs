using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLibrary.Graph
{
    public class Edge : ICloneable
    {

        #region Properties

        public string FirstNodeId { get; set; }

        public string SecondNodeId { get; set; }

        public string Id { get; set; }

        public bool IsDirected { get; private set; }

        public double Weight { get; set; }

        #endregion

        #region Constructors

        public Edge(string firstNodeId, string secondNodeId, string id, bool directed, double weight)
        {
            FirstNodeId = firstNodeId;
            SecondNodeId = secondNodeId;

            Id = id;

            IsDirected = directed;
            Weight = weight;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            bool retVal = Id.Equals((obj as Edge).Id);

            return retVal;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public object Clone()
        {
            Edge clonedEdge = new Edge(FirstNodeId.Clone() as string,
                                        SecondNodeId.Clone() as string, 
                                        Id,
                                        IsDirected, 
                                        Weight);

            return clonedEdge;
        }

        #endregion

    }
}
