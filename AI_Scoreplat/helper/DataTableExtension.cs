using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;
using System.Collections;

namespace AI_Scoreplat
{
    public static class DataTableExtension
    {
        #region 将datatable数据转化成list

        /// <summary>  
        /// 将datatable数据转化成list  
        /// </summary>  
        /// <typeparam name="T">泛型T</typeparam>  
        /// <param name="dt">对应的datatable数据表</param>  
        /// <returns>返回结果的数据集</returns>  
        public static List<T> ToModels<T>(this DataTable dt) where T : class, new()
        {
            Type t = typeof(T);
            PropertyInfo[] propertys = t.GetProperties();
            List<T> lst = new List<T>();
            string typeName = string.Empty;

            foreach (DataRow dr in dt.Rows)
            {
                T entity = new T();
                foreach (PropertyInfo pi in propertys)
                {
                    typeName = pi.Name;
                    if (dt.Columns.Contains(typeName))
                    {
                        if (!pi.CanWrite) continue;
                        object value = dr[typeName];
                        if (value == DBNull.Value) continue;
                        if (pi.PropertyType == typeof(string))
                        {
                            pi.SetValue(entity, value.ToString(), null);
                        }
                        else if (pi.PropertyType == typeof(int) || pi.PropertyType == typeof(int?))
                        {
                            pi.SetValue(entity, int.Parse(value.ToString()), null);
                        }
                        else if (pi.PropertyType == typeof(DateTime?) || pi.PropertyType == typeof(DateTime))
                        {
                            pi.SetValue(entity, DateTime.Parse(value.ToString()), null);
                        }
                        else if (pi.PropertyType == typeof(float))
                        {
                            pi.SetValue(entity, float.Parse(value.ToString()), null);
                        }
                        else if (pi.PropertyType == typeof(double))
                        {
                            pi.SetValue(entity, double.Parse(value.ToString()), null);
                        }
                        else
                        {
                            pi.SetValue(entity, value, null);
                        }
                    }
                }
                lst.Add(entity);
            }
            return lst;

            //调用  
            //List<People> p = dt.ToList<People>();  
        }

        #endregion

        #region  将list数据转化成datatable
        public static DataTable ToDataTable(this IList list, params string[] propertyName)
        {
            List<string> propertyNameList = new List<string>();
            if (propertyName != null)
            {
                propertyNameList.AddRange(propertyName);
            }
            DataTable result = new DataTable();
            if (list.Count > 0)
            {
                PropertyInfo[] propertys = list[0].GetType().GetProperties();
                foreach (PropertyInfo pi in propertys)
                {
                    if (propertyNameList.Count == 0)
                    {
                        result.Columns.Add(pi.Name, pi.PropertyType);
                    }
                    else
                    {
                        if (propertyNameList.Contains(pi.Name))
                            result.Columns.Add(pi.Name, pi.PropertyType);
                    }
                }
                for (int i = 0; i < list.Count; i++)
                {
                    ArrayList tempList = new ArrayList();
                    foreach (PropertyInfo pi in propertys)
                    {
                        if (propertyNameList.Count == 0)
                        {
                            object obj = pi.GetValue(list[i], null);
                            tempList.Add(obj);
                        }
                        else
                        {
                            if (propertyNameList.Contains(pi.Name))
                            {
                                object obj = pi.GetValue(list[i], null);
                                tempList.Add(obj);
                            }
                        }
                    }
                    object[] array = tempList.ToArray();
                    result.LoadDataRow(array, true);
                }
            }
            return result;
        }
        #endregion 
    
    }


}
