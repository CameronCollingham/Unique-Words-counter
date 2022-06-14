using System;
using System.Collections.Generic;
using System.Linq;

namespace Unique_Words_counter
{
    class Run
    {
        /*
         * This program and related classes are written and modified by Cameron Collingham
         * for the purpose of being sample code
         *
         *
         */
        static void Main()
        {
            Console.WriteLine("Enter Sentence:");
            string sentence = Console.ReadLine();
            string[] UnprocessedWords = LogicFunctions.SentenceToArray(sentence);
            List<string> ListUnprocessedWords = new List<string>();
            List<string> processedWords = new List<string>();
            for (int w = 0; w < UnprocessedWords.Length; w++)
            {
                ListUnprocessedWords.Add(UnprocessedWords[w].ToLower());
            }
            processedWords = LogicFunctions.WordRemovePuncThenLowercase(ListUnprocessedWords);

            processedWords = (List<string>)processedWords.OrderBy(q =>q).ToList();
            int count = 0;
            for (int i = 0; i < processedWords.Count; i++)
            {
                
                
                if (i + 1 >= processedWords.Count)
                {
                    count++;
                    Console.WriteLine("Word: " + processedWords[i] + " " + ", Count:" + count);
                    count = 0;
                }
                else if (processedWords[i] != processedWords[i+1])
                {
                    count++;
                    Console.WriteLine("Word: " + processedWords[i] + " " + ", Count:" + count);
                    count = 0;
                }
                else if (processedWords[i] == processedWords[i])
                {
                    count++;
                }
                else
                {
                    count++;
                    Console.WriteLine("Word: " + processedWords[i] + " " + ", Count:" + count);
                    count = 0;
                }




            }

            Console.WriteLine("Please press enter to end Program");
            Console.ReadLine();

        }
    }
}
