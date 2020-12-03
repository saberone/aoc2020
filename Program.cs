using System;
using aoc2020.day1;

namespace aoc2020
{
    class Program
    {
        static void Main(string[] args)
        {
            var content =  InputFileReader.ReadFileAsLines(1, 1);
            Console.WriteLine($"Day 1 Solution 1:{Day1Solver.Solution1(content)}");

            Console.ReadLine();
        }
    }
}
