using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04
{
    /// <summary>
    /// کلاس استاد که اینترفیس آی تست را پیاده سازی میکند
    /// </summary>
    class Teacher:ITest
    {
        public string Test()
        {
            return "Teacher";
        }
    }
}
