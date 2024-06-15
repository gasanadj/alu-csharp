using System.Text;
using System.Collections.Generic; 

namespace Text;

///<summary>
/// public class which has all the string operations
///</summary>
public class Str
{
    ///<summary>
    /// Method that returns the index of the first non-repeating character of a string.
    ///</summary>

    public static int UniqueChar(string? s) {
        if (s == null) {
            return -1;
        }
        Dictionary<char, int> myDict = new Dictionary<char, int>();
        foreach (char letter in s) {
            if (myDict.ContainsKey(letter)) {
                myDict[letter] += 1;
            }else {
                myDict[letter] = 1;
            }
        }

        for(int i = 0; i< s.Length; i++) {
            if (myDict[s[i]] == 1) {
                return i;
            }
        }
        return -1;
    }


}