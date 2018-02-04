using System.Collections.Generic;

namespace WordCount
{
    public class WordCountValidation
    {
        public IDictionary<char, int> CountWords(string word)
        {
            var wordCount = new Dictionary<char, int>();
            char[] letters = word.ToUpper().ToCharArray();

            for (int i = 0; i < letters.Length; i++)
            {
                if (!wordCount.ContainsKey(letters[i]))
                    wordCount.Add(letters[i], 1);
                else
                    wordCount[letters[i]]++;
            }

            return wordCount;
        }
    }
}
