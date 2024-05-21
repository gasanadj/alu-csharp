class List
{
    public static List<int> CommonElements(List<int> list1,List<int> list2)
    {
        List<int> CommonList = new List<int>();
        foreach(int element in list1) 
        {
            if (list2.Contains(element))
            {
                CommonList.Add(element);
            }
        }
        CommonList.Sort();
        return CommonList;
    }
}