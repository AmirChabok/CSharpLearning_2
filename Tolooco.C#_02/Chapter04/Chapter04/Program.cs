using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04
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
        /// ایونت استاتیک مین
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //ایجاد چند شی از کلاس های موجود در برنامه
            Person oPerson = new Person();
            Student oStudent = new Student();
            Teacher oTeacher = new Teacher();

            //ایجاد یک آرایه از جنس آبجکت که اشیا بالا را در بر دارد
            object[] List = new object[] { oPerson, oStudent, oTeacher };

            //حلقه فور ایچ که اندیس آرایه بالا را به ازای هر آیتم که آی تست را پیاده سازی نموده نمایش میدهد
            foreach (ITest  II in List)
            {
                Console.WriteLine(II.Test());
            }

            //Console.WriteLine(oPerson.Test());
            //Console.WriteLine(oStudent.Test());
            //Console.WriteLine(oTeacher.Test());

            Console.ReadKey();

        }
    }
}
