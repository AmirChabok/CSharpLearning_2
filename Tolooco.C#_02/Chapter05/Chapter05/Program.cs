using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Program
    {

        static void Main(string[] args)
        {

            //Student Student_1 = new Student();
            //Student_1.Name = "Ahmad";
            //Student_1.Family = "Mohamadi";
            //Console.WriteLine(Student_1.FullName);

            //استفاده از کلاس تولز بدون ایجاد شی از کلاس
            Console.WriteLine(Tools.AddTag("P", "Body"));

            Console.ReadKey();
        }
    }
}
