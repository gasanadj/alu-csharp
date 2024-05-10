using System;

class Character 
{
    public static bool IsLower(char c) 
    {
        string letters = "abcdefghiklmnopqrstuvwxyz";
        int index = letters.IndexOf(c);
        if (index != -1) {
            return true;
        }else {
            return false;
        }
    }
}