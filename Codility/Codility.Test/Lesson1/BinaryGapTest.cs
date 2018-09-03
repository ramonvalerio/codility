using Codility.Implementations.Lesson1;
using Xunit;

namespace Codility.Test.Lesson1
{
    public class BinaryGapTest
    {
        private readonly BinaryGap _binaryGap;

        public BinaryGapTest()
        {
            _binaryGap = new BinaryGap();
        }

        [Fact]
        public void Case1()
        {
            // Arrange
            int param = 529;

            // Act
            var result = _binaryGap.solution(param);
            var expected = 4;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Case2()
        {
            // Arrange
            int param = 32;

            // Act
            var result = _binaryGap.solution(param);
            var expected = 0;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Case3()
        {
            // Arrange
            int param = 328;

            // Act
            var result = _binaryGap.solution(param);
            var expected = 2;

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
