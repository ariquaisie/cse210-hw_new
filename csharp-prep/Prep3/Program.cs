using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 100);

        int guess = 0;

        do {
            Console.Write("What is your guess?: ");
            string guessstring = Console.ReadLine();
            guess = int.Parse(guessstring);

            if (guess > magic)
            {
                Console.WriteLine("Lower");
            } else if (guess < magic)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the number!");
            }
        } while (guess != magic);
    }
}