using System;
using System.Net.Http.Headers;

class Program
{
    static double AddNumbers(double x, int y)
    {
        return x +y;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello CSE 210 World!");
        Console.WriteLine("Bonjour tout le monde!");

        //Prep 2
        /*
        // WriteLine and ReadLine and int.Parse
        int x=10;
        if (x == 10)
        {
            Console.WriteLine("X is 10");
        }
        else if (x == 20)
        {
            Console.WriteLine("We're in the else if");
        }
        else
        {
            Console.WriteLine("Z is not much fun");
        }*/

        //Prep 3
        /* 
        //while loop
        bool done = false;
        while (!done)
        {
            Console.Write("Are you done (y/n)? ");
            done = Console.ReadLine().ToLower() == "y";
        }*/

        /* 
        //do while loop
        bool done;
        do
        {
            Console.Write("Are you done (y/n)? ");
            done = Console.ReadLine().ToLower() == "y";
        } while(!done);*/

        /* 
        //for loop
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }*/
        /*for (int i=0;i<=100; i+=5)
        {
            Console.Write($"i-");
            Console. WriteLine("Hey Bob");
        }*/

        /*List<string> myFriends = ["Bob", "Aba", "Jessica", "claudia"]; //one way to do it
        List<string> names =new List <string>(); //another way to do it
        myFriends.Add("James");
        myFriends.Add("Chimdinma");

        foreach(string name in myFriends)
        {
            Console.WriteLine(name);
        }*/

        Console.Write

    }
}