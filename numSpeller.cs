using System;

class NumberSpeller
{
    static string[] units = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
    static string[] teens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
    static string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

    static string SpellNumber(int number)
    {
        if (number < 10)
        {
            return units[number];
        }
        else if (number < 20)
        {
            return teens[number - 10];
        }
        else if (number < 100)
        {
            return tens[number / 10] + " " + SpellNumber(number % 10);
        }
        else if (number < 1000)
        {
            return units[number / 100] + " hundred " + SpellNumber(number % 100);
        }
        else if (number < 1000000)
        {
            return SpellNumber(number / 1000) + " thousand " + SpellNumber(number % 1000);
        }
        else if (number < 1000000000)
        {
            return SpellNumber(number / 1000000) + " million " + SpellNumber(number % 1000000);
        }
        else
        {
            return "Number too large to spell";
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number;
        if (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        Console.WriteLine($"Spelling of {number}: {SpellNumber(number)}");
    }
}
