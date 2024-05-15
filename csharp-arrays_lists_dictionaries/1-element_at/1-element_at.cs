using System;

class Array 
{
    public static int elementAt(int[] array, int index)
    {
        int length = array.Length;
        int lastIndex = length - 1;
        if (index > lastIndex || index < 0) 
        {
            Console.WriteLine("Index out of range");
            return -1;
        } else {
            return array[index];
        }
    }
}