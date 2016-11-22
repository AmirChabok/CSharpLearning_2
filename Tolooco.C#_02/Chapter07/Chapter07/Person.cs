using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter07
{
    /// <summary>
    /// 21 March 2014
    /// Version 1.1.1
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
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
			return string.Format("{0}{1}",this.Name,this.Family);
		}
	}
}
