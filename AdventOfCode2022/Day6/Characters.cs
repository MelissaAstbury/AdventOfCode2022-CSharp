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

                if(groupedText.Count == 5)
                {
                    groupedText.Remove(groupedText[0]);

                    var nonDuplcates = groupedText.GroupBy(x => x).Where(j => j.Count() == 1).Select(j => j.Key).ToList();
                    if (nonDuplcates.Count == 4)
                    {
                        Console.WriteLine(nonDuplcates);
                        return result = i + 1;
                    }
                }
            }
                return result;
        }

        //4092
    }
};