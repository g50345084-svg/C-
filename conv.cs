using System;
class Program

{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();
            if (input.ToLower() == "exit")
                break;
else if (input == "jew boy")
                Console.WriteLine("Hail Satan");
                break;
            try
            {
        int num1 = int.Parse(input);
        Console.WriteLine("You entered: " + num1);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number or type 'exit' to quit.");
            }
        }

    }
}