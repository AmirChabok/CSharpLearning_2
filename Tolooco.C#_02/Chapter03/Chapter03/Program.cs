using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
	class Program
	{
		static void Main(string[] args)
		{
            //ایجاد یک آرایه از جنس افراد و مقدار دهی آن
			Persons MyList = new Persons(new Person("Amir", "Chabok", 121), new Person("Hosein", "Sadeghi", 110),
				new Person("Ali", "Jahanshiri", 777));

            //ایجاد یک پرسون و اد نمودن به آرایه
			Person Person_4 = new Person("Alireza", "Mohamadi", 200);
			MyList.Add(Person_4);

            //اد کردن یک پرسون دیگر
			MyList.Add(new Person("Sara","Ahmadi",201));

            //نمایس لیست ایجاد شده از پرسون
			Console.WriteLine(MyList.DisplayList());

			Console.WriteLine("*************************************");

            //حذف یک پرسون از لیست
			MyList.Remove(Person_4);

            //نمایس لیست ایجاد شده از پرسون
			Console.WriteLine(MyList.DisplayList());

            //منتظر کلید
			Console.ReadKey();
		}
	}
}
