using Codility.Implementations.Lesson3;
using Xunit;

namespace Codility.Test.Lesson3
{
    public class TapeEquilibriumTest
    {
        [Fact]
        public void Case01()
        {
            // Arrange
            var algorithm = new TapeEquilibrium();
            var A = new int[] {3, 1, 2, 4, 3 };

            // Act
            var result = algorithm.solution2(A);

            // Assert
            var expected = 1;

            Assert.Equal(expected, result);
        }
    }
}
