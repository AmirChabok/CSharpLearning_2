using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//استفاده از سر برگ زیر
using System.Collections;

namespace Chapter07
{
	/// <summary>
	/// ایجاد یک کلاس استاتیک در برنامه به نام تولز
	/// </summary>
	public static class Tools
	{
		/// <summary>
		/// تعریف یک متد استاتیک  از جنس استرینگ در کلاس تولز
		/// </summary>
		/// <param name="BaseData"></param>
		/// <returns></returns>
		public static string Generator(IEnumerable BaseData)
		{
			string Temp = "This Generator Created By Cwx121.com \r\n ===============================\r\n All Right Reserved @2013 \r\n";

			int Count = 0;

			foreach (object  obj in BaseData)
			{
				Temp +=string.Format("\r\n{0}\r\n-------------------------\r\n",obj);
				Count++;
			}

			Temp += string.Format("Total Count Is :{0}",Count);
			return Temp;
		}
	}
}
