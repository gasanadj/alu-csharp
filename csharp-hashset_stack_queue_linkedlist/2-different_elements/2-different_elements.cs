class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> differentEl = new List<int>();
        foreach(int el in list1)
        {
            if (!list2.Contains(el))
            {
                differentEl.Add(el);
            }else {
                continue;
            }
        }
        foreach(int el in list2)
        {
            if (!list1.Contains(el))
            {
                differentEl.Add(el);
            }else {
                continue;
            }
        } 
        differentEl.Sort();
        return differentEl;
    }
}