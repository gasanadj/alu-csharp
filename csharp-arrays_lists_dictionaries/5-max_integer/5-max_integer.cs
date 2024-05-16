using System;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }
        int Max = myList[0];
        foreach(int num in myList) 
        {
            if (num > Max) {
                Max = num;
            }else {
                continue;
            }
        }
        return Max;
    }
}