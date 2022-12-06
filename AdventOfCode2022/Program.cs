using AdventOfCode2022.Day1;
using AdventOfCode2022.Day4;
using AdventOfCode2022.Day6;

namespace AdventOfCode2022
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string caloriesText = File.ReadAllText(@"calories.txt");
            string overlapText = File.ReadAllText(@"overlaps.txt");
            string characterText = File.ReadAllText(@"characters.txt");

            var day1 = new CalorieCounting();
            Console.WriteLine($"Day 1 - {day1.CalculateMaxCalorie(caloriesText)}");

            var day4 = new Overlaps();
            Console.WriteLine($"Day 4 - {day4.CalculateOverlaps(overlapText)}");

            var day6 = new Characters();
            Console.WriteLine($"Day 6 - {day6.CalculateNoDuplicateCharacters(characterText)}");
        }
    }
}