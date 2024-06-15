using Microsoft.VisualStudio.TestPlatform.Common.Interfaces;
using NUnit.Framework;
using System;

namespace Text.Tests
{
    public class CamelCaseTests
    {
        [TestCase("helloWorld", 2)] 
        [TestCase("myVariableName", 3)] 
        [TestCase("thisIsCamelCase", 4)] 
        [TestCase("single", 1)] 
        [TestCase("", 0)] 
        [TestCase(null, 0)] 
        [TestCase("alreadyCamelCase", 3)] 
        [TestCase("camelCaseWithALongName", 6)] 
        [TestCase("aB", 2)] 
        public void TestCamelCase(string? input, int expected)
        {
            Assert.That(Str.CamelCase(input), Is.EqualTo(expected));
        }

    }

}
