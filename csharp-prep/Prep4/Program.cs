using System;

class Program
{
    static void Main(string[] args)
    {

        List<int> number = new List<int> ();
        int addnumber = 1;

        do {
            Console.Write("Enter a number to add. Enter 0 to finish: ");
            string addnumberstring = Console.ReadLine();
            addnumber = int.Parse(addnumberstring);

            if (addnumber != 0 )
            {
                number.Add (addnumber);
            } 
        } while (addnumber != 0);

        int add = 0;
        foreach (int total in number)
        {
            add += total;
        }
        Console.WriteLine($"The sum is: {add}");
        
        float average = ((float)add) / number.Count;
        Console.WriteLine($"The average is: {average}");

        int largestnumber = number[0];
        foreach (int total in number)
        {
            if (total > largestnumber)
            {
                largestnumber = total;
            }
        }
        Console.WriteLine($"The largest number is: {largestnumber}");
    }
}