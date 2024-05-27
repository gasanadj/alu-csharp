class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current = myLList.First;
        if (myLList.Count > 1) 
        {
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
        }
        if (n > myLList.Last.Value){
            myLList.AddAfter(myLList.Last, n);
        }
        if (myLList.Count <= 1 && n < myLList.First.Value )
        {
            myLList.AddBefore(myLList.First, n);
        }


        return myLList.Find(n);
    }

}