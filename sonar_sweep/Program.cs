using System;

namespace sonar_sweep
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Advent of Code 2021 - Day 1, Sonar Sweep");
            // Load in all the values (input.txt).
            string[] values = System.IO.File.ReadAllLines("input.txt");
            // Create a 'depth' by adding the first value of the input file in a variable.
            var depth = int.Parse(values[0]);
            // Create a counter variable.
            int counter = 0;

            // Loop through all the values of the list.
            for (int i = 1; i < values.Length; i++)
            {
                // If a value is greather than the depth value, the value of counter will increase by 1.
                if (int.Parse(values[i]) > depth) counter++;
                // Make sure that depth is updated with the latest value that was worked with.
                depth = int.Parse(values[i]);
            }
            Console.WriteLine("The answer is {0}!", counter);
        }
    }
}
