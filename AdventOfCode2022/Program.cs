using AdventOfCode2022.Day1;

namespace AdventOfCode2022
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string text = File.ReadAllText(@"calories.txt");

            var day1 = new CalorieCounting();
            Console.WriteLine($"Day 1 - {day1.CalculateMaxCalorie(text)}");
        }
    }
}