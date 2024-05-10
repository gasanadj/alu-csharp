using System;

class Program 
{
    static void Main(string[] args) 
    {
        for (int i = 0; i<100; i++)
        {
            if (i == 99) {
                Console.Write($"{i}\n");
            }else {
                Console.Write($"{i.ToString("D2")}, ");
            }
        }
    }
}
