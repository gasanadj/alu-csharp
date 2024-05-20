class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        IEnumerable<string> sortedKeys = myDict.Keys.OrderBy(key => key);
        foreach(string key in sortedKeys)
        {
            Console.WriteLine($"{key}: {myDict[key]}");
        }
    }
}