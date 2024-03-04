using System;

namespace Problem1
{
    class PascalCaseVariableName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few words separated by space:");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            string variableName = "";

            foreach (string word in words)
            {
                variableName += char.ToUpper(word[0]) + word.Substring(1).ToLower();
            }

            Console.WriteLine("PascalCase variable name: " + variableName);
        }
    }
}
