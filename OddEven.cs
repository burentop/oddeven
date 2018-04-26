using System;

class OddEven
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        string stringInputNumber = Console.ReadLine();
        int inputNumber = int.Parse(stringInputNumber);

        for (int i = 1; i <= inputNumber; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i + " - even");
            }
            else
            {
                Console.WriteLine(i + " - odd");
            }
        }
    }
}