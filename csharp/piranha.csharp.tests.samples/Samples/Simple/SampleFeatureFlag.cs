using System;
using piranha.csharp.tests.samples.Commons;

namespace piranha.csharp.tests.samples.Samples.Simple
{
    public class SampleFeatureFlagTest
    {
        public SampleFeatureFlagTest()
        {
            if (FeatureFlag.IsFeatureFlagOn("Example"))
            {
                Console.WriteLine("Hello World");
            }
        }
    }
}