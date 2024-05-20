using System;

class Dictionary
{
    public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key)
    {
        myDict.Remove(key);
        return myDict;
    }
}