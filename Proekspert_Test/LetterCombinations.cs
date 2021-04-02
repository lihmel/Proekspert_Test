using System;
using System.Collections.Generic;
using System.Linq;

namespace Proekspert_Test
{
    public class LetterCombinations 
    {
        private const int MinCombinationLength = 4;
        private const int Precision = 2;
        private int _totalFrequenciesSum;

        public Dictionary<string, decimal> FindCommonLetterCombinations(string input)
        {
            _totalFrequenciesSum = 0;
            Dictionary<string, int> combinations = FindInputCombinations(input);
            Dictionary<string, decimal> combinationsWithDifferenceInPercentage = FindDifferenceInPercentageForWords(combinations);

            return GetTopTenCombinations(combinationsWithDifferenceInPercentage);
        }

        private Dictionary<string, int> FindInputCombinations(string input)
        {
            Dictionary<string, int> combinations = new Dictionary<string, int>();
            string[] words = input.Split(' ');

            foreach (string word in words)
            {
                this.FindWordCombinations(word, combinations);
            }

            return combinations;
        }

        private void FindWordCombinations(string word, Dictionary<string, int> combinations)
        {
            for (int i = MinCombinationLength; i <= word.Length; i++)
            {
                for (int j = 0; j <= word.Length - i; j++)
                {
                    string letterCombination = word.Substring(j, i);

                    if (!combinations.ContainsKey(letterCombination))
                    {
                        combinations.Add(letterCombination, 1);
                    }
                    else
                    {
                        combinations[letterCombination]++;
                    }
                    _totalFrequenciesSum += 1;
                }
            }
        }

        private Dictionary<string, decimal> FindDifferenceInPercentageForWords(Dictionary<string, int> combinations)
        {
            Dictionary<string, decimal> combinationsWithDifferenceInPercentage = new Dictionary<string, decimal>();

            foreach (var combination in combinations.Keys.ToList())
            {
                combinationsWithDifferenceInPercentage[combination] =
                    Math.Round(((Convert.ToDecimal(combinations[combination]) / _totalFrequenciesSum) * 100),
                        Precision);
            }

            return combinationsWithDifferenceInPercentage;
        }

        private Dictionary<string, decimal> GetTopTenCombinations(Dictionary<string, decimal> combinationsWithDifferenceInPercentage)
        {
            return combinationsWithDifferenceInPercentage
                .OrderByDescending(entry => entry.Value)
                .Take(10)
                .ToDictionary(entry => entry.Key, entry => entry.Value);
        }
    }
}
