using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11
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
    /// تعریف  دلیگیت با دوورودی ویک خروجی اینت
    /// </summary>
    /// <param name="A"></param>
    /// <param name="B"></param>
    /// <returns></returns>
    public delegate int Calculator(int A, int B);

    /// <summary>
    /// تعریف دلیگیت با ورودی و خروجی رشته
    /// </summary>
    /// <param name="value"></param>
    public delegate void ShowMessage(string value);

    //#################################################

    /// <summary>
    /// کلاس تولز که یک متد رشتهای دارد
    /// </summary>
    public class Tools
    {
        public string TestDelegate(Calculator CalcDel_1, int a, int b)
        {
            return string.Format
                ("A:{0}B:{1}Calculator(A,B):{2}", a, b, CalcDel_1(a, b));
        }
    }

    //#################################################

    /// <summary>
    /// کلاس پروگرام
    /// </summary>
    class Program
    {
        /// <summary>
        /// متد استاتیک جمع با دو ورودی اینت
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// متد استاتیک تفریق با دوورودی اینت
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Sub(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// متد استاتیک ضرب با دوورودی اینت
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Mul(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// متد استاتیک تقسیم با دوورودی اینت
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Div(int a, int b)
        {
            return a / b;
        }

        //#################################################

        /// <summary>
        /// متد وید نمایش پیغام قرمز
        /// </summary>
        /// <param name="value"></param>
        public static void ShowRedMessage(string value)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
            Console.ResetColor();
        }

        /// <summary>
        /// متد وید نمایش پیغام زرد
        /// </summary>
        /// <param name="value"></param>
        public static void ShowYellowMessage(string value)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(value);
            Console.ResetColor();
        }

        /// <summary>
        /// متد وید نمایش پیغام آبی
        /// </summary>
        /// <param name="value"></param>
        public static void ShowBlueMessage(string value)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(value);
            Console.ResetColor();
        }

        //#################################################

        /// <summary>
        /// متد استاتیک مین
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //ایجاد یک شی از کلاس تولز و فراخوانی متدهای مختلف با دلیگیت
            //Tools Tools_1 = new Tools();
            //Console.WriteLine(Tools_1.TestDelegate(Sum, 20, 10));
            //Console.WriteLine(Tools_1.TestDelegate(Sub, 20, 10));
            //Console.WriteLine(Tools_1.TestDelegate(Mul, 20, 10));
            //Console.WriteLine(Tools_1.TestDelegate(Div, 20, 10));

            //ایجاد یک شی از دلیگیت شومسیج و نمایش مختلف پیام ها با دلیگیت
            ShowMessage SM = new ShowMessage(ShowRedMessage);
            SM += (ShowYellowMessage);
            SM += (ShowBlueMessage);

            SM("Soroush Sarabi");


            //منتظر کلید از صفحه کلید
            Console.ReadKey();

            //#################################################

        }
    }
}
