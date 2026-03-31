using System;
class IfElse{
static void Main(){
        string[]subjects={"Math","Science","C#","Networking","Graphics"};
        int[]marks = {};
        double total=0;
        int subjects_full_mark=100;
        for (int i=0; i<subjects.Length;i++)
        {
            Console.WriteLine("Enter marks for"+subjects[i]+":");
            int marks_for_this_subject = int.Parse(Console.ReadLine());
            total += marks_for_this_subject;
        }
        double percentage=(double)total/(subjects_full_mark*subjects.Length)*100;
        double gpa=percentage/25;
        Console.WriteLine("Percentage:"+percentage);
        Console.WriteLine("Total Marks:"+total);
        Console.WriteLine("GPA:" + gpa);
        if(gpa>=3.5)
        {
            Console.WriteLine("Grade: A+");
        }
        else
        {
            if(gpa>=3.0)
            {
                Console.WriteLine("Grade: A");
            }
            else
            {
                if(gpa>=2.5)
                {
                    Console.WriteLine("Grade: B+");
                }
                else
                {
                    if(gpa>=2.0)
                    {
                        Console.WriteLine("Grade: B");
                    }
                    else
                    {
                        if(gpa>=1.5)
                        {
                            Console.WriteLine("Grade: C+");
                        }
                            else
                            {
                            if(gpa>=1.0)
                            {
                                Console.WriteLine("Grade: C");
                            }
                                else
                                {
                                    Console.WriteLine("I knew you would fail, Practice more and try again ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }