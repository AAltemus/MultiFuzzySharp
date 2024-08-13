using System;
using FuzzySharp.SimilarityRatio.Strategy;

namespace FuzzySharp.SimilarityRatio.Scorer.StrategySensitive.Simple
{
    public class PrefixRatioScorer : SimpleRatioScorerBase
    {
        protected override Func<string, string, int> Scorer => PrefixRatioStrategy.Calculate;
    }
}
