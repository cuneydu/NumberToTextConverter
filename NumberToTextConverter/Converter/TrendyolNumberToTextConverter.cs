using NumberToTextConverter.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NumberToTextConverter
{
    public class TrendyolNumberToTextConverter : NumberToTextConverterBase, INumberToTextConverter
    {
        /// <summary>
        /// Number to Text Converter Method
        /// </summary>
        /// <param name="amount">20</param>
        /// <returns>Twelve</returns>
        public string ChangeAmountToText(int amount)
        {
            var builder = new StringBuilder();
            var amountString = amount.ToString().Trim();

            var numberList = NumberToTextHelper.GetHunderedsOfAmounts(amountString);

            for (int i = 0; i < numberList.Count; i++)
            {
                var number = numberList[i].ToInt();
                var numberLength = number.ToString().Length;

                var result = this.CalculateOperation(number);
                if (i > 0)
                {
                    builder.Insert(0, string.Format(" {0} {1}", result, Constants.Thousands[i]));
                }
                else
                {
                    builder.Insert(0, string.Format(" {0}", result));
                }
            }

            return builder.ToString().Trim();
        }

        public override string CalculateOperation(int amount)
        {
            return base.CalculateOperation(amount);
        }


        public void Dispose()
        {
            //TODO: Dispose
        }
    }
}
