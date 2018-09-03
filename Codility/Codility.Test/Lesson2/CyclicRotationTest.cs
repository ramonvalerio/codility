using Codility.Implementations.Lesson2;
using Xunit;

namespace Codility.Test
{
    public class CyclicRotationTest
    {
        private readonly CyclicRotation _cyclicRotation;

        public CyclicRotationTest()
        {
            _cyclicRotation = new CyclicRotation();
        }

        [Fact]
        public void Case1()
        {
            // Arrange
            var arrayInput = new int[] { 3, 8, 9, 7, 6 };
            int K = 3;

            // Act
            var result = _cyclicRotation.solution(arrayInput, K);

            // Assert
            var expected = new int[] { 9, 7, 6, 3, 8 };

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Case2()
        {
            // Arrange
            var arrayInput = new int[] { 0, 0, 0 };
            int K = 1;

            // Act
            var result = _cyclicRotation.solution(arrayInput, K);

            // Assert
            var expected = new int[] { 0, 0, 0 };

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Case3()
        {
            // Arrange
            var arrayInput = new int[] { 1, 2, 3, 4 };
            int K = 4;

            // Act
            var result = _cyclicRotation.solution(arrayInput, K);

            // Assert
            var expected = new int[] { 1, 2, 3, 4 };

            Assert.Equal(expected, result);
        }
    }
}
