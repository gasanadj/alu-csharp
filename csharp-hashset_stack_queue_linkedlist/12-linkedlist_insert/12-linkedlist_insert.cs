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
        }else if (n > myLList.Last.Value){
            myLList.AddAfter(myLList.Last, n);
        }else {
            myLList.AddBefore(myLList.Last, n);
        }


        return myLList.Find(n);
    }

}