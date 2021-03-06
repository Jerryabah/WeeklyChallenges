﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);       
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            double sum = 0;
            foreach (var num in numbers)
            {
                sum = numbers.Min() + numbers.Max();
            }
            return sum;         
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return Math.Min(str1.Length, str2.Length);
        }

        public int Sum(int[] numbers)
        {    
            if (numbers == null)
            {
                return 0;
            }
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int even = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    even += numbers[i];                                                    
                }          
            }
            return even;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            if (numbers.Sum() % 2 != 0) 
            {
                return true;
            }
            return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
           // Number must be Postive
           // Number must be Odd
           // Number must be below the long number given
           // Find all the positive numbers
           // Find all the odd numbers that are below the given number.
            
            int count = 0;
            for (int i = 0; i < number; i++)
            {
                if (i > 0 && i % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}