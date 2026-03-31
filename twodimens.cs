//WAP that creates an array with the length given by the user, take the elements of the array from the user and find the sum of all the elements.
using System;
class Program{
static void Main(){
    Console.WriteLine("Enter the length of the array:");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[length];
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        // for (int j = 0; j < length; j++)
        // {
            Console.WriteLine("Enter element at position [" + i + "]:");
            array[i] = Convert.ToInt32(Console.ReadLine());
            sum += array[i];
        
    }
    Console.WriteLine("The sum of all the elements in the array is: " + sum);

}
}

