using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
    /// <summary>
    /// کلاس پرسون
    /// </summary>
	class Person
	{
        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
		public Person()
		{

		}

        /// <summary>
        /// سازنده با دو ورودی
        /// </summary>
        /// <param name="name"></param>
        /// <param name="family"></param>
		public Person(string name,string family)
		{
			this.Name = name;
			this.Family = family;
		}

        /// <summary>
        /// پراپرتی های کلاس
        /// </summary>
		public string  Name { get; set; }
		public string  Family { get; set; }

        /// <summary>
        /// متد اورراید تو استرینگ
        /// </summary>
        /// <returns></returns>
		public override string ToString()
		{
			return string.Format("Name:{0}\r\n Family:{1}\r\n", this.Name, this.Family); 
		}

        //پراپرتی ویرچوال استرینگ دیسپلی
		//public virtual  string Display { get { return string.Format("Name:{0}\r\n Family:{1}\r\n", this.Name, this.Family); } }
	}
}
