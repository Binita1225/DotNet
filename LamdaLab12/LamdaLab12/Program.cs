using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // List of plant names
        List<string> plants = new List<string> { "Azalea", "Bamboo", "Aloe", "Cactus", "Amaryllis", "Geranium" };

        // Using a lambda expression to filter plants starting with "a"
        var result = plants.Where(plant => plant.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();

        // Displaying the result
        Console.WriteLine("Plants starting with 'A':");
        foreach (var plant in result)
        {
            Console.WriteLine(plant);
        }
    }
}
