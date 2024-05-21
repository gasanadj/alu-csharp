class List
{
    public static int Sum(List<int> myList)
    {
        List<int> Unique = new List<int>();
        foreach (int element in myList)
        {
            if (Unique.Contains(element))
            {
                continue;
            }else {
                Unique.Add(element);
            }
        }

        int sum = 0;
        foreach (int el in Unique)
        {
            sum += el;
        }
        return sum;
    }
}
