using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unique_Words_counter;

namespace CounterUnitTest
{
    [TestClass]
    public class UnitTestFunctions
    {
        [TestMethod]
        public void WordRemovePuncThenLowercase_When_Given_Punc_Returns_NoPunc()
        {
            List<string> test = new List<string>();
            List<string> expected = new List<string>();
            string expect = "lamb";
            string word = "lamb#$^";
            
            expected.Add(expect);
            test.Add(word);
            List<string> actual = new List<string>();
            actual = LogicFunctions.WordRemovePuncThenLowercase(test);
            Assert.AreEqual(expected[0], actual[0]);
        }

        [TestMethod]
        public void SentenceToArray_Changes_String_To_Array()
        {
            string str = "something something testing test";
            string[] expected = {"something", "something", "testing", "test"};
            string[] actual = LogicFunctions.SentenceToArray(str);
            Assert.AreEqual(expected.Length, actual.Length);
        }

        [TestMethod]
        public void SentenceToArray_Changes_No_Space_String_To_Array()
        {
            string str = "somethingsomethingtestingtest";
            string[] expected = { "somethingsomethingtestingtest" };
            string[] actual = LogicFunctions.SentenceToArray(str);
            Assert.AreEqual(expected.Length, actual.Length);
        }
    }
}
