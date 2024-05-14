using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0) {
            Console.WriteLine("Size cannot be negative");
            return null;
        } else if (size == 0){
            Console.WriteLine();
            return new int [0];
        } else {
            int[] myArray = new int[size];
            for (int i = 0; i<size; i++) {
                myArray[i] = i;
                if (i == size - 1) {
                    Console.Write(myArray[i]);
                } else {
                    Console.Write(myArray[i] + " ");
                }
            }
            Console.WriteLine();
            return myArray;
        }
    }
}