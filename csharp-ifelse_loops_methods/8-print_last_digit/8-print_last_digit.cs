using System;

class Number 
{
    public static int PrintLastDigit(int number)
    {
        int lastDigit = number % 10;
        Console.Write(Math.Abs(lastDigit));
        return Math.Abs(lastDigit);
    }
}
