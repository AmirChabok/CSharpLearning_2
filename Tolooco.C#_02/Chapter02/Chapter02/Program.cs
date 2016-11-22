using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
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
            //ایجاد یک شی از کلاس دانشجو و مقدار دهی با سازنده پیش فرض
			Student Student_1 = new Student();

			Student_1.Name = "Amir";
			Student_1.Family = "Chabok";
			Student_1.ID = 121;

            //ایجاد یک شی از کلاس دانشجو و مقدار دهی با سازنده دوم
			Student Student_2 = new Student ("Hosein","Sadeghi",110);

			//Console.WriteLine("ShowStudent_1:{0}\r\n ShowStudent_2:{1}"
			//	, Student_1.ShowStudent, Student_2.ShowStudent);

            //ایجاد یک شی از کلاس پرسون و مقدار دهی با سازنده دوم
			Person Person_1 = new Person("Ali", "Jahanshiri");

            //ایجاد یک شی از کلاس دانشجو و مقدار دهی با سازنده دوم
			Student Student_3 = new Student ("Mehdi","Radvand",777);

			//Console.WriteLine("DisplayOnPerson:{0}\r\n DisplayOnStudent:{1}\r\n"
			//	,Person_1.Display,Student_3.Display);

            //ایجاد یک پرسون و کست ایمپلیسیتی آن به استیودنت
			Person Person_2 = Student_3;

			//Console.WriteLine("CastedPerson_2:{0}", Person_2.Display);

			//امکان تبدیل اکسپلیسیتی  هم وجود نداردStudent Student_4 =(Student) Person_1;

            //ایجاد یک شی از کلاس دانشجو و کست اکسپلیسیتی آن
            //دقت نمائید در حالتی که کلاس پدر کست شده به کلاس فرزند باشد مجددا میتواند به کلاس  فرزند کست شود
			Student Student_4 =(Student) Person_2;

			//Console.WriteLine("{0}", Student_4.Display);

            //ایجاد یک آرایه از پرسون و مقدار دهی اولیه آن از انواع پرسون - دانشجو - و استاد
            //چون همگی نوع ها یا خود پرسون و یا فرزندان آن هستند به صورت ایمپلیسیتی کست میشوند
			Person [] PersonList = new Person []
			{new Person ("Amir","Chabok"),new Student ("Hosein","Sadeghi",110),new Person ("Ali","Jahanshiri"),
			new Student("Mehdi","Radvand",777),new Teacher ("Sorosh","Sarabi",555)};

            //حلقه فورایچ برای نمایش کالکشن آرایه
			foreach (Person  P in PersonList)
			{
				Console.WriteLine(P);
			}


            //منتظر کلید از صفحه کلید
			Console.ReadKey();

			
		}
	}
}
