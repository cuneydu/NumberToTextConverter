using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToTextConverter;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.NumberToTextConverter
{
    [TestClass]
    public class NumberToTextConverterTest
    {

        INumberToTextConverter _converter;
        public NumberToTextConverterTest()
        {
            _converter = new TrendyolNumberToTextConverter ();
        }

        [TestMethod]
        public void Should_Be_Equal_1_Amount_To_One_Text()
        {
            Assert.AreEqual<string>(_converter.CalculateOperation(1), "One");
        }

        [TestMethod]
        public void Should_Be_Equal_10_Amount_To_Ten_Text()
        {
            Assert.AreEqual<string>(_converter.CalculateOperation(10), "Ten");
        }

        [TestMethod]
        public void Should_Be_Equal_11_Amount_To_Eleven_Text()
        {
            Assert.AreEqual<string>(_converter.CalculateOperation(11), "Eleven");
        }

        [TestMethod]
        public void Should_Be_Equal_20_Amount_To_Twelve_Text()
        {
            Assert.AreEqual<string>(_converter.CalculateOperation(20), "Twenty");
        }
    }
}
