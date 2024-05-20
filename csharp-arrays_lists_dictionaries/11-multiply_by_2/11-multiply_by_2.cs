using System.Collections.ObjectModel;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int>.KeyCollection keys = myDict.Keys;
        Dictionary<string, int> myNewDict = new Dictionary<string, int>();
        foreach(string key in keys)
        {
            myNewDict.Add(key, myDict[key]*2);
        }
        return myNewDict;
    }
}