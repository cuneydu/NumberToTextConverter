using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToTextConverter;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Tests.NumberToTextConverter
{
    [TestClass]
    public class CaseTest
    {
        INumberToTextConverter _converter;
        public CaseTest()
        {
            _converter = new TrendyolNumberToTextConverter();
        }

        [TestMethod]
        public void Should_Be_Equal_1_Amount_To_One_Text()
        {
            Assert.AreEqual(RunChangeAmountToText(1), "One");
        }
        [TestMethod]
        public void Should_Be_Equal_50_Amount_To_Fifty_Text()
        {
            Assert.AreEqual(RunChangeAmountToText(50), "Fifty");
        }
        [TestMethod]
        public void Should_Be_Equal_750_Amount_To_Seven_Hundered_and_Fifty_Text()
        {
            Assert.AreEqual(RunChangeAmountToText(750), "Seven Hundered and Fifty");
        }
        [TestMethod]
        public void Should_Be_Equal_1750_Amount_To_One_Thousand_Seven_Hundered_and_Fifty_Text()
        {
            Assert.AreEqual(RunChangeAmountToText(1750), "One Thousand Seven Hundered and Fifty");
        }
        [TestMethod]
        public void Should_Be_Equal_200000_Amount_To_Two_Hundred_Thousand_Text()
        {
            Assert.AreEqual(RunChangeAmountToText(200000), "Two Hundered Thousand");
        }
         
        private string RunChangeAmountToText(int amount)
        {
            string amountText =  _converter.ChangeAmountToText(amount);
            Console.WriteLine("{0} for result: {1}", amount, amountText);
            return amountText;
        }

    }
}
