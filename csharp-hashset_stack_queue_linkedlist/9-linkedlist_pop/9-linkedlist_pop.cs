class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.Count == 0)
        {
            return 0;
        }
        int value = myLList.ElementAt(0);
        myLList.RemoveFirst();
        return value;
    }
}