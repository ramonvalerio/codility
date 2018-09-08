using Codility.Implementations.Lesson4;
using Xunit;

namespace Codility.Test.Lesson4
{
    public class PermCheckTest
    {
        [Fact]
        public void Case1()
        {
            // Arrange
            var algorithm = new PermCheck();
            var A = new int[] { 4, 1, 3, 2 };

            // Act
            var result = algorithm.solution(A);

            // Assert
            var expected = 1;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Case2()
        {
            // Arrange
            var algorithm = new PermCheck();
            var A = new int[] { 4, 1, 3 };

            // Act
            var result = algorithm.solution(A);

            // Assert
            var expected = 0;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Case3()
        {
            // Arrange
            var algorithm = new PermCheck();
            var A = new int[] { 1, 3 };

            // Act
            var result = algorithm.solution(A);

            // Assert
            var expected = 0;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Case4()
        {
            // Arrange
            var algorithm = new PermCheck();
            var A = new int[] { 2, 2 };

            // Act
            var result = algorithm.solution(A);

            // Assert
            var expected = 0;

            Assert.Equal(expected, result);
        }
    }
}