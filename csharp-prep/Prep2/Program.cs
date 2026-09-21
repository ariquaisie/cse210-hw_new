using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string final_grade;
        int new_final;
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("Enter your grade ");
        final_grade=Console.ReadLine();
        new_final=int.Parse(final_grade);

        if (new_final >= 93)
        {
            Console.WriteLine("You have an A");
        } else if (new_final < 93 && new_final >= 90)
        {
            Console.WriteLine("You have an A-");
        } else if (new_final < 90 && new_final >= 87)
        {
            Console.WriteLine("You have an B+");
        }else if (new_final < 87 && new_final >= 83)
        {
            Console.WriteLine("You have an B");
        } else if (new_final < 83 && new_final >= 80)
        {
            Console.WriteLine("You have an B-");
        } else if (new_final < 80 && new_final >= 77)
        {
            Console.WriteLine("You have an C+");
        }else if (new_final < 77 && new_final >= 73)
        {
            Console.WriteLine("You have an C");
        } else if (new_final < 73 && new_final >= 70)
        {
            Console.WriteLine("You have an C-");
        }else if (new_final < 70 && new_final >= 67)
        {
            Console.WriteLine("You have an D+");
        }else if (new_final < 67 && new_final >= 63)
        {
            Console.WriteLine("You have an D");
        } else if (new_final < 63 && new_final >= 60)
        {
            Console.WriteLine("You have an D-");
        } else if (new_final < 60)
        {
            Console.WriteLine("You have an F or UW");
        }
        else
        {
            Console.WriteLine("Please enter a correct number");
        }
    }
}