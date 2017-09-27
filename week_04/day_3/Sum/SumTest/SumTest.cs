using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sumnumbers;

namespace SumTest
{
    [TestFixture]
    public class SumTest
    {
        //[Test]
        //public void SumNumbersTest()
        //{
        //    //arrange
        //    List<int> numbers = new List<int> { 1, 2, 3 };
        //    var Sum =  numbers;

        //    //act
        //    int output = 4;

        //    //assert
        //    Assert.AreEqual(numbers.Sum(), output);
        //}
        [Test]
        public void SumNumbersTest()
        {
            //arrange
            List<int> numbers = new List<int> { 1, 2, 3 };
            Sum SumClass = new Sum();

            //act
            int output = 6;

            //assert
            Assert.AreEqual(SumClass.SumMethod(numbers), output);
        }
        [Test]
        public void SumEmptyTest()
        {
            //arrange
            List<int> numbers = new List<int> { };
            Sum SumClass = new Sum();

            //act
            int output = 0;

            //assert
            Assert.AreEqual(SumClass.SumMethod(numbers), output);
        }

        [Test]
        public void SumOneTest()
        {
            //arrange
            List<int> numbers = new List<int> { 5 };
            Sum SumClass = new Sum();

            //act
            int output = 5;

            //assert
            Assert.AreEqual(SumClass.SumMethod(numbers), output);
        }

        [Test]
        public void SumEmpty()
        {
            //arrange
            Sum SumClass = new Sum();

            //act
            int output = 5;

            //assert
            Assert.AreEqual(SumClass.SumMethod(null), output);
        }
    }
}