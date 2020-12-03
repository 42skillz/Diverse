using System.Collections.Generic;
using NFluent;
using NUnit.Framework;

namespace Diverse.Tests
{
    [TestFixture]
    public class FuzzerWithStringShould
    {
        [Test]
        public void Be_able_to_generate_a_random_adjective()
        {
            Fuzzer fuzzer = new Fuzzer(438709238);

            string randomString = fuzzer.GenerateAdjective();

            Check.That(randomString).IsEqualTo("upbeat");
        }

        [Test]
        public void Be_able_to_generate_a_positive_adjective()
        {
            var fuzzer = new Fuzzer(43930430);

            var positiveAdjectives = new List<string>();

            for(var i = 0; i < 3; i++)
            {
                positiveAdjectives.Add(fuzzer.GenerateAdjective(Feeling.Positive));
            }

            Check.That(positiveAdjectives).ContainsExactly("gifted", "sharp", "peaceful");
        }
    }
}