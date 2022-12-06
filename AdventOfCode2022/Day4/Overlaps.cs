using System.Collections.Generic;

namespace AdventOfCode2022.Day4
{
    public class Overlaps
    {
        // 538
        public int CalculateOverlaps(string text)
        {
            string[] groups = text.Split("\n");

            foreach (var group in groups)
            {
                // "1-3, 4-5"
                var splitPairs = group.Split(",");
                // [0] "1-3"
                // [1] "4-5"
                var valueOne = splitPairs[0];
                var valueTwo = splitPairs[1];
                var answer = NumbersInTheMiddle(valueOne, valueTwo);
            }
                return 0;
        }

        public string NumbersInTheMiddle(string valueOne, string valueTwo)
        {
            var splitValueOne = valueOne.Split("-");
            var splitValueTwo = valueTwo.Split("-");
            int answer1;
            int answer2;

            for (int i = int.Parse(splitValueOne[0]); i <= int.Parse(splitValueOne[1]); i = i + 1)
            {
                answer1 = i;
                Console.WriteLine(i);
            }
            // find nums between 2 nums
            //[...new Set([splitValueOne[0], ..., splitValueOne[1])]
            //var splitValue = valueOne.Split("-");
            //var result1 = int.Parse(splitValue[0]);
            //var result2 = int.Parse(splitValue[1]);
            //for (int i = valueOne; i <= valueOne; i = i + 1)
            return "";
        }
    }
}

