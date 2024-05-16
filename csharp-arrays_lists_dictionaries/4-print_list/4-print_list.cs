using System;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0) {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        if (size == 0) {
            Console.WriteLine();    
        }
        List<int> list = new List<int>(size);
        for (int i = 0; i<size; i++)
        {
            list.Add(i);
        }
        for(int j=0; j<size; j++) {
            if (j ==  size - 1) {
                Console.Write(list[j] + "\n");
            }else {
                Console.Write(list[j] + " ");
            }
        }
        // foreach (int k in list) {
        //     Console.Write(k);
        // }
        return list;
    }
}