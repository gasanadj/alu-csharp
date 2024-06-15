using System.Text;

namespace Text;

///<summary>
/// public class which has all the string operations
///</summary>
public class Str
{
    ///<summary>
    /// Method that returns the number of words in a string
    ///</summary>

    public static int CamelCase(string? s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }

        int wordCount = 1;
        foreach (char c in s)
        {
            if (char.IsUpper(c))
            {
                wordCount++;
            }
        }

        return wordCount;
    }


}