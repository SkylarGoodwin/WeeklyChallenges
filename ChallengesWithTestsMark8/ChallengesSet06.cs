using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || words.Contains(null))
                return false;

            
            if (string.IsNullOrEmpty(word))
                return false;

            bool containsWord =false;
            if (ignoreCase) 
            {
                word = word.ToLower();
                List<string> lowercase = words.Select(x => x.ToLower()).ToList();
                containsWord = lowercase.Contains(word);
            }
            if (!ignoreCase)
            {
                containsWord = words.Contains(word);
            }
            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            bool prime = false;
            if (num >= 0)
            {
                if( num%2 != 0 && num%3 != 0) 
                {
                    prime = true;
                }
                if(num == 2 || num == 3)
                {
                    prime = true;
                }
                if(num == 1)
                {
                    prime = false;
                }
            }
            return prime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool unique;
            for (int i = 0; i < str.Length; i++)
            {
                unique = true;
                for (int j = 0; j < str.Length; j++)
                {
                   if( str[i] == str[j] && i != j)
                    {
                        unique = false;
                    }
                }
                if (unique) 
                {
                    index= i;
                }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;
            for(int i = 0;i < numbers.Length;i++)
            {
                int currentCount = 1;
                for (int j = i+1;j < numbers.Length; j++)
                {
                    if(numbers[j] != numbers[i])
                    {
                        break;
                    }
                    currentCount++;
                }
                if(currentCount > count)
                {
                    count = currentCount;
                }
            }
            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> nth = new List<double>();
            if(elements == null || n <= 0 || elements.Count < n ) 
            {
                return nth.ToArray();
            }
            for (int i = n-1; i < elements.Count; i+=n)
            {
                nth.Add(elements[i]);
            }
            return nth.ToArray();
        }
    }
}
