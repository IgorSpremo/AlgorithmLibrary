using AlgorithmLibrary.UnionFind;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsUnitTestsApplication.CollectionsTests
{

    [TestFixture]
    public class WeightedQuickUnionFindTest
    {

        [Test]
        public void ConstructorTest()
        {
            var unionFind = new WeightedQuickUnionFind(10);

            Assert.IsNotNull(unionFind);

        }

        [Test]
        public void UnionTest()
        {
            var unionFind = new WeightedQuickUnionFind(10);

            unionFind.Union(0, 1);
            unionFind.Union(2, 1);
            unionFind.Union(2, 3);

            int expectedId = 0;

            int actualId0 = unionFind.Id[0];
            int actualId1 = unionFind.Id[1];
            int actualId2 = unionFind.Id[2];
            int actualId3 = unionFind.Id[3];

            Assert.AreEqual(expectedId, actualId0);
            Assert.AreEqual(expectedId, actualId1);
            Assert.AreEqual(expectedId, actualId2);
            Assert.AreEqual(expectedId, actualId3);

        }

        [Test]
        public void ConnectedTest()
        {
            var unionFind = new WeightedQuickUnionFind(10);

            unionFind.Union(0, 1);
            unionFind.Union(2, 1);
            unionFind.Union(2, 3);

            Assert.IsTrue(unionFind.Connected(0, 3));
            Assert.IsFalse(unionFind.Connected(0, 5));
        }


    }
}
