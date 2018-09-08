using System;

namespace Codility.Implementations.Lesson3
{
    public class FrogJmp
    {
        public int solution(int X, int Y, int D)
        {
            if (X == Y)
                return 0;

            int count = 0;

            while (X < Y)
            {
                X += D;
                count++;
            }

            return count;
        }

        public int solution2(int X, int Y, int D)
        {
            double totalDistance = Y - X;
            double stepLengthFloating = D;

            return (int)Math.Ceiling(totalDistance / stepLengthFloating);
        }
    }
}