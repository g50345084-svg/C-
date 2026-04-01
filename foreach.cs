//WAP that creates an array of 4 cities and display those cities using foreach loop.
using System;
class Program{
    static void Main(){
    string [] cities={"biratnagar","kathmandu","pokhara","butwal"};

    foreach(string city in cities)
    {
        if(city=="kathmandu")
        {
            Console.WriteLine("Capital city of Nepal is: " +city);
        }
    }
    }
}
 