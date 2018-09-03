using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Codility.Implementations.Lesson1
{
    public class BinaryGap
    {
        public int solution(int N)
        {
            // Step 1
            if (N < 1)
                throw new Exception("Number less than one is not valid.");

            // Step 2
            var binaryNumber = new BitArray(new int[] { N });

            // Step 3
            var binariesGap = new List<int>();

            int count = 0;
            bool start = false;

            for (int i = 0; i < binaryNumber.Count; i++)
            {
                if (binaryNumber[i])
                {
                    if (!start)
                    {
                        start = true;
                        continue;
                    }
                    else
                    {
                        binariesGap.Add(count);
                        count = 0;
                        continue;
                    }
                }

                if (start)
                    count++;
            }

            if (binariesGap.Count > 0)
                return binariesGap.Max();
            else
                return 0;
        }
    }
}