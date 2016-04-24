namespace AlgorithmLibrary.UnionFind
{
    /// <summary>
    /// The WeightedQuickUnionUF class represents a union-find data structure.
    /// It supports the union and find operations, along with methods for determining whether two objects are in the same component and the total number of components.
    /// This implementation uses weighted quick union by size (without path compression).
    /// Initializing a data structure with N objects takes linear time.
    /// Afterwards, union, find, and connected take logarithmic time (in the worst case) and count takes constant time.
    /// </summary>
    public class WeightedQuickUnionFind
    {

        #region Fields

        /// <summary>
        /// IDs of of roots of each element. 
        /// Position in the array is the elements ID and the values is the ID of its root in the tree.
        /// </summary>
        private int[] id;

        /// <summary>
        /// Number of elements in the tree of which the indexed element is a part.
        /// </summary>
        private int[] sz;

        #endregion

        #region Properties

        public int[] Id
        {
            get
            {
                return id;
            }

            private set
            {
                id = value;
            }
        }

        #endregion

        #region Constructors

        public WeightedQuickUnionFind(int n)
        {
            id = new int[n];
            sz = new int[n];

            // We initialize the arrays so that each 
            // element is in its own tree and the tree size is 1.
            for (int i = 0; i < n; i++)
            {
                id[i] = i;
                sz[i] = 1;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Finds the root of the element indexed by <b><i>i</i></b>.
        /// </summary>
        /// <param name="i">elements ID.</param>
        /// <returns>ID of elements root.</returns>
        private int Root(int i)
        {
            // We iterate trough all parent nodes in the 
            // tree while we don't get to the root element.
            while (i != id[i])
            {
                // For every node in the tree we change the root ID by setting its
                // grandparent ID. This flattens the tree and increases algorithm
                // speed.
                id[i] = id[id[i]];

                i = id[i];
            }
            return i;
        }

        /// <summary>
        /// Checks if the two nodes are connected.
        /// </summary>
        /// <param name="p">ID of the first node.</param>
        /// <param name="q">ID of the second node.</param>
        /// <returns>TRUE if the elements are connected and FALSE otherwise.</returns>
        public bool Connected(int p, int q)
        {
            return Root(p) == Root(q);
        }

        /// <summary>
        /// Connects two elements.
        /// </summary>
        /// <param name="p">ID of the first node.</param>
        /// <param name="q">ID of the second node.</param>
        public void Union(int p, int q)
        {
            int i = Root(p);
            int j = Root(q);

            if (i == j)
                return;

            // We make a weight balanced tree by attaching a smaller tree
            // beneath the larger tree.
            if (sz[i] < sz[j])
            {
                id[i] = j;
                sz[j] += sz[i];
            }
            else {
                id[j] = i;
                sz[i] += sz[j];
            }
        }

        #endregion

    }
}
