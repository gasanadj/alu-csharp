class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current = myLList.First;
        if (n < myLList.First.Value) {
            myLList.AddBefore(myLList.First, n);
        }
        while (current.Next != null) 
        {
                if (current.Value < n)
                {
                    current = current.Next;
                }else {
                    myLList.AddBefore(current, n);
                    break;
                }
        }
        if (n > myLList.Last.Value){
            myLList.AddAfter(myLList.Last, n);
        }
        return myLList.Find(n);
    }

}