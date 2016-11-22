using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12
{
    /// <summary>
    /// 21 March 2014
    /// Version 1.1.1
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    //#################################################

    /// <summary>
    /// دلیگیت وید با ورودی استرینگ
    /// </summary>
    /// <param name="value"></param>
	public delegate void OnSetName(string value);


    //#################################################

    /// <summary>
    /// کلاس پرسون
    /// </summary>
	public class Person
	{
        /// <summary>
        /// تعریف ایونت با دلیگیت
        /// </summary>
		public event OnSetName SetName;

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
		public Person()
		{

		}

        /// <summary>
        /// سازنده با دو ورودی
        /// </summary>
        /// <param name="name"></param>
        /// <param name="family"></param>
		public Person(string name,string family)
		{
			this.Name = name;
			this.Family = family;
		}

        /// <summary>
        /// فیلد پرایویت نام
        /// </summary>
		private string _name;

        /// <summary>
        /// فیلد پرایویت فامیلی
        /// </summary>
		private string _family;

        /// <summary>
        /// پراپرتی نام
        /// </summary>
		public string Name
		{
			get { return _name; }
			set{_name = value; if (SetName != null) SetName(value);	}
			
		}

        /// <summary>
        /// پراپرتی فامیلی
        /// </summary>
		public string Family { get { return _family; } set { _family = value; } }
	}

    //#################################################

    /// <summary>
    /// کلاس پروگرام
    /// </summary>
	class Program
	{
        /// <summary>
        /// متد استاتیک بدنه
        /// </summary>
        /// <param name="args"></param>
		static void Main(string[] args)
		{
            //ایجاد یک شی از کلاس پرسون
			Person Person_1 = new Person();

            // مقدار دهی ایونت شی با دو متد ست نیم و دیسپلی
			Person_1.SetName += Person_1_Display;
			Person_1.SetName += Person_1_SetName;
			
            //مقدار دهی نام توسط ورودی
			Person_1.Name = Console.ReadLine();

            //منتظر کلیدی از صفحه کلید
			Console.ReadKey();
		}

        //#################################################

        /// <summary>
        /// متد ست نیم با ورودی استرینگ
        /// </summary>
        /// <param name="value"></param>
		static void Person_1_SetName(string value)
		{
			System.Windows.Forms.MessageBox.Show(value);
		}

        /// <summary>
        /// متد دیسپلی با ورودی استرینگ
        /// </summary>
        /// <param name="value"></param>
		static void Person_1_Display(string value)
		{
			Console.BackgroundColor = ConsoleColor.Red;
			Console.WriteLine(value);
		}

        //#################################################
		
	}
}
