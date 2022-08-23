using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }
            return false;
            
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }

            var runningSum = 0;
            foreach (var number in numbers)
            {
                if (IsOdd(number))
                {
                    runningSum += number;
                }
            }

            return IsOdd(runningSum);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }

            var containsLower = false;
            var containsUpper = false;
            var containsNumber = false;

            foreach (char character in password)
            {
                if (char.IsUpper(character))
                {
                    containsUpper = true;
                }

                if (char.IsLower(character))
                {
                    containsLower = true;
                }

                if (char.IsNumber(character))
                {
                    containsNumber = true;
                }
            }

            return containsLower && containsUpper && containsNumber;
        }

        public char GetFirstLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val)) 
            {
                return default;
            }

            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val))
            {
                return default;
            }

            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0) return 0;

            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
              return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (IsOdd(i))
                {
                    list.Add(i);
                }
            }
            return list.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }

        public bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
    }
}
