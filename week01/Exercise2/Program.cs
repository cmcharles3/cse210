using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, my daughter! What is your percentage mark? ");
        string input = Console.ReadLine();
        double percentage = double.Parse(input);

        if (percentage >= 90)   
        {
            Console.WriteLine("You got an A!");
        }
        else if (percentage >= 80)
        {
            Console.WriteLine("You got a B!");
        }
        else if (percentage >= 70)
        {
            Console.WriteLine("You got a C!");
        }
        else if (percentage >= 60)
        {
            Console.WriteLine("You got a D!");
        }
        else
        {
            Console.WriteLine("You got an F!");
        }

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass.");
        }
    }
}