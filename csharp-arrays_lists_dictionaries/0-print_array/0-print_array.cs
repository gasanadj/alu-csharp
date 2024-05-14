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
            return [];
        } else {
            int[] myArray = new int[size];
            for (int i = 0; i<size; i++) {
                myArray[i] = i;
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine();
            return myArray;
        }
    }
}