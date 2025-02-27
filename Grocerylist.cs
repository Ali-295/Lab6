using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // List of grocery items
        List<string> groceryItems = new List<string>
        {
            "Milk",
            "Bread",
            "Eggs",
            "Apples",
            "Rice"
        };

        // Displaying grocery list
        Console.WriteLine("Grocery List:");
        foreach (string item in groceryItems)
        {
            Console.WriteLine("- " + item);
        }
    }
}
