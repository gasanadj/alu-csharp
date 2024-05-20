using System;

class Program
{
    public static void Main(string[] args)
    {
        int [,] myArray = new int[5,5];
        for (int i = 0; i<myArray.GetLength(0); i++)
        {
            for (int j = 0; j<myArray.GetLength(1); j++)
            {
                myArray[i,j] = 0;
            }
        }
        myArray[2,2] = 1;

        for (int i = 0; i<myArray.GetLength(0); i++)
        {
            for (int j = 0; j<myArray.GetLength(1); j++)
            {
                if (j != myArray.GetLength(1) - 1)
                {
                    Console.Write(myArray[i,j] + " ");
                }else{
                    Console.Write(myArray[i,j]);
                }
            }
            Console.WriteLine();
        }

    }
}