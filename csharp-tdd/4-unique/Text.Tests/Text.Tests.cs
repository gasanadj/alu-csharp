using Microsoft.VisualStudio.TestPlatform.Common.Interfaces;
using NUnit.Framework;
using System;

namespace Text.Tests
{
    public class UniqueTests
    {
        [TestCase("swiss", 1)] // Test with a string with a unique character
        [TestCase("abcdef", 0)] // All unique characters
        [TestCase("aabbcc", -1)] // Test with a string with no unique characters
        [TestCase("", -1)] // Test with an empty string
        [TestCase(null, -1)] // Test with a null string
        [TestCase("aabbccd", 6)] // Test with a string containing repeated characters and a single unique character
        [TestCase("a1b2b1a", 3)] // Test with a string containing non-alphabetic characters
        [TestCase("abcdabcdabcdxyz", 12)] // Test with a long string containing multiple unique characters
        [TestCase("a b c a b", 4)] // Test with a string containing spaces

        public void TestUniqueCharacter(string? s, int index) {
            Assert.That(index, Is.EqualTo(Text.Str.UniqueChar(s)));
        }

    }

}
