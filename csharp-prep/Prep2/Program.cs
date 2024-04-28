using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your score (percentage)?");
        string score = Console.ReadLine();
        float percent = float.Parse(score);

        string grade = "";

        if (percent >= 90)
            {
                grade = "an A";
            }
        else if (percent >= 80)
            {
                grade = "a B";
            }
        else if (percent >= 70)
            {
                grade = "a C";
            }
        else if (percent >= 60)
            {
                grade = "a D";
            }
        else
            {
                grade = "an F";
            }
        
        
        Console.WriteLine("Your got " + grade);

        if (percent >= 70)
            {
                Console.WriteLine("You Passed!! Congratulations.");
            }
        else
            {
                Console.WriteLine("You Failed. Wish you well in your next take.!");
            }
    }
}