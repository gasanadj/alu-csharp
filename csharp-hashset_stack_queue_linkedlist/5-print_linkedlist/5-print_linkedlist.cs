class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> result = new LinkedList<int>();
        if (size < 0) {
            return result;
        }
        int i = 0;
        while (size > 0) {
            result.AddLast(i);
            i++;
            size--;
        }
        foreach (int j in result) {
            Console.WriteLine(j);
        }
        return result;
    }
}
