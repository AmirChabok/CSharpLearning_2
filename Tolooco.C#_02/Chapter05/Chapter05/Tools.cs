using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    /// <summary>
    /// کلاس استاتیک تولز
    /// کلاس های استاتیک نیاز به ساختن شی ندارند
    /// در اعضا استاتیک فقط از اعضا استاتیک میتوان استفاده نمود
    /// در اعضا غیر استاتیک میتوان از اعضا استاتیک و غیر استاتیک استفاده نمود
    /// </summary>
	public static class Tools
	{
        /// <summary>
        /// متد استاتیک کلاس استاتیک تولز
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="value"></param>
        /// <returns></returns>
		public static string AddTag(string tag, string value)
		{
			return string.Format("<{0}>{1}</{0}>",tag,value);
		}
	}
}
