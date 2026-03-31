using System;
using System.Text;
class Program
{
    static void Main()
    {
        //WAP that creates a string builder and adds the following strings to it: "Learning", "C#", "Programming". Then, print the final combined strings.
    //find the last 10 character of the final combined string and print it to the console.
        StringBuilder sb = new StringBuilder();
        sb.Append("Learning");
        sb.Append(" ");
        sb.Append("C#");
        sb.Append(" ");
        sb.Append("Programming");
string finalString = sb.ToString();
        Console.WriteLine(finalString);
        Console.WriteLine(finalString.Substring(finalString.Length - 10));
        
    }
}
