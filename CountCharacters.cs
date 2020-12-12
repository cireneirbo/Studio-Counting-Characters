using System;
using System.Collections.Generic;
using System.Text;

namespace Studio_Counting_Characters
{
    class CountCharacters
    {
        public static string countCharactersInString(string text)
        {
            char[] textArray = text.ToCharArray();
            List<string> textList = new List<string>();
            foreach (char i in textArray)
            {
                textList.Add(textArray[i].ToString());
            }
            
            Dictionary<string, int> stringTally = new Dictionary<string, int>();

            foreach(string letter in textList)
            {
                if (stringTally.ContainsKey(letter))
                {
                    stringTally[letter] += 1;
                }
                else
                {
                    stringTally.Add(letter, 1);
                }


            }
            string output = "";
            foreach (KeyValuePair<string, int> letter in stringTally)
            {
                output += letter.Key + ": " + letter.Value + "\n";
            }

            return output;
        }
    }
}



/*
 * 
 * int charCount = 0;
                foreach(char letter in word)
                {
                    charCount += 1;
                }*/