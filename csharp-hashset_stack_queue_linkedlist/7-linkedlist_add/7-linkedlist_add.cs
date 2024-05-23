class LList 
{
    public static LinkedListNode<int>? Add(LinkedList<int> myLList, int n)
    {
        myLList.AddFirst(n);
        return myLList.First;
    }
}
