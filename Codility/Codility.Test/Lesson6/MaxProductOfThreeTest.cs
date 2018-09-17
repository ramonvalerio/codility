using Codility.Implementations.Lesson6;
using Xunit;

namespace Codility.Test.Lesson6
{
    public class MaxProductOfThreeTest
    {
        [Fact]
        public void Case01()
        {
            // Arrange
            var algorithm = new MaxProductOfThree();
            var A = new int[] { -3, 1, 2, -2, 5, 6 };

            // Act
            var result = algorithm.solution(A);
            var expected = 60;

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
