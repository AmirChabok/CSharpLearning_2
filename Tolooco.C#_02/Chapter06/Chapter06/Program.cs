using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Chapter06
{
    /// <summary>
    /// کلاس پرسون
    /// </summary>
    public class Person
    {
        /// <summary>
        /// متد شمارشی تست
        /// </summary>
        /// <returns></returns>
        public IEnumerable Test()
        {
            //ایجاد آرایه استرینگ
            string[] List_2 = new string[] { "Sara", "Shahla", "Sahel" };

            //نمایش مقادیر آرایه با استفاده از یلد ریترن
            for (int i = 0; i < List_2.Length; i++)
            {
                yield return List_2[i];
            }
        }
    }

    /// <summary>
    /// کلاس دیتا
    /// </summary>
    public class Data
    {
        /// <summary>
        /// متد شمارشی تست 2
        /// </summary>
        /// <returns></returns>
        public IEnumerable Test_2()
        {
            yield return "121";
            yield return "Computer";
            yield return "C#";
        }
    }

    /// <summary>
    /// کلاس نیو دیتا که قانون اینترفیس آی اینام ریبل را میپذیرد
    /// این کلاس شمارشی است
    /// </summary>
    public class NewData : IEnumerable
    {
        /// <summary>
        /// متد شمارشی
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            yield return "121";
            yield return "Computer";
            yield return "C#";
        }
    }
    /// <summary>
    /// کلاس پروگرام و بدنه برنامه
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //ایجاد یک شی از کلاس مدیران
            Managers Mangers_1 = new Managers();

            //فراخوانی متد لیست کلاس مدیران
            Console.WriteLine(Mangers_1.List());

            //Managers MList = new Managers();

            //foreach (Manager man in MList)
            //{
            //	Console.WriteLine(man);
            //}

            //NewData Data_2 = new NewData();

            //foreach (string str in Data_2)
            //{
            //	Console.WriteLine(str);
            //}

            //Data Data_1 = new Data();

            //foreach (string  str in Data_1.Test_2())
            //{
            //	Console.WriteLine(str);
            //}

            //Person Person_1 = new Person();

            //foreach (string  str in Person_1.Test())
            //{
            //	Console.WriteLine(str);
            //}

            //string[] List = new string[] { "Amir", "Hosein", "Ali" };

            //foreach (string  str in List)
            //{
            //	Console.WriteLine(str);
            //}

            Console.ReadKey();
        }
    }
}
