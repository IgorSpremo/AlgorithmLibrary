using System;
using System.Collections.Generic;
using AlgorithmLibrary.JobSchedulingAlgorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmLibrary.Util;
using AlgorithmLibrary.Graph.GraphRepresentations.AdjacencyListGraphRepresentation;
using AlgorithmLibrary.Graph;
using AlgorithmLibrary.GraphSearch;

namespace AlgorithmsUnitTestsApplication
{
    [TestClass]
    public class JobSchedulingUnitTest
    {
        #region Prepairment methods

        private AdjacencyListGraph PrepareDirectedGraph()
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

        private AdjacencyListGraph PrepareUndirectedGraph()
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

        #region Test methods

        [TestMethod]
        public void Scheduling3JobsTest()
        {
            List<Job> actual = new List<Job>(3);

            Job job1 = new Job() { Weight = 1, Lenght = 3 };
            Job job2 = new Job() { Weight = 2, Lenght = 2 };
            Job job3 = new Job() { Weight = 3, Lenght = 1 };

            actual.Add(job3);
            actual.Add(job1);
            actual.Add(job2);

            actual.Sort();

            List<Job> expected = new List<Job>(3);
            expected.Add(job1);
            expected.Add(job2);
            expected.Add(job3);

            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void BfsUndirectedGraphTest()
        {
            AdjacencyListGraph graph = PrepareUndirectedGraph();
            HashSet<Node>.Enumerator graphEnumerator = graph.Nodes.GetEnumerator();

            graphEnumerator.MoveNext();
            Node startingNode = graphEnumerator.Current;

            List<Node> expected = new List<Node>(8);
            Node[] nodes = new Node[8];

            for (int i = 0; i < 8; i++)
            {
                nodes[i] = new Node();
                nodes[i].Id = (i + 1).ToString();
            }

            expected.Add(nodes[0]);
            expected.Add(nodes[5]);
            expected.Add(nodes[3]);
            expected.Add(nodes[1]);
            expected.Add(nodes[6]);
            expected.Add(nodes[4]);
            expected.Add(nodes[2]);
            expected.Add(nodes[7]);

            List<Node> actual = GraphSearch.BFS(graph, startingNode);
            
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void BfsDirectedGraphTest()
        {
            AdjacencyListGraph graph = PrepareDirectedGraph();
            HashSet<Node>.Enumerator graphEnumerator = graph.Nodes.GetEnumerator();

            graphEnumerator.MoveNext();
            Node startingNode = graphEnumerator.Current;

            List<Node> expected = new List<Node>(8);
            Node[] nodes = new Node[8];

            for (int i = 0; i < 8; i++)
            {
                nodes[i] = new Node();
                nodes[i].Id = (i + 1).ToString();
            }

            expected.Add(nodes[0]);
            expected.Add(nodes[5]);
            expected.Add(nodes[3]);
            expected.Add(nodes[1]);
            expected.Add(nodes[6]);
            expected.Add(nodes[4]);
            expected.Add(nodes[7]);

            List<Node> actual = GraphSearch.BFS(graph, startingNode);

            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void RecursiveDfsUndirectedGraphTest()
        {
            AdjacencyListGraph graph = PrepareUndirectedGraph();
            HashSet<Node>.Enumerator graphEnumerator = graph.Nodes.GetEnumerator();

            graphEnumerator.MoveNext();
            Node startingNode = graphEnumerator.Current;

            List<Node> expected = new List<Node>(8);
            Node[] nodes = new Node[8];

            for (int i = 0; i < 8; i++)
            {
                nodes[i] = new Node();
                nodes[i].Id = (i + 1).ToString();
            }

            expected.Add(nodes[0]);
            expected.Add(nodes[5]);
            expected.Add(nodes[3]);
            expected.Add(nodes[1]);
            expected.Add(nodes[6]);
            expected.Add(nodes[4]);
            expected.Add(nodes[2]);
            expected.Add(nodes[7]);

            List<Node> actual = GraphSearch.RecursiveDFS(graph, startingNode);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NonRecursiveDfsUndirectedGraphTest()
        {
            AdjacencyListGraph graph = PrepareUndirectedGraph();
            HashSet<Node>.Enumerator graphEnumerator = graph.Nodes.GetEnumerator();

            graphEnumerator.MoveNext();
            Node startingNode = graphEnumerator.Current;

            List<Node> expected = new List<Node>(8);
            Node[] nodes = new Node[8];

            for (int i = 0; i < 8; i++)
            {
                nodes[i] = new Node();
                nodes[i].Id = (i + 1).ToString();
            }

            expected.Add(nodes[0]);
            expected.Add(nodes[1]);
            expected.Add(nodes[4]);
            expected.Add(nodes[7]);
            expected.Add(nodes[2]);
            expected.Add(nodes[6]);
            expected.Add(nodes[3]);
            expected.Add(nodes[5]);

            List<Node> actual = GraphSearch.NonRecursiveDFS(graph, startingNode);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RecursiveDfsDirectedGraphTest()
        {
            AdjacencyListGraph graph = PrepareDirectedGraph();
            HashSet<Node>.Enumerator graphEnumerator = graph.Nodes.GetEnumerator();

            graphEnumerator.MoveNext();
            Node startingNode = graphEnumerator.Current;

            List<Node> expected = new List<Node>(8);
            Node[] nodes = new Node[8];

            for (int i = 0; i < 8; i++)
            {
                nodes[i] = new Node();
                nodes[i].Id = (i + 1).ToString();
            }

            expected.Add(nodes[0]);
            expected.Add(nodes[5]);
            expected.Add(nodes[6]);
            expected.Add(nodes[3]);
            expected.Add(nodes[4]);
            expected.Add(nodes[7]);
            expected.Add(nodes[1]);

            List<Node> actual = GraphSearch.RecursiveDFS(graph, startingNode);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NonRecursiveDfsDirectedGraphTest()
        {
            AdjacencyListGraph graph = PrepareDirectedGraph();
            HashSet<Node>.Enumerator graphEnumerator = graph.Nodes.GetEnumerator();

            graphEnumerator.MoveNext();
            Node startingNode = graphEnumerator.Current;

            List<Node> expected = new List<Node>(8);
            Node[] nodes = new Node[8];

            for (int i = 0; i < 8; i++)
            {
                nodes[i] = new Node();
                nodes[i].Id = (i + 1).ToString();
            }

            expected.Add(nodes[0]);
            expected.Add(nodes[1]);
            expected.Add(nodes[4]);
            expected.Add(nodes[7]);
            expected.Add(nodes[6]);
            expected.Add(nodes[3]);
            expected.Add(nodes[5]);

            List<Node> actual = GraphSearch.NonRecursiveDFS(graph, startingNode);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindConnectedComponentsTest()
        {

            AdjacencyListGraph graph1 = PrepareUndirectedGraph();
            AdjacencyListGraph graph2 = PrepareUndirectedGraph();
            AdjacencyListGraph graph3 = PrepareUndirectedGraph();

            List<AdjacencyListGraph> graphs = new List<AdjacencyListGraph>(3);
            graphs.Add(graph1);
            graphs.Add(graph2);
            graphs.Add(graph3);

            HashSet<Node>.Enumerator graph1Enumerator = graph1.Nodes.GetEnumerator();
            graph1Enumerator.MoveNext();
            Node startingNode1 = graph1Enumerator.Current;

            HashSet<Node>.Enumerator graph2Enumerator = graph2.Nodes.GetEnumerator();
            graph2Enumerator.MoveNext();
            Node startingNode2 = graph2Enumerator.Current;

            HashSet<Node>.Enumerator graph3Enumerator = graph3.Nodes.GetEnumerator();
            graph3Enumerator.MoveNext();
            Node startingNode3 = graph3Enumerator.Current;


            List<List<Node>> expectedValue = new List<List<Node>>(3);
            expectedValue.Add(GraphSearch.BFS(graph1, startingNode1));
            expectedValue.Add(GraphSearch.BFS(graph2, startingNode2));
            expectedValue.Add(GraphSearch.BFS(graph3, startingNode3));

            List<List<Node>> actualValue = GraphSearch.FindConnectedComponentsInUnirectedGraph(graphs);

            CollectionAssert.AreEquivalent(expectedValue, actualValue);
        }

        #endregion

    }
}
