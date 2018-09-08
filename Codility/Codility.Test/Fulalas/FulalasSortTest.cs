using Codility.Implementations.Fulalas;
using Xunit;

namespace Codility.Test.Fulalas
{
    public class FulalasSortTest
    {
        [Fact]
        public void Case1()
        {
            // Arrange
            var algorithm = new FulalasSort();
            var A = new int[] { 1, 3, 1, 4, 2, 3, 5, 4 };

            // Act
            var result = algorithm.solution(A);
            var expected = false;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Case2()
        {
            // Arrange
            var algorithm = new FulalasSort();
            var A = new int[] { 1, 1, 2, 3, 3, 4, 4, 5 };

            // Act
            var result = algorithm.solution(A);
            var expected = true;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Case3()
        {
            // Arrange
            var algorithm = new FulalasSort();
            var A = new int[] { -2, -3, -1 };

            // Act
            var result = algorithm.solution(A);
            var expected = false;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Case4()
        {
            // Arrange
            var algorithm = new FulalasSort();
            var A = new int[] { -4, -4, -3, -2, -1, -1 };

            // Act
            var result = algorithm.solution(A);
            var expected = true;

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
