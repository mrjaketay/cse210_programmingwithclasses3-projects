using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> number_list = new List<int>();

        int user_number = -1;
        while (user_number != 0)
            {
                Console.Write("Enter a number - Press 0 to quit ");

                string user_input =Console.ReadLine();
                user_number = int.Parse(user_input);

                if (user_number != 0)
                    {
                        number_list.Add(user_number);
                    }
            }

        float sum = 0;
        foreach (int number in number_list)
            {
                sum += number;
            }
        
        Console.WriteLine("The sum is " + sum);
        

        //Average
        float average = sum / number_list.Count;
        Console.WriteLine ("The Average is " + average);

        
        //Largest Number
        int max = number_list[0];

        foreach (int number in number_list)
            {
                if (number > max)
                {
                    max = number;
                }
            }
        Console.WriteLine ("The Largest number is " + max);
    }
}