using System.Text;

namespace Text;

///<summary>
/// public class which has all the string operations
///</summary>
public class Str
{
    ///<summary>
    /// Method which checks if the word is a palindrome or not
    ///</summary>

    public static bool IsPalindrome(string s) {
        StringBuilder sb = new StringBuilder();
        foreach (char letter in s) {
            if (char.IsLetterOrDigit(letter)) {
                sb.Append(char.ToLower(letter));
            }
        }
        string word = sb.ToString();
        int left =0;
        int right = word.Length - 1;

        while (left < right) {
            if (word[left] != word[right]) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }


}


