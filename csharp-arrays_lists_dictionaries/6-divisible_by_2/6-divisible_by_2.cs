using System;

class List 
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> resultList = new List<bool>(myList.Count);
        foreach(int num in myList)
        {
            if (num % 2 == 0)
            {
                resultList.Add(true);
            }else {
                resultList.Add(false);
            }
        }
        return resultList;
    }
}