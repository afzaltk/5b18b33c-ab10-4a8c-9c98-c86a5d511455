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
            Assert.Equal(actualResult, expectedResult);
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
            Assert.Equal(actualResult, expectedResult);
        }
    }
}
