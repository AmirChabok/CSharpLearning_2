using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    /// <summary>
    /// کلاس دانشجو که از کلاس ابستراکت پرسون اینهریت شده
    /// در این صورت مثل اینترفیس میتواند پیاده سازی شود
    /// تنها مواردی پیاده سازی میشود که در کلاس پدر به صورت ابستراکت باشند
    /// </summary>
	class Student :Person
	{
        /// <summary>
        /// پیاده سازی بصورت اورراید خواهد بود
        /// تنها اجزا ابستراکت در کلاس پدر را میتوان به صورت اورراید شده پیاده سازی نمود
        /// </summary>
		public override string FullName
		{
			get
			{
				return string.Format("{0}{1}",Name,Family);
			}
			set
			{
				throw new NotImplementedException();
			}
		}
	}
}
