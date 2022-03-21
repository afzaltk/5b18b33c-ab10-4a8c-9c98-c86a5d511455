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

            var input = inputSequence.Split(" ").Select(int.Parse).ToList();

            return input[0].ToString();
        }
    }
}
