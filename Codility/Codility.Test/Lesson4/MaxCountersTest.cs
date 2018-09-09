using Codility.Implementations.Lesson4;
using Xunit;

namespace Codility.Test.Lesson4
{
    public class MaxCountersTest
    {
        [Fact]
        public void Case01()
        {
            // Arrange
            var algorithm = new MaxCounters();
            int N = 5;
            var A = new int[] { 3, 4, 4, 6, 1, 4, 4 };

            // Act
            var result = algorithm.solution(N, A);
            var expected = new int[]{ 3, 2, 2, 4, 2 };

            // Assert
            Assert.Equal(expected, result);
        }
    }
}