using System;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            var answer =minuend - subtrahend;
            return answer;
        }

        public int Add(int number1, int number2)
        {
            var sum = number1 + number2;
            return sum;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if (number1 < number2){ return number1;} return number2;
        }

        public long Multiply(long factor1, long factor2)
        {
            var product = factor1 * factor2;
            return product;
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson == "")
            {return "Hello!";} return $"Hello, {nameOfPerson}!";
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
