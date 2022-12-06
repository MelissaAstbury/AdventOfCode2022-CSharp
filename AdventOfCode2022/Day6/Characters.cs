using System;
using System.Text.RegularExpressions;

namespace AdventOfCode2022.Day6
{
    public class Characters
    {
        public int CalculateNoDuplicateCharacters(string text)
        {
            var groupedText = new List<string>();
            var result = 0;

            for (int i = 0; i < text.Length; i++)
            {
                var charToString = text[i].ToString();

                groupedText.Add(charToString);

                //part one code should be if(groupedText.Count == 5)
                if (groupedText.Count == 15)
                {
                    groupedText.Remove(groupedText[0]);

                    var nonDuplcates = groupedText.GroupBy(x => x).Where(j => j.Count() == 1).Select(j => j.Key).ToList();
                    //part one code should be if (nonDuplcates.Count == 4)
                    if (nonDuplcates.Count == 14)
                    {
                        Console.WriteLine(nonDuplcates);
                        return result = i + 1;
                    }
                }
            }
                return result;
        }

        // PART ONE
        //4092 - attempt one - WRONG
        //1987 -attempt two - CORRECT

        //PART TWO
        //3059 - attempt one - CORRECT
    }
};