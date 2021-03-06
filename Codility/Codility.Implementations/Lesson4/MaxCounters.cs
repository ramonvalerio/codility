﻿using System.Linq;

namespace Codility.Implementations.Lesson4
{
    public class MaxCounters
    {
        public int[] solution(int N, int[] A)
        {
            int[] counters = Enumerable.Repeat(0, N).ToArray();

            for (int x = 0; x < N; x++)
            {
                int counter = 0;

                for (int k = 0; k < A.Length; k++)
                {
                    if (A[k] <= 1 && A[k] <= N)
                    {
                        A[k] = A[k] + 1;
                    }
                    else
                    {
                        break;
                    }
                }

                counters[x] = counter;
            }

            return counters;
        }
    }
}