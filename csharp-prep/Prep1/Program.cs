using System;

class Program
{
    static void Main(string[] args)
    {
        string firstname;
        string lastname;
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("Please enter your first name ");
        firstname=Console.ReadLine();
        Console.Write("Please enter your last name ");
        lastname=Console.ReadLine();

        Console.WriteLine($"Your name is {firstname} {lastname}");
    }
}