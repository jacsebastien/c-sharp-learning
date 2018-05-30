using System;
using System.Collections.Generic;

namespace TextSummary
{
    public class StringUtility
    {
        // method need to be public and static to be called from another method using StringUtility.SummerizeText()
        public static string SummerizeText(string text, int maxLength = 20) {

            if(text.Length < maxLength)
                return text;

            // text.Substring(0, maxLength);  // last word may be cut => not a good solution
            var words = text.Split(' ');
            var totalChar = 0;
            var summaryWords = new List<string>();

            // store each word one by one if we have less than 20 char
            foreach (var word in words) {
                summaryWords.Add(word);

                totalChar += word.Length +1; // +1 to count the space after the word

                if(totalChar > maxLength)
                    break;
            }

            return String.Join(" ", summaryWords) + "...";
        }
    }
}