using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountLetters;
namespace CountLettersTest
{
    [TestFixture]
    public class CountLettersTest
    {
        CountLet countIt = new CountLet();

        [Test]
        public void DictionaryTester()
        {
            Dictionary<char, int> output = new Dictionary<char, int>()
            {
            { 'e', 1},
            { 't', 1},
            { 'h', 1},
            { 'a', 1},
            { 'r', 1}
            };
            Assert.AreEqual(output, countIt.LetterCounter("earth"));
        }
    }
}
