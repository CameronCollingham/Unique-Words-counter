using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Unique_Words_counter
{
    //this function takes a 
    public class LogicFunctions
    {
        //given a string it will return a list without whitespace
        public static string[] SentenceToArray(string sentence)
        {
            string[] words = sentence.Split(' '); ;

            return words;
        }
        //given a string it will remove punctuation then return the word
        public static List<string> WordRemovePuncThenLowercase(List<string> words)
        {
            List<string> test = new List<string>();
            for (int i = 0; i < words.Count; i++)
            {
                string currWord = Regex.Replace(words[i], @"[^\w\d\s]", "");
                test.Add(currWord);
            }

            return test;
        }
        

    }
}
