using NUnit.Framework;
using System;

namespace Text.Tests
{
    public class StrTests
    {
        [TestCase("racecar", true)] // A palindrome with all lowercase letters.
        [TestCase("hello", false)] // A non-palindrome word.
        [TestCase("", true)] // An empty string is considered a palindrome.
        [TestCase("a", true)] // A single character is considered a palindrome.
        [TestCase("aa", true)] // Two identical characters form a palindrome.
        [TestCase("ab", false)] // Two different characters do not form a palindrome.
        [TestCase("RaceCar", true)] // A palindrome with mixed case, ignoring case differences.
        [TestCase("A man, a plan, a canal, Panama!", true)] // A palindrome phrase with spaces, punctuation, and mixed case.
        [TestCase("!!!@@@", true)] // A string with only non-alphanumeric characters, which is considered a palindrome after removing all non-alphanumeric characters (resulting in an empty string).
        [TestCase("12321", true)] // A numerical palindrome.
        [TestCase("12345", false)] // A numerical non-palindrome.
        [TestCase("A1B2B1A", true)] // An alphanumeric palindrome.
        [TestCase("A1B2C3", false)] // An alphanumeric non-palindrome.
        [TestCase("     ", true)] // A string with only spaces, which is considered a palindrome after removing all spaces (resulting in an empty string).

        public void TestIsPalindrome(string input, bool expected)
        {
            Assert.That(Text.Str.IsPalindrome(input), Is.EqualTo(expected));
        }
    }

}
