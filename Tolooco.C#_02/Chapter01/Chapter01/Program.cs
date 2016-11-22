using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01
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
			//ایجاد شی از کلاس پرسون با استفاده از سازنده پیش فرض
			Person Person_1 = new Person();
			Person_1.Name = "Dariush";
			Person_1.Family = "Tasdighi";
			//ایجاد شی دوم از کلاس پرسون با استفاده از سازنده دوم
			Person Person_2 = new Person("Soroush", "Sarabi");
			//Console.WriteLine("{0}\r\n{1}", Person_1.ShowInfo, Person_2.ShowInfo);
			//ایجاد شی سوم از کلاس پرسون با استفاده از سازنده سوم که چهار ورودی دارد
			Person Person_3 =
				new Person("Ali", "Pishkari", new Address_Person("Tehran", 555),
					new Phone_Person("0912336655", "0216655898"));

			Console.WriteLine("{0}\r\n{1}\r\n{2}\r\n",Person_3.ShowInfo,Person_3.PersonAddress.ShowAddress
				,Person_3.PersonPhone.ShowPhone);
			

			Console.ReadKey();
		}
	}
}
