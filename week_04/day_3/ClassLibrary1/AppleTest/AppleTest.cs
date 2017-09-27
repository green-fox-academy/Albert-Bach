using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apples;

namespace AppleTest
{
    [TestFixture]
    public class AppleTest
    {
        [Test]
        public void GetAppleTest()
        {
            string fruit = "Apple";
            var apple = new Apple(fruit);

            string output = apple.GetApple();

            Assert.AreEqual(fruit, output);
        }

        [Test]
        public void GetPearTest()
        {
            string fruit = "Pear";
            var apple = new Apple(fruit);

            string output = apple.GetApple();

            Assert.AreEqual(fruit, output);
        }

        [Test]
        public void GetApplesTest()
        {
            string fruit = "Apple";
            var apple = new Apple(fruit);

            string output = apple.GetApple();

            Assert.AreEqual(fruit, output);
        }
    }
}