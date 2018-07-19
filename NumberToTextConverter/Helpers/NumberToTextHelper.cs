using System;
using System.Collections.Generic;
using System.Text;

namespace NumberToTextConverter.Helper
{
    public class NumberToTextHelper
    {  
        internal static List<string> GetHunderedsOfAmounts(string amountString)
        {
            var numberList = new List<string>();
            while (amountString.Length > 0)
            {
                if (amountString.Length > 3)
                {
                    var p = amountString.Substring(amountString.Length - 3, 3);
                    amountString = amountString.Remove(amountString.Length - 3, 3);
                    numberList.Add(p);
                }
                else
                {
                    numberList.Add(amountString);
                    amountString = amountString.Remove(0, amountString.Length);
                }
            }

            return numberList;
        } 
    }
}
