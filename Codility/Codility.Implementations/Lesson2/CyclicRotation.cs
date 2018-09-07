namespace Codility.Implementations.Lesson2
{
    public class CyclicRotation
    {
        public int[] solution(int[] A, int K)
        {
            var total = A.Length;
            var result = new int[total];

            for (int x = 0; x < K; x++)
            {
                var lastElement = A[total - 1];

                for (int y = 0; y < total; y++)
                {
                    var index = (y + K) % total;
                    result[index] = A[y];
                }
            }

            return result;
        }
    }
}