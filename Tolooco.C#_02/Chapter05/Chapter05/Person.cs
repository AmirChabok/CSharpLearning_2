using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    /// <summary>
    /// 21 March 2014
    /// Version 1.1.1
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    /// <summary>
    /// کلاس ابستراکت پرسون
    /// از کلاس های ابستراکت نمیتوان شی ایجاد نمود
    /// میتوان کلاس های دیگری داشت که از کلاس ابستراکت اینهریت شود
    /// از کلاس های اینهریت شده از کلاس ابستراکت میتوان شی ساخت
    /// ابستراکت نیز مفهوم چند ریختی یا پلی مرفیزم را پیاده سازی میکند
    /// هر کلاس تنها از یک ابستراکت کلاس میتواند ارث بری داشته باشد.
    /// این کلاس ها میتوانند در داخل خود متد و پراپرتی  نیز پیاده سازی نمایند
    /// </summary>
	public abstract class Person
	{
        /// <summary>
        /// پراپرتی های کلاس
        /// </summary>
		public string  Name { get; set; }
		public string  Family { get; set; }

        /// <summary>
        /// پراپرتی ابستراکت کلاس
        /// </summary>
		public abstract string  FullName { get; set; }
	}
}
