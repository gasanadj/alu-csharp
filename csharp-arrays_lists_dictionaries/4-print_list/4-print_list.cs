using System;

class List
{
    public static List<int> CreatePrint(int size)
    {
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