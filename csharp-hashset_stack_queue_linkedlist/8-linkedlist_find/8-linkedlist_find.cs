class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int result = -1;
        int index = 0;
        foreach(int element in myLList)
        {
            if (element == value)
            {
                result = index;
            }
            index = index + 1;
        }
        return result;
    }
}