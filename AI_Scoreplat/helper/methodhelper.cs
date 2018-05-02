using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AI_Scoreplat
{
    public static class methodhelper
    {
        public static string[] splits(string str1, string str2)
        {
            return Regex.Split(str1,str2);      
        }
    }
}
