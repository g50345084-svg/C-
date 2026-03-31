using System;
using System.Text;
class Program
{
    static void Main()
    {
    //    string text = "Prabodh Koirala";
    //      Console.WriteLine(text.ToUpper());
    //      Console.WriteLine(text.ToLower());
    //      Console.WriteLine(text.Substring(5, 5));
    //      Console.WriteLine(text.Replace("Koirala", "Shrestha"));
    // Console.Write("Enter a string: ");
    // string name = Console.ReadLine();
    // Console.WriteLine("The length of the string is: " + name.Length);
    // Console.WriteLine("The string in uppercase is: " + name.ToUpper());
    // Console.WriteLine("The string in lowercase is: " + name.ToLower());
    StringBuilder sb = new StringBuilder();

    sb.Append("Hello");
    sb.Append(" ");
    sb.Append("World");

    Console.WriteLine(sb.ToString());
    }
}