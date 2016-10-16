using System;
using System.Collections.Generic;

namespace _04_Pig_Latin
{
    internal class Translator
    {
        internal string Translate(string word)
        {
            List<Char> vowels = new List<Char> { 'a', 'e', 'i', 'o' };
            string firstLetter = word.Substring(0, 1);
            string newWord = "";
            string[] diffWords = word.Split(' ');
            string finalWord;
            foreach (string diffWord in diffWords)
            {
                bool isFirstVowel = true;
                for (int p = 0; p < diffWord.Length; p++)
                {
                    if (vowels.Contains(diffWord[p]) && isFirstVowel == true)
                    {
                        finalWord = diffWord.Substring(p) + diffWord.Substring(0, p) + "ay";
                        if (diffWord.Substring(0,1) == diffWord.Substring(0, 1).ToUpper())
                        {
                            finalWord = finalWord.Substring(0, 1).ToUpper() + finalWord.Substring(1).ToLower();
                        }
                        newWord = newWord + " " + finalWord;
                        isFirstVowel = false;
                    }
                }
            }
            return newWord.Trim();
        }
    }
}
