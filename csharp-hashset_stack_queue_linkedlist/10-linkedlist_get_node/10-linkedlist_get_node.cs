using System.Runtime.Serialization;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (n < 0 || n >= myLList.Count)
        {
            return 0;
        }
        if (!myLList.Contains(myLList.ElementAt(n)))
        {
            return 0;
        }
        return myLList.ElementAt(n);
    }
}