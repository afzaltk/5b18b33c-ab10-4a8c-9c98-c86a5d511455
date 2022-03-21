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
            string input = null;

            //Act
            string actualResult = _longestIncreasingSequence.GetLongestIncreasingSequence(input);

            //Assert
            Assert.Null(actualResult);

        }

        [Fact]
        public void GetLongestIncreasingSequence_InputStringContainsSingleNumber_ShouldReturnSingleNumber()
        {
            //Arrange
            string input = "4";
            string expectedResult = "4";

            //Act
            string actualResult = _longestIncreasingSequence.GetLongestIncreasingSequence(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void GetLongestIncreasingSequence_InputStringContainsTwoSameNumbers_ShouldReturnEarliestNumber()
        {
            //Arrange
            string input = "4 4";
            string expectedResult = "4";

            //Act
            string actualResult = _longestIncreasingSequence.GetLongestIncreasingSequence(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData("4 5", "4 5")]
        [InlineData("4 5 7", "4 5 7")]
        [InlineData("4 2 5 7", "2 5 7")]
        [InlineData("4 3 1 2 5 7", "1 2 5 7")]
        public void GetLongestIncreasingSequence_InputStringContainsTwoNumbersinIncreasingOrder_ShouldReturnBothNumbers(string input, string expectedResult)
        {
            //Act
            string actualResult = _longestIncreasingSequence.GetLongestIncreasingSequence(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
