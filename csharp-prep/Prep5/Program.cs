using System;
using System.Globalization;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage ();

        string user_name = PromptUserName ();
        int user_number = PromptUserNumber ();

        int squared_number = SquareNumber (user_number);

        DisplayResult (user_name, squared_number);
    }

    static void DisplayWelcomeMessage () {
        Console.WriteLine ("\nYou are Welcome my sleepy friend.\n");
    }

    static string PromptUserName () {
        Console.Write ("Please enter your name: ");
        string user_name = Console.ReadLine();

        return user_name;
    }

    static int PromptUserNumber () {
        Console.Write ("Enter your favorite number: ");
        int user_number = int.Parse(Console.ReadLine());

        return user_number;
    }

    static int SquareNumber (int number) {
        int square = number * number;
        return square;
    }

    static void DisplayResult (string name, int square) {
        Console.WriteLine("\n" + name + ", the square of your number is " + square + ".\n");
        Console.WriteLine("**********");
        Console.WriteLine(" GOODBYE! ");
        Console.WriteLine("**********");
    }
}