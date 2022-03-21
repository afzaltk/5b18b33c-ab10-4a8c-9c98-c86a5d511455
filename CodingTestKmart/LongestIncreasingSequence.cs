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
            var longestSequence = new List<int> {
                inputNumbers[0] };
            var temporarySequence = new List<int>();
            while (i < inputNumbers.Count - 1)
            {
                var j = i + 1;
                temporarySequence = new List<int>{
                    inputNumbers[i]
                };
                while (j < inputNumbers.Count && inputNumbers[i] < inputNumbers[j])
                {
                    temporarySequence.Add(inputNumbers[j]);
                    j += 1;
                    i += 1;
                }

                if (temporarySequence.Count > longestSequence.Count)
                {
                    longestSequence = temporarySequence;
                }
                i++;
            }

            return string.Join(" ", longestSequence);
        }
    }
}
