using System;

class Program 
{
    static void Main(string[] args) 
    {
        for(int i = 0; i<99; i++) 
        {
            Console.Write($"{i} = 0x{i.ToString("x")} \n");
        }
    }
}