using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Anagram;

namespace AnagramTest
{
    [TestFixture]
    class AnagramCheckerTest
    {
        static void Main(string[] args)
        {
        }

        [Test]
        public void WhenTwoEmptyStrings()
        {
            string inputString1 = String.Empty;
            string inputString2 = String.Empty;

            Assert.False(AnagramChecker.IsAnagram(inputString1, inputString2));
            
        }

        [Test]
        public void WhenNullStrings()
        {
            string inputString1 = null;
            string inputString2 = "doggo";

            Assert.False(AnagramChecker.IsAnagram(inputString1, inputString2));

        }

        [Test]
        public void WhenOneEmptyString()
        {
            string inputstr1 = "team";
            string inputstr2 = String.Empty;

            Assert.False(AnagramChecker.IsAnagram(inputstr1, inputstr2));
        }

        [Test]
        public void WhenLengthsAreNotEqual()
        {
            string String1 = "dog";
            string String2 = "appletree";

            Assert.False(AnagramChecker.IsAnagram(String1, String2));
        }

        [Test]
        public void WhenStringsAreEqual()
        {
            string string1 = "dog";
            string string2 = "dog";

            Assert.True(AnagramChecker.IsAnagram(string1, string2));
        }

        [Test]
        public void WhenStringsAreEqualButMixedCase()
        {
            string string1 = "dOG";
            string string2 = "dog";

            Assert.True(AnagramChecker.IsAnagram(string1, string2));
        }

        [Test]
        public void WhenStringsAreEqualButMixedCaseWithSpace()
        {
            string string1 = "dOG";
            string string2 = "do g";

            Assert.True(AnagramChecker.IsAnagram(string1, string2));
        }

        [Test]
        public void WhenStringsAreEqualButReversed()
        {
            string string1 = "dog";
            string string2 = "god";

            Assert.True(AnagramChecker.IsAnagram(string1, string2));
        }

        [Test]
        public void WhenStringsAreEqualButMixedLettersAndMixedCase()
        {
            string string1 = "dog";
            string string2 = "God";

            Assert.True(AnagramChecker.IsAnagram(string1, string2));
        }

        [Test]
        public void WhenStringsAreEqualLenghtButDifferent()
        {
            string string1 = "dog";
            string string2 = "cat";

            Assert.False(AnagramChecker.IsAnagram(string1, string2));
        }

        [Test]
        public void WhenStringsAreEqualWithReversedLettersWithMixedCaseWithSpace()
        {
            string string1 = "dog";
            string string2 = "Go  d";

            Assert.True(AnagramChecker.IsAnagram(string1, string2));
        }

        [Test]
        public void WhenStringsAreNotEqualWithOneSpecialChar()
        {
            string string1 = "$og";
            string string2 = "God";

            Assert.False(AnagramChecker.IsAnagram(string1, string2));
        }

        [Test]
        public void WhenStringsAreAnagram()
        {
            string string1 = "dog";
            string string2 = "god";

            Assert.True(AnagramChecker.IsAnagram(string1, string2));
        }

        [Test]
        public void WhenStringsAreAnagramTwo()
        {
            string string1 = "dog";
            string string2 = "dgo";

            Assert.True(AnagramChecker.IsAnagram(string1, string2));
        }
    }
}
