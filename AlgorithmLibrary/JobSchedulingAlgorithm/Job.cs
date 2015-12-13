using System;

namespace AlgorithmLibrary.JobSchedulingAlgorithm
{
    public class Job : IComparable
    {

        public double Weight { get; set; }

        public double Lenght { get; set; }


        public int CompareTo(object obj)
        {
            if (obj is Job)
            {
                Job other = obj as Job;

                double otherRation = other.Weight / other.Lenght;
                double thisRatio = Weight / Lenght;

                int retVal = 0;

                if (otherRation > thisRatio)
                {
                    retVal = -1;
                }
                else if (otherRation < thisRatio)
                {
                    retVal = 1;
                }

                return retVal;
            }

            throw new Exception("Wrong argument type.");
        }
    }
}
