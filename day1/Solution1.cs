using System;
using System.Collections;
using System.Collections.Immutable;
using System.Linq;

namespace aoc2020.day1
{
    public static class  Day1Solver
    {
        
        public static int Solution1(string[] input)
        {
            var inputNumbers = input.Select(int.Parse).ToArray();
            var numbersBits = new BitArray(2020, false);
            var inverseNumberBits = new BitArray(2020, false);
            
            for (int i = 0; i < inputNumbers.Length - 1 ; i++)
            {
                numbersBits.Set(inputNumbers[i], true);
                inverseNumberBits.Set(2020 - inputNumbers[i], true);
            }

            var result =  numbersBits.And(inverseNumberBits);
            
            var solutionIndex = GetTrueIndex(result);


            return solutionIndex * (2020 - solutionIndex);

        }

        private static int GetTrueIndex(BitArray arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr.Get(i)) return i;
            }

            return -1;
        }
    }
}