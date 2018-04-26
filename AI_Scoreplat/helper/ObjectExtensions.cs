using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace AI_Scoreplat
{
    public static class ObjectExtensions
    {
        public static string GetPropertyValue(this object arg, string propertyName)
        {
            string result = null;
            if (propertyName == null) return result;
            PropertyInfo pi = arg.GetType().GetProperty(propertyName);
            if (pi != null)
            {
                object obj = pi.GetValue(arg, null);
                if (obj!=null)
                    result = obj.ToString();
            }

            return result;
        }

        public static void SetPropertyValue(this object arg, string propertyName, object value)
        {
            PropertyInfo pi = arg.GetType().GetProperty(propertyName);
            object objValue = null;
            if (pi != null)
            {
                if (pi.PropertyType.IsEnum)
                {
                    objValue = Enum.Parse(pi.PropertyType, value.ToString());
                }
                else 
                {
                    objValue = value;
                }
                if ((pi.PropertyType.ToString() == "System.Single" ) && ((null == objValue) || ("" == objValue.ToString()))) 
                    objValue = "0.0";
                if ((pi.PropertyType.ToString() == "System.Single") && (objValue.ToString()=="-"))
                    return;
                pi.SetValue(arg, Convert.ChangeType(objValue, pi.PropertyType), null);
            }
        }

        /// <summary>
        /// 判断对象为Null或者转化成字符串后是否为空
        /// </summary>
        public static bool IsNullOrEmpty(this object arg)
        {
            bool result = true;
            if (arg != null && !string.IsNullOrEmpty(arg.ToString()))
            {
                result = false;
            }
            return result;
        }
    }
}
