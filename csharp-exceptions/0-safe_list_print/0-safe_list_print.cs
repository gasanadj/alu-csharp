class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int count = 0;
        try
        {
            for (int i = 0; i<n; i++) {
                count++;
                Console.WriteLine(myList[i]);
            }
            return count;
        }
        catch (ArgumentOutOfRangeException)
        {
            return count-1;
        }
    }
}