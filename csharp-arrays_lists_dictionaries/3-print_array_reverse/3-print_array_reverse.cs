using System;

class Array 
{
    public static void Reverse(int[]? array)
    {
        if (array == null || array.Length == 0) 
        {
            Console.WriteLine();
            return;
        }
        int [] reverseArray = new int[array.Length];
        int index = 0;
        for(int i = array.Length - 1; i>=0; i--)
        {
            reverseArray[index] = array[i];
            index++;
        }
        for (int j = 0; j<reverseArray.Length; j++) 
        {
            if (j == reverseArray.Length - 1){
                Console.Write(reverseArray[j] + "\n");
            }else {
                Console.Write(reverseArray[j] + " ");
            }
        }
    }
}