//WAP that takes a numbewr as input from user and checks whether it is positive, negative or zero.
using System;
class Program{
    static void Main(){
        int n;
        Console.WriteLine("Do you want to check a number? (y/no)");
        string answer = Console.ReadLine();
        while(answer != "y" && answer != "no"){
            Console.WriteLine("Invalid input. Please enter 'y' or 'no'.");
            answer = Console.ReadLine();
        }
        if(answer == "no"){
            return;
        }
else{
        Console.WriteLine("Enter a number:");
         n = Convert.ToInt32(Console.ReadLine());
        if(n > 0){
            Console.WriteLine("The number is positive.");
        }
        else if(n < 0){
            Console.WriteLine("The number is negative.");
        }
        else{
            Console.WriteLine("The number is zero.");
        }
    }
}
}