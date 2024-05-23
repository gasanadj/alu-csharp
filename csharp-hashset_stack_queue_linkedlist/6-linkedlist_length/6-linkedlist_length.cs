class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int counter = 0;
        foreach(int element in myLList)
        {
            counter ++;
        }
        return counter;
    }
}
