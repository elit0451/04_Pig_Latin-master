using System;
using System.Linq;

namespace _04_Pig_Latin
{
    public class Translator
    {
        public Translator()
        {
        }
        public string Translate(string v)
        {
            char[] vowels = new char[4] { 'a', 'e', 'i', 'o' };
            string[] words;
            words = v.Split(' ');
            string result = "";
            foreach (string word in words)
            {
                char firstletter = word[0];
                char secondletter = word[1];
                char thirdletter = word[2];

                if (vowels.Contains(firstletter))
                {
                    result = result + word + "ay ";
                }
                else
                {
                    if (vowels.Contains(secondletter))
                    {
                        string bob = "";
                        bob = word.Substring(1);
                        result = result + bob + firstletter + "ay ";
                    }
                    else
                    {
                        if (vowels.Contains(thirdletter))
                        {
                            string eli = "";
                            eli = word.Substring(2);
                            result = result + eli + firstletter + secondletter + "ay ";
                        }
                        else
                        {
                            
                            if (firstletter == char.ToUpper(firstletter))
                            {
                                string mom = "";
                                mom = word.Substring(3);
                                result = result + mom + char.ToUpper(firstletter) + char.ToLower(secondletter) + thirdletter + "ay ";
                            }
                            else
                            {
                                string mom = "";
                                mom = word.Substring(3);
                                result = result + mom + firstletter + secondletter + thirdletter + "ay ";
                            }
                        }
                    }
                }
            }
            return result.Trim();
        }
    }

}