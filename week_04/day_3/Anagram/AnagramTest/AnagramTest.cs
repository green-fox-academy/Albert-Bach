using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anagram;
using NUnit.Framework;

namespace AnagramTest
{
    [TestFixture]
    public class AnagramTest
    {
        Anagrammas anagrams = new Anagrammas();

        [Test]
        public void AnagramTester()
        {
            // arrange
            string word1 = "fire";
            string word2 = "earth";
            
            //act
            bool output = false;

            //assert
            Assert.AreEqual(output, anagrams.IsAnagram(word1,word2));
        }
    }
}