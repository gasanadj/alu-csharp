using System;

class Program
{
    static void Main()
    {
        bool first = true;
        for (int i = 0; i < 10; i++)
        {
            for (int j = i + 1; j < 10; j++)
            {
                if (!first)
                {
                    Console.Write(", ");
                }
                Console.Write($"{i:D1}{j:D1}");
                first = false;
            }
        }
        Console.WriteLine(); 
    }
}
