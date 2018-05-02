using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AI_Scoreplat.helper
{
    public static class StringExtension
    {
        public static string[] splits(this string str1, string str2)
        {
            return Regex.Split(str1, str2);
        }
    }
}
