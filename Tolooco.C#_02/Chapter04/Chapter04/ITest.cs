using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04
{
    /// <summary>
    /// اینترفیس با نام آی تست 
    /// یک قانون دارد و آن یک متد استرینگ هست
    /// کلاس های دیگر میتوانند قوانین اینترفیس ها را پیاده سازی نمایند
    /// اینترفیس مفهوم چند ریختی یا پلی مرفیزم را پیاده سازی میکند
    /// هر کلاس از بی نهایت اینترفیس میتواند ارث بری داشته باشد
    /// </summary>
    interface ITest
    {
        string Test();
    }
}
