using System;

namespace VariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables Declaration
            string dogName = "Brisket";
            int dogAge = 4;
            bool cuteDog = true;
            var chars = "B";
            decimal dogWeight = 11.7m;
            double oldDogWeight = 4.44;

            // Variables initializations
            Console.WriteLine($"I have a pomeranian named {dogName}, his name starts with a {chars}.");
            Console.WriteLine($"He is {dogAge} years old.");
            Console.WriteLine($"When I got him he was only {oldDogWeight}lbs.");
            Console.WriteLine($"He weighs {dogWeight}lbs.");
            Console.WriteLine($"Is it true that pomeranians are cute? {cuteDog}");
            Console.ReadLine();
        }
    }
}

