using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Number_converter;

namespace Number_converterTest
{
    [TestFixture]
    public class Tester
    {
    }

    [Test]
    public void NumberIsZero()
    {
        int input = 0;
        string output = "zero";

        Assert.AreEqual(output, NumberConverter.Convert(input));
    }
}