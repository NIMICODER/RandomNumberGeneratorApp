using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list to store the generated numbers
        List<int> generatedNumbers = new List<int>();

        // Generate a random number
        Random random = new Random();
       start: Console.WriteLine("Press Enter to Generate new number.");
        Console.ReadLine();
        int randomNumber = random.Next(1, 27);
        // Check if the number has already been generated
            
        // Add the number to the list of generated numbers
        generatedNumbers.Add(randomNumber);

        // Print the number
        Console.WriteLine(randomNumber);
        goto start;

    }
}
