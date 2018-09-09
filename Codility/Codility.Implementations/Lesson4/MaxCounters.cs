using System.Linq;

namespace Codility.Implementations.Lesson4
{
    public class MaxCounters
    {
        public int[] solution(int N, int[] A)
        {
            int[] counters = Enumerable.Repeat(0, N).ToArray();

            for (int x = 0; x < N; x++)
            {
                for (int k = 0; k < A.Length; k++)
                {
                    if (A[k] == x && 1 <= x && x <= N)
                    {
                        counters[x] = counters[x] + 1;
                    }
                }
            }

            return counters;
        }
    }
}