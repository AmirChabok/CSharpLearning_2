using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04
{
    /// <summary>
    /// کلاس پرسون که اینترفیس آی تست را پیاده سازی میکند
    /// </summary>
    class Person:ITest
    {
        //پیاده سازی اینترفیس
        public string Test()
        {
            return string.Format("Person");
        }
    }
}
