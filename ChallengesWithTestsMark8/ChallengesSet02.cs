using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
           return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if(vals.Length % 2 == 0)
            {  return true; }
            return false;
        }

        public bool IsNumberEven(int number)
        {
            if(number %2 == 0) { return true;}
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num %2 == 0) { return false;}
            return true;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return numbers.Max() + numbers.Min();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if(str1.Length > str2.Length)
            {  return str2.Length; }
            return str1.Length;
        }

        public int Sum(int[] numbers)
        {
            var sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            var sum = 0;
            for(int i = 0;i < numbers.Length;i++)
                if (numbers[i] % 2 == 0)
                {  sum += numbers[i]; }
          return sum;

        }

        public bool IsSumOdd(List<int> numbers)
        {
            return (numbers.Sum() % 2 != 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var count = 0;
            for(long i = number; i>0; i--)
            {
                count++;
            }
            return count;
        }
    }
}
