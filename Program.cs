using System;

namespace Week_1_Deliverable_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            string series = "";

            while (true)
            {
                try
                {
                    Console.Write("Enter an integer number between 1 and 100: ");
                    input = int.Parse(Console.ReadLine());

                    if (input >= 1 && input <= 100)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Only integer numbers between 1 and 100 are allowed.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter an integer number.");
                }
            }

            while (true)
            {
                Console.Write("Specify the series type: Even or Odd: ");
                series = Console.ReadLine();

                if (series == "Even" || series == "Odd")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid series type. Please enter 'Even' or 'Odd'. ");
                }
            }

            Console.WriteLine("You have selected the " + series + " series. The numbers between 0 and " + input + "are:");

            if (series == "Odd")
            {
                for (int i = 1; i <= input; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
            else if (series == "Even")
            {
                for (int i = 2; i <= input; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}