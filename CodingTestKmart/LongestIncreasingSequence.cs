using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestKmart
{
    public class LongestIncreasingSequence
    {

        public string GetLongestIncreasingSequence(string inputSequence)
        {
            if (string.IsNullOrEmpty(inputSequence))
            {
                return null;
            }

            var inputNumbers = inputSequence.Split(" ").Select(int.Parse).ToList();

            var i = 0;
            var longestSequence = inputNumbers;

            while (i < inputNumbers.Count - 1)
            {
                if (inputNumbers[i + 1] == inputNumbers[i])
                {
                    longestSequence = new List<int> {
                        inputNumbers[i]
                    };
                }
                i++;
            }

            return string.Join(" ", longestSequence);
        }
    }
}
