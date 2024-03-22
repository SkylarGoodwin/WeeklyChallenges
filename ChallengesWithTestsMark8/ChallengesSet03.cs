using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for(int i  = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null || numbers.Count() == 0)
            {  return false; }
            var sum = numbers.Sum();
            return (sum%2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var hasLower = false;
            var hasUpper = false;
            var hasNumber = false;

            for(int i = 0;i < password.Length;i++)
            {
                if (char.IsLower(password[i]))
                {
                    hasLower = true;
                }
                if (char.IsUpper(password[i]))
                {
                    hasUpper = true;
                }
                if (char.IsNumber(password[i]))
                {
                    hasNumber = true;
                }

            }
            if( hasLower == true && hasUpper == true && hasNumber == true)
            {
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return (char)val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return (dividend / divisor);
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] -nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    list.Add(i);
                }
            }
            return list.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            foreach(string word in words)
            {
                word.ToUpper();
            }
        }
    }
}
