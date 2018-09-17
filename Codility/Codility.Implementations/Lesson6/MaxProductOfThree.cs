using System;
using System.Linq;

namespace Codility.Implementations.Lesson6
{
    public class MaxProductOfThree
    {
        public int solution(int[] A)
        {
            if (A.Length < 3)
                throw new Exception("Invalid argument");

            Array.Sort(A);

            return A.Max();
        }
    }
}
