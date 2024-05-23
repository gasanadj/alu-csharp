class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int element = myLList.ElementAt(index);
        myLList.Remove(element);
    }
}