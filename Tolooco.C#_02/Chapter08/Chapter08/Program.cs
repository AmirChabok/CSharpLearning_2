using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter08
{
    /// <summary>
    /// 21 March 2014
    /// Version 1.1.1
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			#region Chapter08

            //ایجاد دو شی از کلاس پرسون و نمایش آنها
			//Person Person_1 = new Person("Mohammad", "Alavi");
			//Person Person_2 = new Person("Mohammad", "Alavi");
			//Console.WriteLine(Person_1.GetHashCode());
			//Console.WriteLine(Person_2.GetHashCode());

            //فراخوانی متد های پیاده سازی شده از اینترفیس آی ایکواتیبل در کلاس پرسون
			//Console.WriteLine(Person_1==Person_2);
			//Console.WriteLine(Person_1.Equals(Person_2));

			//Console.ReadKey();

			#endregion

            //تعریف یک شی از کلاس دیتا با تایپ اینت
			Data<int> Data_1 = new Data<int>();

            //تعریف یک اینتیجر و برابر قرار دادن با متد کلاس دیتا
			int i = Data_1.Method_2(10) + 21;

            //تعریف یک شی از کلاس دیتا با تایپ رشته ای
			Data<string> Data_2 = new Data<string>();

            //تعریف یک استرینگ و برابر قرار دادن با متد کلاس دیتا
			string Temp = Data_2.Method_2(Data_2.Prop_1) + "A";

		}
	}
}
