using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine ("Guess the magic number...? ");
        //int answer = int.Parse(Console.ReadLine());
        
        Random randomNumber = new Random();
        int magic_number = randomNumber.Next(1, 101);

        Console.WriteLine ("What is the magic number...? ");
        int user_guess = int.Parse(Console.ReadLine());

        

        while (user_guess != magic_number)
            {
                Console.Write("Guess Again: ");
                user_guess =int.Parse(Console.ReadLine());

                if (user_guess < magic_number)
                    {
                        Console.WriteLine("Try Higher");
                    }
                else if (user_guess > magic_number)
                    {
                        Console.WriteLine("Try Lower");
                    }
                else
                    {
                        Console.WriteLine("You a genius or what? You guessed it! Congrats ***");
                    }
            }
    }
}