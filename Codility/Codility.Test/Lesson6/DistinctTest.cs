using Codility.Implementations.Lesson6;
using Xunit;

namespace Codility.Test.Lesson6
{
    public class DistinctTest
    {
        [Fact]
        public void Case01()
        {
            // Arrange
            var algorithm = new Distinct();
            var A = new int[] { 2, 1, 1, 2, 3, 1 };

            // Act
            var result = algorithm.solution(A);
            var expected = 3;

            // Assert
            Assert.Equal(expected, result);
        }
    }
}