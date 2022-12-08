using AdventOfCode2022.Day1;
using AdventOfCode2022.Day2;
using AdventOfCode2022.Day4;
using AdventOfCode2022.Day6;
using AdventOfCode2022.Day7;

namespace AdventOfCode2022
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string caloriesText = File.ReadAllText(@"calories.txt");
            string gameText = File.ReadAllText(@"game.txt");
            string overlapText = File.ReadAllText(@"overlaps.txt");
            string characterText = File.ReadAllText(@"characters.txt");
            string fileSizeText = File.ReadAllText(@"fileSizes.txt");

            var day1 = new CalorieCounting();
            Console.WriteLine($"Day 1 - {day1.CalculateMaxCalorie(caloriesText)}");

            var day2 = new Game();
            Console.WriteLine($"Day 2 - {day2.TotalScore(gameText)}");

            var day4 = new Overlaps();
            Console.WriteLine($"Day 4 - {day4.CalculateOverlaps(overlapText)}");

            var day6 = new Characters();
            Console.WriteLine($"Day 6 - {day6.CalculateNoDuplicateCharacters(characterText)}");

            var day7 = new FileSizes();
            Console.WriteLine($"Day 7 - {day7.CalculateTheTotalOfFileSizes(fileSizeText)}");
        }
    }
}