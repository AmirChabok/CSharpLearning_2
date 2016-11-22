using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04
{
    /// <summary>
    /// کلاس دانشجو که اینترفیس آی تست را پیاده سازی میکند
    /// </summary>
    class Student : ITest
    {
        public string Test()
        {
            return "Student";
        }
    }
}
