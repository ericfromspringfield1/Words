using System;
using System.Collections.Generic;

namespace Words
{    class Program
    {
        static void Main(string[] args)
        {
            /*
    Create a dictionary with key value pairs to
    represent words (key) and its definition (value)
*/
Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

// Add several more words and their definitions
wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
wordsAndDefinitions.Add("Stank", "The feeling of students when they get all up in the valley of despair");
wordsAndDefinitions.Add("Woot", "The sound of excitement when a student whoops C#");
wordsAndDefinitions.Add("Poot", "The sound of gas leaving the bootwah");
wordsAndDefinitions.Add("Question", "What students should ask many of when at NSS");

/*
    Use square brackets to get the definition of two of the
    words and then output them to the console
*/

string def1 = wordsAndDefinitions["Awesome"];
string def2 = wordsAndDefinitions["Question"];

Console.WriteLine(def1);
Console.WriteLine(def2);

/*
    Below, loop over the wordsAndDefinitions dictionary to get the following output:
        The definition of (WORD) is (DEFINITION)
        The definition of (WORD) is (DEFINITION)
        The definition of (WORD) is (DEFINITION)
*/
foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
{
// Console.WriteLine($"The definition of {word.Key} is {word.Value}");
}
        }
    }
}
