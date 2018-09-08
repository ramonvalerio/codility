using Codility.Implementations.Lesson4;
using Xunit;

namespace Codility.Test.Lesson4
{
    public class FrogRiverOneTest
    {
        [Fact]
        public void Case1()
        {
            // Arrange
            var algorithm = new FrogRiverOne();
            int X = 5;
            var A = new int[] { 1, 3, 1, 4, 2, 3, 5, 4 };

            // Act
            var result = algorithm.solution(X, A);

            // Assert
            var expected = 6;

            Assert.Equal(expected, result);
        }
    }
}