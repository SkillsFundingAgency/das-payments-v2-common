using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFA.DAS.Payments.Core.UnitTests
{
        [TestFixture]
        public class ExtensionTests
    {
        [TestCase(123.45678, 123.45678)]
        [TestCase(0.00001, 0.00001)]
        [TestCase(99.999994, 99.99999)]
        [TestCase(99.999995, 100.00000)]
        [TestCase(99.999996, 100.00000)]
        [TestCase(1.234445, 1.23444)]
        [TestCase(1.234455, 1.23446)]
        [TestCase(-1.234445, -1.23444)]
        [TestCase(-1.234455, -1.23446)]
        [TestCase(2.718281828, 2.71828)]
        [TestCase(3.14, 3.14)]
        [TestCase(0.000005, 0.00000)]
        [TestCase(0.000004, 0.00000)]
        public void Check_DecimalRounding(decimal value, decimal expected)
        {
            var actual = value.AsRounded();

            Assert.That(actual, Is.EqualTo(expected), $"Input: {value}. Output: {actual}");

        }



    }
}
