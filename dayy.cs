//WAP that creates [3,2] array with the elements assigneed by the user and print all the elements with its postition.
using System;
class dayy
{
    static void Main()
    {
        int[,] arr = new int[3, 2];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"Element at position [{i},{j}]: ");
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nThe elements of the array with their positions are:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine($"Element at position [{i},{j}]: {arr[i, j]}");
            }
        }
    }
}