using System.IO;

namespace aoc2020
{
    public static class InputFileReader
    {
        public static string[] ReadFileAsLines(int day, int entry)
        {
            string basePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            string inputFilePath = Path.Combine(basePath, $"day{day}/input{entry}.txt");
            
            var inputContent = File.ReadAllLines(inputFilePath);

            return inputContent;
        }
    }
}