using System;
namespace AdventOfCode2022.Day2
{
    public class Game
    {
        // PART ONE
        // RULES TO FOLLOW:

        // rocks beats scissors
        // scissors beats paper
        // paper beats rock
        // choose the same is a draw
        // first column is oppenent
        // second colmn is me

        // rock - 1 point - A & X
        // paper - 2 points - B & Y
        // scissors - 3 points - C & Z

        // lose - 0 points
        // draw - 3 points
        // win - 6 points
        public int TotalScore(string text)
        {
            var eachPlay = text.Split("\n");
            var count = 0;

            foreach(var play in eachPlay)
            {
                switch (play)
                {
                    case "A X":
                        count += 4;
                        break;
                    case "A Y":
                        count += 8;
                        break;
                    case "A Z":
                        count += 3;
                        break;
                    case "B X":
                        count += 1;
                        break;
                    case "B Y":
                        count += 5;
                        break;
                    case "B Z":
                        count += 9;
                        break;
                    case "C X":
                        count += 7;
                        break;
                    case "C Y":
                        count += 2;
                        break;
                    case "C Z":
                        count += 6;
                        break;
                }
            }
            // attempt one - 15422 - CORRECT
            return count;
        }
    }
}