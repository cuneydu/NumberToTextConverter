using NumberToTextConverter.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace NumberToTextConverter
{
    public abstract class NumberToTextConverterBase
    {
        /// <summary>
        /// Between 20-99 numbers
        /// </summary>
        /// <param name="number">20</param>
        /// <returns>Twelve</returns>
        protected virtual string TensOperations(int number)
        {
            var result = new StringBuilder();
            result.Append(Constants.Tens.GetValue(number / 10 - 2));
            return result.ToString();
        }

        /// <summary>
        /// Between 10-20 numbers
        /// </summary>
        /// <param name="number">11</param>
        /// <returns>Eleven</returns>
        protected virtual string TeensOperations(int number)
        {
            var result = new StringBuilder();
            result.Append(Constants.Teens.GetValue(number - 10));
            return result.ToString();
        }

        /// <summary>
        /// Between 1-9 numbers
        /// </summary>
        /// <param name="number">1</param>
        /// <returns>One</returns>
        protected virtual string OnesOperations(int number)
        {
            var result = new StringBuilder();
            if (number > 0)
                result.Append(Constants.Ones.GetValue(number));

            return result.ToString();
        }

        /// <summary>
        /// When number is more then 99
        /// </summary>
        /// <param name="number">101</param>
        /// <returns>One hundered and one</returns>
        protected virtual string HundredsOperations(int number)
        {
            var result = new StringBuilder();
            var secondaryDigit = number % 100;

            result.Append(Constants.Ones.GetValue(number / 100));

            result.AppendFormat(" {0}", Constants.Thousands[0]);

            var secondaryDigitTextResult = CalculateOperation(secondaryDigit);
            if (secondaryDigitTextResult.Length > 0)
                result.AppendFormat(" and {0}", secondaryDigitTextResult);

            return result.ToString();
        }

        /// <summary>
        /// General Calculation Method base
        /// </summary>
        /// <param name="number">101</param>
        /// <returns>One hundered and one</returns>
        public virtual string CalculateOperation(int number)
        {
            var result = new StringBuilder();

            if (number >= 0 && number < 10)
            {
                result.AppendFormat("{0}", OnesOperations(number));
            }
            else if (number > 9 && number < 20)
            {
                result.AppendFormat(" {0}", TeensOperations(number));
            }
            else if (number <= 99)
            {
                result.Append(TensOperations(number));
                result.AppendFormat(" {0}", OnesOperations(number.ToString().ToCharArray()[1].ToInt()));
            }
            else
            {
                result.Append(HundredsOperations(number));
            }

            return result.ToString().Trim();
        }

    }
}
