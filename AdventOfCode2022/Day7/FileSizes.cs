using System;
using System.Text.RegularExpressions;

namespace AdventOfCode2022.Day7
{
    public class FileSizes
    {
        public int CalculateTheTotalOfFileSizes(string text)
        {
            // Make a dictionary of all the folders name which appear as "cd {name}"
            IDictionary<int, string> directories = new Dictionary<int, string>();
            var key = 0;

            var splitText = text.Split("\n");
            foreach (var command in splitText)
            {
                // Need to find a way to only pick up cd {name}??
                if (command.Contains("$ cd") &&!directories.ContainsKey(key))
                {
                    directories.Add(key, command);
                    key++;
                }
                else if (command.Contains("$ cd"))
                {
                    // how to find existing one in dictionary??
                    directories[key] += command;
                }
            }
            Console.WriteLine("here");

            //var count = 0;
            //var splitText = text.Split("\n");

            //var groupedList = new List<string>();

            //for (int i = 0; i < text.Length; i++)
            //{
            //    var charToString = splitText[i].ToString();

            //    if (charToString == "$ ls")
            //    {
            //        directories[key] += int.Parse(item);
            //        //count++;
            //    }
            //}
            // loop through all
            // needs to be oer 100,000 to be able to go towards count
            return 0;
        }
    }
}

// find each "dir" and push name in Dictionary

//If following loops don't contain dir or cd ..

// dir - name of the folder
// cd .. - comes out of the current folder
// ls - looks into the folder
// cd {folder} - going into folder

//a
    // x

    // v
