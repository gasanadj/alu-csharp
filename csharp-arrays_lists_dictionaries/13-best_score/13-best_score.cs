class Dictionary
{
    public static string BestScore(Dictionary<string, int> myDict)
    {
        string bestScore = "";
        int best = 0;
        foreach(KeyValuePair<string,int> kvp in myDict)
        {
            if (kvp.Value > best)
            {
                bestScore = kvp.Key;
                best = kvp.Value;
            }else {
                continue;
            }
        }
        return bestScore;
    }
}