class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int sum = 0;
        foreach (int el in myLList)
        {
            sum +=el;
        }
        return sum;
    }
}