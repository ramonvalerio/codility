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
            var solution = new DemoTask01();
            var A = new int[] { 1, 3, 6, 4, 1, 2 };

            // Act
            var result = solution.solution3(A);
            var expected = 5;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Case2()
        {
            // Arrange
            var solution = new DemoTask01();
            var A = new int[] { 1, 2, 3 };

            // Act
            var result = solution.solution3(A);
            var expected = 4;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Case3()
        {
            // Arrange
            var solution = new DemoTask01();
            var A = new int[] { -1, -3 };

            // Act
            var result = solution.solution3(A);
            var expected = 1;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Case4()
        {
            // Arrange
            var solution = new DemoTask01();
            var A = new int[] { 9, 3, 9, 3, 9, 7, 9 };

            // Act
            var result = solution.solution3(A);
            var expected = 7;

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
