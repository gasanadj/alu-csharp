class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
    #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        LinkedListNode<int> current = myLList.First;
    #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
    #pragma warning disable CS8602 // Dereference of a possibly null reference.
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
    #pragma warning restore CS8602 // Dereference of a possibly null reference.
    #pragma warning disable CS8603 // Possible null reference return.
        return myLList.Find(n);
    #pragma warning restore CS8603 // Possible null reference return.
    }

}