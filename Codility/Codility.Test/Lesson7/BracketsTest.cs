using Codility.Implementations.Lesson7;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Codility.Test.Lesson7
{
    public class BracketsTest
    {
        [Fact]
        public void Case1()
        {
            // Arrange
            var S = "{[()()]}";
            var aaa = new Brackets();

            // Act
            var result = aaa.solution(S);

            // Assert
            var expected = 1;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Case2()
        {
            // Arrange
            var S = "{[()([]}";
            var aaa = new Brackets();

            // Act
            var result = aaa.solution(S);

            // Assert
            var expected = 0;

            Assert.Equal(expected, result);
        }
    }
}
