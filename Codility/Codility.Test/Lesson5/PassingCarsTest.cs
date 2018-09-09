using Codility.Implementations.Lesson5;
using Xunit;

namespace Codility.Test.Lesson5
{
    public class PassingCarsTest
    {
        [Fact]
        public void Case01()
        {
            // Arrange
            var A = new int[] {0, 1, 0, 1, 1};
            var algorithm = new PassingCars();

            // Act
            int result = algorithm.solution(A);

            // Assert
            int expected = 5;
            Assert.Equal(expected, result);

        }
    }
}