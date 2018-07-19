using System;
using System.Collections.Generic;
using System.Text;

namespace NumberToTextConverter
{
    /// <summary>
    /// 
    /// </summary>
    public static class Extentions
    {
        public static int ToInt(this string value)
        {
            return int.Parse(value);
        }

        public static int ToInt(this char value)
        {
            return ToInt(value.ToString());
        }
    }
}
