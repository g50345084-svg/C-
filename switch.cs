//WAP that takes choices from user 1-4 such that those choices represent different color and display invalid choice otherwise.
using System;
class Program{
    static void Main(){
        string choice;
        Console.WriteLine("Enter your choice:");
        choice=Console.ReadLine();
        switch(choice)
        {
            case "1":
                Console.WriteLine("Red");
                break;
            case "2":
                Console.WriteLine("Green");
                break;
            case "3":
                Console.WriteLine("Blue");
                break;
            case "4":
                Console.WriteLine("Yellow");
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}