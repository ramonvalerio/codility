using Codility.Implementations.Lesson2;
using Xunit;

namespace Codility.Test.Lesson2
{
    public class OddOccurrencesInArrayTest
    {
        [Fact]
        public void Case1()
        {
            // Arrange
            var arrayInput = new int[] { 0, 3, 9 };
            var algorithm = new OddOccurrencesInArray();

            // Act
            var result = algorithm.solution(arrayInput);

            // Assert
            var expected = 7;

            Assert.Equal(expected, result);
        }
    }
}