using System;

namespace FuzzySharp.SimilarityRatio.Strategy
{
    internal class PrefixRatioStrategy
    {
        public static int Calculate(string input1, string input2)
        {
           if (input1.Length == 0 || input2.Length == 0)
           {
               return 0;
           }

           var distance = JaroWinkler.Distance(input1, input2);
           return (int)Math.Round(100 * (1 - distance));
        }
    }
}

