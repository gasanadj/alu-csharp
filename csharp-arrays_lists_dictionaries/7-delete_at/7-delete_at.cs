using System;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index > myList.Count - 1  || index < 0) 
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }
        int element = myList[index];
        myList.Remove(element);
        return myList;
    }
}