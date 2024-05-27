class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (index > myLList.Count - 1 || index < 0){
            return;
        }
        int element = myLList.ElementAt(index);
        myLList.Remove(element);
    }
}