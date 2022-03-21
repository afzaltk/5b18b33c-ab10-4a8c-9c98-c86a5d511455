using CodingTestKmart;
using System;
using Xunit;

namespace CodingTestKmartUnitTests
{
    public class LongIncreasingSequenceTests
    {
        private readonly LongestIncreasingSequence _longestIncreasingSequence = new();

        [Fact]
        public void GetLongestIncreasingSequence_InputStringIsNull_ShouldReturnNull()
        {
            //Arrange
            String input = null;

            //Act
            String actualResult = _longestIncreasingSequence.GetLongestIncreasingSequence(input);

            //Assert
            Assert.Null(actualResult);

        }
    }
}
