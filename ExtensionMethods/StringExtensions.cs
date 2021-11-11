using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static List<string> getWordList(this string s)
        {
            List<string> wordList = new List<string>();
            foreach (var item in new Regex(@"\w+").Matches(s))
            {
                wordList.Add(item.ToString());
            }
            return wordList;
        }
    }
}
