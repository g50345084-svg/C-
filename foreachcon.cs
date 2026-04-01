//WAP that prints number from 1-20 skip when the value is 13 and terminate the program if 17 is encountered.
using System;
class Program{
    static void Main(){
        int [] numbers={1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
        foreach(int num in numbers){
            if(num==13)
            {
                continue;
            }
            if(num==17)
            {
                break;
            }
            Console.WriteLine(num);
        }
    }
}