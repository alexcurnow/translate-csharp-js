using System;
using System.Collections.Generic;

namespace insulter
{
    class Program
    {
        static void Main(string[] args)
        {
            // A list of insults, clearly...
            List<string> insults = new List<string>()
            {
                "You look like what morning breath smells like.",
                "If you tried to give me cpr I would probably throw myself back under water",
                "I am not a fan of you",
                "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
                "I'd rather walk than be on the same plane as you",
                "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
                "Do you have to be so...like that?"
            };

            // Initialize an empty list
            List<int> indexes = new List<int>();

            // Generate a random number variable
            Random random = new Random();

            // While the length of our list is less that 3, do the following...
            while (indexes.Count < 3)
            {
                // Generate a random number between 0 and 3
                int candidate = random.Next(3);
                // Check to see if our indexes list does NOT already contain the random numer
                if (!indexes.Contains(candidate))
                {
                    // If it does not, then add it to the indexes list
                    indexes.Add(candidate);
                }
            }

            // Generate a for loop that increments int i for the length of the indexes list
            for (int i = 0; i < indexes.Count; i++)
            {
                //store the value found at each index in the index variable
                int index = indexes[i];

                // Print each result to the console
                Console.WriteLine(insults[index]);
            }

        }
    }
}