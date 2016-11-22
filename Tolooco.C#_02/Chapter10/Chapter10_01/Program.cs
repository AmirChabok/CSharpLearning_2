using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10_01
{
    /// <summary>
    /// 21 March 2014
    /// Version 1.1.1
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    /// <summary>
    /// کلاس پروگرام
    /// </summary>
	class Program
	{
        /// <summary>
        /// متد استاتیک مین
        /// </summary>
        /// <param name="args"></param>
		static void Main(string[] args)
		{
            //ایجاد یک ارایه از افراد
			Persons List_3 = new Persons();
            //افزودن یک شخص به ارایه
			List_3.Add(new Person("Amir", "Hoseini"));

            //ذخیره فایل ایکس ام ال
			List_3.Save();

            //فراخوانی فایل ایکس ام ال
			List_3.Load();

            //نمایش آرایه
			Console.WriteLine(List_3);
            //منتظر کلیدی از صفحه کلید
			Console.ReadKey();
		}
	}
}
