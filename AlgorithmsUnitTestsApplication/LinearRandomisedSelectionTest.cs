using AlgorithmLibrary.LinearSelection;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsUnitTestsApplication
{
    [TestFixture]

    public class LinearRandomisedSelectionTest
    {
        [Test]
        public void FindFirstElementTest()
        {
            // TODO: Check what's wrong here...
            double[] array = { 1.0f, 4.2f, 2.1f, 3.9f, 0.534f };

            LinearRandomisedSelection<double> linearRandomisedSelection = new LinearRandomisedSelection<double>();

            double actual = linearRandomisedSelection.Find(array, 1);
            double expected = 1.0f;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindSecondElementTest()
        {
            // TODO: Check what's wrong here...
            double[] array = { 1.0f, 4.2f, 2.1f, 3.9f, 0.534f };

            LinearRandomisedSelection<double> linearRandomisedSelection = new LinearRandomisedSelection<double>();

            double actual = linearRandomisedSelection.Find(array, 2);
            double expected = 4.2f;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindThirdElementTest()
        {
            // TODO: Check what's wrong here...
            double[] array = { 1.0f, 4.2f, 2.1f, 3.9f, 0.534f };

            LinearRandomisedSelection<double> linearRandomisedSelection = new LinearRandomisedSelection<double>();

            double actual = linearRandomisedSelection.Find(array, 3);
            double expected = 2.1f;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindFourthElementTest()
        {
            // TODO: Check what's wrong here...
            double[] array = { 1.0f, 4.2f, 2.1f, 3.9f, 0.534f };

            LinearRandomisedSelection<double> linearRandomisedSelection = new LinearRandomisedSelection<double>();

            double actual = linearRandomisedSelection.Find(array, 4);
            double expected = 3.9f;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindFifthElementTest()
        {
            // TODO: Check what's wrong here...
            double[] array = { 1.0f, 4.2f, 2.1f, 3.9f, 0.534f };

            LinearRandomisedSelection<double> linearRandomisedSelection = new LinearRandomisedSelection<double>();

            double actual = linearRandomisedSelection.Find(array, 5);
            double expected = 0.534f;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindElementAtPositionZeroTest()
        {
            float[] array = { 1.0f, 4.2f, 2.1f, 3.9f, 0.534f };

            LinearRandomisedSelection<float> linearRandomisedSelection = new LinearRandomisedSelection<float>();

            Assert.Throws(typeof(ArgumentException), () => linearRandomisedSelection.Find(array, 0));
        }

        [Test]
        public void FindElementInNullArrayTest()
        {
            float[] array = null;

            LinearRandomisedSelection<float> linearRandomisedSelection = new LinearRandomisedSelection<float>();

            Assert.Throws(typeof(ArgumentNullException), () => linearRandomisedSelection.Find(array, 0));
        }
    }
}
