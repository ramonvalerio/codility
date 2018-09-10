using Codility.Implementations.DemoTask;
using Xunit;

namespace Codility.Test.DemoTask
{
    public class DemoTask01Test
    {
        [Fact]
        public void Case1()
        {
            // Arrange
            var algorithm = new DemoTask01();
            var A = new int[] { 1, 3, 6, 4, 1, 2 };

            // Act
            var result = algorithm.solution(A);
            var expected = 5;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Case2()
        {
            // Arrange
            var algorithm = new DemoTask01();
            var A = new int[] { 1, 2, 3 };

            // Act
            var result = algorithm.solution(A);
            var expected = 4;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Case3()
        {
            // Arrange
            var algorithm = new DemoTask01();
            var A = new int[] { -1, -3 };

            // Act
            var result = algorithm.solution(A);
            var expected = 1;

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
