using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmLibrary.Graph;
using AlgorithmLibrary.Graph.GraphRepresentations.AdjacencyListGraphRepresentation;
using AlgorithmLibrary.Sorting;

namespace AlgorithmLibrary
{
    class Program
    {


        #region Prepairment methods

        private static AdjacencyListGraph PrepareDirectedGraph()
        {
            AdjacencyListGraph graph = new AdjacencyListGraph();

            Node[] nodes = new Node[8];

            for (int i = 0; i < 8; i++)
            {
                nodes[i] = new Node();
                nodes[i].Id = (i + 1).ToString();
                graph.AddNode(nodes[i]);
            }

            Edge e1 = new Edge(nodes[0].Id, nodes[5].Id, "1", true, 0);
            Edge e2 = new Edge(nodes[0].Id, nodes[3].Id, "2", true, 0);
            Edge e3 = new Edge(nodes[0].Id, nodes[1].Id, "3", true, 0);
            Edge e4 = new Edge(nodes[1].Id, nodes[3].Id, "4", true, 0);
            Edge e5 = new Edge(nodes[3].Id, nodes[5].Id, "5", true, 0);
            Edge e6 = new Edge(nodes[3].Id, nodes[6].Id, "6", true, 0);
            Edge e7 = new Edge(nodes[3].Id, nodes[4].Id, "7", true, 0);
            Edge e8 = new Edge(nodes[1].Id, nodes[4].Id, "8", true, 0);
            Edge e9 = new Edge(nodes[4].Id, nodes[6].Id, "9", true, 0);
            Edge e10 = new Edge(nodes[5].Id, nodes[6].Id, "10", true, 0);
            Edge e11 = new Edge(nodes[2].Id, nodes[4].Id, "11", true, 0);
            Edge e12 = new Edge(nodes[4].Id, nodes[7].Id, "12", true, 0);
            Edge e13 = new Edge(nodes[2].Id, nodes[7].Id, "13", true, 0);

            nodes[0].AddEdge(graph, e1);
            nodes[0].AddEdge(graph, e2);
            nodes[0].AddEdge(graph, e3);

            nodes[1].AddEdge(graph, e3);
            nodes[1].AddEdge(graph, e4);
            nodes[1].AddEdge(graph, e8);

            nodes[2].AddEdge(graph, e11);
            nodes[2].AddEdge(graph, e13);

            nodes[3].AddEdge(graph, e2);
            nodes[3].AddEdge(graph, e4);
            nodes[3].AddEdge(graph, e5);
            nodes[3].AddEdge(graph, e6);
            nodes[3].AddEdge(graph, e7);

            nodes[4].AddEdge(graph, e7);
            nodes[4].AddEdge(graph, e8);
            nodes[4].AddEdge(graph, e9);
            nodes[4].AddEdge(graph, e11);
            nodes[4].AddEdge(graph, e12);

            nodes[5].AddEdge(graph, e1);
            nodes[5].AddEdge(graph, e5);
            nodes[5].AddEdge(graph, e10);

            nodes[6].AddEdge(graph, e6);
            nodes[6].AddEdge(graph, e9);
            nodes[6].AddEdge(graph, e10);

            nodes[7].AddEdge(graph, e12);
            nodes[7].AddEdge(graph, e13);


            graph.AddEdge(e1);
            graph.AddEdge(e2);
            graph.AddEdge(e3);
            graph.AddEdge(e4);
            graph.AddEdge(e5);
            graph.AddEdge(e6);
            graph.AddEdge(e7);
            graph.AddEdge(e8);
            graph.AddEdge(e9);
            graph.AddEdge(e10);
            graph.AddEdge(e11);
            graph.AddEdge(e12);
            graph.AddEdge(e13);

            return graph;
        }

        private static AdjacencyListGraph PrepareUndirectedGraph()
        {
            AdjacencyListGraph graph = new AdjacencyListGraph();

            Node[] nodes = new Node[8];

            for (int i = 0; i < 8; i++)
            {
                nodes[i] = new Node();
                nodes[i].Id = (i + 1).ToString();
                graph.AddNode(nodes[i]);
            }

            Edge e1 = new Edge(nodes[0].Id, nodes[5].Id, "1", false, 0);
            Edge e2 = new Edge(nodes[0].Id, nodes[3].Id, "2", false, 0);
            Edge e3 = new Edge(nodes[0].Id, nodes[1].Id, "3", false, 0);
            Edge e4 = new Edge(nodes[1].Id, nodes[3].Id, "4", false, 0);
            Edge e5 = new Edge(nodes[3].Id, nodes[5].Id, "5", false, 0);
            Edge e6 = new Edge(nodes[3].Id, nodes[6].Id, "6", false, 0);
            Edge e7 = new Edge(nodes[3].Id, nodes[4].Id, "7", false, 0);
            Edge e8 = new Edge(nodes[1].Id, nodes[4].Id, "8", false, 0);
            Edge e9 = new Edge(nodes[4].Id, nodes[6].Id, "9", false, 0);
            Edge e10 = new Edge(nodes[5].Id, nodes[6].Id, "10", false, 0);
            Edge e11 = new Edge(nodes[2].Id, nodes[4].Id, "11", false, 0);
            Edge e12 = new Edge(nodes[4].Id, nodes[7].Id, "12", false, 0);
            Edge e13 = new Edge(nodes[2].Id, nodes[7].Id, "13", false, 0);

            nodes[0].AddEdge(graph, e1);
            nodes[0].AddEdge(graph, e2);
            nodes[0].AddEdge(graph, e3);

            nodes[1].AddEdge(graph, e3);
            nodes[1].AddEdge(graph, e4);
            nodes[1].AddEdge(graph, e8);

            nodes[2].AddEdge(graph, e11);
            nodes[2].AddEdge(graph, e13);

            nodes[3].AddEdge(graph, e2);
            nodes[3].AddEdge(graph, e4);
            nodes[3].AddEdge(graph, e5);
            nodes[3].AddEdge(graph, e6);
            nodes[3].AddEdge(graph, e7);

            nodes[4].AddEdge(graph, e7);
            nodes[4].AddEdge(graph, e8);
            nodes[4].AddEdge(graph, e9);
            nodes[4].AddEdge(graph, e11);
            nodes[4].AddEdge(graph, e12);

            nodes[5].AddEdge(graph, e1);
            nodes[5].AddEdge(graph, e5);
            nodes[5].AddEdge(graph, e10);

            nodes[6].AddEdge(graph, e6);
            nodes[6].AddEdge(graph, e9);
            nodes[6].AddEdge(graph, e10);

            nodes[7].AddEdge(graph, e12);
            nodes[7].AddEdge(graph, e13);


            graph.AddEdge(e1);
            graph.AddEdge(e2);
            graph.AddEdge(e3);
            graph.AddEdge(e4);
            graph.AddEdge(e5);
            graph.AddEdge(e6);
            graph.AddEdge(e7);
            graph.AddEdge(e8);
            graph.AddEdge(e9);
            graph.AddEdge(e10);
            graph.AddEdge(e11);
            graph.AddEdge(e12);
            graph.AddEdge(e13);

            return graph;
        }

        #endregion


        static void Main()
        {
            #region Graph algorithms

            #region Preparing graphs

            AdjacencyListGraph g = PrepareDirectedGraph();
            AdjacencyListGraph g1 = PrepareDirectedGraph();
            AdjacencyListGraph g2 = PrepareDirectedGraph();

            AdjacencyListGraph g3 = PrepareUndirectedGraph();
            AdjacencyListGraph g4 = PrepareUndirectedGraph();
            AdjacencyListGraph g5 = PrepareUndirectedGraph();

            #endregion


            #region FindConnectedComponents

            //List<AdjacencyListGraph> graphs1 = new List<AdjacencyListGraph>(3);
            //graphs1.Add(g);
            //graphs1.Add(g1);
            //graphs1.Add(g2);


            //List<AdjacencyListGraph> graphs2 = new List<AdjacencyListGraph>(3);
            //graphs2.Add(g3);
            //graphs2.Add(g4);
            //graphs2.Add(g5);


            //List<List<Node>> result1 = GraphSearch.GraphSearch.FindConnectedComponentsInUnirectedGraph(graphs1);
            //List<List<Node>> result2 = GraphSearch.GraphSearch.FindConnectedComponentsInUnirectedGraph(graphs2);

            #endregion


            #region Graph searches

            //////List<Node> result1 = GraphSearch.GraphSearch.BFS(g, "1");
            //////List<Node> result2 = GraphSearch.GraphSearch.BFS(g3, "1");

            ////List<Node> result1 = GraphSearch.GraphSearch.NonRecursiveDFS(g, "1");
            ////List<Node> result2 = GraphSearch.GraphSearch.NonRecursiveDFS(g3, "1");

            //List<Node> result1 = GraphSearch.GraphSearch.RecursiveDFS(g, "1");
            //List<Node> result2 = GraphSearch.GraphSearch.RecursiveDFS(g3, "1");

            //Console.WriteLine("Directed graph result:");
            //foreach (Node n in result1)
            //{
            //    Console.WriteLine(n.Id);
            //}

            //Console.WriteLine();

            //Console.WriteLine("Undirected graph result:");
            //foreach (Node n in result2)
            //{
            //    Console.WriteLine(n.Id);
            //}

            //Console.WriteLine();

            #endregion

            #endregion


            #region Sorting algorithms

            //using (SorterClass<int> sorter = new SorterClass<int>())
            //{
            //    int[] arrayToBeSorted = { 5, 2, 6, 8, 3, 1, 4, 99, 0, -1, 42, -52, -99 };
            //    int[] sortedArray = sorter.QuickSort(arrayToBeSorted);
            //}

            #endregion


            Console.WriteLine("Application finished executing.");
            Console.ReadKey();
        }
    }
}
