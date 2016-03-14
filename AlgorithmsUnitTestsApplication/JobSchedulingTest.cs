using AlgorithmLibrary.JobSchedulingAlgorithm;
using NUnit.Framework;
using System.Collections.Generic;

namespace AlgorithmsUnitTestsApplication
{
    [TestFixture]
    public class JobSchedulingTest
    {

        [Test]
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
    }
}
