using System;
using System.Collections.Generic;

namespace Problem2
{
    class FacebookPostLikes
    {
        static void Main(string[] args)
        {
            List<string> likers = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter a name (Press Enter to finish):");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    break;

                likers.Add(input);
            }

            int count = likers.Count;
            if (count == 0)
                Console.WriteLine("No one likes your post.");
            else if (count == 1)
                Console.WriteLine($"{likers[0]} likes your post.");
            else if (count == 2)
                Console.WriteLine($"{likers[0]} and {likers[1]} like your post.");
            else
                Console.WriteLine($"{likers[0]}, {likers[1]} and {count - 2} others like your post.");
        }
    }
}
