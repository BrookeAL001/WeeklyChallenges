using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
                        
            if (string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }

            if (ignoreCase == false)
            {

                if (words.Contains(word) == true)
                {
                    return true;
                }

                return false;
            }


            if (ignoreCase == true)
            {
                List<string> lowCase = words.Select(word => word.ToLower()).ToList();
                if (lowCase.Contains(word) == true)
                {
                    return true;
                }

                return false;
            }


            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 1)
            {
                return false;
            }

            if (num == 1)
            {
                return false;
            }

            if (num == 2 || num == 3)

            {
                return true;
            }

            if (num % 2 == 0 || num % 3 == 0)
            {
                return false;
            }


            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            return str.IndexOf(
            str
                .Distinct()
                .Reverse()
                .FirstOrDefault(x => str.Count(y => y.Equals(x)) == 1));
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }

                    currentCount++;
                }

                if (currentCount > count)
                {
                    count = currentCount;
                }
            }

            return count;
        }
        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> nthElement = new List<double>();
            double[] nullCheck = new double[0];

            if (elements == null)
            {
                return nullCheck;
            }

            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % n == 0)
                {
                    nthElement.Add(elements[i]);
                }

                if (n < 0 || n > elements.Count)
                {
                    nthElement.Clear();
                }
            }

            double[] finalArray = nthElement.ToArray();

            return finalArray;
        }
    }
}
